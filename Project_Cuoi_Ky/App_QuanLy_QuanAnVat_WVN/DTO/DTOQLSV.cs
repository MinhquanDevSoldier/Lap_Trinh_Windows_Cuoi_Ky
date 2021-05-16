using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTOQLSV
    {
        private DTOQLSV() { }
        private static DTOQLSV instance;
        private String TenTK;

        public static DTOQLSV Instance {

            get
            {
                if (instance == null)
                {
                    instance = new DTOQLSV();
                }
                return instance;
            }
        }

        public string TenTK1 { 
            get { return TenTK; }
            set { TenTK = value; } 
        }
    }
}
