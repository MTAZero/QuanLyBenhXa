using QuanLyBenhXa.BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBenhXa
{
    public static class ThamSoHeThong
    {
        public static TAIKHOAN curTaikhoan = new TAIKHOAN(); // tài khoản đang đăng nhập
        public static BACSI curBacsi = new BACSI(); // bác sĩ đang đăng nhập

        // kham dinh ki va kham thuong xuyen
        public static KHAMTHUONGXUYEN khamthuongxuyen = new KHAMTHUONGXUYEN();
        public static KHAMDINHKI khamdinhki = new KHAMDINHKI();
        public static CAPTHUOC capthuoc = new CAPTHUOC();
        public static MUONVATTU muonvattu = new MUONVATTU();
    }
}
