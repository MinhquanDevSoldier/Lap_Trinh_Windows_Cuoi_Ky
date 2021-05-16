using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DTO
{
    public class KhuvucDTO
    {
        private string iDkv, tenkv;
        public string IDkv
        {
            get { return iDkv; }
            set { iDkv = value; }
        }
        public string Tenkv
        {
            get { return tenkv; }
            set { tenkv = value; }
        }
        public KhuvucDTO(string id,string Tenkv)
        {
            this.iDkv = id;
            this.tenkv = Tenkv;
        }
        public KhuvucDTO(DataRow row)
        {
            this.iDkv = row["IDkv"].ToString();
            this.tenkv = row["Tenkv"].ToString();
        }
    }
}
