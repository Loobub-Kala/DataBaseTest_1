using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DataBaseTest_1
{
    class DataBaseClass
    {

        String server = "127.0.0.1";
        String port = "3306";
        String user = "root";
        String password = "kala123";
        String database = "dormitory_management";
        String charset = "utf8";

        public DataBaseClass() { }
        public DataBaseClass(String server, String port, String user, String password, String database, String charset)
        {
            this.server = server;
            this.port = port;
            this.user = user;
            this.password = password;
            this.database = database;
            this.charset = charset;
        }
        public DataBaseClass setServer(String server)
        {
            this.server = server;
            return this;
        }

        public DataBaseClass setPort(String port)
        {
            this.port = port;
            return this;
        }

        public DataBaseClass setUser(String user)
        {
            this.user = user;
            return this;
        }

        public DataBaseClass setPassword(String password)
        {
            this.password = password;
            return this;
        }

        public DataBaseClass setDatabase(String database)
        {
            this.database = database;
            return this;
        }

        public DataBaseClass setCharset(String charset)
        {
            this.charset = charset;
            return this;
        }


        /// <summary>
        /// 建立数据库连接.
        /// </summary>
        /// <returns>返回MySqlConnection对象</returns>

        private MySqlConnection GetMySQLConnection()
        {
            //string是c#中的类，String是Framework的类
            //C# string 映射为 Framework的 String
            //如果用string,编译器会把它编译成String
            //所以如果直接用String就可以让编译器少做一点点工作
            //如果使用C#，建议使用string，比较符合规范
            String M_str_sqlcon = string.Format("server={0};port={1};user={2};password={3};database={4};Charset={5}", server, port, user, password, database, charset);
            //String connetStr = "server=127.0.0.1;port=3306;user=root;password=kala123"; 
            MySqlConnection myCon = new MySqlConnection(M_str_sqlcon);
            return myCon;
        }

        /// <summary>
        /// 执行MySqlCommand
        /// </summary>
        /// <param name="M_str_sqlstr">SQL语句</param>
        public void ExeUpdate(String M_str_sqlstr)
        {
            MySqlConnection mysqlcon = this.GetMySQLConnection();
            MySqlCommand mysqlcom = new MySqlCommand(M_str_sqlstr, mysqlcon);
            mysqlcon.Open();
            mysqlcom.ExecuteNonQuery();
            mysqlcom.Dispose();
            mysqlcon.Close();
            mysqlcon.Dispose();
        }

        /// <summary>
    /// 创建一个MySqlDataReader对象
    /// </summary>
    /// <param name="M_str_sqlstr">SQL语句</param>
    /// <returns>返回MySqlDataReader对象</returns>
    public MySqlDataReader ExeQuery(String M_str_sqlstr)
        {
            Console.WriteLine(M_str_sqlstr);
            MySqlConnection mysqlcon = this.GetMySQLConnection();
            MySqlCommand mysqlcom = new MySqlCommand(M_str_sqlstr, mysqlcon);
            mysqlcon.Open();
            MySqlDataReader mysqlread = mysqlcom.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            return mysqlread;
        }
    }
}
