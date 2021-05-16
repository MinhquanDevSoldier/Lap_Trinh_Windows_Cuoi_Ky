using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class taikhoan
    {
        string Tentk, matkhau,loaitk,tenNV,ngaysinh,cmnd,sdt,mucluong;
        public taikhoan() { }

        public taikhoan(string tentk, string matkhau, string loaitk, string tenNV, string ngaysinh, string cmnd, string sdt, string mucluong)
        {
            Tentk1 = tentk;
            this.Matkhau = matkhau;
            this.Loaitk = loaitk;
            this.TenNV = tenNV;
            this.Ngaysinh = ngaysinh;
            this.Cmnd = cmnd;
            this.Sdt = sdt;
            this.Mucluong = mucluong;
        }

        public string Tentk1 { get => Tentk; set => Tentk = value; }
        public string Matkhau { get => matkhau; set => matkhau = value; }
        public string Loaitk { get => loaitk; set => loaitk = value; }
        public string TenNV { get => tenNV; set => tenNV = value; }
        public string Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public string Cmnd { get => cmnd; set => cmnd = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Mucluong { get => mucluong; set => mucluong = value; }
    }
}
