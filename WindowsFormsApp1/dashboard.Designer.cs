namespace WindowsFormsApp1
{
    partial class frm_dashboard
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
            this.btn_accountForm = new System.Windows.Forms.Button();
            this.btn_documentsForm = new System.Windows.Forms.Button();
            this.btn_userLogsForm = new System.Windows.Forms.Button();
            this.btn_documentGenForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_accountForm
            // 
            this.btn_accountForm.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_accountForm.Location = new System.Drawing.Point(27, 33);
            this.btn_accountForm.Name = "btn_accountForm";
            this.btn_accountForm.Size = new System.Drawing.Size(204, 70);
            this.btn_accountForm.TabIndex = 0;
            this.btn_accountForm.Text = "ACCOUNT";
            this.btn_accountForm.UseVisualStyleBackColor = true;
            // 
            // btn_documentsForm
            // 
            this.btn_documentsForm.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_documentsForm.Location = new System.Drawing.Point(27, 109);
            this.btn_documentsForm.Name = "btn_documentsForm";
            this.btn_documentsForm.Size = new System.Drawing.Size(204, 70);
            this.btn_documentsForm.TabIndex = 1;
            this.btn_documentsForm.Text = "DOCUMENTS";
            this.btn_documentsForm.UseVisualStyleBackColor = true;
            // 
            // btn_userLogsForm
            // 
            this.btn_userLogsForm.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_userLogsForm.Location = new System.Drawing.Point(27, 185);
            this.btn_userLogsForm.Name = "btn_userLogsForm";
            this.btn_userLogsForm.Size = new System.Drawing.Size(204, 70);
            this.btn_userLogsForm.TabIndex = 2;
            this.btn_userLogsForm.Text = "USER LOGS";
            this.btn_userLogsForm.UseVisualStyleBackColor = true;
            // 
            // btn_documentGenForm
            // 
            this.btn_documentGenForm.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_documentGenForm.Location = new System.Drawing.Point(27, 261);
            this.btn_documentGenForm.Name = "btn_documentGenForm";
            this.btn_documentGenForm.Size = new System.Drawing.Size(204, 70);
            this.btn_documentGenForm.TabIndex = 3;
            this.btn_documentGenForm.Text = "REPORT GENERATION";
            this.btn_documentGenForm.UseVisualStyleBackColor = true;
            // 
            // frm_dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 450);
            this.Controls.Add(this.btn_documentGenForm);
            this.Controls.Add(this.btn_userLogsForm);
            this.Controls.Add(this.btn_documentsForm);
            this.Controls.Add(this.btn_accountForm);
            this.Name = "frm_dashboard";
            this.Text = "Dashboard";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_accountForm;
        private System.Windows.Forms.Button btn_documentsForm;
        private System.Windows.Forms.Button btn_userLogsForm;
        private System.Windows.Forms.Button btn_documentGenForm;
    }
}