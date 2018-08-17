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
    public partial class docuForm : Form
    {
        private frm_dashboard db;
        

        public docuForm()
        {
            InitializeComponent();
            db = new frm_dashboard();

            
        }

        public void docuFormGet(DataView ds)
        {
            dg_area.DataSource = ds;
            this.Hide();
        }

        private void docuForm_Load(object sender, EventArgs e)
        {
            txt_titleDocu.Text = document.Title.ToString();

        }
        
        private void btn_addDocu_Click(object sender, EventArgs e)
        {
            db.dbCommand("","addDocu","insert into area_table(area_no,area_desc,doc_id) values ('"+cmb_areaNo.Text+"','"+txt_descDocu.Text+"','"+ document.Id.ToString() +"')");
            db.dbCommand("", "getArea", "select area_id as 'Area ID', area_no as 'Area No' ,area_desc as 'Area Description' from area_table where doc_id ='" + document.Id.ToString() + "'");
            this.Hide();
        }

        private void dg_area_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            foreach (DataGridViewRow row in dg_area.SelectedRows)
            {
                int areaId;
                areaId = Convert.ToInt32(row.Cells[0].Value.ToString());
                area.Id = areaId;
                area.area_no = row.Cells[1].Value.ToString();
                area.area_descs = row.Cells[2].Value.ToString();

                txt_descDocu.Text = area.area_descs.ToString();
                //area.Title = row.Cells[1].Value.ToString();

                string areaNumber = area.area_no.ToString();


                if (areaNumber == "AREA 1")
                {
                    cmb_areaNo.SelectedIndex = 0;
                }
                else if (areaNumber == "AREA 2")
                {
                    cmb_areaNo.SelectedIndex = 1;
                }
                else if (areaNumber == "AREA 3")
                {
                    cmb_areaNo.SelectedIndex = 2;
                }
                else if (areaNumber == "AREA 4")
                {
                    cmb_areaNo.SelectedIndex = 3;
                }
                else if (areaNumber == "AREA 5")
                {
                    cmb_areaNo.SelectedIndex = 4;
                }
                else if (areaNumber == "AREA 6")
                {
                    cmb_areaNo.SelectedIndex = 5;
                }
                else if (areaNumber == "AREA 7")
                {
                    cmb_areaNo.SelectedIndex = 6;
                }
                else if (areaNumber == "AREA 8")
                {
                    cmb_areaNo.SelectedIndex = 7;
                }
                else if (areaNumber == "AREA 9")
                {
                    cmb_areaNo.SelectedIndex = 8;
                }
                else if (areaNumber == "AREA 10")
                {
                    cmb_areaNo.SelectedIndex = 9;
                }

            }
        }

       

        private void btn_deleteArea_Click(object sender, EventArgs e)
        {
            db.dbCommand("","deleteArea","delete from area_table where area_id ='"+area.Id.ToString()+"'");
            this.Hide();
        }

        private void dg_area_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtEditArea_Click(object sender, EventArgs e)
        {
            db.dbCommand("", "updateArea", "update area_table set area_no = '"+ cmb_areaNo.Text +"', area_desc = '"+ txt_descDocu.Text +"' where area_id ='" + area.Id.ToString() + "'");
            this.Hide();
        }
    }
}
