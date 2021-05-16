using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using DAO;

namespace BUS
{
    public class BUS_QLFOOD
    {
        //Singleton parten =======================================================================================================
        private static BUS_QLFOOD instance;
        private BUS_QLFOOD() { }
        public static BUS_QLFOOD Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new BUS_QLFOOD();
                }
                return instance;
            }
            set
            {
                instance = value;
            }
        }
        //========================================================================================================================
        public DataTable load_DMTP_BUS()
        {
            return Dataprovider.Instance.ExcuteQuery("select * from dbo.DMTP");
        }
        public DataTable load_dtg_DMTP_BUS()
        {
            return Dataprovider.Instance.ExcuteQuery("select * from dbo.DMTP");
        }
        public DataTable load_Food_BUS(string iddmtp,int key)
        {
            if(key == 0)
            {
                return Dataprovider.Instance.ExcuteQuery("select * from dbo.Thucpham where iddmtp ='"+iddmtp+"'");
            }
            else
            {
                return Dataprovider.Instance.ExcuteQuery("select TenTP,Gia from dbo.Thucpham where iddmtp ='" + iddmtp + "'");
            }
            
        }
        public void ThemDM(String tendm)
        {
            Dataprovider.Instance.ExcuteNonQuery("insert into dbo.DMTP values(N'"+tendm+"')");
        }
        public void CapNhatDM(String tendm,String iddm)
        {
            Dataprovider.Instance.ExcuteNonQuery("update dbo.DMTP set TenDM = N'"+tendm+"' where IDDMTP = '"+iddm+"'");
        }
        public void ThemTP(String tentp,String iddm,String giatp)
        {
            Dataprovider.Instance.ExcuteNonQuery("insert into dbo.Thucpham values('"+iddm+"',N'"+tentp+"','"+giatp+"') ");
        }
        public void CapNhatTP(String idtp,String iddm,String tentp,String giatp)
        {
            String query = "update dbo.Thucpham set iddmtp = '"+iddm+"',TenTP = N'"+tentp+"',Gia = '"+giatp+"' where IDTP = '"+idtp+"'";
            Dataprovider.Instance.ExcuteNonQuery(query);
        }
        public void XoaTP(String idtp)
        {
            Dataprovider.Instance.ExcuteNonQuery("delete dbo.Thucpham where IDTP = "+idtp);
        }
    }
}
