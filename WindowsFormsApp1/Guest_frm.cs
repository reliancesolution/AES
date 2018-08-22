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
    public partial class Guest_frm : Form
    {
        private string cs = @"server=localhost;userid=root;
            password=;database=db_aes;SslMode=none";
        private MySqlCommand query;
        private MySqlDataAdapter adapt;
        private DataTable dataTable = new DataTable();
        private MySqlConnection conn = null;
        DataSet setData;

        private frm_dashboard db;

        public Guest_frm()
        {
            InitializeComponent();
            db = new frm_dashboard();
        }

        public void docuFormGuest(DataView gf)
        {
            //lv_docu.Items.Add(gf);
            //MessageBox.Show(gf.Table.Rows[0][1].ToString());

            dg_documentsForGuest.DataSource = gf;
        }
        public void loadGuestBySearch(DataView gf)
        {
            if (gf.Table.Rows.Count > 0)
            {
                MessageBox.Show("has value : " + gf.Table.Rows.Count);
            }
            else
            {
                MessageBox.Show("doesn't have value : " + gf.Table.Rows.Count);
            }
            //DataGridView dataGridView1 = new DataGridView();

            //lv_docu.DataSource = gf;
            //dataGridView1.gf.ToList();
        }

        private void btn_backToLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 goToLoginForm = new Form1();
            goToLoginForm.Show();
        }

        public void Guest_frm_Load(object sender, EventArgs e)
        {
            //db.dbCommand("", "showDocuGuest", "select id as 'ID', title as 'Title' from document_table");
           // db.dbCommand("", "showDocuGuest", "select * from document_table");


            try
            {
                conn = new MySqlConnection(cs);
                conn.Open();
                query = conn.CreateCommand();
                query.CommandText = "select id as 'ID', title as 'Title' from document_table";


                adapt = new MySqlDataAdapter(query);
                setData = new DataSet();
                adapt.Fill(setData);
                dg_documentsForGuest.DataSource = setData.Tables[0].DefaultView;

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

        public void btn_SearchGuestDocu_Click(object sender, EventArgs e)
        {

            try
            {
                conn = new MySqlConnection(cs);
                conn.Open();
                query = conn.CreateCommand();
                query.CommandText =  "select id as 'ID', title as 'Title' from document_table where title Like '%" + txtSearchGuest.Text + "%'";


                adapt = new MySqlDataAdapter(query);
                setData = new DataSet();
                adapt.Fill(setData);
                dg_documentsForGuest.DataSource = setData.Tables[0].DefaultView;
           
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

           // db.dbCommand("", "searchDocuGuest", "select id as 'ID', title as 'Title' from document_table where title Like '%" + txtSearchGuest.Text + "%'");
        }

        
    }
}
