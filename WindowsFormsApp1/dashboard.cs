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

using System.Data.OleDb;

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

        Guest_frm gf;


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

        public void dbCommandLogs(string message) {

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
                else if (module == "" && specialAction == "showDocuGuest")
                {
                    adapt = new MySqlDataAdapter(query);
                    setData = new DataSet();
                    
                    adapt.Fill(setData);
                    gf = new Guest_frm();
                    gf.docuFormGuest(setData.Tables[0].DefaultView);


                   

                }                
                else if (module == "" && specialAction == "searchDocuGuest")
                {
                    adapt = new MySqlDataAdapter(query);
                    setData = new DataSet();
                    adapt.Fill(setData);
                    gf = new Guest_frm();
                    gf.loadGuestBySearch(setData.Tables[0].DefaultView);
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
                else if (module == "" && specialAction == "importArea")
                {
                    query.ExecuteNonQuery();
                }                
                else if (module == "" && specialAction == "searchDocuByTitle")
                {
                    adapt = new MySqlDataAdapter(query);
                    setData = new DataSet();
                    adapt.Fill(setData);
                    dt_docu.DataSource = setData.Tables[0].DefaultView;
                }
                else if (module == "" && specialAction == "searchDocuGuest")
                {
                    adapt = new MySqlDataAdapter(query);
                    setData = new DataSet();
                    adapt.Fill(setData);
                    gf = new Guest_frm();
                    gf.loadGuestBySearch(setData.Tables[0].DefaultView);

                    //dt_docu.DataSource = setData.Tables[0].DefaultView;
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
            txtSaveExcelPath.Enabled = false;

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

                    dbCommandLogs(Session.FullName.ToString() + " added new account.");
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

        private void txtChoose_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();

            if (OFD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.txtPath.Text = OFD.FileName;
            }
            try
            {
                //string PathConn = "Provider=Microsoft.Jet.OLEB.4.0;Data Source= " + txtPath.Text + ";Extended Properties=\"Excel 8.0;HDR=Yes;\";";
                if (txtPath.Text == "")
                {
                    MessageBox.Show("Must fill all the blanks.");
                }
                else
                {
                    string PathConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= " + txtPath.Text + ";Extended Properties='Excel 12.0 Xml;HDR=YES';";
                    OleDbConnection conn = new OleDbConnection(PathConn);
                    //OleDbDataAdapter myOledbDataAdapter = new OleDbDataAdapter("Select * from [" + txtLoadFile.Text + "$]", conn);
                    OleDbDataAdapter myOledbDataAdapter = new OleDbDataAdapter("Select * from [Sheet1$]", conn);
                    dataTable = new DataTable();
                    myOledbDataAdapter.Fill(dataTable);
                    dg_excelImport.DataSource = dataTable;
                    txtSaveExcelPath.Enabled = true;
                    MessageBox.Show("Success Importing");
                }
            }
            catch (Exception ex) { MessageBox.Show("Failed to Load: " + ex); }
        }

        private void txtSaveExcelPath_Click(object sender, EventArgs e)
        {
            try {

                if (txtDocument_id.Text == "" || txtPath.Text == "")
                {
                    MessageBox.Show("Please fill the blanks.");
                }
                else
                {
                    string StrQuery;
                    for (int i = 0; i <= Convert.ToInt32(dg_excelImport.Rows.Count) - 1; i++)
                    {
                        if (dg_excelImport.Rows[i].Cells["Area No"].Value.ToString() != "")
                        {
                            StrQuery = @"INSERT INTO area_table (area_no,area_desc,doc_id) VALUES ('"
                            + dg_excelImport.Rows[i].Cells["Area No"].Value.ToString().Replace("'", "''") + "','"
                            + dg_excelImport.Rows[i].Cells["Description"].Value.ToString().Replace("'", "''") + "','"
                            + txtDocument_id.Text + "');";

                            dbCommand("", "importArea", StrQuery);

                        }


                    } // end for
                    MessageBox.Show("Successfully imported!");
                    dbCommandLogs(Session.FullName.ToString() +" successfully imported an excel file.");


                    txtPath.Text = "";
                    txtDocument_id.Text = "";

                    dg_excelImport.DataSource = null;
                    dg_excelImport.Rows.Clear();
                    dg_excelImport.Refresh();
                }

            } catch (Exception ex) {

                MessageBox.Show("Failed to import.");

            }
            
        }

        private void btn_searchDocu_Click(object sender, EventArgs e)
        {
            dbCommand("","searchDocuByTitle", "select id as 'ID', title as 'Title' from document_table where title Like '%" + txt_searchDocu.Text +"%'");
        }

        private void btnPrint_Click(object sender, EventArgs e)
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

            //printPreviewDialog1.Document = printDocument1;
            //printPreviewDialog1.ShowDialog();
        }

        

        //private void dg_accounts_SelectionChanged(object sender, EventArgs e)
        //{

        //}
    }
}
