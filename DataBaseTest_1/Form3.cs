using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseTest_1
{
    public partial class FormStudent : Form
    {
        private DataBaseClass sql = new DataBaseClass("127.0.0.1", "3306", "root", "kala123", "dormitory_management", "utf8");
        private String dataBaseName = "dormitory_data";
        private String dataBaseName1 = "dormitory_student";
        private TextBox textBox;

        public FormStudent()
        {
            InitializeComponent();
        }

        private void FormStudent_Load(object sender, EventArgs e)
        {
            this.Location = new Point(FormMain.formMain.Location.X + 100, FormMain.formMain.Location.Y + 70);
        }

        private void FormStudent_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormMain.formMain.Show();
        }

        private void textBox0_KeyPress(object sender, KeyPressEventArgs e)
        {
            //如果输入的不是数字键，也不是Backspace键，则取消该输入
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
            //回车键查询
            if (e.KeyChar == (char)13)
            {
                textBox = this.textBox0;
                showData(textBox.Text);
            }
        }

        private void returnMain_Click(object sender, EventArgs e)
        {
            FormMain.formMain.Show();
            this.Close();
        }

        private void queryID_Click(object sender, EventArgs e)
        {
            textBox = this.textBox0;
            showData(textBox.Text);
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
            Boolean isHave = false;
            Boolean isOK = false;
            String sql_str;
            String sql_str_stu;
            MySqlDataReader reader = null;
            MySqlDataReader readerStudent = null;
            if (data.Length == 7 || data.Length == 6)
            {
                if (data.Length == 7)
                {
                    sql_str = "select * from " + dataBaseName + " where exists (select studentID from " + dataBaseName1 + ") and studentID = '"+ data +"';";
                    reader = sql.ExeQuery(sql_str);
                    sql_str_stu = "select * from " + dataBaseName1 + " where studentID = '" + data + "';";
                    readerStudent = sql.ExeQuery(sql_str_stu);
                }
                else
                {
                    sql_str = "select * from " + dataBaseName + " where exists (select cardID from " + dataBaseName1 + ") and cardID = '" + data + "';";
                    reader = sql.ExeQuery(sql_str);
                    sql_str_stu = "select * from " + dataBaseName1 + " where cardID = '" + data + "';";
                    readerStudent = sql.ExeQuery(sql_str_stu);
                }
                while (reader.Read())
                {
                    int index = dataGridView.Rows.Add();
                    dataGridView.Rows[index].Cells[0].Value = index + 1;
                    dataGridView.Rows[index].Cells[1].Value = reader.GetValue(2);
                    isHave = true;
                }
                if (readerStudent.Read())
                {
                    this.studentName.Text = readerStudent.GetValue(3).ToString();
                    this.studentID.Text = readerStudent.GetValue(2).ToString();
                    this.cardID.Text = readerStudent.GetValue(1).ToString();
                    this.dormitoryID.Text = readerStudent.GetValue(4).ToString();

                    //String[] pic = Directory.GetFiles(@"E:\\大三\\RFID\\项目\\stuPicture\\111111.jpg");
                    String path = "E:\\大三\\RFID\\项目\\stuPicture\\" + this.cardID.Text + ".jpg";
                    this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    this.pictureBox1.Image = Image.FromFile(@path);
                    isOK = true;
                }

                //卡号、学号、姓名、寝室号
                if (!isOK)
                {
                    MessageBox.Show("查无此人<(－︿－)>");
                }
                else
                {
                    if (!isHave)
                    {
                        MessageBox.Show("没有数据<(－︿－)>");
                    }
                }
            }
            else
            {
                MessageBox.Show("乱打我是不会帮你查的，哼，重打吧<(－︿－)>");
            }
        }

    }
}
