namespace App_QuanLy_QuanAnVat_WVN
{
    partial class frmAdd
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
            this.lbNameFromMenu = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.lbUp = new System.Windows.Forms.Label();
            this.lbDown = new System.Windows.Forms.Label();
            this.btnXacNhanAdd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbAdd = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNameFromMenu
            // 
            this.lbNameFromMenu.BackColor = System.Drawing.Color.White;
            this.lbNameFromMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbNameFromMenu.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameFromMenu.Location = new System.Drawing.Point(80, 171);
            this.lbNameFromMenu.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lbNameFromMenu.Name = "lbNameFromMenu";
            this.lbNameFromMenu.Size = new System.Drawing.Size(400, 61);
            this.lbNameFromMenu.TabIndex = 1;
            this.lbNameFromMenu.Text = "Tên Món";
            this.lbNameFromMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(224, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 35);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số lượng";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(244, 305);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(80, 39);
            this.txtSL.TabIndex = 3;
            this.txtSL.TextChanged += new System.EventHandler(this.txtSL_TextChanged);
            this.txtSL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSL_KeyPress);
            // 
            // lbUp
            // 
            this.lbUp.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUp.Location = new System.Drawing.Point(346, 305);
            this.lbUp.Name = "lbUp";
            this.lbUp.Size = new System.Drawing.Size(39, 39);
            this.lbUp.TabIndex = 4;
            this.lbUp.Text = "+";
            this.lbUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbUp.Click += new System.EventHandler(this.lbUp_Click);
            // 
            // lbDown
            // 
            this.lbDown.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDown.Location = new System.Drawing.Point(178, 305);
            this.lbDown.Name = "lbDown";
            this.lbDown.Size = new System.Drawing.Size(39, 39);
            this.lbDown.TabIndex = 5;
            this.lbDown.Text = "-";
            this.lbDown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbDown.Click += new System.EventHandler(this.lbDown_Click);
            // 
            // btnXacNhanAdd
            // 
            this.btnXacNhanAdd.BackColor = System.Drawing.Color.White;
            this.btnXacNhanAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXacNhanAdd.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhanAdd.Location = new System.Drawing.Point(210, 350);
            this.btnXacNhanAdd.Name = "btnXacNhanAdd";
            this.btnXacNhanAdd.Size = new System.Drawing.Size(150, 39);
            this.btnXacNhanAdd.TabIndex = 6;
            this.btnXacNhanAdd.Text = "Xác nhận";
            this.btnXacNhanAdd.UseVisualStyleBackColor = false;
            this.btnXacNhanAdd.Click += new System.EventHandler(this.btnXacNhanAdd_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lbNameFromMenu);
            this.panel1.Controls.Add(this.btnXacNhanAdd);
            this.panel1.Controls.Add(this.pbAdd);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbDown);
            this.panel1.Controls.Add(this.txtSL);
            this.panel1.Controls.Add(this.lbUp);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 426);
            this.panel1.TabIndex = 7;
            // 
            // pbAdd
            // 
            this.pbAdd.BackColor = System.Drawing.Color.Transparent;
            this.pbAdd.BackgroundImage = global::App_QuanLy_QuanAnVat_WVN.Properties.Resources.cooltext378690457806667;
            this.pbAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbAdd.Location = new System.Drawing.Point(80, 14);
            this.pbAdd.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.pbAdd.Name = "pbAdd";
            this.pbAdd.Size = new System.Drawing.Size(400, 150);
            this.pbAdd.TabIndex = 0;
            this.pbAdd.TabStop = false;
            // 
            // frmAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 426);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "frmAdd";
            this.Text = "Thêm món";
            this.Load += new System.EventHandler(this.frmAdd_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbAdd;
        private System.Windows.Forms.Label lbNameFromMenu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.Label lbUp;
        private System.Windows.Forms.Label lbDown;
        private System.Windows.Forms.Button btnXacNhanAdd;
        private System.Windows.Forms.Panel panel1;
    }
}