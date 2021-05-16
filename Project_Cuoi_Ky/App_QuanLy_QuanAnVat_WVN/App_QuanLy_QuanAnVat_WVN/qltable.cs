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
    public partial class qltable : Form
    {
        //CheckPoint
        int CheckThemKV;
        int CheckCapNhatKV;
        int CheckThemBan;
        int CheckCapNhatBan;

        //Data
        DataTable dataKV = BUS.BUSWVN.Instance.DSKV("");
        DataTable dataBan = new DataTable();
        BindingSource bsKV = new BindingSource();
        BindingSource bsBan = new BindingSource();

        //QLKV
        public void GiaoDienMacDinhKV()
        {
            dataKV = BUS.BUSWVN.Instance.DSKV("");
            bsKV.DataSource = dataKV;
            dtgDSKV.DataSource = bsKV;
            dtgDSKV.Update();

            CheckCapNhatKV = 0;
            CheckThemKV = 0;

            tbMaKV.Text = "";
            tbTenKV.Text = "";
            tbMaKV.Enabled = false;
            tbTenKV.Enabled = false;

            btnTaoMoiKV.Enabled = true;
            btnTaoMoiKV.BackColor = Color.DarkOliveGreen;
            btnTaoMoiKV.Text = "Mới";

            btnCapNhatKV.Text = "Sửa";
            btnCapNhatKV.Enabled = false;
            btnCapNhatKV.BackColor = Color.Gray;

            btnXoaKV.Enabled = false;
            btnXoaKV.BackColor = Color.Gray;
            btnHuyKV.Enabled = false;
            btnHuyKV.BackColor = Color.Gray;
            GiaoDienMacDinhBan();
        }
        public void GiaoDienNhapKV()
        {
            tbMaKV.Text = "Thêm tự động";
            tbTenKV.Text = "";
            tbTenKV.Enabled = true;
            btnTaoMoiKV.Text = "Thêm";
            btnTaoMoiKV.BackColor = Color.DarkTurquoise;
            btnHuyKV.Enabled = true;
            btnHuyKV.BackColor = Color.Brown;

            CheckThemKV = 1;
        }
        private void btnTaoMoiKV_Click(object sender, EventArgs e)
        {
            if(CheckThemKV == 0)
            {
                GiaoDienNhapKV();
            }
            else
            {
                try
                {
                    String tenkv = tbTenKV.Text;
                    if(tenkv == "")
                    {
                        MessageBox.Show("Chưa nhập tên khu vực");
                    }
                    else if(KiemtratrungKV(tenkv))
                    {
                        MessageBox.Show(tenkv+" đã tồn tại");
                    }
                    else
                    {
                        BUS.BUSWVN.Instance.ThemKV(tenkv);
                        MessageBox.Show("Đã thêm "+tenkv);
                        GiaoDienMacDinhKV();
                    }
                    
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                
            }
        }
        public bool KiemtratrungKV(String TenKV)
        {
            foreach(DataRow row in dataKV.Rows )
            {
                if(TenKV == row[1].ToString())
                {
                    return true;
                }
            }
            return false;
        }
        private void btnCapNhatKV_Click(object sender, EventArgs e)
        {
            if(CheckCapNhatKV == 0)
            {
                btnCapNhatKV.Text = "Xác nhận";
                btnCapNhatKV.BackColor = Color.DarkCyan;
                tbTenKV.Enabled = true;

                CheckCapNhatKV = 1;
            }
            else
            {
                String TenKVModify = tbTenKV.Text;
                String idkv = tbMaKV.Text;
                if(TenKVModify == "")
                {
                    MessageBox.Show("Tên Khu vực không được trống");
                }
                else if(KiemtratrungKV(TenKVModify))
                {
                    MessageBox.Show(TenKVModify + " Đã tồn tại");
                }
                else
                {
                    BUS.BUSWVN.Instance.CapNhatKV(TenKVModify,idkv);
                    GiaoDienMacDinhKV();
                }
               
            }
        }
        //-----------------------------------------------------------------------------------------------------
        //QLBan
        public void GiaoDienMacDinhBan()
        {
            dataBan = BUS.BUSWVN.Instance.DSBAN(0);
            dtgDSBan.DataSource = BUS.BUSWVN.Instance.DSBAN(1);
            dtgDSBan.Refresh();

            cbKhuvuc.DataSource = dataKV;
            cbKhuvuc.DisplayMember = "TenKV";
            cbKhuvuc.ValueMember = "IDKV";

            cbKhuvucInfo.DataSource = dataKV;
            cbKhuvucInfo.DisplayMember = "TenKV";
            cbKhuvucInfo.ValueMember = "IDKV";

            CheckThemBan = 0;
            CheckCapNhatBan = 0;

            tbMaBan.Text = "";
            tbTenBan.Text = "";
            tbMaBan.Enabled = false;
            tbTenBan.Enabled = false;
            cbKhuvucInfo.Enabled = false;
            //cbKhuvucInfo.SelectedIndex = 0;

            btnTaoMoiBan.Enabled = true;
            btnTaoMoiBan.BackColor = Color.DarkOliveGreen;
            btnTaoMoiBan.Text = "Mới";

            btnCapNhatBan.Text = "Sửa";
            btnCapNhatBan.Enabled = false;
            btnCapNhatBan.BackColor = Color.Gray;

            btnXoaBan.Enabled = false;
            btnXoaBan.BackColor = Color.Gray;
            btnHuyBan.Enabled = false;
            btnHuyBan.BackColor = Color.Gray;
        }
        public void GiaoDienNhapBan()
        {
            cbKhuvucInfo.Enabled = true;
            tbMaBan.Text = "Thêm tự động";
            tbTenBan.Text = "";
            tbTenBan.Enabled = true;
            btnTaoMoiBan.Text = "Thêm";
            btnTaoMoiBan.BackColor = Color.DarkCyan;
            btnHuyBan.Enabled = true;
            btnHuyBan.BackColor = Color.Brown;

            CheckThemBan = 1;
        }
        private void btnTaoMoiBan_Click(object sender, EventArgs e)
        {
            if(CheckThemBan == 0)
            {
                GiaoDienNhapBan();
            }
            else
            {
                String TenBan = tbTenBan.Text;
                String idkv = cbKhuvucInfo.SelectedValue.ToString();
                if (TenBan == "")
                {
                    MessageBox.Show("Tên bàn không được để trống");
                }
                else if(TrungTenBan(TenBan,idkv))
                {
                    MessageBox.Show(TenBan + " Đã tồn tại");
                }
                else
                {
                    BUS.BUSWVN.Instance.ThemBan(TenBan,idkv);
                    GiaoDienMacDinhBan();
                }
                
            }
        }
        public bool TrungTenBan(String tenban,String idkv)
        {
            foreach(DataRow row in dataBan.Rows)
            {
                if(tenban == row[2].ToString() && idkv == row[1].ToString())
                {
                    return true;
                }
            }
            return false;
        }
        private void btnCapNhatBan_Click(object sender, EventArgs e)
        {
            if (CheckCapNhatBan == 0)
            {
                btnCapNhatBan.Text = "Xác nhận";
                btnCapNhatBan.BackColor = Color.DarkCyan;
                tbTenBan.Enabled = true;
                cbKhuvucInfo.Enabled = true;

                CheckCapNhatBan = 1;
            }
            else
            {
                String tenbanModify,idkvModify;
                tenbanModify = tbTenBan.Text;
                idkvModify = cbKhuvucInfo.SelectedValue.ToString();

                if(tenbanModify == "")
                {
                    MessageBox.Show("Tên bàn không được để trống");
                }
                else if (TrungTenBan(tenbanModify, idkvModify))
                {
                    MessageBox.Show(tenbanModify + " Đã tồn tại");
                }
                else
                {
                    BUS.BUSWVN.Instance.CapNhatBan(tenbanModify, idkvModify,tbMaBan.Text);
                    GiaoDienMacDinhBan();
                }
                GiaoDienMacDinhBan();
            }
        }
        //-----------------------------------------------------------------------------------------------------
        public qltable()
        {
            InitializeComponent();
        }
        private void qltable_Load(object sender, EventArgs e)
        {
            GiaoDienMacDinhBan();
            GiaoDienMacDinhKV();
        }
        private void btnBackFromQL_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnHuyKV_Click(object sender, EventArgs e)
        {
            GiaoDienMacDinhKV();
        }

        private void dtgDSKV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (CheckThemKV == 1 || CheckCapNhatKV == 1)
            {
                MessageBox.Show("Không thể chọn do đang thực hiện thao tác khác\n Hủy Thao tác hiện tại trước.");
            }
            else
            {
                //Lay thong tin 
                try
                {
                    tbMaKV.Text = dtgDSKV.Rows[e.RowIndex].Cells[0].Value.ToString();
                    tbTenKV.Text = dtgDSKV.Rows[e.RowIndex].Cells[1].Value.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                //Trình điều khiển
                btnTaoMoiKV.BackColor = Color.Gray;
                btnCapNhatKV.BackColor = Color.Navy;
                btnXoaKV.BackColor = Color.Brown;
                btnHuyKV.BackColor = Color.Brown;

                btnTaoMoiKV.Enabled = false;
                btnCapNhatKV.Enabled = true;
                btnXoaKV.Enabled = true;
                btnHuyKV.Enabled = true;
            }
        }

        private void dtgDSBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (CheckThemBan == 1 || CheckCapNhatBan == 1)
            {
                MessageBox.Show("Không thể chọn do đang thực hiện thao tác khác\n Hủy Thao tác hiện tại trước.");
            }
            else
            {
                //Lay thong tin 
                try
                {
                    tbMaBan.Text = dtgDSBan.Rows[e.RowIndex].Cells[0].Value.ToString();
                    tbTenBan.Text = dtgDSBan.Rows[e.RowIndex].Cells[1].Value.ToString();
                    String idkv = dataBan.Rows[e.RowIndex]["idkv"].ToString();
                    for(int i = 0; i <  dataKV.Rows.Count;i++)
                    {
                        if(dataKV.Rows[i]["IDKV"].ToString() == idkv )
                        {
                            cbKhuvucInfo.SelectedIndex = i;
                            break;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                //Trình điều khiển
                btnTaoMoiBan.BackColor = Color.Gray;
                btnCapNhatBan.BackColor = Color.Navy;
                btnXoaBan.BackColor = Color.Brown;
                btnHuyBan.BackColor = Color.Brown;

                btnTaoMoiBan.Enabled = false;
                btnCapNhatBan.Enabled = true;
                btnXoaBan.Enabled = true;
                btnHuyBan.Enabled = true;
            }
        }

        private void btnHuyBan_Click(object sender, EventArgs e)
        {
            GiaoDienMacDinhBan();
        }

        private void btnXoaKV_Click(object sender, EventArgs e)
        {
            String idkv = tbMaKV.Text;
            DialogResult dlrDelete = MessageBox.Show("Xác nhận xóa " + tbTenKV.Text, "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(dlrDelete == DialogResult.Yes)
            {
                BUS.BUSWVN.Instance.XoaKV(idkv);
                GiaoDienMacDinhKV();
            }
        }

        private void btnTimKV_Click(object sender, EventArgs e)
        {
            String tenkvCanTim ="";
            tenkvCanTim = tbTenKVCanTim.Text;
            dtgDSKV.DataSource = BUS.BUSWVN.Instance.DSKV(tenkvCanTim);
            dtgDSKV.Refresh();
        }

        private void btnLocBanTheoKV_Click(object sender, EventArgs e)
        {
            String idkv = cbKhuvuc.SelectedValue.ToString();
            dtgDSBan.DataSource = BUS.BUSWVN.Instance.DSBAN1(idkv,"");
            dtgDSKV.Refresh();
        }

        private void btnTimTenBan_Click(object sender, EventArgs e)
        {
            String idkv = cbKhuvuc.SelectedValue.ToString();
            String tenBanCantim = tbTenBanCanTim.Text;
            dtgDSBan.DataSource = BUS.BUSWVN.Instance.DSBAN1(idkv,tenBanCantim);
            dtgDSKV.Refresh();
        }

        private void btnXoaBan_Click(object sender, EventArgs e)
        {
            String idban = tbMaBan.Text;
            DialogResult dlrDeleteBan = MessageBox.Show("Xác nhận xóa " + tbTenBan.Text, "Xóa bàn", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(dlrDeleteBan == DialogResult.Yes)
            {
                BUS.BUSWVN.Instance.XoaBan(idban);
                GiaoDienMacDinhBan();
            }
        }
    }
}
