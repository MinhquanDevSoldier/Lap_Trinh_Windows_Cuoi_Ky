using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_QuanLy_QuanAnVat_WVN
{
    public partial class dangnhapfrm : Form
    {
        int check = 0;
        public dangnhapfrm()
        {
            InitializeComponent();
        }

        private void dangnhapfrm_Load(object sender, EventArgs e)
        {

        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            if(BUS.BUSWVN.Instance.dang_Nhap(txtTentk.Text, txtMatkhau.Text))
            {
                MessageBox.Show("Đăng nhập thành công");
                string tennv = BUS.BUSWVN.Instance.getTenNV(txtTentk.Text);
                string idnv = BUS.BUSWVN.Instance.getIDNV(txtTentk.Text);
                check = 0;
                Form1 form1 = new Form1(tennv,idnv);
                form1.StartPosition = FormStartPosition.CenterScreen;
                this.Hide();
                form1.ShowDialog();
                this.Show();
            }
            else
            {
                check++;
                MessageBox.Show("Sai Tên tài khoản hoặc Mật khẩu\nSai quá 3 lần tự động thoát \n("+check+" lần)");
                
                if (check == 3)
                {
                    this.Dispose();
                }
            }
        }
    }
}
