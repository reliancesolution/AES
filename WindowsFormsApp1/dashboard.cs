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
    public partial class frm_dashboard : Form
    {
        private string cs = @"server=localhost;userid=root;
            password=;database=db_aes;SslMode=none";
        private MySqlCommand query;
        private MySqlDataAdapter adapt;
        private DataTable dataTable = new DataTable();
        private MySqlConnection conn = null;

        public frm_dashboard()
        {
            InitializeComponent();
        }
        private void clearRegTextBox() {
            txt_regUsername.Text = "";
            txt_regPassword.Text = "";
            txt_regConfirmPassword.Text = "";
            txt_regFullName.Text = "";
            cmb_regType.SelectedIndex = -1;

        }

        private void dbCommand(string module, string specialAction, string qry) {
            try
            {
                conn = new MySqlConnection(cs);
                conn.Open();
                query = conn.CreateCommand();
                query.CommandText = qry;
                

                if (module == "" && specialAction == "addUser")
                {                    
                    adapt = new MySqlDataAdapter(query);
                    dataTable = new DataTable();
                    adapt.Fill(dataTable);

                    if (dataTable.Rows[0][0].ToString() == "0")
                    {
                        query = conn.CreateCommand();
                        query.CommandText = "insert into account_table(username,password,full_name,type) values (@username,@password,@full_name,@type)";
                        query.Parameters.AddWithValue("@username", txt_regUsername.Text);
                        query.Parameters.AddWithValue("@password", txt_regPassword.Text);
                        query.Parameters.AddWithValue("@full_name", txt_regFullName.Text);
                        query.Parameters.AddWithValue("@type", cmb_regType.Text);
                        query.ExecuteNonQuery();

                        MessageBox.Show("Account successfully added!");
                        clearRegTextBox();
                    }
                    else
                    {
                        MessageBox.Show("Account Exist");
                        clearRegTextBox();
                    }

                
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error:", ex.ToString());
                MessageBox.Show("Error:", ex.ToString());
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 showLogin = new Form1();
            showLogin.Show();
        }

        private void btn_regAdd_Click(object sender, EventArgs e)
        {

            if (txt_regUsername.Text != "" && txt_regPassword.Text != "" && txt_regFullName.Text != "" && cmb_regType.Text != "")
            {
                if (txt_regPassword.Text == txt_regConfirmPassword.Text)
                {
                    dbCommand("", "addUser", "select count(*) from account_table where username= '" + txt_regUsername.Text + "' and password='" + txt_regPassword.Text + "'");
                }
                else
                {
                    MessageBox.Show("Password does not matched.");
                }
            }
            else
            {
                MessageBox.Show("Please fill all the blank.");
            }
           
        }

        private void txt_regPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
