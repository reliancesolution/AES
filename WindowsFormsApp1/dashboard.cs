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
        DataSet setData;

        docuForm df;


        string userId;
       

        public frm_dashboard()
        {
            InitializeComponent();
            dbCommand("", "viewUser", "");
            dbCommand("", "showLogs", "select username as 'Username', full_name as 'Full Name', description as 'Description' from log_table");
            dbCommand("", "showDocu", "select id as 'ID', title as 'Title' from document_table");
        }
        private void clearRegTextBox() {
            txt_regUsername.Text = "";
            txt_regPassword.Text = "";
            txt_regConfirmPassword.Text = "";
            txt_regFullName.Text = "";
            cmb_regType.SelectedIndex = -1;

        }

        private void dbCommandLogs(string message) {

            try
            {
                conn = new MySqlConnection(cs);
                conn.Open();
                query = conn.CreateCommand();
                query.CommandText = "insert into log_table(username,full_name,description) values ('"+ Session.Username.ToString() +"','"+ Session.FullName.ToString() + "','"+ message +"')";
                query.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error:", ex.ToString());
                MessageBox.Show("Error:" + ex.ToString());
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

        }

        public void dbCommand(string module, string specialAction, string qry) {
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

                        dbCommandLogs(Session.FullName.ToString() + " added new account.");

                        MessageBox.Show("Account successfully added!");
                        clearRegTextBox();

                        query = conn.CreateCommand();
                        query.CommandText = "select id as 'ID', username as 'Username', full_name as 'Full Name', type as 'Type' from account_table where id != '" + Session.Id + "'";
                        adapt = new MySqlDataAdapter(query);
                        setData = new DataSet();
                        adapt.Fill(setData);
                        dg_accounts.DataSource = setData.Tables[0].DefaultView;

                    }
                    else
                    {
                        MessageBox.Show("Account Exist");
                        clearRegTextBox();
                    }


                }
                else if (module == "" && specialAction == "viewUser")
                {

                    query = conn.CreateCommand();
                    query.CommandText = "select id as 'ID', username as 'Username', full_name as 'Full Name', type as 'Type' from account_table where id != '" + Session.Id + "'";
                    adapt = new MySqlDataAdapter(query);
                    setData = new DataSet();
                    adapt.Fill(setData);
                    dg_accounts.DataSource = setData.Tables[0].DefaultView;

                }
                else if (module == "" && specialAction == "deleteUser")
                {
                    query.ExecuteNonQuery();
                    MessageBox.Show("Successfully deleted.");

                    dbCommandLogs(Session.FullName.ToString() + " has been successfully deleted an account.");


                }
                else if (module == "" && specialAction == "updateUser")
                {
                    query.Parameters.AddWithValue("@username", txt_regUsername.Text);
                    query.Parameters.AddWithValue("@full_name", txt_regFullName.Text);
                    query.Parameters.AddWithValue("@password", txt_regPassword.Text);                    
                    query.Parameters.AddWithValue("@type", cmb_regType.Text);
                    query.ExecuteNonQuery();

                    MessageBox.Show("Account has been updated!");

                    dbCommandLogs(Session.FullName.ToString() + " has been successfully updated an account.");
                }
                else if (module == "" && specialAction == "showLogs")
                {
                    adapt = new MySqlDataAdapter(query);
                    setData = new DataSet();
                    adapt.Fill(setData);
                    dt_logs.DataSource = setData.Tables[0].DefaultView;
                }                
                else if (module == "" && specialAction == "showDocu")
                {
                    adapt = new MySqlDataAdapter(query);
                    setData = new DataSet();
                    adapt.Fill(setData);
                    dt_docu.DataSource = setData.Tables[0].DefaultView;
                }                
                else if (module == "" && specialAction == "createDocuTitle")
                {
                    query.ExecuteNonQuery();
                }                
                else if (module == "" && specialAction == "getDocuId")
                {
                    adapt = new MySqlDataAdapter(query);
                    dataTable = new DataTable();
                    adapt.Fill(dataTable);

                    document.Id = Convert.ToInt32(dataTable.Rows[0][0].ToString());
                    document.Title = txt_titleDocu.Text;
                }
                else if (module == "" && specialAction == "addDocu")
                {
                    query.ExecuteNonQuery();
                }                
                else if (module == "" && specialAction == "showArea")
                {
                    
                        adapt = new MySqlDataAdapter(query);
                        setData = new DataSet();
                        adapt.Fill(setData);
                        df = new docuForm();
                        df.docuFormGet(setData.Tables[0].DefaultView);
                        //dg.DataSource = setData.Tables[0].DefaultView;
                        
                        df.Show();
                    
                }
                else if (module == "" && specialAction == "getArea")
                {

                    adapt = new MySqlDataAdapter(query);
                    setData = new DataSet();
                    adapt.Fill(setData);
                    df = new docuForm();
                    df.docuFormGet(setData.Tables[0].DefaultView);
                    //dg.DataSource = setData.Tables[0].DefaultView;

                    df.Hide();

                }
                else if (module == "" && specialAction == "deleteArea")
                {

                    query.ExecuteNonQuery();

                }
                else if (module == "" && specialAction == "deleteDocu")
                {
                    query.ExecuteNonQuery();
                }
                else if (module == "" && specialAction == "deleteArea")
                {
                    query.ExecuteNonQuery();
                }
                else if (module == "" && specialAction == "updateArea")
                {
                    query.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error:", ex.ToString());
                MessageBox.Show("Error:" + ex.ToString());
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

        //ignore
        //private void txt_regPassword_TextChanged(object sender, EventArgs e)
        //{

        //}

        private void dg_accounts_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btn_regDelete.Enabled = true;
            foreach (DataGridViewRow row in dg_accounts.SelectedRows)
            {
                userId = row.Cells[0].Value.ToString();
            }
        }

        private void btn_regDelete_Click(object sender, EventArgs e)
        {
            dbCommand("","deleteUser","delete from account_table where id='"+ userId +"'");
            dbCommand("", "viewUser", "");
            btn_regDelete.Enabled = false;
            clearRegTextBox();
        }

        private void frm_dashboard_Load(object sender, EventArgs e)
        {
            btn_regDelete.Enabled = false;
            btn_regUserSave.Visible = false;

           
        }

        private void btn_regEdit_Click(object sender, EventArgs e)
        {
            btn_regAdd.Enabled = false;
            btn_regDelete.Enabled = false;
            btn_regEdit.Visible = false;
            btn_regUserSave.Visible = true;
            foreach (DataGridViewRow row in dg_accounts.SelectedRows)
            {
                userId = row.Cells[0].Value.ToString();
                txt_regUsername.Text = row.Cells[1].Value.ToString();
                txt_regFullName.Text = row.Cells[2].Value.ToString();

                string regType = row.Cells[3].Value.ToString();

                if (regType == "admin")
                {
                    cmb_regType.SelectedIndex = 0;
                }
                else if (regType == "coordinator")
                {
                    cmb_regType.SelectedIndex = 1;
                }
                
            }
        }

        private void btn_regUserSave_Click(object sender, EventArgs e)
        {
            int userIdInt = Convert.ToInt32(userId);

            if (txt_regUsername.Text != "" && txt_regPassword.Text != "" && txt_regFullName.Text != "" && cmb_regType.Text != "")
            {
                if (txt_regPassword.Text == txt_regConfirmPassword.Text)
                {
                    dbCommand("", "updateUser", "update account_table set username = @username, full_name = @full_name, password = @password, type = @type where id= " + userIdInt + "");
                    dbCommand("", "viewUser", "");
                }
                else
                {
                    MessageBox.Show("Password Doesn't Match");
                }
              

            }
            else
            {
                MessageBox.Show("Fill all the blanks");
            }
            

            btn_regAdd.Enabled = true;
            btn_regEdit.Visible = true;
            btn_regUserSave.Visible = false;

            clearRegTextBox();
        }

        private void btn_logRefresh_Click(object sender, EventArgs e)
        {
            dbCommand("", "showLogs", "select username as 'Username', full_name as 'Full Name', description as 'Description' from log_table");
        }

        private void btn_refreshDocu_Click(object sender, EventArgs e)
        {
            dbCommand("", "showDocu", "select id as 'ID', title as 'Title' from document_table");
        }

        private void btnCreateDocu_Click(object sender, EventArgs e)
        {
            if (txt_titleDocu.Text != "")
            {
                dbCommand("", "createDocuTitle", "insert into document_table(title) values ('" + txt_titleDocu.Text + "')");
                dbCommand("", "getDocuId", "select id from document_table where title ='" + txt_titleDocu.Text + "'");

                txt_titleDocu.Text = "";
                docuForm manageDocu = new docuForm();
                manageDocu.Show();
            }
            else
            {
                MessageBox.Show("Fill all the blanks.");
            }

           
        }

        private void btnEditDocu_Click(object sender, EventArgs e)
        {
            

            if (txt_titleDocu.Text != "")
            {
                foreach (DataGridViewRow row in dt_docu.SelectedRows)
                {
                    int docId;
                    docId = Convert.ToInt32(row.Cells[0].Value.ToString());
                    document.Id = docId;
                    document.Title = row.Cells[1].Value.ToString();

                    //if (regType == "admin")
                    //{
                    // cmb_regType.SelectedIndex = 0;
                    //}
                    //else if (regType == "coordinator")
                    //{
                    //    cmb_regType.SelectedIndex = 1;
                    //}

                }
                dbCommand("", "showArea", "select area_id as 'Area ID', area_no as 'Area No' ,area_desc as 'Area Description' from area_table where doc_id ='" + document.Id.ToString() + "'");
                txt_titleDocu.Text = "";
            }
            else
            {
                MessageBox.Show("Fill all the blanks.");
            }


            
            
        }

        private void dt_docu_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            foreach (DataGridViewRow row in dt_docu.SelectedRows)
            {
                txt_titleDocu.Text = row.Cells[1].Value.ToString();
            }
        }

        private void btn_deleteDocu_Click(object sender, EventArgs e)
        {
            if (txt_titleDocu.Text != "")
            {
                foreach (DataGridViewRow row in dt_docu.SelectedRows)
                {
                    int docId;
                    docId = Convert.ToInt32(row.Cells[0].Value.ToString());
                    document.Id = docId;
                    document.Title = row.Cells[1].Value.ToString();
                }
                dbCommand("", "deleteDocu", "delete from document_table where id='" + document.Id.ToString() + "'");
                dbCommand("", "deleteArea", "delete from area_table where doc_id='" + document.Id.ToString() + "'");
                dbCommand("", "showDocu", "select id as 'ID', title as 'Title' from document_table");

                txt_titleDocu.Text = "";
            }
            else
            {
                MessageBox.Show("Fill all the blanks.");
            }
           
        }

        //private void dg_accounts_SelectionChanged(object sender, EventArgs e)
        //{

        //}
    }
}
