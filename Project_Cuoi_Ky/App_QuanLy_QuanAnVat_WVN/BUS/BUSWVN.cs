using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using DAO;
using DTO;

namespace BUS
{
    public class BUSWVN
    {
        private static BUSWVN instance;
        public static BUSWVN Instance {

            get
            {
                if (instance == null)
                {
                    instance = new BUSWVN();
                }
                return instance;
            }
            private set => instance = value; }
        private BUSWVN() { }
        //Danh sach Du lieu
        public DataTable DSKV(String tenkv)
        {
            return DAOWVN.Instance.DSKV(tenkv);
        }
        public DataTable DSBAN(int key)
        {
            return DAOWVN.Instance.DSBAN(key);
        }
        public DataTable DSBAN1(String idkv,String tenban)
        {
            return DAOWVN.Instance.DSBAN1(idkv,tenban);
        }
        //Tai Khoan
        public DataTable DSTK()
        {
            return DAOWVN.Instance.DSTK();
        }
        public DataTable DSTK1()
        {
            return DAOWVN.Instance.DSTK1();
        }

        //Dang nhap
        public bool dang_Nhap(string tk,string mk)
        {
            return DAOWVN.Instance.dang_Nhap(tk, mk);
        }
        public string getTenNV(String tentk)
        {
            return DAOWVN.Instance.getTenNV(tentk);
        }
        public string getIDNV(String tentk)
        {
            return DAOWVN.Instance.getIDNV(tentk);
        }
        public bool phan_quyen_Admin_BUS(string idnv)
        {
            return DAOWVN.Instance.phan_quyen_Admin_DAO(idnv);
        }
        //
        public DataTable loaddanhmuc()
        {
            DataTable data = Dataprovider.Instance.ExcuteQuery("select * from dbo.DMTP");
            return data;
        }
        public DataTable LoadKhuvuc()
        {
            return Dataprovider.Instance.ExcuteQuery("select * from dbo.KhuVuc");
        }
        public DataTable LoadThucPham(string id,string tenmon)
        {
            DataTable data = Dataprovider.Instance.ExcuteQuery("select * from dbo.ThucPham where iddmtp = '" + id+"' and TenTP like N'%"+tenmon+"%'");
            return data;
        }
        private void btnTP_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
            
        }

        public DataTable LoadSoBan(string tenkv)
        {
            return Dataprovider.Instance.ExcuteQuery("select * from dbo.Ban inner join dbo.KhuVuc on Ban.idkv = KhuVuc.IDkv where KhuVuc.Tenkv = N'"+tenkv+"'");
        }
        //
        public DataTable showOrderBUS(string id)
        {
            return Dataprovider.Instance.ExcuteQuery("exec dbo.USP_HienThiHoaDon N'"+id+"'");
        }
        //xu ly hinh anh

        //xu ly hoa don
        public DataTable timtheodate(string date1,string date2)
        {
            DataTable data = Dataprovider.Instance.ExcuteQuery(
                "select ban.TenBan,hd.DateIn,hd.DateOut,hd.Tongtien"
                +" from dbo.Hoadon as hd, dbo.Ban as ban"
                +" where hd.Trangthai = 1 and hd.idban = ban.IDBan and hd.DateIn between '"+date1+"' and '"+date2+"'");
            return data;
        }
        public void HoaDonBUS(DataGridView dtghd)
        {
            dtghd.DataSource = DAOWVN.Instance.HoaDonDAO();
        }
        public void ThanhtoanhdBUS(String idban)
        {
            DAOWVN.Instance.thanhtoanhdDAO(idban);
        }
        public void ThemMonOrderBUS(String tenban,String tentp,int soluong)
        {
            DAOWVN.Instance.themMonOrderDAO(tenban, tentp, soluong);
        }

        //----------------------------
        public void TaoHoaDonBUS(String idban,String idnv)
        {
            DAOWVN.Instance.TaoHoaDon(idban,idnv);
        }
        public void HuyHoaDon(String idban)
        {
            DAOWVN.Instance.HuyHoaDon(idban);
        }
        //Khu vuc
        public void ThemKV(String tenkv)
        {
            DAOWVN.Instance.ThemKV(tenkv);
        }
        public void XoaKV(String idkv)
        {
            DAOWVN.Instance.XoaKV(idkv);
        }
        public void CapNhatKV(String tenkv,string idkv)
        {
            DAOWVN.Instance.CapNhatKV(tenkv, idkv);
        }
        //Ban
        public void ThemBan(String tenkv,String idkv)
        {
            DAOWVN.Instance.ThemBan(tenkv,idkv);
        }
        public void XoaBan(String idban)
        {
            DAOWVN.Instance.XoaBan(idban);
        }
        public void CapNhatBan(String tenban, String idkv,String idban)
        {
            DAOWVN.Instance.CapNhatBan(tenban, idkv,idban);
        }
        //Tai khoan
        public void XoaTK(String idtk)
        {
            DAOWVN.Instance.XoaTK(idtk);
        }
        public void ThemTK(DTO.taikhoan tk)
        {
            DAOWVN.Instance.ThemTk(tk);
        }
        public void CapNhatTK(DTO.taikhoan tk,String idtk)
        {
            DAOWVN.Instance.CapNhatTK(tk,idtk);
        }
    }
}
