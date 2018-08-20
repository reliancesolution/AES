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
            this.btn_logout = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tb_admin = new System.Windows.Forms.TabControl();
            this.tb_manageAccount = new System.Windows.Forms.TabPage();
            this.btn_regUserSave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Type = new System.Windows.Forms.Label();
            this.cmb_regType = new System.Windows.Forms.ComboBox();
            this.txt_regFullName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_regConfirmPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_regPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_regUsername = new System.Windows.Forms.TextBox();
            this.dg_accounts = new System.Windows.Forms.DataGridView();
            this.btn_regAdd = new System.Windows.Forms.Button();
            this.btn_regDelete = new System.Windows.Forms.Button();
            this.btn_regEdit = new System.Windows.Forms.Button();
            this.tb_manageDocuments = new System.Windows.Forms.TabPage();
            this.txt_titleDocu = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCreateDocu = new System.Windows.Forms.Button();
            this.btn_refreshDocu = new System.Windows.Forms.Button();
            this.btnEditDocu = new System.Windows.Forms.Button();
            this.btn_deleteDocu = new System.Windows.Forms.Button();
            this.btn_searchDocu = new System.Windows.Forms.Button();
            this.txt_searchDocu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dt_docu = new System.Windows.Forms.DataGridView();
            this.tb_userLogs = new System.Windows.Forms.TabPage();
            this.btn_logRefresh = new System.Windows.Forms.Button();
            this.dt_logs = new System.Windows.Forms.DataGridView();
            this.tb_reportGeneration = new System.Windows.Forms.TabPage();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtChoose = new System.Windows.Forms.Button();
            this.txtSaveExcelPath = new System.Windows.Forms.Button();
            this.dg_excelImport = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDocument_id = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tb_admin.SuspendLayout();
            this.tb_manageAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_accounts)).BeginInit();
            this.tb_manageDocuments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_docu)).BeginInit();
            this.tb_userLogs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_logs)).BeginInit();
            this.tb_reportGeneration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_excelImport)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_logout
            // 
            this.btn_logout.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.Location = new System.Drawing.Point(756, 4);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(204, 24);
            this.btn_logout.TabIndex = 9;
            this.btn_logout.Text = "LOGOUT";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(492, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(8, 8);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(0, 0);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(0, 0);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tb_admin
            // 
            this.tb_admin.Controls.Add(this.tb_manageAccount);
            this.tb_admin.Controls.Add(this.tb_manageDocuments);
            this.tb_admin.Controls.Add(this.tb_userLogs);
            this.tb_admin.Controls.Add(this.tb_reportGeneration);
            this.tb_admin.Location = new System.Drawing.Point(12, 32);
            this.tb_admin.Name = "tb_admin";
            this.tb_admin.SelectedIndex = 0;
            this.tb_admin.Size = new System.Drawing.Size(948, 405);
            this.tb_admin.TabIndex = 7;
            // 
            // tb_manageAccount
            // 
            this.tb_manageAccount.Controls.Add(this.btn_regUserSave);
            this.tb_manageAccount.Controls.Add(this.label4);
            this.tb_manageAccount.Controls.Add(this.Type);
            this.tb_manageAccount.Controls.Add(this.cmb_regType);
            this.tb_manageAccount.Controls.Add(this.txt_regFullName);
            this.tb_manageAccount.Controls.Add(this.label3);
            this.tb_manageAccount.Controls.Add(this.txt_regConfirmPassword);
            this.tb_manageAccount.Controls.Add(this.label2);
            this.tb_manageAccount.Controls.Add(this.txt_regPassword);
            this.tb_manageAccount.Controls.Add(this.label1);
            this.tb_manageAccount.Controls.Add(this.txt_regUsername);
            this.tb_manageAccount.Controls.Add(this.dg_accounts);
            this.tb_manageAccount.Controls.Add(this.btn_regAdd);
            this.tb_manageAccount.Controls.Add(this.btn_regDelete);
            this.tb_manageAccount.Controls.Add(this.btn_regEdit);
            this.tb_manageAccount.Location = new System.Drawing.Point(4, 22);
            this.tb_manageAccount.Name = "tb_manageAccount";
            this.tb_manageAccount.Padding = new System.Windows.Forms.Padding(3);
            this.tb_manageAccount.Size = new System.Drawing.Size(940, 379);
            this.tb_manageAccount.TabIndex = 0;
            this.tb_manageAccount.Text = "Accounts";
            this.tb_manageAccount.UseVisualStyleBackColor = true;
            // 
            // btn_regUserSave
            // 
            this.btn_regUserSave.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_regUserSave.Location = new System.Drawing.Point(712, 325);
            this.btn_regUserSave.Name = "btn_regUserSave";
            this.btn_regUserSave.Size = new System.Drawing.Size(107, 45);
            this.btn_regUserSave.TabIndex = 23;
            this.btn_regUserSave.Text = "SAVE";
            this.btn_regUserSave.UseVisualStyleBackColor = true;
            this.btn_regUserSave.Click += new System.EventHandler(this.btn_regUserSave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(718, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Full Name";
            // 
            // Type
            // 
            this.Type.AutoSize = true;
            this.Type.Location = new System.Drawing.Point(718, 205);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(31, 13);
            this.Type.TabIndex = 21;
            this.Type.Text = "Type";
            // 
            // cmb_regType
            // 
            this.cmb_regType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_regType.FormattingEnabled = true;
            this.cmb_regType.Items.AddRange(new object[] {
            "admin",
            "coordinator"});
            this.cmb_regType.Location = new System.Drawing.Point(718, 221);
            this.cmb_regType.Name = "cmb_regType";
            this.cmb_regType.Size = new System.Drawing.Size(214, 21);
            this.cmb_regType.TabIndex = 5;
            // 
            // txt_regFullName
            // 
            this.txt_regFullName.Location = new System.Drawing.Point(718, 73);
            this.txt_regFullName.Name = "txt_regFullName";
            this.txt_regFullName.Size = new System.Drawing.Size(214, 20);
            this.txt_regFullName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(718, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Confirm Password";
            // 
            // txt_regConfirmPassword
            // 
            this.txt_regConfirmPassword.Location = new System.Drawing.Point(718, 179);
            this.txt_regConfirmPassword.Name = "txt_regConfirmPassword";
            this.txt_regConfirmPassword.PasswordChar = '*';
            this.txt_regConfirmPassword.Size = new System.Drawing.Size(214, 20);
            this.txt_regConfirmPassword.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(718, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Password";
            // 
            // txt_regPassword
            // 
            this.txt_regPassword.Location = new System.Drawing.Point(718, 130);
            this.txt_regPassword.Name = "txt_regPassword";
            this.txt_regPassword.PasswordChar = '*';
            this.txt_regPassword.Size = new System.Drawing.Size(214, 20);
            this.txt_regPassword.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(718, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Username";
            // 
            // txt_regUsername
            // 
            this.txt_regUsername.Location = new System.Drawing.Point(718, 26);
            this.txt_regUsername.Name = "txt_regUsername";
            this.txt_regUsername.Size = new System.Drawing.Size(214, 20);
            this.txt_regUsername.TabIndex = 1;
            // 
            // dg_accounts
            // 
            this.dg_accounts.AllowUserToAddRows = false;
            this.dg_accounts.AllowUserToResizeColumns = false;
            this.dg_accounts.AllowUserToResizeRows = false;
            this.dg_accounts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_accounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_accounts.Location = new System.Drawing.Point(6, 6);
            this.dg_accounts.MultiSelect = false;
            this.dg_accounts.Name = "dg_accounts";
            this.dg_accounts.ReadOnly = true;
            this.dg_accounts.RowHeadersVisible = false;
            this.dg_accounts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dg_accounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_accounts.Size = new System.Drawing.Size(700, 365);
            this.dg_accounts.TabIndex = 11;
            this.dg_accounts.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dg_accounts_CellMouseClick);
            // 
            // btn_regAdd
            // 
            this.btn_regAdd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_regAdd.Location = new System.Drawing.Point(712, 274);
            this.btn_regAdd.Name = "btn_regAdd";
            this.btn_regAdd.Size = new System.Drawing.Size(220, 45);
            this.btn_regAdd.TabIndex = 6;
            this.btn_regAdd.Text = "ADD";
            this.btn_regAdd.UseVisualStyleBackColor = true;
            this.btn_regAdd.Click += new System.EventHandler(this.btn_regAdd_Click);
            // 
            // btn_regDelete
            // 
            this.btn_regDelete.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_regDelete.Location = new System.Drawing.Point(825, 325);
            this.btn_regDelete.Name = "btn_regDelete";
            this.btn_regDelete.Size = new System.Drawing.Size(107, 45);
            this.btn_regDelete.TabIndex = 8;
            this.btn_regDelete.Text = "DELETE";
            this.btn_regDelete.UseVisualStyleBackColor = true;
            this.btn_regDelete.Click += new System.EventHandler(this.btn_regDelete_Click);
            // 
            // btn_regEdit
            // 
            this.btn_regEdit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_regEdit.Location = new System.Drawing.Point(712, 325);
            this.btn_regEdit.Name = "btn_regEdit";
            this.btn_regEdit.Size = new System.Drawing.Size(107, 45);
            this.btn_regEdit.TabIndex = 7;
            this.btn_regEdit.Text = "EDIT";
            this.btn_regEdit.UseVisualStyleBackColor = true;
            this.btn_regEdit.Click += new System.EventHandler(this.btn_regEdit_Click);
            // 
            // tb_manageDocuments
            // 
            this.tb_manageDocuments.Controls.Add(this.txt_titleDocu);
            this.tb_manageDocuments.Controls.Add(this.label8);
            this.tb_manageDocuments.Controls.Add(this.btnCreateDocu);
            this.tb_manageDocuments.Controls.Add(this.btn_refreshDocu);
            this.tb_manageDocuments.Controls.Add(this.btnEditDocu);
            this.tb_manageDocuments.Controls.Add(this.btn_deleteDocu);
            this.tb_manageDocuments.Controls.Add(this.btn_searchDocu);
            this.tb_manageDocuments.Controls.Add(this.txt_searchDocu);
            this.tb_manageDocuments.Controls.Add(this.label5);
            this.tb_manageDocuments.Controls.Add(this.dt_docu);
            this.tb_manageDocuments.Location = new System.Drawing.Point(4, 22);
            this.tb_manageDocuments.Name = "tb_manageDocuments";
            this.tb_manageDocuments.Padding = new System.Windows.Forms.Padding(3);
            this.tb_manageDocuments.Size = new System.Drawing.Size(940, 379);
            this.tb_manageDocuments.TabIndex = 1;
            this.tb_manageDocuments.Text = "Documents";
            this.tb_manageDocuments.UseVisualStyleBackColor = true;
            // 
            // txt_titleDocu
            // 
            this.txt_titleDocu.Location = new System.Drawing.Point(656, 147);
            this.txt_titleDocu.Name = "txt_titleDocu";
            this.txt_titleDocu.Size = new System.Drawing.Size(180, 20);
            this.txt_titleDocu.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(611, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "TITLE :";
            // 
            // btnCreateDocu
            // 
            this.btnCreateDocu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateDocu.Location = new System.Drawing.Point(656, 173);
            this.btnCreateDocu.Name = "btnCreateDocu";
            this.btnCreateDocu.Size = new System.Drawing.Size(87, 24);
            this.btnCreateDocu.TabIndex = 15;
            this.btnCreateDocu.Text = "CREATE";
            this.btnCreateDocu.UseVisualStyleBackColor = true;
            this.btnCreateDocu.Click += new System.EventHandler(this.btnCreateDocu_Click);
            // 
            // btn_refreshDocu
            // 
            this.btn_refreshDocu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refreshDocu.Location = new System.Drawing.Point(3, 18);
            this.btn_refreshDocu.Name = "btn_refreshDocu";
            this.btn_refreshDocu.Size = new System.Drawing.Size(119, 24);
            this.btn_refreshDocu.TabIndex = 14;
            this.btn_refreshDocu.Text = "REFRESH";
            this.btn_refreshDocu.UseVisualStyleBackColor = true;
            this.btn_refreshDocu.Click += new System.EventHandler(this.btn_refreshDocu_Click);
            // 
            // btnEditDocu
            // 
            this.btnEditDocu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditDocu.Location = new System.Drawing.Point(749, 173);
            this.btnEditDocu.Name = "btnEditDocu";
            this.btnEditDocu.Size = new System.Drawing.Size(87, 24);
            this.btnEditDocu.TabIndex = 12;
            this.btnEditDocu.Text = "EDIT";
            this.btnEditDocu.UseVisualStyleBackColor = true;
            this.btnEditDocu.Click += new System.EventHandler(this.btnEditDocu_Click);
            // 
            // btn_deleteDocu
            // 
            this.btn_deleteDocu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deleteDocu.Location = new System.Drawing.Point(656, 200);
            this.btn_deleteDocu.Name = "btn_deleteDocu";
            this.btn_deleteDocu.Size = new System.Drawing.Size(180, 24);
            this.btn_deleteDocu.TabIndex = 11;
            this.btn_deleteDocu.Text = "DELETE";
            this.btn_deleteDocu.UseVisualStyleBackColor = true;
            this.btn_deleteDocu.Click += new System.EventHandler(this.btn_deleteDocu_Click);
            // 
            // btn_searchDocu
            // 
            this.btn_searchDocu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_searchDocu.Location = new System.Drawing.Point(415, 18);
            this.btn_searchDocu.Name = "btn_searchDocu";
            this.btn_searchDocu.Size = new System.Drawing.Size(87, 24);
            this.btn_searchDocu.TabIndex = 10;
            this.btn_searchDocu.Text = "SEARCH";
            this.btn_searchDocu.UseVisualStyleBackColor = true;
            // 
            // txt_searchDocu
            // 
            this.txt_searchDocu.Location = new System.Drawing.Point(257, 21);
            this.txt_searchDocu.Name = "txt_searchDocu";
            this.txt_searchDocu.Size = new System.Drawing.Size(152, 20);
            this.txt_searchDocu.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(203, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "SEARCH :";
            // 
            // dt_docu
            // 
            this.dt_docu.AllowUserToAddRows = false;
            this.dt_docu.AllowUserToResizeRows = false;
            this.dt_docu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dt_docu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_docu.Location = new System.Drawing.Point(3, 45);
            this.dt_docu.MultiSelect = false;
            this.dt_docu.Name = "dt_docu";
            this.dt_docu.ReadOnly = true;
            this.dt_docu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dt_docu.Size = new System.Drawing.Size(499, 328);
            this.dt_docu.TabIndex = 0;
            this.dt_docu.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dt_docu_CellMouseClick);
            // 
            // tb_userLogs
            // 
            this.tb_userLogs.Controls.Add(this.btn_logRefresh);
            this.tb_userLogs.Controls.Add(this.dt_logs);
            this.tb_userLogs.Location = new System.Drawing.Point(4, 22);
            this.tb_userLogs.Name = "tb_userLogs";
            this.tb_userLogs.Size = new System.Drawing.Size(940, 379);
            this.tb_userLogs.TabIndex = 2;
            this.tb_userLogs.Text = "User Logs";
            this.tb_userLogs.UseVisualStyleBackColor = true;
            // 
            // btn_logRefresh
            // 
            this.btn_logRefresh.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logRefresh.Location = new System.Drawing.Point(733, 336);
            this.btn_logRefresh.Name = "btn_logRefresh";
            this.btn_logRefresh.Size = new System.Drawing.Size(204, 24);
            this.btn_logRefresh.TabIndex = 10;
            this.btn_logRefresh.Text = "REFRESH";
            this.btn_logRefresh.UseVisualStyleBackColor = true;
            this.btn_logRefresh.Click += new System.EventHandler(this.btn_logRefresh_Click);
            // 
            // dt_logs
            // 
            this.dt_logs.AllowUserToAddRows = false;
            this.dt_logs.AllowUserToResizeRows = false;
            this.dt_logs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dt_logs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_logs.Location = new System.Drawing.Point(3, 3);
            this.dt_logs.MultiSelect = false;
            this.dt_logs.Name = "dt_logs";
            this.dt_logs.ReadOnly = true;
            this.dt_logs.RowHeadersVisible = false;
            this.dt_logs.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dt_logs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dt_logs.Size = new System.Drawing.Size(934, 317);
            this.dt_logs.TabIndex = 0;
            // 
            // tb_reportGeneration
            // 
            this.tb_reportGeneration.Controls.Add(this.label7);
            this.tb_reportGeneration.Controls.Add(this.txtDocument_id);
            this.tb_reportGeneration.Controls.Add(this.dg_excelImport);
            this.tb_reportGeneration.Controls.Add(this.txtSaveExcelPath);
            this.tb_reportGeneration.Controls.Add(this.txtChoose);
            this.tb_reportGeneration.Controls.Add(this.label6);
            this.tb_reportGeneration.Controls.Add(this.txtPath);
            this.tb_reportGeneration.Location = new System.Drawing.Point(4, 22);
            this.tb_reportGeneration.Name = "tb_reportGeneration";
            this.tb_reportGeneration.Size = new System.Drawing.Size(940, 379);
            this.tb_reportGeneration.TabIndex = 3;
            this.tb_reportGeneration.Text = "Report Generation";
            this.tb_reportGeneration.UseVisualStyleBackColor = true;
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(52, 17);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(240, 20);
            this.txtPath.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "PATH";
            // 
            // txtChoose
            // 
            this.txtChoose.Location = new System.Drawing.Point(298, 15);
            this.txtChoose.Name = "txtChoose";
            this.txtChoose.Size = new System.Drawing.Size(75, 23);
            this.txtChoose.TabIndex = 2;
            this.txtChoose.Text = "Choose";
            this.txtChoose.UseVisualStyleBackColor = true;
            this.txtChoose.Click += new System.EventHandler(this.txtChoose_Click);
            // 
            // txtSaveExcelPath
            // 
            this.txtSaveExcelPath.Location = new System.Drawing.Point(379, 15);
            this.txtSaveExcelPath.Name = "txtSaveExcelPath";
            this.txtSaveExcelPath.Size = new System.Drawing.Size(75, 23);
            this.txtSaveExcelPath.TabIndex = 3;
            this.txtSaveExcelPath.Text = "Save";
            this.txtSaveExcelPath.UseVisualStyleBackColor = true;
            this.txtSaveExcelPath.Click += new System.EventHandler(this.txtSaveExcelPath_Click);
            // 
            // dg_excelImport
            // 
            this.dg_excelImport.AllowUserToAddRows = false;
            this.dg_excelImport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_excelImport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_excelImport.Location = new System.Drawing.Point(13, 87);
            this.dg_excelImport.Name = "dg_excelImport";
            this.dg_excelImport.ReadOnly = true;
            this.dg_excelImport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_excelImport.Size = new System.Drawing.Size(441, 289);
            this.dg_excelImport.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Type Document Id :";
            // 
            // txtDocument_id
            // 
            this.txtDocument_id.Location = new System.Drawing.Point(115, 43);
            this.txtDocument_id.Name = "txtDocument_id";
            this.txtDocument_id.Size = new System.Drawing.Size(177, 20);
            this.txtDocument_id.TabIndex = 5;
            // 
            // frm_dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 451);
            this.Controls.Add(this.tb_admin);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btn_logout);
            this.Name = "frm_dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.frm_dashboard_Load);
            this.tabControl1.ResumeLayout(false);
            this.tb_admin.ResumeLayout(false);
            this.tb_manageAccount.ResumeLayout(false);
            this.tb_manageAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_accounts)).EndInit();
            this.tb_manageDocuments.ResumeLayout(false);
            this.tb_manageDocuments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_docu)).EndInit();
            this.tb_userLogs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dt_logs)).EndInit();
            this.tb_reportGeneration.ResumeLayout(false);
            this.tb_reportGeneration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_excelImport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tb_admin;
        private System.Windows.Forms.TabPage tb_manageAccount;
        private System.Windows.Forms.TabPage tb_manageDocuments;
        private System.Windows.Forms.Label Type;
        private System.Windows.Forms.ComboBox cmb_regType;
        private System.Windows.Forms.TextBox txt_regFullName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_regConfirmPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_regPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_regUsername;
        private System.Windows.Forms.DataGridView dg_accounts;
        private System.Windows.Forms.Button btn_regAdd;
        private System.Windows.Forms.Button btn_regDelete;
        private System.Windows.Forms.Button btn_regEdit;
        private System.Windows.Forms.TabPage tb_userLogs;
        private System.Windows.Forms.TabPage tb_reportGeneration;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_regUserSave;
        private System.Windows.Forms.DataGridView dt_logs;
        private System.Windows.Forms.Button btn_logRefresh;
        private System.Windows.Forms.Button btnEditDocu;
        private System.Windows.Forms.Button btn_deleteDocu;
        private System.Windows.Forms.Button btn_searchDocu;
        private System.Windows.Forms.TextBox txt_searchDocu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dt_docu;
        private System.Windows.Forms.Button btn_refreshDocu;
        private System.Windows.Forms.Button btnCreateDocu;
        private System.Windows.Forms.TextBox txt_titleDocu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dg_excelImport;
        private System.Windows.Forms.Button txtSaveExcelPath;
        private System.Windows.Forms.Button txtChoose;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDocument_id;
    }
}