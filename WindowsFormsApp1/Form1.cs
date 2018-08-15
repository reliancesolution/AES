using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            testConnection();
        }

        public void testConnection() {

            string cs = @"server=localhost;userid=root;
            password=;database=db_aes;SslMode=none";

            MySqlConnection conn = null;

            try
            {
                conn = new MySqlConnection(cs);
                conn.Open();
                //Console.WriteLine("MySQL version : {0}", conn.ServerVersion);
               
                MessageBox.Show("connection success");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error:", ex.ToString());
                // MessageBox.Show("Error:", ex.ToString());
                MessageBox.Show("connection failed." + ex.ToString());

            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

            
        }

        public void checkCredentials(string username, string password)
        {

            string cs = @"server=localhost;userid=root;
            password=;database=db_aes;SslMode=none";

            MySqlConnection conn = null;

            try
            {
                conn = new MySqlConnection(cs);
                conn.Open();
                //Console.WriteLine("MySQL version : {0}", conn.ServerVersion);

                MySqlCommand query = conn.CreateCommand();
                query.CommandText = "select count(*) from account_table where username= '" + username + "' and password='" + password + "'";
                MySqlDataAdapter adapt = new MySqlDataAdapter(query);
                DataTable dataTable = new DataTable();
                adapt.Fill(dataTable);

                if(dataTable.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show("Login Success!");
                   

                }
                else if (dataTable.Rows[0][0].ToString() == "2")
                {
                    MessageBox.Show("Error: Duplicated Account!");
                }
                else
                {
                    MessageBox.Show("Username or Password is incorrect!");
                }
           

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error:", ex.ToString());
                // MessageBox.Show("Error:", ex.ToString());
                MessageBox.Show("connection failed." + ex.ToString());

            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }




        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            checkCredentials(txt_username.Text, txt_password.Text);
        }
    }
}
