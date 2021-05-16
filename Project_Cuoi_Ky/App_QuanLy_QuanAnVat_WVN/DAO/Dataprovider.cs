using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAO
{
    public class Dataprovider
    {
        private String connectionstr = @"Data Source=.\;Initial Catalog=QLAnVatWVN;Integrated Security=True";
        private static Dataprovider instance;
        private Dataprovider() {}

        public static Dataprovider Instance 
        {
            get
            {
                if(instance == null)
                {
                    instance = new Dataprovider();
                }
                return instance;
            }
            set
            {
                instance = value;
            }
        }
        public DataTable ExcuteQuery(string Query)
        {
            DataTable data = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionstr))
            {
                conn.Open();
                SqlCommand comm = new SqlCommand(Query,conn);
                SqlDataAdapter adtData = new SqlDataAdapter(comm);
                adtData.Fill(data);
                conn.Close();
            }
            return data;
        }
        public void ExcuteNonQuery(String Query)
        {
            using (SqlConnection conn = new SqlConnection(connectionstr))
            {
                conn.Open();
                SqlCommand comm = new SqlCommand(Query, conn);
                comm.ExecuteNonQuery();
                conn.Close();
            }
        }
    }
}
