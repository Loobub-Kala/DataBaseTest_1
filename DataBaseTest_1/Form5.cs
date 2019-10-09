using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseTest_1
{
    public partial class FormTime : Form
    {
        private DataBaseClass sql = new DataBaseClass("127.0.0.1", "3306", "root", "kala123", "dormitory_management", "utf8");
        private String dataBaseName = "dormitory_data";
        private String timeCase1Text;
        private String timeCase2Text;

        public FormTime()
        {
            InitializeComponent();
        }

        private void FormTime_Load(object sender, EventArgs e)
        {
            showData("", "", "");
            this.Location = new Point(FormMain.formMain.Location.X + 100, FormMain.formMain.Location.Y + 70);
        }

        private void FormTime_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormMain.formMain.Show();
            this.Close();
        }

        private void timeCase1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //回车键查询
            if (e.KeyChar == (char)13)
            {
                query();
            }
        }

        private void timeCase2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //回车键查询
            if (e.KeyChar == (char)13)
            {
                query();
            }
        }
       
        private void returnMain_Click(object sender, EventArgs e)
        {
            FormMain.formMain.Show();
            this.Close();
        }

        private void newTable_Click(object sender, EventArgs e)
        {
            showData("", "", "");
        }

        private void queryTime_Click(object sender, EventArgs e)
        {
            query();
        }

        //查询时段
        public void query()
        {
            if (DateTime.Compare(timeCase1.Value, timeCase2.Value) < 0)
            {
                TimeSpan tc1 = new TimeSpan(timeCase1.Value.Ticks);
                TimeSpan tc2 = new TimeSpan(timeCase2.Value.Ticks);
                TimeSpan ts = tc2.Subtract(tc1);
                showTime.Text = ts.Days.ToString() + "天" + ts.Hours.ToString() + "小时" + ts.Minutes.ToString() + "分";
                timeCase1Text = timeCase1.Text.ToString();
                timeCase2Text = timeCase2.Text.ToString();
                showData(timeCase1Text, timeCase2Text, "time");
                //MessageBox.Show(timeCase1.Text.ToString());
            }
            else
            {
                showTime.Text = "0天0小时0分";
                MessageBox.Show("时间不正确诶，请仔细检查一下错误吧〒▽〒" + "\n");
                //showData("", "");
            }
        }

        public void showData(String time1, String time2, String dataType)
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
            MySqlDataReader reader = queryData(time1, time2, dataType);
            //String result = "";

            while (reader.Read())
            {
                int index = dataGridView.Rows.Add();
                dataGridView.Rows[index].Cells[0].Value = index + 1;
                for (int i = 1; i < reader.FieldCount; i++)
                {
                    //卡号、时间
                    dataGridView.Rows[index].Cells[i].Value = reader.GetValue(i);
                    //result += reader.GetName(1) + "\t" + reader.GetValue(1) + "\r\n";
                    //textBox1.Text = result;
                }
            }
        }

        //查询数据
        public MySqlDataReader queryData(String data1, String data2, String dataType)
        {
            String str = null;
            if (dataType.Equals("time"))
            {
                str = "select * from " + dataBaseName + " where studentTime between '" + data1 + "' and '" + data2 + "';";
                //MessageBox.Show(str + "\n");
                return sql.ExeQuery(str);
            }
            else
            {
                str = "select * from " + dataBaseName;
                return sql.ExeQuery(str);
            }
        }
    }
}
