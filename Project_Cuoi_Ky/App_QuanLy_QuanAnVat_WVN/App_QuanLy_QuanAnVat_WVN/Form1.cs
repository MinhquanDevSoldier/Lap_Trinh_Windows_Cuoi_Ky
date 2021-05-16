using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace App_QuanLy_QuanAnVat_WVN
{
    public partial class Form1 : Form
    {
        string tennv;
        string idNV;
        public TabControl TabControl1
        {
            get
            {
                return tabControl1;
            }
            set
            {
                tabControl1 = value;
            }
        }

        public Form1(String TenNV,String idnv)
        {
            InitializeComponent();
            tennv = TenNV;
            lbTTtentk.Visible = true;
            lbTTtentk.Text = TenNV;
            idNV = idnv;
        }
        //code giao dien---------------------------------------------------------------------------------------------------------------------------------------------
        private void Form1_Resize(object sender, EventArgs e)
        {
            tabControl1.SetBounds(this.Width / 2 - tabControl1.Width / 2, this.Height / 2 - tabControl1.Height / 2, tabControl1.Width, tabControl1.Height);
        }
        private void lbThucAn_Click(object sender, EventArgs e)
        {
            lbThucAn.ForeColor = Color.White;
            lbThucAn.BackColor = Color.SteelBlue;

            lbDoUong.ForeColor = Color.SteelBlue;
            lbDoUong.BackColor = Color.WhiteSmoke;
            lbCombo.ForeColor = Color.SteelBlue;
            lbCombo.BackColor = Color.WhiteSmoke;
            lbKhac.ForeColor = Color.SteelBlue;
            lbKhac.BackColor = Color.WhiteSmoke;
            HienThiTheoDM(13);
        }

        private void lbDoUong_Click(object sender, EventArgs e)
        {
            lbThucAn.ForeColor = Color.SteelBlue;
            lbThucAn.BackColor = Color.WhiteSmoke;

            lbDoUong.ForeColor = Color.WhiteSmoke;
            lbDoUong.BackColor = Color.SteelBlue;
            lbCombo.ForeColor = Color.SteelBlue;
            lbCombo.BackColor = Color.WhiteSmoke;
            lbKhac.ForeColor = Color.SteelBlue;
            lbKhac.BackColor = Color.WhiteSmoke;
            HienThiTheoDM(14);
        }

        private void lbCombo_Click(object sender, EventArgs e)
        {
            lbThucAn.ForeColor = Color.SteelBlue;
            lbThucAn.BackColor = Color.WhiteSmoke;

            lbDoUong.ForeColor = Color.SteelBlue;
            lbDoUong.BackColor = Color.WhiteSmoke;
            lbCombo.ForeColor = Color.WhiteSmoke;
            lbCombo.BackColor = Color.SteelBlue;
            lbKhac.ForeColor = Color.SteelBlue;
            lbKhac.BackColor = Color.WhiteSmoke;
            HienThiTheoDM(3);
        }

        private void lbKhac_Click(object sender, EventArgs e)
        {
            lbThucAn.ForeColor = Color.SteelBlue;
            lbThucAn.BackColor = Color.WhiteSmoke;

            lbDoUong.ForeColor = Color.SteelBlue;
            lbDoUong.BackColor = Color.WhiteSmoke;
            lbCombo.ForeColor = Color.SteelBlue;
            lbCombo.BackColor = Color.WhiteSmoke;
            lbKhac.ForeColor = Color.WhiteSmoke;
            lbKhac.BackColor = Color.SteelBlue;
            HienThiTheoDM(4);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Button
            btnCloseApp.BackColor = Color.Red;
            btnCloseApp.ForeColor = Color.White;
            btnhuy.BackColor = Color.Firebrick;
            btnhuy.ForeColor = Color.White;
            btnhuy.FlatStyle = FlatStyle.Popup;
            btnluu.FlatStyle = FlatStyle.Popup;
            btnluu.BackColor = Color.DarkOliveGreen;
            btnluu.ForeColor = Color.White;
            btntimkiem.FlatStyle = FlatStyle.Popup;
            btntinhtien.FlatStyle = FlatStyle.Popup;
            btntinhtien.ForeColor = Color.White;
            btntinhtien.BackColor = Color.Goldenrod;
            //btnTP_Click.FlatStyle = FlatStyle.Popup;
            //btnBan_Click.FlatStyle = FlatStyle.Popup;
            btnCloseApp.FlatStyle = FlatStyle.Popup;
            //btndangnhap.FlatStyle = FlatStyle.Popup;
            //Form
            this.BackColor = Color.WhiteSmoke;
            tbOrder.BackColor = Color.White;
            lbTenban.ForeColor = Color.Black;
            tbBill.BackColor = Color.Gold;
            gbHoadon.BackColor = Color.White;
            panelOrder.BackColor = Color.Gold;
            tabControl1.SelectedIndex = 1;

            //
            loadngaythang();
            loadcbdanhmuc();
            LoadBangOrder();
            txtTimkiem.Text = "Nhâp Mã/Tên Món muốn tìm";
            txtTimkiem.ForeColor = Color.Gray;
            cbDanhmuc.SelectedIndex = 0;
            btnQLban.Enabled = false;
            btnQLthucpham.Enabled = false;
            btnQLhoadon.Enabled = false;
            loadBan(cbKhuvuc.Text);
            loadKhuVuc();
            string indexofDM = cbDanhmuc.SelectedValue.ToString();
            LoadThucPham(indexofDM.ToString(),"");

            //Phan loai nguoi dung
            if(BUSWVN.Instance.phan_quyen_Admin_BUS(idNV))
            {
                btnQLhoadon.Enabled = true;
                btnQLban.Enabled = true;
                btnQLthucpham.Enabled = true;
                lbvaitro.Text = "Quản lý";
            }
            else
            {
                lbvaitro.Text = "Phục vụ";
            }
            
        }
        //Code tab dat mon---------------------------------------------------------------------------------------------------------------------------------------------
        public void loadcbdanhmuc()
        {
            cbDanhmuc.DataSource = BUSWVN.Instance.loaddanhmuc();
            cbDanhmuc.DisplayMember = "TenDM";
            cbDanhmuc.ValueMember = "IDDMTP";
        }
        public void LoadThucPham(string id,string tenmon)
        {
            if(txtTimkiem.Text == "Nhâp Mã/Tên Món muốn tìm")
            {
                tenmon = "";
            }
            else
            {
                tenmon = txtTimkiem.Text;
            }
            
            flpThucPham.Controls.Clear();
            DataTable data = BUSWVN.Instance.LoadThucPham(id,tenmon);
            foreach (DataRow item in data.Rows)
            {
                Button btnTP = new Button() { Width = 230, Height = 230 };
                btnTP.TextAlign = ContentAlignment.MiddleCenter;
                //btnTP.Image = Image.FromFile("../../Image/Mon/"+item["Hinhanh"].ToString());
                //btnTP.ImageAlign = ContentAlignment.TopCenter;
                btnTP.BackColor = Color.LightYellow;
                btnTP.Text = item["TenTP"].ToString();
                btnTP.Click += btnTP_Click;
                btnTP.Tag = item["TenTP"];
                flpThucPham.Controls.Add(btnTP);
            }

        }

        private void btnTP_Click(object sender, EventArgs e)
        {
            if (lbTenban.Text == "Tên bàn")
            {
                MessageBox.Show("Hãy chọn bàn trước");
            }
            else
            {
                //frmAdd frmAddnew = new frmAdd();
                //frmAddnew.StartPosition = FormStartPosition.CenterScreen;
                //frmAddnew.MaximizeBox = false;
                //frmAddnew.MaximumSize = new Size(frmAddnew.Width, frmAddnew.Height);
                //frmAddnew.MinimumSize = new Size(frmAddnew.Width, frmAddnew.Height);
                //frmAddnew.ShowDialog();
                    
                using (frmAdd frmAddnew = new frmAdd((sender as Button).Text, lbTenban.Text))
                {
                    frmAddnew.StartPosition = FormStartPosition.CenterScreen;
                    frmAddnew.ActiveControl = null;
                    frmAddnew.ShowDialog();
                    
                    loadorder(lbidban.Text);
                    dtgOrder.Refresh();
                    //MessageBox.Show("Đã thêm " + frmAddnew.resultSL +" "+ (sender as Button).Text);
                }
            }

            //throw new NotImplementedException();
        }
        public void HienThiTheoDM(int madm)
        {
            int id = madm;
            LoadThucPham(id.ToString(),"");
        }
        private void cbDanhmuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        public void LoadBangOrder()
        {
            dtgOrder.BackgroundColor = Color.White;
            dtgOrder.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dtgOrder.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgOrder.ReadOnly = true;
            dtgOrder.RowTemplate.Height = 40;
            dtgOrder.Columns.Add("TenTP", "Tên món");
            dtgOrder.Columns[0].DataPropertyName = "tentp";
            dtgOrder.Columns[0].Width = 200;
            dtgOrder.Columns.Add("soluong", "SL");
            dtgOrder.Columns[1].DataPropertyName = "Soluong";
            dtgOrder.Columns[1].Width = 60;
            dtgOrder.Columns.Add("thanhtien", "Thành tiền");
            dtgOrder.Columns[2].DataPropertyName = "thanhtien";
            dtgOrder.Columns[2].Width = 200;
        }

        private void txtTimkiem_Click(object sender, EventArgs e)
        {
            if (txtTimkiem.Text == "Nhâp Mã/Tên Món muốn tìm")
            {
                txtTimkiem.Text = "";
                txtTimkiem.ForeColor = Color.Black;
            }
        }

        private void txtTimkiem_Leave(object sender, EventArgs e)
        {
            if (txtTimkiem.Text == "")
            {
                txtTimkiem.Text = "Nhâp Mã/Tên Món muốn tìm";
                txtTimkiem.ForeColor = Color.Gray;
            }
        }
        private void btntinhtien_Click(object sender, EventArgs e)
        {
            int rowcount = dtgOrder.Rows.Count;
            if (rowcount == 1)
            {
                MessageBox.Show("hóa đơn trống");
                BUSWVN.Instance.HuyHoaDon(lbidban.Text);
                tabControl1.SelectedTab = tbTable;
                loadBan(cbKhuvuc.Text);
                lbTenban.Text = "Tên bàn";
                dtgOrder.DataSource = null;
                LoadBangOrder();
            }
            else
            {
                String idban = lbidban.Text;
                BUSWVN.Instance.ThanhtoanhdBUS(idban);
                MessageBox.Show("Đã thanh toán");
                dtgOrder.DataSource = null;
                tabControl1.SelectedTab = tbTable;
                loadBan(cbKhuvuc.Text);
                lbTenban.Text = "Tên bàn";

            }
            
        }
        //code tab so ban--------------------------------------------------------------------------------------------------------------------------------------------- 
        public void loadKhuVuc()
        {
            cbKhuvuc.Items.Clear();
            cbKhuvuc.DataSource = BUS.BUSWVN.Instance.LoadKhuvuc();
            cbKhuvuc.DisplayMember = "Tenkv";
            cbKhuvuc.ValueMember = "IDKV";
        }
        public void loadBan(string tenkv)
        {
            //tenkv = cbKhuvuc.Text;
            flpBan.Controls.Clear();
            DataTable data = BUSWVN.Instance.LoadSoBan(tenkv);//Dataprovider.Instance.ExcuteQuery("select * from dbo.Ban where idkv = " + id);
            foreach (DataRow item in data.Rows)
            {
                Button btnBan = new Button() { Width = 200, Height = 200 };
                btnBan.Text = item["TenBan"].ToString();
                btnBan.Click += btnBan_Click;
                btnBan.Tag = item["IDBan"];
                if (item["Trangthai"].ToString() == "False")
                {
                    btnBan.ForeColor = Color.Crimson;
                    btnBan.BackColor = Color.Cornsilk;
                }
                else
                {
                    btnBan.ForeColor = Color.Cornsilk;
                    btnBan.BackColor = Color.Crimson;
                }
                flpBan.Controls.Add(btnBan);
            }
        }
        private void cbKhuvuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadBan(cbKhuvuc.Text);
        }
        private void cbKhuvuc_SelectedValueChanged(object sender, EventArgs e)
        {
            //loadBan();
        }
        private void btnBan_Click(object sender, EventArgs e)
        {
            string tenban = (sender as Button).Text;
            string idban = (sender as Button).Tag.ToString();
            tabControl1.SelectedTab = tbOrder;
            lbTenban.Text = tenban;
            lbidban.Text = idban;
            BUSWVN.Instance.TaoHoaDonBUS(idban,idNV);
            loadorder(idban);
            //MessageBox.Show(id);
        }
        public void loadorder(String id)
        {
            //dtgOrder.Rows.Clear();
            //LoadBangOrder();
            dtgOrder.DataSource = BUS.BUSWVN.Instance.showOrderBUS(id);
            dtgOrder.Refresh();
        }


        //code tab hoa don---------------------------------------------------------------------------------------------------------------------------------------------
        public void loadngaythang()
        {
            int[] Nam = new int[30];
            int nam = 2021;
            for(int i = 0;i<Nam.Length;i++)
            {
                Nam[i] = nam;
                nam++;
                cbNam.Items.Add(Nam[i]);
            }
            int[] Thang = { 1,2,3,4,5,6,7,8,9,10,11,12};
            
            for(int  i = 0;i<Thang.Length;i++)
            {
                cbThang.Items.Add(Thang[i]);
            }
            cbNam.SelectedIndex = 0;
            cbThang.SelectedIndex = 0;
        }
        private void btnLammoihd_Click(object sender, EventArgs e)
        {
            BUSWVN.Instance.HoaDonBUS(dtgHoadon);
        }
        public void setdtgHoaDon()
        {
            //DataColumn columnid = new DataColumn();
            //columnid.ColumnName = "Mã bàn";

        }
        //code tab he thong---------------------------------------------------------------------------------------------------------------------------------------------
        private void btnCloseApp_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Xác nhận đóng", "Chọn Yes đế xác nhận thoát ứng dụng", MessageBoxButtons.YesNoCancel);
            if (dlr == DialogResult.Yes)
            {
                this.Dispose();
                
            }
        }
        private void btndangnhap_Click(object sender, EventArgs e)
        {
           
        }
        private void lbTTtentk_TextChanged(object sender, EventArgs e)
        {
            if(lbTTtentk.Text != "Bạn cần đăng nhập để quản lý")
            {
                btnQLhoadon.Enabled = true;
                btnQLban.Enabled = true;
                btnQLthucpham.Enabled = true;
            }
        }        
        //////lay thong tin tu frmLogin
        //public string InfomationTK
        //{
        //    set
        //    {
        //        lbTTtentk.Text = value;
        //    }
        //}
        //public string sdt
        //{
        //    set
        //    {
        //        lbTTsoDT.Text = value;
        //    }
        //}
        //public string mail
        //{
        //    set
        //    {
        //        lbTTemail.Text = value;
        //    }
        //}

        private void dtgHoadon_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            
        }

        private void dtgHoadon_CellValidated(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgHoadon_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (dtgOrder.Rows.Count > 1)
            {
                float thanhtien = 0;
                DataTable data = new DataTable();
                data = ((DataTable)dtgOrder.DataSource).Copy();
                foreach (DataRow item in data.Rows)
                {
                    float tongtien = 0;
                    tongtien = float.Parse(item.ItemArray.GetValue(2).ToString());
                    thanhtien += tongtien;
                }
                lbThanhtien.Text = thanhtien.ToString();
            }
            else
            {
                lbThanhtien.Text = 0.0000.ToString();
            }
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            BUSWVN.Instance.HuyHoaDon(lbidban.Text);
            
            MessageBox.Show("Đã hủy");
            tabControl1.SelectedTab = tbTable;
            loadBan(cbKhuvuc.Text);
            lbTenban.Text = "Tên bàn";
            dtgOrder.DataSource = null;
            LoadBangOrder();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            //BUSWVN.Instance.HuyHoaDon(lbTenban.Text);
            if(dtgOrder.Rows.Count > 1)
            {   
                MessageBox.Show("Lưu thành công");
                tabControl1.SelectedTab = tbTable;
                loadBan(cbKhuvuc.Text);
                lbTenban.Text = "Tên bàn";
                dtgOrder.DataSource = null;
                LoadBangOrder();
            }
            else
            {
                MessageBox.Show("Hãy thêm món trước khi lưu");
                BUSWVN.Instance.HuyHoaDon(lbidban.Text);
                tabControl1.SelectedTab = tbTable;
                loadBan(cbKhuvuc.Text);
                lbTenban.Text = "Tên bàn";
                dtgOrder.DataSource = null;
                LoadBangOrder();
            }
            
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void btQLthucan_Click(object sender, EventArgs e)
        {
            qlfood foodManage = new qlfood();
            foodManage.StartPosition = FormStartPosition.CenterScreen;
            foodManage.ShowDialog();
        }

        private void btQLdouong_Click(object sender, EventArgs e)
        {
            qltable TableManager = new qltable();
            TableManager.StartPosition = FormStartPosition.CenterScreen;
            TableManager.ShowDialog();
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if(e.TabPage == tbTable)
            {
                loadBan(cbKhuvuc.Text);
            }
            if(e.TabPage == tbOrder)
            {
                lbThucAn.Select();
            }
        }

        private void panelOrder_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            LoadThucPham(cbDanhmuc.SelectedValue.ToString(),txtTimkiem.Text);
        }
        public void sapxepnamthang()
        {
            cbNgay1.Items.Clear();
            cbNgay2.Items.Clear();
            int[] Ngay = new int[31];
            for (int i = 0; i < Ngay.Length; i++)
            {
                Ngay[i] = i + 1;
            }
            if (cbThang.Text == "2")
            {
                if (int.Parse(cbNam.Text.ToString()) % 4 == 0)
                {
                    for (int i = 0; i < 29; i++)
                    {
                        cbNgay1.Items.Add(Ngay[i]);
                        cbNgay2.Items.Add(Ngay[i]);
                    }
                }
                else
                {
                    for (int i = 0; i < 28; i++)
                    {
                        cbNgay1.Items.Add(Ngay[i]);
                        cbNgay2.Items.Add(Ngay[i]);
                    }
                }

            }
            else
            {
                for (int i = 0; i < 30; i++)
                {
                    cbNgay1.Items.Add(Ngay[i]);

                    cbNgay2.Items.Add(Ngay[i]);
                }
            }
            cbNgay1.SelectedIndex = 0;
            cbNgay2.SelectedIndex = 0;
        }
        private void cbThang_SelectedValueChanged(object sender, EventArgs e)
        {
            sapxepnamthang();
        }

        private void cbNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            sapxepnamthang();
        }

        private void btntimtheodate_Click(object sender, EventArgs e)
        {
            int thang = int.Parse(cbThang.Text.ToString());
            int ngay1 = int.Parse(cbNgay1.Text.ToString());
            int ngay2 = int.Parse(cbNgay2.Text.ToString());
            if(ngay1>=ngay2)
            {
                MessageBox.Show("ngày bắt đầu phải nhỏ hơn ngày kết thúc");
            }
            else
            {
                string day1, day2;
                if (thang < 10)
                {
                    if (ngay1 < 10)
                    {
                        if (ngay2 < 10)
                        {
                            day1 = cbNam.Text + "-0" + cbThang.Text + "-0" + cbNgay1.Text;
                            day2 = cbNam.Text + "-0" + cbThang.Text + "-0" + cbNgay2.Text;
                        }
                        else
                        {
                            day1 = cbNam.Text + "-0" + cbThang.Text + "-0" + cbNgay1.Text;
                            day2 = cbNam.Text + "-0" + cbThang.Text + "-" + cbNgay2.Text;
                        }
                    }
                    else
                    {
                        if (ngay2 < 10)
                        {
                            day1 = cbNam.Text + "-0" + cbThang.Text + "-" + cbNgay1.Text;
                            day2 = cbNam.Text + "-0" + cbThang.Text + "-0" + cbNgay2.Text;
                        }
                        else
                        {
                            day1 = cbNam.Text + "-0" + cbThang.Text + "-" + cbNgay1.Text;
                            day2 = cbNam.Text + "-0" + cbThang.Text + "-" + cbNgay2.Text;
                        }

                    }
                }
                else
                {
                    if (ngay1 < 10)
                    {
                        if (ngay2 < 10)
                        {
                            day1 = cbNam.Text + "-" + cbThang.Text + "-0" + cbNgay1.Text;
                            day2 = cbNam.Text + "-" + cbThang.Text + "-0" + cbNgay2.Text;
                        }
                        else
                        {
                            day1 = cbNam.Text + "-" + cbThang.Text + "-0" + cbNgay1.Text;
                            day2 = cbNam.Text + "-" + cbThang.Text + "-" + cbNgay2.Text;
                        }
                    }
                    else
                    {
                        if (ngay2 < 10)
                        {
                            day1 = cbNam.Text + "-" + cbThang.Text + "-" + cbNgay1.Text;
                            day2 = cbNam.Text + "-" + cbThang.Text + "-0" + cbNgay2.Text;
                        }
                        else
                        {
                            day1 = cbNam.Text + "-" + cbThang.Text + "-" + cbNgay1.Text;
                            day2 = cbNam.Text + "-" + cbThang.Text + "-" + cbNgay2.Text;
                        }
                    }
                }
                
                dtgHoadon.DataSource = BUSWVN.Instance.timtheodate(day1,day2);
            }
            
        }

        private void btnCloseApp_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Đăng xuất", btnCloseApp);
        }

        private void btnQLhoadon_Click(object sender, EventArgs e)
        {
            qlbill BillManager = new qlbill();
            BillManager.StartPosition = FormStartPosition.CenterScreen;
            BillManager.ShowDialog();
        }

        private void btnQLTaikhoan_Click(object sender, EventArgs e)
        {
            qlAccount AccountManager = new qlAccount();
            AccountManager.StartPosition = FormStartPosition.CenterScreen;
            AccountManager.ShowDialog();
        }
    }
}
