namespace WindowsFormsApp1
{
    partial class docuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_titleDocu = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_addDocu = new System.Windows.Forms.Button();
            this.txtEditArea = new System.Windows.Forms.Button();
            this.btn_deleteArea = new System.Windows.Forms.Button();
            this.txt_descDocu = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_areaNo = new System.Windows.Forms.ComboBox();
            this.dg_area = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dg_area)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_titleDocu
            // 
            this.txt_titleDocu.Enabled = false;
            this.txt_titleDocu.Location = new System.Drawing.Point(650, 51);
            this.txt_titleDocu.Name = "txt_titleDocu";
            this.txt_titleDocu.Size = new System.Drawing.Size(152, 20);
            this.txt_titleDocu.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(605, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "TITLE :";
            // 
            // btn_addDocu
            // 
            this.btn_addDocu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addDocu.Location = new System.Drawing.Point(808, 48);
            this.btn_addDocu.Name = "btn_addDocu";
            this.btn_addDocu.Size = new System.Drawing.Size(87, 24);
            this.btn_addDocu.TabIndex = 25;
            this.btn_addDocu.Text = "ADD";
            this.btn_addDocu.UseVisualStyleBackColor = true;
            this.btn_addDocu.Click += new System.EventHandler(this.btn_addDocu_Click);
            // 
            // txtEditArea
            // 
            this.txtEditArea.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditArea.Location = new System.Drawing.Point(901, 48);
            this.txtEditArea.Name = "txtEditArea";
            this.txtEditArea.Size = new System.Drawing.Size(87, 51);
            this.txtEditArea.TabIndex = 23;
            this.txtEditArea.Text = "EDIT";
            this.txtEditArea.UseVisualStyleBackColor = true;
            this.txtEditArea.Click += new System.EventHandler(this.txtEditArea_Click);
            // 
            // btn_deleteArea
            // 
            this.btn_deleteArea.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deleteArea.Location = new System.Drawing.Point(808, 75);
            this.btn_deleteArea.Name = "btn_deleteArea";
            this.btn_deleteArea.Size = new System.Drawing.Size(87, 24);
            this.btn_deleteArea.TabIndex = 22;
            this.btn_deleteArea.Text = "DELETE";
            this.btn_deleteArea.UseVisualStyleBackColor = true;
            this.btn_deleteArea.Click += new System.EventHandler(this.btn_deleteArea_Click);
            // 
            // txt_descDocu
            // 
            this.txt_descDocu.Location = new System.Drawing.Point(650, 114);
            this.txt_descDocu.Multiline = true;
            this.txt_descDocu.Name = "txt_descDocu";
            this.txt_descDocu.Size = new System.Drawing.Size(338, 241);
            this.txt_descDocu.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(562, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "DESCRIPTION :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(584, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "AREA NO. :";
            // 
            // cmb_areaNo
            // 
            this.cmb_areaNo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmb_areaNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_areaNo.FormattingEnabled = true;
            this.cmb_areaNo.Items.AddRange(new object[] {
            "AREA 1",
            "AREA 2",
            "AREA 3",
            "AREA 4",
            "AREA 5",
            "AREA 6",
            "AREA 7",
            "AREA 8",
            "AREA 9",
            "AREA 10"});
            this.cmb_areaNo.Location = new System.Drawing.Point(650, 78);
            this.cmb_areaNo.Name = "cmb_areaNo";
            this.cmb_areaNo.Size = new System.Drawing.Size(152, 21);
            this.cmb_areaNo.TabIndex = 18;
            // 
            // dg_area
            // 
            this.dg_area.AllowUserToAddRows = false;
            this.dg_area.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_area.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_area.Location = new System.Drawing.Point(23, 44);
            this.dg_area.Name = "dg_area";
            this.dg_area.ReadOnly = true;
            this.dg_area.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_area.Size = new System.Drawing.Size(530, 348);
            this.dg_area.TabIndex = 28;
            this.dg_area.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_area_CellContentClick);
            this.dg_area.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dg_area_CellMouseClick);
            // 
            // docuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 450);
            this.Controls.Add(this.dg_area);
            this.Controls.Add(this.txt_titleDocu);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_addDocu);
            this.Controls.Add(this.txtEditArea);
            this.Controls.Add(this.btn_deleteArea);
            this.Controls.Add(this.txt_descDocu);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmb_areaNo);
            this.Name = "docuForm";
            this.Text = "Documents";
            this.Load += new System.EventHandler(this.docuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_area)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_titleDocu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_addDocu;
        private System.Windows.Forms.Button txtEditArea;
        private System.Windows.Forms.Button btn_deleteArea;
        private System.Windows.Forms.TextBox txt_descDocu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_areaNo;
        private System.Windows.Forms.DataGridView dg_area;
    }
}