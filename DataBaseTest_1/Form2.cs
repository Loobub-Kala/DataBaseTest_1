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
    public partial class FormOld : Form
    {
        private DataBaseClass sql = new DataBaseClass("127.0.0.1", "3306", "root", "kala123", "dormitory_management", "utf8");
        private String dataBaseName = "dormitory_data";

        public FormOld()
        {
            InitializeComponent();
        }

        private void FormOld_Load(object sender, EventArgs e)
        {
            showData("");
            this.Location = new Point(FormMain.formMain.Location.X + 100, FormMain.formMain.Location.Y + 70);
        }

        private void FormOld_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormMain.formMain.Show();
        }

        private void returnMain_Click(object sender, EventArgs e)
        {
            FormMain.formMain.Show();
            this.Close();
        }

        private void newTable_Click(object sender, EventArgs e)
        {
            showData("");
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
            String sql_str = "select * from " + dataBaseName;
            MySqlDataReader reader = sql.ExeQuery(sql_str);
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

        public void insertData(String data)
        {
            String sql_str = "insert into " + dataBaseName + "(cardID,studentTime,studentID,studentName) values (" + data + ")";
            sql.ExeUpdate(sql_str);
        }
    }
}
