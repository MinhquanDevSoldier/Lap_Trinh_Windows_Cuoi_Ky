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
    public partial class qlfood : Form
    {
        //Bien cuc bo
        private int checkSuaDM = 0,checkThemDM=0,checkSuaTP=0,checkThemTP=0;
        DataTable dataMon = new DataTable();
        DataTable dataDM = new DataTable();
        //============================================================================
        public qlfood()
        {
            InitializeComponent();
        }

        private void qlfood_Load(object sender, EventArgs e)
        {
            load_TP();
            String iddm = cbCategory.SelectedValue.ToString();
            //MessageBox.Show(iddm + "");
            dtg_Thuc_Pham.DataSource = BUS.BUS_QLFOOD.Instance.load_Food_BUS(iddm + "",0);
            //cac nut dieu khien
            giao_dien_TP();
            giao_dien_DMTP();
            //Location
            int x = (-this.Width + Screen.PrimaryScreen.Bounds.Width) / 2;
            int y = (-this.Height + Screen.PrimaryScreen.Bounds.Height) / 2;
            this.Location = new Point(x, y);
            //Data
            dtg_DMTP.DataSource = BUS.BUS_QLFOOD.Instance.load_dtg_DMTP_BUS();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult xacnhanthoat = MessageBox.Show(this, "Xác nhận thoát", "Thoát", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (xacnhanthoat == DialogResult.Yes)
            {
                this.Dispose();
            }
        }
        //================================================================================================================================
        //================================================================================================================================
        //Quan ly danh muc ====================================================================================================================
        //================================================================================================================================
        public void load_TP()
        {
            dataDM = BUS.BUS_QLFOOD.Instance.load_DMTP_BUS();
            cbCategory.DataSource = dataDM;
            cbCategory.ValueMember = dataDM.Columns[0].ToString();
            cbCategory.DisplayMember = dataDM.Columns[1].ToString();

            cbCategory_select.DataSource = dataDM;
            cbCategory_select.ValueMember = dataDM.Columns[0].ToString();
            cbCategory_select.DisplayMember = dataDM.Columns[1].ToString();
        }
        //=================================================================================================================================
        //Code giao dien =================================================================================================================================
        public void giao_dien_DMTP()
        {
            dtg_DMTP.DataSource = BUS.BUS_QLFOOD.Instance.load_dtg_DMTP_BUS(); 

            checkThemDM = 0;
            checkSuaDM = 0;
            txt_Ten_DM.Enabled = false;
            txt_Ten_DM.Text = "";
            btn_Xoa_DM.Enabled = false;
            btn_Huy_DM.Enabled = false;
            btn_Sua_DM.Enabled = false;
            btn_Sua_DM.Text = "Sửa";
            btn_Xoa_DM.BackColor = Color.Silver;
            btn_Sua_DM.BackColor = Color.Silver;
            btn_Huy_DM.BackColor = Color.Silver;
            btn_Them_DM.Text = "Tạo mới";
            btn_Them_DM.BackColor = Color.YellowGreen;
            txt_MaDM.Text = "";

            btn_Them_DM.BackColor = Color.YellowGreen;
            btn_Them_DM.Enabled = true;
            load_TP();
        }
        public void khi_click_dtg_DMTP()
        {
            btn_Huy_DM.BackColor = Color.Brown;
            btn_Huy_DM.Enabled = true;

            btn_Them_DM.BackColor = Color.Silver;
            btn_Them_DM.Enabled = false;

            btn_Sua_DM.Enabled = true;
            btn_Sua_DM.BackColor = Color.Teal;
            btn_Xoa_DM.Enabled = true;
            btn_Xoa_DM.BackColor = Color.Brown;
        }
        public void khi_click_btnSuaDM()
        {
            // chuyển nút sửa thành xác nhận - vô hiệu hóa tạo mới và xóa - kích hoạt nút hủy
            btn_Huy_DM.Enabled = true;
            btn_Huy_DM.BackColor = Color.Crimson;
            txt_Ten_DM.Enabled = true;
            btn_Xoa_DM.BackColor = Color.Silver;
            btn_Xoa_DM.Enabled = false;
            btn_Sua_DM.Text = "Xác nhận";
            btn_Sua_DM.BackColor = Color.DarkGreen;
            btn_Them_DM.Text = "Thêm";
            btn_Them_DM.BackColor = Color.LightSeaGreen;
            btn_Them_DM.Enabled = false;
            btn_Them_DM.BackColor = Color.Silver;

            checkSuaDM++;
            checkThemDM++;
        }
        public void khi_click_btnThemDM()
        {
            btn_Huy_DM.Enabled = true;
            btn_Huy_DM.BackColor = Color.Brown;

            btn_Xoa_DM.Enabled = false;
            btn_Sua_DM.Enabled = false;
            //btn_Sua_DM.Text = "Sửa";
            btn_Xoa_DM.BackColor = Color.Silver;
            btn_Sua_DM.BackColor = Color.Silver;
            //chuyển nút tạo mới thành thêm
            btn_Them_DM.Text = "Thêm";
            btn_Them_DM.BackColor = Color.LightSeaGreen;
            checkThemDM++;
        }
        public void khoi_phuc_Sua()
        {
            txt_Ten_DM.Enabled = false;
            btn_Sua_DM.Text = "Sửa";
            btn_Sua_DM.BackColor = Color.Teal;
            checkSuaDM = 0;
        }
        //=================================================================================================================================
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_Them_DM_Click(object sender, EventArgs e)
        {
            if(checkThemDM == 0)
            {
                txt_Ten_DM.Enabled = true;
                txt_Ten_DM.Focus();
                txt_MaDM.Text = "Thêm tự động";
                khi_click_btnThemDM();
            }
            else
            {
                if (txt_Ten_DM.Text == "")
                {
                    MessageBox.Show("Tên danh mục không được để trống");
                    checkThemDM = 1;
                }
                else
                {
                    BUS.BUS_QLFOOD.Instance.ThemDM(txt_Ten_DM.Text);
                    MessageBox.Show("Đã thêm danh mục "+txt_Ten_DM.Text);
                    dtg_DMTP.DataSource = BUS.BUS_QLFOOD.Instance.load_dtg_DMTP_BUS();
                    //khoi phuc ban dau
                    giao_dien_DMTP();
                }
            }
        }

        private void btn_Sua_DM_Click(object sender, EventArgs e)
        {
            
            if(checkSuaDM == 0)
            {
                if (txt_Ten_DM.Text == "")
                {
                    MessageBox.Show("Hãy chọn danh mục muốn Sửa");
                }
                else
                {
                    khi_click_btnSuaDM();
                }
                
            }
            else 
            {
                //hoan tat sua du lieu
                if (txt_Ten_DM.Text == "") 
                {
                    MessageBox.Show("Tên danh mục không được để trống");
                    checkSuaDM = 1;
                }
                else
                {
                    String tendm = txt_Ten_DM.Text;
                    String iddm = txt_MaDM.Text;
                    BUS.BUS_QLFOOD.Instance.CapNhatDM(tendm,iddm);
                    MessageBox.Show("Tên danh mục đã cập nhập");
                    //khoi phuc nut sua va huy va xoa
                    giao_dien_DMTP();
                } 
            }
        }

        private void btn_Xoa_DM_Click(object sender, EventArgs e)
        {
            if (txt_Ten_DM.Text == "")
            {
                MessageBox.Show("Hãy chọn danh mục muốn xóa");
            }
            else
            {
                DialogResult dlrDeleteDM = MessageBox.Show(this, "Nếu Xóa Danh mục này \nTất cả món ăn thuộc danh mục " +
                "này \nCũng bị xóa theo, Xác nhận ?", "Xóa Danh Mục", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(dlrDeleteDM == DialogResult.Yes)
                {
                    giao_dien_DMTP();
                }
            }

        }
        //================================================================================================================
        private void dtg_DMTP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                String TenDM = dtg_DMTP.Rows[e.RowIndex].Cells[1].Value.ToString();
                String MaDM = dtg_DMTP.Rows[e.RowIndex].Cells[0].Value.ToString();
                if (TenDM == "")
                {
                    //MessageBox.Show("Dữ liệu trống");
                }
                else
                {
                    khi_click_dtg_DMTP();
                    txt_Ten_DM.Text = TenDM;
                    txt_MaDM.Text = MaDM;
                }
            }
            catch
            {}
            
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                String iddm = cbCategory.SelectedValue.ToString();
                dtg_Thuc_Pham.DataSource = BUS.BUS_QLFOOD.Instance.load_Food_BUS(iddm+"",1);
            }
            catch
            {
                
            }
        }

        private void dtg_DMTP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Huy_DM_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đã hủy thao tác");
            giao_dien_DMTP();
        }
        //================================================================================================================================
        //================================================================================================================================
        //Quan ly mon ================================================================================================================================
        public void giao_dien_TP()
        {
            String iddm = cbCategory.SelectedValue.ToString();
            dataMon = BUS.BUS_QLFOOD.Instance.load_Food_BUS(iddm + "",0);
            dtg_Thuc_Pham.DataSource = BUS.BUS_QLFOOD.Instance.load_Food_BUS(iddm + "",1);
            load_TP();
            checkThemTP = 0;
            checkSuaTP = 0;

            cbCategory_select.Enabled = false;
            btn_Sua_TP.Text = "Sửa";
            btn_Xoa_TP.BackColor = Color.Silver;
            btn_Sua_TP.BackColor = Color.Silver;
            btn_Huy_TP.BackColor = Color.Silver;
            btn_Them_TP.Text = "Tạo mới";
            btn_Them_TP.BackColor = Color.YellowGreen;

            txt_Ten_TP.Enabled = false;
            txt_Ma_TP.Enabled = false;
            txt_Gia_TP.Enabled = false;
            txt_Ten_TP.Text = "";
            txt_Ma_TP.Text = "";
            txt_Gia_TP.Text = "";
            cbCategory_select.SelectedIndex = 0;
        }
        public void khi_click_dtg_TP()
        {
            btn_Sua_TP.Enabled = true;
            btn_Sua_TP.BackColor = Color.Teal;
            btn_Xoa_TP.Enabled = true;
            btn_Xoa_TP.BackColor = Color.Brown;
        }

        private void btn_Them_TP_Click(object sender, EventArgs e)
        {
            if(checkThemTP == 0)
            {
                
                txt_Ma_TP.Text = "Thêm tự động";
                txt_Ten_DM.Text = "";
                txt_Gia_TP.Text = "";
                cbCategory_select.SelectedIndex = 0;
                khi_click_btnThemTP();
            }
            else
            {
                if (txt_Ten_TP.Text == "")
                {
                    MessageBox.Show("Chưa nhập tên Thực phẩm");
                    checkThemDM = 1;
                }
                else
                {
                    if(txt_Gia_TP.Text == "")
                    {
                        MessageBox.Show("Chưa nhập Giá Thực phẩm");
                        checkThemDM = 1;
                    }
                    else
                    {
                        String tentp, iddm, giatp;
                        tentp = txt_Ten_TP.Text;
                        iddm = cbCategory_select.SelectedValue.ToString();
                        giatp = txt_Gia_TP.Text;
                        BUS.BUS_QLFOOD.Instance.ThemTP(tentp,iddm,giatp);
                        MessageBox.Show("Đã thêm:\n- " + txt_Ten_TP.Text +"\nVào danh mục:\n- "+cbCategory_select.Text);
                        //dtg_DMTP.DataSource = null;
                        //dtg_DMTP.DataSource = BUS.BUS_QLFOOD.Instance.load_dtg_DMTP_BUS();
                        //khoi phuc ban dau
                        giao_dien_TP();
                    }
                    
                }
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dtg_Thuc_Pham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //khi_click_btnSuaTP()
            txt_Ma_TP.Text = dataMon.Rows[e.RowIndex][0].ToString();
            String iddm = dataMon.Rows[e.RowIndex][1].ToString();
            for(int i = 0; i < dataDM.Rows.Count;i++)
            {
                if(iddm == dataDM.Rows[i].ItemArray[0].ToString())
                {
                    cbCategory_select.SelectedIndex = i;
                    break;
                }
            }
            txt_Ten_TP.Text = dataMon.Rows[e.RowIndex][2].ToString();
            txt_Gia_TP.Text = dataMon.Rows[e.RowIndex][3].ToString();
            btn_Xoa_TP.Enabled = true;
            btn_Xoa_TP.BackColor = Color.Brown;
            btn_Them_DM.Enabled = false;
            btn_Sua_TP.Enabled = true;
            btn_Sua_TP.BackColor = Color.Teal;
            btn_Huy_TP.Enabled = true;
            btn_Huy_TP.BackColor = Color.Brown;
        }

        private void btn_Xoa_TP_Click(object sender, EventArgs e)
        {
            DialogResult dlrXoaTP = MessageBox.Show("Xác nhận xóa "+txt_Ten_TP.Text, "Xóa Thực Phẩm",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if(dlrXoaTP == DialogResult.Yes)
            {
                BUS.BUS_QLFOOD.Instance.XoaTP(txt_Ma_TP.Text);
                giao_dien_TP();
            }
            
        }

        private void btn_Sua_TP_Click(object sender, EventArgs e)
        {
            if (checkSuaTP == 0)
            {
                khi_click_btnSuaTP();
            }
            else
            {
                if (txt_Ten_TP.Text == "")
                {
                    MessageBox.Show("Chưa nhập tên Thực phẩm");
                    checkThemDM = 1;
                }
                else
                {
                    if (txt_Gia_TP.Text == "")
                    {
                        MessageBox.Show("Chưa nhập Giá Thực phẩm");
                        checkThemDM = 1;
                    }
                    else
                    {
                        String tentp, iddm, giatp;
                        tentp = txt_Ten_TP.Text;
                        iddm = cbCategory_select.SelectedValue.ToString();
                        giatp = txt_Gia_TP.Text;
                        //BUS.BUS_QLFOOD.Instance.ThemTP(tentp, iddm, giatp);
                        //MessageBox.Show("Đã thêm:\n- " + txt_Ten_TP.Text + "\nVào danh mục:\n- " + cbCategory_select.Text);
                        //dtg_DMTP.DataSource = null;
                        //dtg_DMTP.DataSource = BUS.BUS_QLFOOD.Instance.load_dtg_DMTP_BUS();
                        //khoi phuc ban dau
                        giao_dien_TP();
                    }

                }

            }
        }
        private void btn_Huy_TP_Click(object sender, EventArgs e)
        {
            giao_dien_TP();
        }

        public void khi_click_btnSuaTP()
        {
            // chuyển nút sửa thành xác nhận - vô hiệu hóa tạo mới và xóa - kích hoạt nút hủy
            btn_Huy_TP.Enabled = true;
            btn_Huy_TP.BackColor = Color.Crimson;
            txt_Ten_TP.Enabled = true;
            txt_Gia_TP.Enabled = true;
            cbCategory_select.Enabled = true;
            btn_Xoa_TP.BackColor = Color.Silver;
            btn_Xoa_TP.Enabled = false;
            btn_Sua_TP.Text = "Xác nhận";
            btn_Sua_TP.BackColor = Color.DarkGreen;
            btn_Them_TP.Text = "Thêm";
            btn_Them_TP.BackColor = Color.LightSeaGreen;

            checkSuaTP++;
            checkThemTP++;
        }
        public void khi_click_btnThemTP()
        {
            btn_Xoa_TP.Enabled = false;
            btn_Huy_TP.Enabled = true;
            btn_Sua_TP.Enabled = false;
            //btn_Sua_DM.Text = "Sửa";
            btn_Xoa_TP.BackColor = Color.Silver;
            btn_Sua_TP.BackColor = Color.Silver;
            btn_Huy_TP.BackColor = Color.Brown;
            //chuyển nút tạo mới thành thêm
            btn_Them_TP.Text = "Thêm";
            btn_Them_TP.BackColor = Color.LightSeaGreen;

            txt_Gia_TP.Enabled = true;
            txt_Ten_TP.Enabled = true;
            checkThemTP++;
        }
        public void khoi_phuc_Sua_TP()
        {
            txt_Ten_DM.Enabled = false;
            btn_Sua_DM.Text = "Sửa";
            btn_Sua_DM.BackColor = Color.Teal;
            checkSuaDM = 0;
        }
    }
}
