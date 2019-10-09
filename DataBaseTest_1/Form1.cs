using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseTest_1
{
    public partial class FormMain : Form
    {
        // 申明变量
        private TcpListener tcpListen = null;
        private TcpClient tcpClient = null;
        private Int32 port = 888;
        IPAddress ipAddress = IPAddress.Loopback;
        private NetworkStream networkStream = null;
        private BinaryReader reader;
        private BinaryWriter writer;
        
        //private DormStudent student;

        private DataBaseClass sql = new DataBaseClass("127.0.0.1", "3306", "root", "kala123", "dormitory_management", "utf8");
        private String dataBaseName = "dormitory_data";
        private String dataBaseName1 = "dormitory_student";
        private String dataBaseName2 = "dormitory_illegal";
        public static FormMain formMain = null;
        public delegate void MyInvoke(String str1);

        // 申明委托
        private delegate void ShowMessage(string str);

        public FormMain()
        {
            formMain = this;
            InitializeComponent();
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void newData_Click(object sender, EventArgs e)
        {
            showData("");
        }

        private void oldData_Click(object sender, EventArgs e)
        {
            //this.Hide();
            FormOld formOld = new FormOld();
            formOld.Show();
        }


        private void inputData_Click(object sender, EventArgs e)
        {
            //this.Hide();
            FormInput formInput = new FormInput();
            formInput.Show();
        }

        private void queryStudent_Click(object sender, EventArgs e)
        {
            //this.Hide();
            FormStudent formStudent = new FormStudent();
            formStudent.Show();
        }

        private void queryIllegal_Click(object sender, EventArgs e)
        {
            //this.Hide();
            FormIllegal formIllegal = new FormIllegal();
            formIllegal.Show();
        }

        private void queryTime_Click(object sender, EventArgs e)
        {
            //this.Hide();
            FormTime formTime = new FormTime();
            formTime.Show();
        }

        //其实是打开/关闭数据库显示界面
        private void startListener_Click(object sender, EventArgs e)
        {
            if(startListener.Text.Equals("启动监听"))
            {
                try
                {
                    Thread showThread = new Thread(connectThread);
                    showThread.Start();
                    try
                    {
                        //通过线程发起请求，多线程
                        tcpListen = new TcpListener(ipAddress, port);
                        tcpListen.Start();
                        // 启动一个线程来接受请求
                        Thread acceptThread = new Thread(acceptClientConnect);
                        acceptThread.Start();
                        startListener.Text = "监听中";
                        startListener.Enabled = false;
                        MessageBox.Show("启动成功了～\\(≧▽≦)/～");
                    }
                    catch
                    {
                        MessageBox.Show("启动不了呢，请主人仔细检查一下错误吧〒▽〒");
                    }
                }
                catch
                {
                    MessageBox.Show("连接失败！！o(≧口≦)o" + "\n");
                }
            }
        }

        private void acceptClientConnect()
        {
            Thread.Sleep(300);
            try
            {
                tcpClient = tcpListen.AcceptTcpClient();
                if (tcpClient != null)
                {
                    networkStream = tcpClient.GetStream();
                    reader = new BinaryReader(networkStream);
                    writer = new BinaryWriter(networkStream);
                    Thread threadread = new Thread(new ThreadStart(receiveMessage));
                    threadread.Start();
                }
            }
            catch
            {
                Thread.Sleep(300);
            }
        }

        // 接收消息
        private void receiveMessage()
        {
            while (true)
            {
                String data = null;
                //tsState.Text = "接收消息中";
                try
                {
                    if (reader != null)
                    {
                        data = reader.ReadString();

                        try
                        {
                            MessageBox.Show("客户端发消息来了：" + data);
                            String send_str;
                            MySqlDataReader readerStudent = null;
                            //MessageBox.Show("2 " + data);
                            if (data.Length == 6)
                            {
                                //MessageBox.Show("3 " + data);
                                readerStudent = queryData(data, dataBaseName1);

                                if (readerStudent.Read())
                                {
                                    //MessageBox.Show("4 " + data);
                                    DormStudent student = new DormStudent();
                                    student.studentName = readerStudent.GetValue(3).ToString();
                                    student.studentID = readerStudent.GetValue(2).ToString();
                                    student.cardID = readerStudent.GetValue(1).ToString();
                                    student.dormitoryID = readerStudent.GetValue(4).ToString();

                                    //卡号、学号、姓名、寝室号
                                    send_str = "Y " + student.cardID + " " + student.studentID + " " + student.studentName + " " + student.dormitoryID;
                                    //卡号、时间、学号、姓名
                                    String insert_str = "'" + student.cardID + "','" + DateTime.Now.ToString("yyyy-mm-dd hh:mm:ss") + "','" + student.studentID + "','" + student.studentName + "'";
                                    insertMessage(insert_str, dataBaseName);
                                    showData("");
                                }
                                else
                                {
                                    //MessageBox.Show("5 " + data);
                                    send_str = "N IllegalAccounts";
                                    String str = "'" + data + "','" + DateTime.Now.ToString("yyyy-mm-dd hh:mm:ss") + "'";
                                    insertMessage(str, dataBaseName2);
                                }
                            }
                            else
                            {
                                //MessageBox.Show("6 " + data);
                                send_str = "N  IllegalInput";
                                String str = "'" + data + "','" + DateTime.Now.ToString("yyyy-mm-dd hh:mm:ss") + "'";
                                insertMessage(str, dataBaseName2);
                                //MessageBox.Show("反正你给的不是卡号，所以我不管了<(－︿－)>");
                            }
                            if (send_str != null)
                            {
                                Thread threadread = new Thread(new ParameterizedThreadStart(sendMessage));
                                threadread.Start(send_str);
                            }
                        }
                        catch
                        {
                            //MessageBox.Show("聊聊没有成功接受消息呢，请主人仔细检查一下错误吧〒▽〒" + "\n" + ex.Message);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("给我错误消息了，请仔细检查一下错误吧〒▽〒" + "\n" + ex.Message);
                }
            }
        }

        private void sendMessage(object Data)
        {
            String data = Data.ToString();
            try
            {
                MessageBox.Show("我发消息去了：" + data);
                writer.Write(data);
                writer.Flush();
            }
            catch (Exception ex)
            {
                MessageBox.Show("没有成功发送消息呢，请仔细检查一下错误吧〒▽〒" + "\n" + ex.Message);
            }
        }

        private void connectThread()
        {
            MyInvoke mi = new MyInvoke(showData);
            this.BeginInvoke(mi, new Object[] {""});
            //showData("", this.dataGridView);
        }

        public void showData(String data)
        {
            if (dataGridView.RowCount != 0)
            {
                int x = 0;
                while (x >= 0)
                {
                    x = dataGridView.RowCount - 1;
                    dataGridView.Rows.Remove(dataGridView.Rows[x]);
                    x--;
                }
            }
            MySqlDataReader reader = queryData("", dataBaseName);
            //String result = "";
            
            while (reader.Read())
            {
                int index = dataGridView.Rows.Add();
                dataGridView.Rows[index].Cells[0].Value = index + 1;
                for (int i = 1; i < reader.FieldCount; i++)
                {
                    //卡号、时间、学号、姓名
                    dataGridView.Rows[index].Cells[i].Value = reader.GetValue(i);
                    //result += reader.GetName(1) + "\t" + reader.GetValue(1) + "\r\n";
                    //textBox1.Text = result;
                }
            }
        }

        //插入数据
        public void insertMessage(String data,String dataBase)
        {
            String str = null;
            if (dataBase.Equals(dataBaseName))
            {
                str = "insert into " + dataBase + "(cardID,studentTime,studentID,studentName) values (" + data + ")";
                sql.ExeUpdate(str);
            }
            if (dataBase.Equals(dataBaseName1))
            {
                str = "insert into " + dataBase + "(cardID,studentID,studentName,dormitoryID) values (" + data + ")";
                sql.ExeUpdate(str);
            }
            if (dataBase.Equals(dataBaseName2))
            {
                str = "insert into " + dataBase + "(cardID,time) values (" + data + ")";
                sql.ExeUpdate(str);
            }
            
        }

        //查询数据
        public MySqlDataReader queryData(String data, String dataBase)
        {
            String str = null;
            if (dataBase.Equals(dataBaseName))
            {
                str = "select * from " + dataBase;
                return sql.ExeQuery(str);
            }
            if (dataBase.Equals(dataBaseName1))
            {
                str = "select * from " + dataBase + " where cardID = '" + data + "';";
                return sql.ExeQuery(str);
            }
            return null;
        }
    }
}