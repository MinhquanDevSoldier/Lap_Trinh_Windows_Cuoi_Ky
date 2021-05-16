namespace App_QuanLy_QuanAnVat_WVN
{
    partial class qlfood
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
            this.components = new System.ComponentModel.Container();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.dtg_DMTP = new System.Windows.Forms.DataGridView();
            this.MaDM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_MaDM = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_Huy_DM = new System.Windows.Forms.Button();
            this.btn_Xoa_DM = new System.Windows.Forms.Button();
            this.btn_Sua_DM = new System.Windows.Forms.Button();
            this.btn_Them_DM = new System.Windows.Forms.Button();
            this.txt_Ten_DM = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_Ma_TP = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbCategory_select = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Huy_TP = new System.Windows.Forms.Button();
            this.txt_Gia_TP = new System.Windows.Forms.TextBox();
            this.btn_Xoa_TP = new System.Windows.Forms.Button();
            this.txt_Ten_TP = new System.Windows.Forms.TextBox();
            this.btn_Sua_TP = new System.Windows.Forms.Button();
            this.btn_Them_TP = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtg_Thuc_Pham = new System.Windows.Forms.DataGridView();
            this.TenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dMTPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gradientPanel2 = new App_QuanLy_QuanAnVat_WVN.GradientPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.gradientPanel1 = new App_QuanLy_QuanAnVat_WVN.GradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_DMTP)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Thuc_Pham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMTPBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.gradientPanel2.SuspendLayout();
            this.gradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbCategory
            // 
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(164, 26);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(205, 40);
            this.cbCategory.TabIndex = 1;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.cbCategory_SelectedIndexChanged);
            // 
            // dtg_DMTP
            // 
            this.dtg_DMTP.AllowUserToDeleteRows = false;
            this.dtg_DMTP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtg_DMTP.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtg_DMTP.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dtg_DMTP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_DMTP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDM,
            this.TenDM});
            this.dtg_DMTP.Location = new System.Drawing.Point(8, 44);
            this.dtg_DMTP.MultiSelect = false;
            this.dtg_DMTP.Name = "dtg_DMTP";
            this.dtg_DMTP.ReadOnly = true;
            this.dtg_DMTP.RowHeadersWidth = 51;
            this.dtg_DMTP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_DMTP.Size = new System.Drawing.Size(377, 420);
            this.dtg_DMTP.TabIndex = 3;
            this.dtg_DMTP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_DMTP_CellClick);
            this.dtg_DMTP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_DMTP_CellContentClick);
            // 
            // MaDM
            // 
            this.MaDM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.MaDM.DataPropertyName = "IDDMTP";
            this.MaDM.HeaderText = "Mã DM";
            this.MaDM.Name = "MaDM";
            this.MaDM.ReadOnly = true;
            this.MaDM.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MaDM.Width = 125;
            // 
            // TenDM
            // 
            this.TenDM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TenDM.DataPropertyName = "TenDM";
            this.TenDM.HeaderText = "Tên DM";
            this.TenDM.Name = "TenDM";
            this.TenDM.ReadOnly = true;
            this.TenDM.Width = 200;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(376, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "CATEGORY";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.txt_MaDM);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btn_Huy_DM);
            this.groupBox1.Controls.Add(this.btn_Xoa_DM);
            this.groupBox1.Controls.Add(this.btn_Sua_DM);
            this.groupBox1.Controls.Add(this.btn_Them_DM);
            this.groupBox1.Controls.Add(this.txt_Ten_DM);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(391, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(862, 455);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Info Category";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txt_MaDM
            // 
            this.txt_MaDM.Enabled = false;
            this.txt_MaDM.Location = new System.Drawing.Point(260, 111);
            this.txt_MaDM.Name = "txt_MaDM";
            this.txt_MaDM.Size = new System.Drawing.Size(372, 39);
            this.txt_MaDM.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(193, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(195, 32);
            this.label9.TabIndex = 7;
            this.label9.Text = "Mã Danh Mục:";
            // 
            // btn_Huy_DM
            // 
            this.btn_Huy_DM.BackColor = System.Drawing.Color.Silver;
            this.btn_Huy_DM.Enabled = false;
            this.btn_Huy_DM.ForeColor = System.Drawing.Color.White;
            this.btn_Huy_DM.Location = new System.Drawing.Point(512, 392);
            this.btn_Huy_DM.Name = "btn_Huy_DM";
            this.btn_Huy_DM.Size = new System.Drawing.Size(120, 41);
            this.btn_Huy_DM.TabIndex = 6;
            this.btn_Huy_DM.Text = "Hủy";
            this.btn_Huy_DM.UseVisualStyleBackColor = false;
            this.btn_Huy_DM.Click += new System.EventHandler(this.btn_Huy_DM_Click);
            // 
            // btn_Xoa_DM
            // 
            this.btn_Xoa_DM.BackColor = System.Drawing.Color.Silver;
            this.btn_Xoa_DM.Enabled = false;
            this.btn_Xoa_DM.ForeColor = System.Drawing.Color.White;
            this.btn_Xoa_DM.Location = new System.Drawing.Point(512, 345);
            this.btn_Xoa_DM.Name = "btn_Xoa_DM";
            this.btn_Xoa_DM.Size = new System.Drawing.Size(120, 41);
            this.btn_Xoa_DM.TabIndex = 5;
            this.btn_Xoa_DM.Text = "Xóa";
            this.btn_Xoa_DM.UseVisualStyleBackColor = false;
            this.btn_Xoa_DM.Click += new System.EventHandler(this.btn_Xoa_DM_Click);
            // 
            // btn_Sua_DM
            // 
            this.btn_Sua_DM.BackColor = System.Drawing.Color.Teal;
            this.btn_Sua_DM.ForeColor = System.Drawing.Color.White;
            this.btn_Sua_DM.Location = new System.Drawing.Point(386, 345);
            this.btn_Sua_DM.Name = "btn_Sua_DM";
            this.btn_Sua_DM.Size = new System.Drawing.Size(120, 88);
            this.btn_Sua_DM.TabIndex = 4;
            this.btn_Sua_DM.Text = "Sửa";
            this.btn_Sua_DM.UseVisualStyleBackColor = false;
            this.btn_Sua_DM.Click += new System.EventHandler(this.btn_Sua_DM_Click);
            // 
            // btn_Them_DM
            // 
            this.btn_Them_DM.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_Them_DM.ForeColor = System.Drawing.Color.White;
            this.btn_Them_DM.Location = new System.Drawing.Point(260, 345);
            this.btn_Them_DM.Name = "btn_Them_DM";
            this.btn_Them_DM.Size = new System.Drawing.Size(120, 88);
            this.btn_Them_DM.TabIndex = 3;
            this.btn_Them_DM.Text = "Mới";
            this.btn_Them_DM.UseVisualStyleBackColor = false;
            this.btn_Them_DM.Click += new System.EventHandler(this.btn_Them_DM_Click);
            // 
            // txt_Ten_DM
            // 
            this.txt_Ten_DM.Location = new System.Drawing.Point(260, 224);
            this.txt_Ten_DM.Name = "txt_Ten_DM";
            this.txt_Ten_DM.Size = new System.Drawing.Size(373, 39);
            this.txt_Ten_DM.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 32);
            this.label6.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(193, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(225, 32);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tên Danh mục :";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.txt_Ma_TP);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.cbCategory_select);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btn_Huy_TP);
            this.groupBox2.Controls.Add(this.txt_Gia_TP);
            this.groupBox2.Controls.Add(this.btn_Xoa_TP);
            this.groupBox2.Controls.Add(this.txt_Ten_TP);
            this.groupBox2.Controls.Add(this.btn_Sua_TP);
            this.groupBox2.Controls.Add(this.btn_Them_TP);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(421, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(829, 458);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Info Food";
            // 
            // txt_Ma_TP
            // 
            this.txt_Ma_TP.Location = new System.Drawing.Point(354, 32);
            this.txt_Ma_TP.Name = "txt_Ma_TP";
            this.txt_Ma_TP.Size = new System.Drawing.Size(223, 39);
            this.txt_Ma_TP.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(228, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 32);
            this.label10.TabIndex = 12;
            this.label10.Text = "Mã TP :";
            // 
            // cbCategory_select
            // 
            this.cbCategory_select.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory_select.FormattingEnabled = true;
            this.cbCategory_select.Location = new System.Drawing.Point(354, 88);
            this.cbCategory_select.Name = "cbCategory_select";
            this.cbCategory_select.Size = new System.Drawing.Size(223, 40);
            this.cbCategory_select.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(93, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(255, 32);
            this.label3.TabIndex = 11;
            this.label3.Text = "Thuộc danh mục :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Huy_TP
            // 
            this.btn_Huy_TP.BackColor = System.Drawing.Color.Silver;
            this.btn_Huy_TP.Enabled = false;
            this.btn_Huy_TP.ForeColor = System.Drawing.Color.White;
            this.btn_Huy_TP.Location = new System.Drawing.Point(519, 394);
            this.btn_Huy_TP.Name = "btn_Huy_TP";
            this.btn_Huy_TP.Size = new System.Drawing.Size(120, 42);
            this.btn_Huy_TP.TabIndex = 10;
            this.btn_Huy_TP.Text = "Hủy";
            this.btn_Huy_TP.UseVisualStyleBackColor = false;
            this.btn_Huy_TP.Click += new System.EventHandler(this.btn_Huy_TP_Click);
            // 
            // txt_Gia_TP
            // 
            this.txt_Gia_TP.Location = new System.Drawing.Point(354, 196);
            this.txt_Gia_TP.Name = "txt_Gia_TP";
            this.txt_Gia_TP.Size = new System.Drawing.Size(223, 39);
            this.txt_Gia_TP.TabIndex = 3;
            // 
            // btn_Xoa_TP
            // 
            this.btn_Xoa_TP.BackColor = System.Drawing.Color.Silver;
            this.btn_Xoa_TP.Enabled = false;
            this.btn_Xoa_TP.ForeColor = System.Drawing.Color.White;
            this.btn_Xoa_TP.Location = new System.Drawing.Point(519, 348);
            this.btn_Xoa_TP.Name = "btn_Xoa_TP";
            this.btn_Xoa_TP.Size = new System.Drawing.Size(120, 42);
            this.btn_Xoa_TP.TabIndex = 9;
            this.btn_Xoa_TP.Text = "Xóa";
            this.btn_Xoa_TP.UseVisualStyleBackColor = false;
            this.btn_Xoa_TP.Click += new System.EventHandler(this.btn_Xoa_TP_Click);
            // 
            // txt_Ten_TP
            // 
            this.txt_Ten_TP.Location = new System.Drawing.Point(354, 141);
            this.txt_Ten_TP.Name = "txt_Ten_TP";
            this.txt_Ten_TP.Size = new System.Drawing.Size(223, 39);
            this.txt_Ten_TP.TabIndex = 2;
            // 
            // btn_Sua_TP
            // 
            this.btn_Sua_TP.BackColor = System.Drawing.Color.Teal;
            this.btn_Sua_TP.ForeColor = System.Drawing.Color.White;
            this.btn_Sua_TP.Location = new System.Drawing.Point(393, 348);
            this.btn_Sua_TP.Name = "btn_Sua_TP";
            this.btn_Sua_TP.Size = new System.Drawing.Size(120, 88);
            this.btn_Sua_TP.TabIndex = 8;
            this.btn_Sua_TP.Text = "Sửa";
            this.btn_Sua_TP.UseVisualStyleBackColor = false;
            this.btn_Sua_TP.Click += new System.EventHandler(this.btn_Sua_TP_Click);
            // 
            // btn_Them_TP
            // 
            this.btn_Them_TP.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_Them_TP.ForeColor = System.Drawing.Color.White;
            this.btn_Them_TP.Location = new System.Drawing.Point(267, 348);
            this.btn_Them_TP.Name = "btn_Them_TP";
            this.btn_Them_TP.Size = new System.Drawing.Size(120, 88);
            this.btn_Them_TP.TabIndex = 7;
            this.btn_Them_TP.Text = "Mới";
            this.btn_Them_TP.UseVisualStyleBackColor = false;
            this.btn_Them_TP.Click += new System.EventHandler(this.btn_Them_TP_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(258, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 32);
            this.label8.TabIndex = 1;
            this.label8.Text = "Giá :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(258, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 32);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tên :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 32);
            this.label4.TabIndex = 9;
            this.label4.Text = "Select :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // dtg_Thuc_Pham
            // 
            this.dtg_Thuc_Pham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtg_Thuc_Pham.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtg_Thuc_Pham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Thuc_Pham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenMon,
            this.GiaMon});
            this.dtg_Thuc_Pham.Location = new System.Drawing.Point(8, 72);
            this.dtg_Thuc_Pham.Name = "dtg_Thuc_Pham";
            this.dtg_Thuc_Pham.RowHeadersWidth = 51;
            this.dtg_Thuc_Pham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_Thuc_Pham.Size = new System.Drawing.Size(407, 392);
            this.dtg_Thuc_Pham.TabIndex = 8;
            this.dtg_Thuc_Pham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_Thuc_Pham_CellClick);
            // 
            // TenMon
            // 
            this.TenMon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TenMon.DataPropertyName = "TenTP";
            this.TenMon.HeaderText = "Tên Món";
            this.TenMon.Name = "TenMon";
            this.TenMon.ReadOnly = true;
            this.TenMon.Width = 200;
            // 
            // GiaMon
            // 
            this.GiaMon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.GiaMon.DataPropertyName = "Gia";
            this.GiaMon.HeaderText = "Giá";
            this.GiaMon.Name = "GiaMon";
            this.GiaMon.ReadOnly = true;
            this.GiaMon.Width = 160;
            // 
            // dMTPBindingSource
            // 
            this.dMTPBindingSource.DataMember = "DMTP";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 100);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1264, 581);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.dtg_DMTP);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 41);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1256, 536);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Danh mục";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.cbCategory);
            this.tabPage2.Controls.Add(this.dtg_Thuc_Pham);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 41);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1256, 536);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Thực phẩm";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gradientPanel2
            // 
            this.gradientPanel2.Angle = 0F;
            this.gradientPanel2.Bottomcolor = System.Drawing.Color.Cornsilk;
            this.gradientPanel2.Controls.Add(this.button1);
            this.gradientPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gradientPanel2.Location = new System.Drawing.Point(0, 611);
            this.gradientPanel2.Name = "gradientPanel2";
            this.gradientPanel2.Size = new System.Drawing.Size(1264, 70);
            this.gradientPanel2.TabIndex = 8;
            this.gradientPanel2.Topcolor = System.Drawing.Color.DarkGoldenrod;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.DarkRed;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.MistyRose;
            this.button1.Location = new System.Drawing.Point(1073, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "Quay lại";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Angle = 0F;
            this.gradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gradientPanel1.Bottomcolor = System.Drawing.Color.Cornsilk;
            this.gradientPanel1.Controls.Add(this.label1);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(1264, 100);
            this.gradientPanel1.TabIndex = 2;
            this.gradientPanel1.Topcolor = System.Drawing.Color.DarkGoldenrod;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kaushan Script", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 92);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Food";
            // 
            // qlfood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.gradientPanel2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.gradientPanel1);
            this.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "qlfood";
            this.Text = "qlfood";
            this.Load += new System.EventHandler(this.qlfood_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_DMTP)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Thuc_Pham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMTPBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.gradientPanel2.ResumeLayout(false);
            this.gradientPanel2.PerformLayout();
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbCategory;
        private GradientPanel gradientPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtg_DMTP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dtg_Thuc_Pham;
        private System.Windows.Forms.TextBox txt_Ten_DM;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Xoa_DM;
        private System.Windows.Forms.Button btn_Sua_DM;
        private System.Windows.Forms.Button btn_Them_DM;
        private System.Windows.Forms.Button btn_Huy_DM;
        private System.Windows.Forms.BindingSource dMTPBindingSource;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_Huy_TP;
        private System.Windows.Forms.TextBox txt_Gia_TP;
        private System.Windows.Forms.Button btn_Xoa_TP;
        private System.Windows.Forms.TextBox txt_Ten_TP;
        private System.Windows.Forms.Button btn_Sua_TP;
        private System.Windows.Forms.Button btn_Them_TP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private GradientPanel gradientPanel2;
        private System.Windows.Forms.ComboBox cbCategory_select;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_MaDM;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_Ma_TP;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDM;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDM;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaMon;
    }
}