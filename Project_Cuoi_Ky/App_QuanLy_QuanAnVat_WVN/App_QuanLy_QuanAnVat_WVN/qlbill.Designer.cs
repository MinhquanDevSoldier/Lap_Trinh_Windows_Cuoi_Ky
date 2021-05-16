namespace App_QuanLy_QuanAnVat_WVN
{
    partial class qlbill
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.gradientPanel2 = new App_QuanLy_QuanAnVat_WVN.GradientPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.gradientPanel1 = new App_QuanLy_QuanAnVat_WVN.GradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.gbHoadon = new System.Windows.Forms.GroupBox();
            this.cbNam = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.cbThang = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.cbNgay2 = new System.Windows.Forms.ComboBox();
            this.cbNgay1 = new System.Windows.Forms.ComboBox();
            this.btntimtheodate = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dtgHoadon = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.gradientPanel2.SuspendLayout();
            this.gradientPanel1.SuspendLayout();
            this.gbHoadon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHoadon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgHoadon);
            this.panel1.Controls.Add(this.gbHoadon);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1264, 511);
            this.panel1.TabIndex = 13;
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
            this.gradientPanel2.TabIndex = 12;
            this.gradientPanel2.Topcolor = System.Drawing.Color.DarkGoldenrod;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.DarkRed;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.MistyRose;
            this.button1.Location = new System.Drawing.Point(1073, 8);
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
            this.gradientPanel1.TabIndex = 11;
            this.gradientPanel1.Topcolor = System.Drawing.Color.DarkGoldenrod;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kaushan Script", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 92);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Bill";
            // 
            // gbHoadon
            // 
            this.gbHoadon.Controls.Add(this.cbNam);
            this.gbHoadon.Controls.Add(this.label22);
            this.gbHoadon.Controls.Add(this.cbThang);
            this.gbHoadon.Controls.Add(this.label21);
            this.gbHoadon.Controls.Add(this.cbNgay2);
            this.gbHoadon.Controls.Add(this.cbNgay1);
            this.gbHoadon.Controls.Add(this.btntimtheodate);
            this.gbHoadon.Controls.Add(this.label11);
            this.gbHoadon.Controls.Add(this.label12);
            this.gbHoadon.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbHoadon.Location = new System.Drawing.Point(0, 0);
            this.gbHoadon.Name = "gbHoadon";
            this.gbHoadon.Size = new System.Drawing.Size(1264, 106);
            this.gbHoadon.TabIndex = 13;
            this.gbHoadon.TabStop = false;
            this.gbHoadon.Text = "Tìm theo ngày";
            // 
            // cbNam
            // 
            this.cbNam.FormattingEnabled = true;
            this.cbNam.Location = new System.Drawing.Point(687, 48);
            this.cbNam.Name = "cbNam";
            this.cbNam.Size = new System.Drawing.Size(124, 40);
            this.cbNam.TabIndex = 14;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(596, 53);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(90, 32);
            this.label22.TabIndex = 13;
            this.label22.Text = "/ Năm";
            // 
            // cbThang
            // 
            this.cbThang.FormattingEnabled = true;
            this.cbThang.Location = new System.Drawing.Point(510, 50);
            this.cbThang.Name = "cbThang";
            this.cbThang.Size = new System.Drawing.Size(79, 40);
            this.cbThang.TabIndex = 12;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(384, 52);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(120, 32);
            this.label21.TabIndex = 11;
            this.label21.Text = "/ Tháng";
            // 
            // cbNgay2
            // 
            this.cbNgay2.FormattingEnabled = true;
            this.cbNgay2.Location = new System.Drawing.Point(299, 50);
            this.cbNgay2.Name = "cbNgay2";
            this.cbNgay2.Size = new System.Drawing.Size(79, 40);
            this.cbNgay2.TabIndex = 10;
            // 
            // cbNgay1
            // 
            this.cbNgay1.FormattingEnabled = true;
            this.cbNgay1.Location = new System.Drawing.Point(147, 49);
            this.cbNgay1.Name = "cbNgay1";
            this.cbNgay1.Size = new System.Drawing.Size(79, 40);
            this.cbNgay1.TabIndex = 9;
            // 
            // btntimtheodate
            // 
            this.btntimtheodate.Location = new System.Drawing.Point(817, 47);
            this.btntimtheodate.Name = "btntimtheodate";
            this.btntimtheodate.Size = new System.Drawing.Size(131, 43);
            this.btntimtheodate.TabIndex = 8;
            this.btntimtheodate.Text = "Tìm";
            this.btntimtheodate.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(93, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 32);
            this.label11.TabIndex = 1;
            this.label11.Text = "Từ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(232, 52);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 32);
            this.label12.TabIndex = 2;
            this.label12.Text = "Đến";
            // 
            // dtgHoadon
            // 
            this.dtgHoadon.AllowUserToAddRows = false;
            this.dtgHoadon.AllowUserToDeleteRows = false;
            this.dtgHoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgHoadon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dtgHoadon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgHoadon.Location = new System.Drawing.Point(0, 106);
            this.dtgHoadon.Name = "dtgHoadon";
            this.dtgHoadon.ReadOnly = true;
            this.dtgHoadon.RowTemplate.Height = 41;
            this.dtgHoadon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgHoadon.Size = new System.Drawing.Size(1264, 405);
            this.dtgHoadon.TabIndex = 14;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "TenBan";
            this.Column1.HeaderText = "Tên bàn";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "DateIn";
            this.Column2.HeaderText = "Thời gian vào";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 300;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "DateOut";
            this.Column3.HeaderText = "Thời gian thanh toán";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 300;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Tongtien";
            this.Column4.HeaderText = "Tổng hóa đơn";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 400;
            // 
            // qlbill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gradientPanel2);
            this.Controls.Add(this.gradientPanel1);
            this.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "qlbill";
            this.Text = "qlbill";
            this.panel1.ResumeLayout(false);
            this.gradientPanel2.ResumeLayout(false);
            this.gradientPanel2.PerformLayout();
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            this.gbHoadon.ResumeLayout(false);
            this.gbHoadon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHoadon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private GradientPanel gradientPanel2;
        private System.Windows.Forms.Button button1;
        private GradientPanel gradientPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbHoadon;
        private System.Windows.Forms.ComboBox cbNam;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox cbThang;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox cbNgay2;
        private System.Windows.Forms.ComboBox cbNgay1;
        private System.Windows.Forms.Button btntimtheodate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dtgHoadon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}