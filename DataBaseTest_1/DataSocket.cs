using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
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
    class DataSocket
    {
        /*private DataBaseClass sql = new DataBaseClass("127.0.0.1", "3306", "root", "kala123", "dormitory_management", "utf8");
        private String dataBaseName1 = "dormitory_student";
        public delegate void MyInvoke(String str1);
        
        private String studentName;
        private String studentID;
        private String cardID;
        private String dormitoryID;

        // 申明变量
        private TcpListener tcpListen = null;
        private TcpClient tcpClient = null;
        private Int32 port = 888;
        IPAddress ipAddress;
        private NetworkStream networkStream = null;
        private BinaryReader reader;
        private BinaryWriter writer;
        
        // 申明委托
        // 接收消息
        //private delegate void ReceiveMessage(String data);
        //private ReceiveMessage receiveMessageCallback;
        // 发送消息
        private delegate void SendMessage();
        private SendMessage sendMessageCallback;

        public DataSocket()
        {
            Control.CheckForIllegalCrossThreadCalls = false;//设置该属性 为false

            // 实例化委托
            //receiveMessageCallback = new ReceiveMessage(receiveMessage);

            sendMessageCallback = new SendMessage(sendMessage);
            

            ipAddress = IPAddress.Loopback;
            port = Int32.Parse("888");
        }


        // 接受请求
        private void acceptClientConnect()
        {
            //tsState.Text = "正在监听";
            Thread.Sleep(300);
            try
            {
                //tsState.Text = "等待连接";
                tcpClient = tcpListen.AcceptTcpClient();
                if (tcpClient != null)
                {
                    //tsState.Text = "已连接";
                    networkStream = tcpClient.GetStream();
                    reader = new BinaryReader(networkStream);
                    writer = new BinaryWriter(networkStream);
                    //Thread threadread = new Thread(new ThreadStart(receiveMessage));
                    //threadread.Start();
                }
            }
            catch
            {
                //tsState.Text = "停止监听";
                Thread.Sleep(300);
                //tsState.Text = "就绪";
            }
        }

        // 接受请求
        /*private void acceptClientConnect()
        {
            //tsState.Text = "正在监听";
            Thread.Sleep(300);
           // try
            //{
                //tsState.Text = "等待连接";
                tcpClient = tcpListen.AcceptTcpClient();
                if (tcpClient != null)
                {
                    //tsState.Text = "已连接";
                    networkStream = tcpClient.GetStream();
                    reader = new BinaryReader(networkStream);
                    writer = new BinaryWriter(networkStream);
                    Thread threadread = new Thread(new ThreadStart(receiveMessage));
                    threadread.Start();
                    //MyInvoke mi = new MyInvoke(receiveMessage);
                    //this.BeginInvoke(mi, new Object[] { "hh"});
                }
            //}
            //catch
            //{
                //tsState.Text = "停止监听";
                //Thread.Sleep(300);
                //tsState.Text = "就绪";
            //}
        }*/

        // 接收消息
        /*private void receiveMessage(String data)
        {
            //tsState.Text = "接收消息中";
            try
            {
                while (reader != null)
                {
                    data = reader.ReadString();
                    //这句不是很懂
                    //charContent.Invoke(showMessageCallback, tcpClient.Client.RemoteEndPoint + ": " + receivemessage + Environment.NewLine);
                    //charContent.Invoke(showMessageCallback, "客户端" + ": " + receivemessage + Environment.NewLine);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("聊聊没有成功接受消息呢，请主人仔细检查一下错误吧〒▽〒" + "\n" + ex.Message);
            }
            try
            {
                Boolean isOK = false;
                String sql_str_stu;
                MySqlDataReader readerStudent = null;
                if (data.Length == 7 || data.Length == 6)
                {
                    if (data.Length == 7)
                    {
                        sql_str_stu = "select * from " + dataBaseName1 + " where studentID = '" + data + "';";
                        readerStudent = sql.ExeQuery(sql_str_stu);
                    }
                    else
                    {
                        sql_str_stu = "select * from " + dataBaseName1 + " where cardID = '" + data + "';";
                        readerStudent = sql.ExeQuery(sql_str_stu);
                    }
                    if (readerStudent.Read())
                    {
                        studentName = readerStudent.GetValue(3).ToString();
                        studentID = readerStudent.GetValue(2).ToString();
                        cardID = readerStudent.GetValue(1).ToString();
                        dormitoryID = readerStudent.GetValue(4).ToString();
                        
                        isOK = true;
                    }

                    //卡号、学号、姓名、寝室号
                    if (!isOK)
                    {
                        MessageBox.Show("查无此人<(－︿－)>");
                    }
                }
                else
                {
                    MessageBox.Show("乱打我是不会帮你查的，哼，重打吧<(－︿－)>");
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("聊聊没有成功接受消息呢，请主人仔细检查一下错误吧〒▽〒" + "\n" + ex.Message);
            }
        }

        private void sendMessage()
        {
            //tsState.Text = "接收消息中";
            try
            {
                //tsState.Text = "正在发送";
                //writer.Write(sendContent.Text);

                writer.Flush();
                //charContent.Invoke(showMessageCallback, "我: " + sendContent.Text + Environment.NewLine);
                //sendContent.Invoke(resetMessageCallBack, null);
            }
            catch (Exception ex)
            {
                //MessageBox.Show("聊聊没有成功接受消息呢，请主人仔细检查一下错误吧〒▽〒" + "\n" + ex.Message);
            }
        }

        public void insertData(String data,String dataBaseName)
        {
            String str = "insert into " + dataBaseName + "(cardID,studentTime,studentID,studentName) values (" + data + ")";
            sql.ExeUpdate(str);
        }*/

    }
}
