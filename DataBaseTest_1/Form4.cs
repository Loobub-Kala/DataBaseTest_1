using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseTest_1
{
    public partial class FormIllegal : Form
    {
        private DataBaseClass sql = new DataBaseClass("127.0.0.1", "3306", "root", "kala123", "dormitory_management", "utf8");
        private String dataBaseName2 = "dormitory_illegal";
        private String cardCaseText;
        private String timeCase1Text;
        private String timeCase2Text;

        public FormIllegal()
        {
            InitializeComponent();
        }

        private void FormIllegal_Load(object sender, EventArgs e)
        {
            showData("", "", "");
            this.Location = new Point(FormMain.formMain.Location.X + 100, FormMain.formMain.Location.Y + 70);
        }

        private void FormIllegal_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormMain.formMain.Show();
        }
        
        private void cardCase_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                cardCaseText = this.cardCase.Text;
                showData(cardCaseText, "", "cardID");
            }
        }

        private void timeCase1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                query();
            }
        }

        private void timeCase2_KeyPress(object sender, KeyPressEventArgs e)
        {
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

        private void queryCard_Click(object sender, EventArgs e)
        {
            cardCaseText = this.cardCase.Text;
            showData(cardCaseText, "", "cardID");
        }

        private void queryTime_Click(object sender, EventArgs e)
        {
            query();
        }

        public void query()
        {
            //MessageBox.Show(timeCase1.Value+"+++"+timeCase2.Value+"+++"+ DateTime.Compare(timeCase1.Value, timeCase2.Value) + "\n");
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

        public void showData(String data1, String data2, String dataType)
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
            MySqlDataReader reader = queryData(data1, data2, dataType);
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
            if (dataType.Equals("cardID"))
            {
                str = "select * from " + dataBaseName2 + " where cardID = '" + data1 + "';";
                return sql.ExeQuery(str);
            }
            else if (dataType.Equals("time"))
            {
                str = "select * from " + dataBaseName2 + " where time between '" + data1 + "' and '" + data2 + "';";
                //MessageBox.Show(str + "\n");
                return sql.ExeQuery(str);
            }
            else
            {
                str = "select * from " + dataBaseName2;
                return sql.ExeQuery(str);
            }

        }
    }
}
