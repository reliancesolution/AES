namespace WindowsFormsApp1
{
    partial class Guest_frm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchGuest = new System.Windows.Forms.TextBox();
            this.btn_SearchGuestDocu = new System.Windows.Forms.Button();
            this.btn_backToLogin = new System.Windows.Forms.Button();
            this.dg_documentsForGuest = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dg_documentsForGuest)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(952, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search";
            // 
            // txtSearchGuest
            // 
            this.txtSearchGuest.Location = new System.Drawing.Point(999, 17);
            this.txtSearchGuest.Name = "txtSearchGuest";
            this.txtSearchGuest.Size = new System.Drawing.Size(100, 20);
            this.txtSearchGuest.TabIndex = 1;
            // 
            // btn_SearchGuestDocu
            // 
            this.btn_SearchGuestDocu.Location = new System.Drawing.Point(1105, 15);
            this.btn_SearchGuestDocu.Name = "btn_SearchGuestDocu";
            this.btn_SearchGuestDocu.Size = new System.Drawing.Size(75, 23);
            this.btn_SearchGuestDocu.TabIndex = 2;
            this.btn_SearchGuestDocu.Text = "Search";
            this.btn_SearchGuestDocu.UseVisualStyleBackColor = true;
            this.btn_SearchGuestDocu.Click += new System.EventHandler(this.btn_SearchGuestDocu_Click);
            // 
            // btn_backToLogin
            // 
            this.btn_backToLogin.Location = new System.Drawing.Point(1050, 462);
            this.btn_backToLogin.Name = "btn_backToLogin";
            this.btn_backToLogin.Size = new System.Drawing.Size(130, 23);
            this.btn_backToLogin.TabIndex = 4;
            this.btn_backToLogin.Text = "Back to Login";
            this.btn_backToLogin.UseVisualStyleBackColor = true;
            this.btn_backToLogin.Click += new System.EventHandler(this.btn_backToLogin_Click);
            // 
            // dg_documentsForGuest
            // 
            this.dg_documentsForGuest.AllowUserToAddRows = false;
            this.dg_documentsForGuest.AllowUserToDeleteRows = false;
            this.dg_documentsForGuest.AllowUserToResizeColumns = false;
            this.dg_documentsForGuest.AllowUserToResizeRows = false;
            this.dg_documentsForGuest.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_documentsForGuest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_documentsForGuest.Location = new System.Drawing.Point(43, 59);
            this.dg_documentsForGuest.MultiSelect = false;
            this.dg_documentsForGuest.Name = "dg_documentsForGuest";
            this.dg_documentsForGuest.ReadOnly = true;
            this.dg_documentsForGuest.Size = new System.Drawing.Size(1137, 397);
            this.dg_documentsForGuest.TabIndex = 5;
            // 
            // Guest_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 497);
            this.Controls.Add(this.dg_documentsForGuest);
            this.Controls.Add(this.btn_backToLogin);
            this.Controls.Add(this.btn_SearchGuestDocu);
            this.Controls.Add(this.txtSearchGuest);
            this.Controls.Add(this.label1);
            this.Name = "Guest_frm";
            this.Text = "GUEST";
            this.Load += new System.EventHandler(this.Guest_frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_documentsForGuest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchGuest;
        private System.Windows.Forms.Button btn_SearchGuestDocu;
        private System.Windows.Forms.Button btn_backToLogin;
        private System.Windows.Forms.DataGridView dg_documentsForGuest;
    }
}