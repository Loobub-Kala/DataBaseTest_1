using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseTest_1
{
    public partial class FormInput : Form
    {
        private DataBaseClass sql = new DataBaseClass("127.0.0.1", "3306", "root", "kala123", "dormitory_management", "utf8");
        private String dataBaseName1 = "dormitory_student";

        public FormInput()
        {
            InitializeComponent();
        }

        private void FormInput_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormMain.formMain.Show();
        }

        private void returnMain_Click(object sender, EventArgs e)
        {
            FormMain.formMain.Show();
            this.Close();
        }

        private void textCard_KeyPress(object sender, KeyPressEventArgs e)
        {
            //如果输入的不是数字键，也不是Backspace键，则取消该输入
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void textID_KeyPress(object sender, KeyPressEventArgs e)
        {
            //如果输入的不是数字键，也不是Backspace键，则取消该输入
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void FormInput_Load(object sender, EventArgs e)
        {
            this.Location = new Point(FormMain.formMain.Location.X + 100, FormMain.formMain.Location.Y + 70);
            //combo1、combo2表示宿舍楼名和宿舍号
            this.combo1.Items.Clear();
            this.combo2.Items.Clear();
            
            //combo1 : ① i 表示行健轩/弘毅轩/至诚轩/敏行楼
            //         ② j 表示行健轩(6)/弘毅轩(4)/至诚轩(4)/敏行楼(1)
            String comboData1;
            for(int i=0;i<4;i++)
            {
                switch(i)
                {
                    case 0:
                        for(int j=1;j<=6;j++)
                        {
                            comboData1 = "行健轩" + j.ToString();
                            this.combo1.Items.Add(comboData1);
                        }
                        break;
                    case 1:
                        for (int j = 1; j <= 4; j++)
                        {
                            comboData1 = "弘毅轩"+ j.ToString();
                            this.combo1.Items.Add(comboData1);
                        }
                        break;
                    case 2:
                        for (int j = 1; j <= 4; j++)
                        {
                            comboData1 = "至诚轩"+ j.ToString();
                            this.combo1.Items.Add(comboData1);
                        }
                        break;
                    case 3:
                        comboData1 = "敏行楼";
                        this.combo1.Items.Add(comboData1);
                        break;
                }
            }

            //combo2 : ① x 表示A区\B区
            //         ② y 表示楼层 1\2\3\4\5\6
            //         ③ z 表示宿舍号 1-31
            String comboData2;
            for (int x = 0; x < 2; x++)
            {
                switch (x)
                {
                    case 0:
                        for (int y = 1; y <= 6; y++)
                        {
                            for (int z = 1; z <= 9; z++)
                            {
                                comboData2 = "A" + y.ToString() + "0" + z.ToString();
                                this.combo2.Items.Add(comboData2);
                            }
                            for (int z = 10; z <= 31; z++)
                            {
                                comboData2 = "A" + y.ToString() + z.ToString();
                                this.combo2.Items.Add(comboData2);
                            }
                        }
                        break;
                    case 1:
                        for (int y = 1; y <= 6; y++)
                        {
                            for (int z = 1; z <= 9; z++)
                            {
                                comboData2 = "B" + y.ToString() + "0" + z.ToString();
                                this.combo2.Items.Add(comboData2);
                            }
                            for (int z = 10; z <= 31; z++)
                            {
                                comboData2 = "B" + y.ToString() + z.ToString();
                                this.combo2.Items.Add(comboData2);
                            }
                        }
                        break;
                }
            }
        }

        private void combo2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //回车键录入
            if (e.KeyChar == (char)13)
            {
                entryMessage();
            }
        }

        private void choosePic_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Filter ="JPG图片|*.jpg";
            if (openfile.ShowDialog() == DialogResult.OK && (openFileDialog1.FileName != ""))
            {
                picShow.SizeMode = PictureBoxSizeMode.StretchImage;
                picShow.ImageLocation = openfile.FileName;
            }
            openfile.Dispose();
        }

        private void inputMessage_Click(object sender, EventArgs e)
        {
            entryMessage();
        }

        private void newMessage_Click(object sender, EventArgs e)
        {
            resetMessage();
        }
        
        //数据录入
        public void entryMessage()
        {
            if (textName.Text != "" && textID.Text != "" && textCard.Text != "" && textCard.Text != "" && combo1.Text != "" && combo2.Text != "" && picShow.Image != null)
            {
                //保存 姓名、学号、卡号、宿舍号、图片
                DormStudent newStudent = new DormStudent();
                //姓名
                newStudent.studentName = textName.Text;
                //学号
                newStudent.studentID = textID.Text;
                //卡号
                newStudent.cardID = textCard.Text;
                //宿舍号
                newStudent.dormitoryID = combo1.Text + "-" + combo2.Text;

                //图片,复制到指定位置
                ImageFormat imgformat = null;
                imgformat = ImageFormat.Jpeg;
                String path = "E:\\大三\\RFID\\项目\\stuPicture\\";
                picShow.Image.Save(path + @"\" + newStudent.cardID + ".jpg", imgformat);

                //卡号、学号、姓名、寝室号
                String insert_str = "'" + newStudent.cardID + "','" + newStudent.studentID + "','" + newStudent.studentName + "','" + newStudent.dormitoryID + "'";
                MessageBox.Show("!!!!" + insert_str);
                insertMessage(insert_str, dataBaseName1);
            }
        }


        //插入数据
        public void insertMessage(String data, String dataBase)
        {
            String str = null;
            if (dataBase.Equals(dataBaseName1))
            {
                str = "insert into " + dataBase + "(cardID,studentID,studentName,dormitoryID) values (" + data + ")";
                sql.ExeUpdate(str);
            }
            MessageBox.Show("学生数据录入成功!");
            resetMessage();
        }

        //重置数据
        public void resetMessage()
        {
            //重置 姓名、学号、卡号、宿舍号、图片
            textName.Text = "";
            textID.Text = "";
            textCard.Text = "";
            textCard.Text = "";
            combo1.Text = "";
            combo2.Text = "";
            picShow.Image = null;
        }
    }
}
