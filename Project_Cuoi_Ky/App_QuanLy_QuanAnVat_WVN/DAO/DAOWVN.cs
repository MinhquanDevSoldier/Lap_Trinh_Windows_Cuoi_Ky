using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO;
namespace DAO
{
    public class DAOWVN
    {
        private static DAOWVN instance;
        private DAOWVN() { }

        public static DAOWVN Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new DAOWVN();
                }
                return instance;
            }
            set
            {
                instance = value;
            }
        }
        //Danh sach du lieu
        public DataTable DSKV(String tenkv)
        {
            String query;
            if(tenkv == "")
            {
                query = "select * from dbo.Khuvuc";
            }
            else
            {
                query = "select * from dbo.Khuvuc where TenKV like N'%"+tenkv+"%'";
            }
            return Dataprovider.Instance.ExcuteQuery(query);
        }
        public DataTable DSBAN(int key)
        {
            if(key == 0)
            {
                return Dataprovider.Instance.ExcuteQuery("select * from dbo.Ban");
            }
            return Dataprovider.Instance.ExcuteQuery("select IDBan,TenBan from dbo.Ban");
        }
        public DataTable DSBAN1(String idkv,String tenban)
        {
            if (tenban == "")
            {
                return Dataprovider.Instance.ExcuteQuery("select IDBan,TenBan from dbo.Ban where idkv ="+idkv);
            }
            else
            {
                return Dataprovider.Instance.ExcuteQuery("select IDBan,TenBan from dbo.Ban where idkv ="+idkv+" and TenBan like N'%"+tenban+"%'");
            }
            
        }

        //Tai khoan
        public DataTable DSTK()
        {
            DataTable data = new DataTable();
            data = Dataprovider.Instance.ExcuteQuery("select * from dbo.Taikhoan");
            return data;
        }
        public DataTable DSTK1()
        {
            DataTable data = new DataTable();
            data = Dataprovider.Instance.ExcuteQuery("select IDTK,Tentk from dbo.Taikhoan");
            return data;
        }
        //dang nhap
        public bool dang_Nhap(string tk,string mk)
        {
            DataTable data = Dataprovider.Instance.ExcuteQuery("select * from dbo.Taikhoan where Tentk = '"+tk+"' and Matkhau = '"+mk+"'");
            if(data.Rows.Count == 1)
            {
                return true;
            }
            return false;
        }
        public string getTenNV(string tentk)
        {
            DataTable data = Dataprovider.Instance.ExcuteQuery("select TenNV from dbo.Taikhoan where Tentk = '" + tentk+"'");
            return data.Rows[0].ItemArray[0].ToString();
        }
        public string getIDNV(string tentk)
        {
            DataTable data = Dataprovider.Instance.ExcuteQuery("select IDTK from dbo.Taikhoan where Tentk = '" + tentk + "'");
            return data.Rows[0].ItemArray[0].ToString();
        }
        //Order
        public DataTable showOrderDAO(String tenban)
        {
            return Dataprovider.Instance.ExcuteQuery("");
        }
        //
        public List<KhuvucDTO> loadComboItem()
        {
            List<KhuvucDTO> ListKV = new List<KhuvucDTO>();
            DataTable datakv = Dataprovider.Instance.ExcuteQuery("select * from dbo.KhuVuc");
            foreach(DataRow item in datakv.Rows)
            {
                KhuvucDTO kv = new KhuvucDTO(item);
                ListKV.Add(kv);
            }
            return ListKV;
        }
        //hinh anh
        
        //Hoa Don
        public DataTable HoaDonDAO()
        {
            DataTable data = Dataprovider.Instance.ExcuteQuery("exec USP_showhoadon");//where Dathanhtoan = '1'
            return data;
        }
        public void thanhtoanhdDAO(String idban)
        {
            Dataprovider.Instance.ExcuteNonQuery("exec dbo.USP_Thanhtoan '"+idban+"'");
        }
        public void themMonOrderDAO(String tenban, String tentp, int soluong)
        {
            Dataprovider.Instance.ExcuteNonQuery("exec dbo.USP_Themmon N'"+tenban+"',N'"+tentp+"',"+soluong);
        }
        /// <summary>
        /// </summary>
        /// <param name="idban"></param>
        
        public void TaoHoaDon(String idban,string idnv)
        {
            Dataprovider.Instance.ExcuteNonQuery("exec dbo.USP_TaoHoaDon "+idban+",'"+idnv+"'");
        }
        public void HuyHoaDon(String idban)
        {
            Dataprovider.Instance.ExcuteNonQuery("exec dbo.USP_Huyhoadon N'" + idban + "'");
        }
        //phan quyen
        public bool phan_quyen_Admin_DAO(string idnv)
        {
            DataTable data = Dataprovider.Instance.ExcuteQuery("select loai from dbo.Taikhoan where IDTK = '" + idnv+"'");
            if(data.Rows[0].ItemArray[0].ToString() == "True")
            {
                return true;
            }
            return false;
        }
        //Khu vuc
        public void ThemKV(String Tenkv)
        {
            Dataprovider.Instance.ExcuteNonQuery("insert into dbo.Khuvuc values (N'"+Tenkv+"')");
        }
        public void XoaKV(String idkv)
        {
            Dataprovider.Instance.ExcuteNonQuery("delete from dbo.Khuvuc where IDKV = "+idkv);
        }
        public void CapNhatKV(String tenkv,String idkv)
        {
            Dataprovider.Instance.ExcuteNonQuery("update dbo.Khuvuc set TenKV = '"+tenkv+"' where IDKV = "+idkv);
        }
        //Ban
        public void ThemBan(String TenBan,String idkv)
        {
            Dataprovider.Instance.ExcuteNonQuery("insert into dbo.Ban (idkv,TenBan) values('"+idkv+"',N'"+TenBan+"')");
        }
        public void XoaBan(String idban)
        {
            Dataprovider.Instance.ExcuteNonQuery("delete from dbo.Ban where IDBan = " + idban);
        }
        public void CapNhatBan(String tenBan, String idkv,String idban)
        {
            Dataprovider.Instance.ExcuteNonQuery("update dbo.Ban set idkv = '"+idkv+"',TenBan ='"+tenBan+"' where IDBan = '"+idban+"'");
        }
        //Taikhoan
        public void XoaTK(String idtk)
        {
            Dataprovider.Instance.ExcuteNonQuery("delete from dbo.Taikhoan where IDTK = '"+idtk+"'");
        }
        public void ThemTk(DTO.taikhoan tk)
        {
            String query = "insert dbo.Taikhoan" +
            "(Tentk, Matkhau, loai, TenNV, NgaySinh, CMND, SDT, MucLuong)" +
            "values" +
            "(" +
                "'" + tk.Tentk1 + "'," +
                "'" + tk.Matkhau + "'," +
                tk.Loaitk + "," +
                "N'" + tk.TenNV + "'," +
                "convert(date,'"+tk.Ngaysinh+"',103)," +
                "'" + tk.Cmnd + "'," +
                "'" + tk.Sdt + "'," +
                "'"+tk.Mucluong+"'" +
            ")";
            Dataprovider.Instance.ExcuteNonQuery(query);
        }
        public void CapNhatTK(DTO.taikhoan tk,String idtk)
        {
            String query = "update dbo.Taikhoan set "+
            "Tentk = '"+tk.Tentk1+"'," +
            "Matkhau = '" + tk.Matkhau + "'," +
            "loai = " + tk.Loaitk + "," +
            "TenNV = N'" + tk.TenNV + "'," +
            "NgaySinh = CONVERT(date, '" + tk.Ngaysinh + "', 103)," +
            "CMND = '" + tk.Cmnd + "'," +
            "SDT = '" + tk.Sdt + "'," +
            "MucLuong = '" + tk.Mucluong + "'" +
            "where idtk = '" + idtk + "'";
            Dataprovider.Instance.ExcuteNonQuery(query);
        }
    }
}
