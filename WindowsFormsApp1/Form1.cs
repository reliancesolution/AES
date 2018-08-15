using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public bool checkCredentials(string username, string password)
        {

            try {



            } catch (Exception x) {
                MessageBox.Show("ERROR CHECK CREDENTIALS : " + x);
            }




            return false;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
           
        }
    }
}
