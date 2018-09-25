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
        private string cs = @"server=localhost;userid=root;
            password=;database=db_aes;SslMode=none";
        private MySqlCommand query;
        private MySqlDataAdapter adapt;
        private DataTable dataTable = new DataTable();
        private MySqlConnection conn = null;

        Guest_frm showGuest;

        public Form1()
        {
            InitializeComponent();
            testConnection();
        }

        public void testConnection() {
           
            try
            {
                conn = new MySqlConnection(cs);
                conn.Open();
                //Console.WriteLine("MySQL version : {0}", conn.ServerVersion);
               
                //MessageBox.Show("connection success");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error:", ex.ToString());
                // MessageBox.Show("Error:", ex.ToString());
                MessageBox.Show("Database Connection failed." + ex.ToString());

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

            try
            {
                conn = new MySqlConnection(cs);
                conn.Open();
                //Console.WriteLine("MySQL version : {0}", conn.ServerVersion);

                query = conn.CreateCommand();
                query.CommandText = "select count(*) from account_table where username= '" + username + "' and password='" + password + "'";
                adapt = new MySqlDataAdapter(query);
                dataTable = new DataTable();
                adapt.Fill(dataTable);
                
                if (dataTable.Rows[0][0].ToString() == "1")
                {
                    query.CommandText = "select type from account_table where username= '" + username + "' and password='" + password + "'";
                    adapt = new MySqlDataAdapter(query);
                    dataTable = new DataTable();
                    adapt.Fill(dataTable);

                    
                    
                    if (dataTable.Rows[0][0].ToString() == "admin")
                    {
                        //create session
                        query.CommandText = "select * from account_table where username= '" + username + "' and password='" + password + "'";
                        adapt = new MySqlDataAdapter(query);
                        dataTable = new DataTable();
                        adapt.Fill(dataTable);

                        Session.Id = Convert.ToInt32(dataTable.Rows[0][0].ToString());
                        Session.Username = dataTable.Rows[0][1].ToString();
                        Session.FullName = dataTable.Rows[0][2].ToString();
                        Session.Type = dataTable.Rows[0][3].ToString();
                        
                        this.Hide();
                        
                        frm_dashboard showDashboard = new frm_dashboard();
                        showDashboard.dbCommandLogs(Session.FullName.ToString() + " logged in. ");
                        showDashboard.Show();
                        
                    }
                    else if (dataTable.Rows[0][0].ToString() == "coordinator")
                    {
                        //create session
                        query.CommandText = "select * from account_table where username= '" + username + "' and password='" + password + "'";
                        adapt = new MySqlDataAdapter(query);
                        dataTable = new DataTable();
                        adapt.Fill(dataTable);

                        Session.Id = Convert.ToInt32(dataTable.Rows[0][0].ToString());
                        Session.Username = dataTable.Rows[0][1].ToString();
                        Session.FullName = dataTable.Rows[0][2].ToString();
                        Session.Type = dataTable.Rows[0][3].ToString();

                        this.Hide();

                        frm_dashboard showDashboard = new frm_dashboard();
                        showDashboard.dbCommandLogs(Session.FullName.ToString() + " logged in. ");
                        showDashboard.Show();
                    }

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
                MessageBox.Show("connection failed.");

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

            try
            {
                conn = new MySqlConnection(cs);
                conn.Open();


                checkCredentials(txt_username.Text, txt_password.Text);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error:", ex.ToString());
                // MessageBox.Show("Error:", ex.ToString());
                MessageBox.Show("Database Connection failed." + ex.ToString());

            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }



            
        }

        private void btnGoToGuest_Click(object sender, EventArgs e)
        {
            this.Hide();
            showGuest = new Guest_frm();

            showGuest.Show();
        }
    }
}
