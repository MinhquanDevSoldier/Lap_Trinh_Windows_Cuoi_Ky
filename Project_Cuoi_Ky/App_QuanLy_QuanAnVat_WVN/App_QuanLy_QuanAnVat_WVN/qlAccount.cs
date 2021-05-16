using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace App_QuanLy_QuanAnVat_WVN
{
    public partial class qlAccount : Form
    {
        //CheckPoint Kiểm tra
        int CheckThemMoiTK = 0;
        int CheckCapNhatTK = 0;
        //Data
        DataTable dataAccount = new DataTable();

        public qlAccount()
        {
            InitializeComponent();
        }
        //Quan lý Giao diện
        public void GiaoDienMacDinh()
        {
            dataAccount = BUS.BUSWVN.Instance.DSTK();
            dtgDSTK.DataSource = BUS.BUSWVN.Instance.DSTK1();

            cbLoaiTK.SelectedIndex = 0;
            cbLoaiTK.Enabled = false;
            //TextBox
            tbMaTK.Text = "";
            tbTenTK.Text = "";
            tbMatKhau.Text = "";
            cbLoaiTK.SelectedIndex = 0;
            tbTenNV.Text = "";
            dtpNgaySinhNV.Value = DateTime.Now;
            tbCMNDNV.Text = "";
            tbMucLuongNV.Text = "";
            tbSDTNV.Text = "";

            tbMaTK.Enabled = false;
            tbTenTK.Enabled = false;
            tbMatKhau.Enabled = false;
            tbTenNV.Enabled = false;
            tbCMNDNV.Enabled = false;
            tbSDTNV.Enabled = false;
            tbMucLuongNV.Enabled = false;
            dtpNgaySinhNV.Enabled = false;
        }
        private void qlAccount_Load(object sender, EventArgs e)
        {
            cbLoaiTKLoc.SelectedIndex = 0;
            GiaoDienMacDinh();
            //Button
            ButtonMacDinh();
            LoadDSTK();

        }
        public void ButtonMacDinh()
        {
            CheckThemMoiTK= 0;
            CheckCapNhatTK = 0;
            btnTaoMoiTK.Text = "Mới";
            btnTaoMoiTK.BackColor = Color.DarkOliveGreen;
            btnCapNhatTK.Text = "Sửa";

            btnCapNhatTK.BackColor = Color.Gray;
            btnHuyTK.BackColor = Color.Gray;
            btnXoaTK.BackColor = Color.Gray;

            btnTaoMoiTK.Enabled = true;
            btnCapNhatTK.Enabled = false;
            btnHuyTK.Enabled = false;
            btnXoaTK.Enabled = false;
        }
        public void LoadDSTK()
        {
            dataAccount = BUS.BUSWVN.Instance.DSTK();
            dtgDSTK.DataSource = BUS.BUSWVN.Instance.DSTK1();
            
        }
        public void GiaoDienCapNhat()
        {
            cbLoaiTK.Enabled = true;
            tbMatKhau.Enabled = true;
            tbTenNV.Enabled = true;
            tbCMNDNV.Enabled = true;
            tbSDTNV.Enabled = true;
            tbMucLuongNV.Enabled = true;
            dtpNgaySinhNV.Enabled = true;
        }
        public void GiaoDienNhapTT()
        {
            tbMaTK.Text = "Tự động thêm";
            cbLoaiTK.SelectedIndex = 0;
            cbLoaiTK.Enabled = true;
            //TextBox
            tbTenTK.Text = "";
            tbMatKhau.Text = "";
            cbLoaiTK.SelectedIndex = 0;
            tbTenNV.Text = "";
            dtpNgaySinhNV.Value = DateTime.Now;
            tbCMNDNV.Text = "";
            tbMucLuongNV.Text = "";
            tbSDTNV.Text = "";
            //Enabled
            tbTenTK.Enabled = true;
            tbMatKhau.Enabled = true;
            tbTenNV.Enabled = true;
            tbCMNDNV.Enabled = true;
            tbSDTNV.Enabled = true;
            tbMucLuongNV.Enabled = true;
            dtpNgaySinhNV.Enabled = true;
        }
        //Thao tác trên giao diện
        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnTaoMoiBan_Click(object sender, EventArgs e)
        {
            
            if(CheckThemMoiTK == 0)
            {
                GiaoDienNhapTT();
                btnTaoMoiTK.Text = "Thêm";
                btnTaoMoiTK.BackColor = Color.DarkTurquoise;
                CheckThemMoiTK = 1;

                btnHuyTK.Enabled = true;
                btnHuyTK.BackColor = Color.Brown;
            }
            else
            {
                try
                {
                    String TenTK, MatKhau, TenNV;
                    TenTK = tbTenTK.Text;
                    MatKhau = tbMatKhau.Text;
                    TenNV = tbTenNV.Text;

                    if(TenTK.Length == 0)
                    {
                        MessageBox.Show("Tên Tài khoản không được trống");
                    }
                    else if(MatKhau.Length == 0)
                    {
                        MessageBox.Show("Mật khẩu không được trống");
                    }
                    else if (cbLoaiTK.SelectedIndex == 0)
                    {
                        MessageBox.Show("Hãy chọn một chức vụ");
                    }
                    else if (TenNV.Length == 0)
                    {
                        MessageBox.Show("Mỗi tài khoản cần ít nhất một tên đại diện");
                    }
                    else
                    {
                        DTO.taikhoan tk = new DTO.taikhoan();
                        tk.Tentk1 = tbTenTK.Text;
                        tk.Matkhau = tbMatKhau.Text;
                        tk.Loaitk = cbLoaiTK.SelectedIndex.ToString();
                        tk.TenNV = tbTenNV.Text;
                        tk.Cmnd = tbCMNDNV.Text;
                        tk.Ngaysinh = dtpNgaySinhNV.Text;
                        tk.Sdt = tbSDTNV.Text;
                        tk.Mucluong = tbMucLuongNV.Text;

                        BUS.BUSWVN.Instance.ThemTK(tk);
                        MessageBox.Show("Thêm thành công");
                        GiaoDienMacDinh();
                        ButtonMacDinh();
                    }
                    
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    MessageBox.Show("Thêm tài khoản Thất bại, Vui lòng thử lại!!\nBấm Hủy đề thoát");
                }
                
            }
        }

        private void btnHuyTK_Click(object sender, EventArgs e)
        {
            GiaoDienMacDinh();
            ButtonMacDinh();
        }

        private void btnXoaTK_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Xác nhận xóa "+tbTenTK.Text,"Đang xóa",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if(dlr == DialogResult.Yes )
            {
                BUS.BUSWVN.Instance.XoaTK(tbMaTK.Text);
                GiaoDienMacDinh();
                ButtonMacDinh();
            }
        }

        private void btnCapNhatTK_Click(object sender, EventArgs e)
        {
            if(CheckCapNhatTK == 0)
            {
                GiaoDienCapNhat();
                btnCapNhatTK.Text = "Xác nhận";
                btnCapNhatTK.BackColor = Color.DarkCyan;

                btnHuyTK.Enabled = true;
                CheckCapNhatTK = 1;
            }
            else
            {
                DTO.taikhoan tk = new DTO.taikhoan();
                tk.Tentk1 = tbTenTK.Text;
                tk.Matkhau = tbMatKhau.Text;
                tk.Loaitk = cbLoaiTK.SelectedIndex.ToString();
                tk.TenNV = tbTenNV.Text;
                tk.Cmnd = tbCMNDNV.Text;
                tk.Ngaysinh = dtpNgaySinhNV.Text;
                tk.Sdt = tbSDTNV.Text;
                tk.Mucluong = tbMucLuongNV.Text;
                BUS.BUSWVN.Instance.CapNhatTK(tk,tbMaTK.Text);

                btnCapNhatTK.Text = "Sửa";
                btnCapNhatTK.BackColor = Color.Navy;
                GiaoDienMacDinh();
                ButtonMacDinh();
            }
        }

        private void dtgDSTK_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }

        private void dtgDSTK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(CheckThemMoiTK == 1 || CheckCapNhatTK == 1)
            {
                MessageBox.Show("Không thể chọn do đang thực hiện thao tác khác\n Hủy Thao tác hiện tại trước.");
            }
            else
            {
                //Lay thong tin 
                try
                {
                    tbMaTK.Text =  dtgDSTK.Rows[e.RowIndex].Cells[0].Value.ToString();
                    tbTenTK.Text = dtgDSTK.Rows[e.RowIndex].Cells[1].Value.ToString();
                    tbMatKhau.Text = dataAccount.Rows[e.RowIndex]["Matkhau"].ToString();
                    tbTenNV.Text = dataAccount.Rows[e.RowIndex]["TenNV"].ToString();
                    tbCMNDNV.Text = dataAccount.Rows[e.RowIndex]["CMND"].ToString();
                    if(dataAccount.Rows[e.RowIndex]["loai"].ToString() == "True")
                    {
                        cbLoaiTK.SelectedIndex = 1;
                    }
                    else
                    {
                        cbLoaiTK.SelectedIndex = 2;
                    }
                    DateTime dateTime = Convert.ToDateTime(dataAccount.Rows[e.RowIndex]["NgaySinh"].ToString());
                    dtpNgaySinhNV.Value = dateTime;
                    tbSDTNV.Text = dataAccount.Rows[e.RowIndex]["SDT"].ToString();
                    tbMucLuongNV.Text = dataAccount.Rows[e.RowIndex]["MucLuong"].ToString();

                    //Trình điều khiển   
                    btnTaoMoiTK.BackColor = Color.Gray;
                    btnCapNhatTK.BackColor = Color.Navy;
                    btnXoaTK.BackColor = Color.Brown;
                    btnHuyTK.BackColor = Color.Brown;
            
                    btnTaoMoiTK.Enabled = false;
                    btnCapNhatTK.Enabled = true;
                    btnXoaTK.Enabled = true;
                    btnHuyTK.Enabled = true;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }
            
        }
    }
}
