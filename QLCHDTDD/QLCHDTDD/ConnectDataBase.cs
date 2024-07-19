using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data;
using System.Threading.Tasks.Sources;
using System.Security.Cryptography.Pkcs;
using Microsoft.VisualBasic;
using System.Collections;

namespace QLCHDTDD
{
    internal class ConnectDataBase
    {
        
        SqlConnection conn;
        public void OpenConect()
        {
            string sql = @"Data Source=LAPTOP-E9NPR00H;Initial Catalog=QLCHDTDD;Integrated Security=True";
            conn = new SqlConnection(sql);
            conn.Open();
        }
        public void CloseConect()
        {
            conn.Close();
        }

        //Bảng Nhân Viên

        //ham lay du lieu bang nhanvien
        public DataTable dsNhanVien()
        {
            OpenConect();
            string query = "select * from NhanVien";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            CloseConect();
            return dt;
        }

        public bool CheckNV(string manv)
        {
            OpenConect();
            string query = "select * from NhanVien where MaNV = @ma";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("ma", manv);
            SqlDataReader dr2 = cmd.ExecuteReader();
            bool kt = false;
            if (dr2.HasRows) kt = true;
            CloseConect();
            return kt;
        }
        public void AddInformation(string ma, string ht, DateTime ns, string gt, string dc, string sdt)
        {
            OpenConect();
            string query = "insert into NhanVien values(@MaNV, @HoTen, @NgaySinh, @GioiTinh, @DiaChi, @SoDienThoai)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("MaNV", ma);
            cmd.Parameters.AddWithValue("HoTen", ht);
            cmd.Parameters.AddWithValue("NgaySinh", ns);
            cmd.Parameters.AddWithValue("GioiTinh", gt);
            cmd.Parameters.AddWithValue("DiaChi", dc);
            cmd.Parameters.AddWithValue("SoDienThoai", sdt);
            cmd.ExecuteNonQuery();
            CloseConect();
        }

        public void DeleteInfomation(string manv)
        {
            OpenConect();
            string query = "delete NhanVien where MaNV = @ma";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("ma", manv);
            cmd.ExecuteNonQuery();
            CloseConect();
        }

        public void ChangeInformation(string ma, string ht, DateTime ns, string gt, string dc, string dt)
        {
            OpenConect();
            string query = "update NhanVien set HoTen = @ten, NgaySinh = @ngaysinh, GioiTinh = @gioitinh, DiaChi = @diachi, SoDienThoai = @dienthoai where MaNV = @manv";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("manv", ma);
            cmd.Parameters.AddWithValue("ten", ht);
            cmd.Parameters.AddWithValue("ngaysinh", ns);
            cmd.Parameters.AddWithValue("gioitinh", gt);
            cmd.Parameters.AddWithValue("diachi", dc);
            cmd.Parameters.AddWithValue("dienthoai", dt);
            cmd.ExecuteNonQuery();
            CloseConect();
        }

        // Bảng Mặt Hàng

        public DataTable dsMatHang()
        {
            OpenConect();
            string query = "select * from MatHang";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            CloseConect();
            return dt;
        }

        public bool CheckMH(string mamh)
        {
            OpenConect();
            string query = "select * from MatHang where MaMH = @ma";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("ma", mamh);
            SqlDataReader dr2 = cmd.ExecuteReader();
            bool kt = false;
            if (dr2.HasRows) kt = true;
            CloseConect();
            return kt;
        }
        public void AddMH(string ma, string ten, string thongso, string mausac, string cauhinh, string pin, Decimal dongiaban, string phukien, string khuyenmai, string hang, string xuatxu)
        {
            OpenConect();
            string query = "insert into MatHang(MaMH, TenMH, ThongSo, MauSac, CauHinh, Pin, DonGiaBan, PhuKien, KhuyenMai, HangSX, XuatXu) values(@MaMH, @TenMH, @ThongSo, @MauSac, @CauHinh, @Pin, @DonGiaBan, @PhuKien, @KhuyenMai, @HangSX, @XuatXu)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("MaMH", ma);
            cmd.Parameters.AddWithValue("TenMH", ten);
            cmd.Parameters.AddWithValue("ThongSo", thongso);
            cmd.Parameters.AddWithValue("MauSac", mausac);
            cmd.Parameters.AddWithValue("CauHinh", cauhinh);
            cmd.Parameters.AddWithValue("Pin", pin);
            cmd.Parameters.AddWithValue("DonGiaBan", dongiaban);
            cmd.Parameters.AddWithValue("PhuKien", phukien);
            cmd.Parameters.AddWithValue("KhuyenMai", khuyenmai);
            cmd.Parameters.AddWithValue("HangSX", hang);
            cmd.Parameters.AddWithValue("XuatXu", xuatxu);
            cmd.ExecuteNonQuery();
            CloseConect();
        }

        public void DeleteMH(string mamh)
        {
            OpenConect();
            string query = "delete MatHang where MaMH = @ma";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("ma", mamh);
            cmd.ExecuteNonQuery();
            CloseConect();
        }

        public void ChangeMH(string ma, string ten, string thongso, string mausac, string cauhinh, string pin, Decimal dongiaban, string phukien, string khuyenmai, string hsx, string xxu)
        {
            OpenConect();
            string query = "update MatHang set TenMH = @tenmh, ThongSo = @ts, MauSac = @ms, CauHinh = @ch, Pin = @pinmh, DonGiaBan = @dongia, PhuKien = @pk, KhuyenMai = @km, HangSX = @hang, XuatXu = @xuatxu where MaMH = @mamh";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("mamh", ma);
            cmd.Parameters.AddWithValue("tenmh", ten);
            cmd.Parameters.AddWithValue("ts", thongso);
            cmd.Parameters.AddWithValue("ms", mausac);
            cmd.Parameters.AddWithValue("ch", cauhinh);
            cmd.Parameters.AddWithValue("pinmh", pin);
            cmd.Parameters.AddWithValue("dongia", dongiaban);
            cmd.Parameters.AddWithValue("pk", phukien);
            cmd.Parameters.AddWithValue("km", khuyenmai);
            cmd.Parameters.AddWithValue("hang", hsx);
            cmd.Parameters.AddWithValue("xuatxu", xxu);
            cmd.ExecuteNonQuery();
            CloseConect();
        }

        //LOGIN
        //ktra ton tai ng dung
        public bool CheackAccount(string ten, string pass)
        {
            bool kt = false;
            OpenConect();
            string query = "select * from NguoiDung where account = @tka and passwork = @mka";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("tka", ten);
            cmd.Parameters.AddWithValue("mka", pass);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows) kt = true;
            CloseConect();
            return kt;
        }

        //Bảng KHACH HANG

        public DataTable dsKhachHang()
        {
            OpenConect();
            string query = "select * from KhachHang";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            CloseConect();
            return dt;
        }

        public bool CheckKH(string makh)
        {
            OpenConect();
            string query = "select * from KhachHang where MaKH = @ma";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("ma", makh);
            SqlDataReader dr2 = cmd.ExecuteReader();
            bool kt = false;
            if (dr2.HasRows) kt = true;
            CloseConect();
            return kt;
        }
        public void AddKH(string ma, string ht, string dc, string cccd, string sdt, string ghichu)
        {
            OpenConect();
            string query = "insert into KhachHang values(@MaKH, @HoTenKH, @DiaChi, @CCCD, @SoDienThoai, @GhiChu)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("MaKH", ma);
            cmd.Parameters.AddWithValue("HoTenKH", ht);
            cmd.Parameters.AddWithValue("DiaChi", dc);
            cmd.Parameters.AddWithValue("CCCD", cccd);
            cmd.Parameters.AddWithValue("SoDienThoai", sdt);
            cmd.Parameters.AddWithValue("GhiChu", ghichu);
            cmd.ExecuteNonQuery();
            CloseConect();
        }

        public void DeleteKH(string makh)
        {
            OpenConect();
            string query = "delete KhachHang where MaKH = @ma";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("ma", makh);
            cmd.ExecuteNonQuery();
            CloseConect();
        }

        public void ChangeKH(string ma, string ht, string dc, string cccd, string sdt, string ghichu)
        {
            OpenConect();
            string query = "update KhachHang set HoTenKH = @ten, DiaChi = @diachi, CCCD = @cccdkh, SoDienThoai = @dienthoai, GhiChu = @ghichukh where MaKH = @makh";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("makh", ma);
            cmd.Parameters.AddWithValue("ten", ht);
            cmd.Parameters.AddWithValue("diachi", dc);
            cmd.Parameters.AddWithValue("cccdkh", cccd);
            cmd.Parameters.AddWithValue("dienthoai", sdt);
            cmd.Parameters.AddWithValue("ghichukh", ghichu);
            cmd.ExecuteNonQuery();
            CloseConect();
        }

        //HOA DON BAN
        public DataTable dsHoaDonBan()
        {
            OpenConect();
            string query = "select distinct HoaDonBan.MaDonBan, HoaDonBan.MaNV, NhanVien.HoTen, HoaDonBan.MaKH, KhachHang.HoTenKH, HoaDonBan.NgayBan, HoaDonBan.TongTien, HoaDonBan.GhiChu\r\nfrom HoaDonBan, NhanVien, KhachHang, MatHang\r\nwhere HoaDonBan.MaNV = NhanVien.MaNV\r\nand\tHoaDonBan.MaKH = KhachHang.MaKH";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            CloseConect();
            return dt;
        }
        public bool CheckHoaDonBan(string mahd)
        {
            OpenConect();
            string query = "select * from HoaDonBan where MaDonBan = @ma";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("ma", mahd);
            SqlDataReader dr2 = cmd.ExecuteReader();
            bool kt = false;
            if (dr2.HasRows) kt = true;
            CloseConect();
            return kt;
        }
        //Mã nhân viên
        public List<string> DataCBNhanVien()
        {
            List<string> data = new List<string>();
            OpenConect();
            string query = "select MaNV from NhanVien";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                //Thêm dữ liệu từ cột vào list
                data.Add(dr[0].ToString());
            }
            CloseConect();
            return data;
        }

        public string LoadTenNV(string manv)
        {
            string tennv = "";
            OpenConect();
            string query = "select HoTen from NhanVien where MaNV = @ma";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("ma", manv);
            object result = cmd.ExecuteScalar();
            if (result != null)
            {
                tennv = result.ToString();
            }
            CloseConect();
            return tennv;
        }
        //Mã khách hàng
        public List<string> DataCBKhachHang()
        {
            List<string> data = new List<string>();
            OpenConect();
            string query = "select distinct MaKH from KhachHang";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                //Thêm dữ liệu từ cột vào list
                data.Add(dr[0].ToString());
            }
            CloseConect();
            return data;
        }

        public string LoadTenKH(string makh)
        {
            string tenkh = "";
            OpenConect();
            string query = "select HoTenKH from KhachHang where MaKH = @ma";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("ma", makh);
            object result = cmd.ExecuteScalar();
            if (result != null)
            {
                tenkh = result.ToString();

            }
            CloseConect();
            return tenkh;
        }
        public string LoadCCCDKH(string makh)
        {
            string cccd = "";
            OpenConect();
            string query = "select CCCD from KhachHang where MaKH = @ma";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("ma", makh);
            object result = cmd.ExecuteScalar();
            if (result != null)
            {
                cccd = result.ToString();

            }
            CloseConect();
            return cccd;
        }
        public string LoadDiaChiKH(string makh)
        {
            string diachi = "";
            OpenConect();
            string query = "select DiaChi from KhachHang where MaKH = @ma";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("ma", makh);
            object result = cmd.ExecuteScalar();
            if (result != null)
            {
                diachi = result.ToString();

            }
            CloseConect();
            return diachi;
        }

        public string LoadSDTKH(string makh)
        {
            string sdt = "";
            OpenConect();
            string query = "select SoDienThoai from KhachHang where MaKH = @ma";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("ma", makh);
            object result = cmd.ExecuteScalar();
            if (result != null)
            {
                sdt = result.ToString();

            }
            CloseConect();
            return sdt;
        } 
        public void AddHoaDonBan(string mahd, string makh, string manv, DateTime ngayban, string ghichu)
        {
            OpenConect();
            string query = "insert into HoaDonBan(MaDonBan, MaKH, MaNV, NgayBan, GhiChu) values(@MaDonBan, @MaNV, @MaKH, @NgayBan, @GhiChu)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@MaDonBan", mahd);
            cmd.Parameters.AddWithValue("@MaNV", manv);
            cmd.Parameters.AddWithValue("@MaKH", makh);
            cmd.Parameters.AddWithValue("@NgayBan", ngayban);
            cmd.Parameters.AddWithValue("@GhiChu", ghichu);
            cmd.ExecuteNonQuery();
            CloseConect();
        }
        public void DelHoaDonBan(string mahd)
        {
            OpenConect();
            string query = "DELETE FROM ChiTietHoaDonBan\r\nWHERE MaDonBan = @ma DELETE FROM HoaDonBan\r\nWHERE MaDonBan = @ma";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("ma", mahd);
            cmd.ExecuteNonQuery();
            CloseConect();
        }

        public void ChangeHoaDonBan(string mahd, string makh, string manv, DateTime ngayban, string note)
        {
            OpenConect();
            string query = "update HoaDonBan set MaNV = @nv, MaKH = @kh, NgayBan = @ngay, GhiChu = @ghichu where MaDonBan = @ma";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("ma", mahd);
            cmd.Parameters.AddWithValue("nv", manv);
            cmd.Parameters.AddWithValue("kh", makh);
            cmd.Parameters.AddWithValue("ngay", ngayban);
            cmd.Parameters.AddWithValue("ghichu", note);
            cmd.ExecuteNonQuery();
            CloseConect();
        }

        //CHI TIET HOA DON BAN
        public DataTable dsCTHoaDonBan(string ma)
        {
            OpenConect();
            string query = "select distinct ChiTietHoaDonBan.MaDonBan, MatHang.MaMH, MatHang.TenMH, ChiTietHoaDonBan.SoLuong, MatHang.DonGiaBan, MatHang.DonGiaBan*ChiTietHoaDonBan.SoLuong as ThanhTien\r\nfrom ChiTietHoaDonBan, MatHang, HoaDonBan\r\nWhere ChiTietHoaDonBan.MaMH = MatHang.MaMH\r\nand ChiTietHoaDonBan.MaDonBan = @mahd";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("mahd", ma.Trim());
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            CloseConect();
            return dt;
        }

        //Ma Mat Hang
        public List<string> DataCBCTHDMatHang()
        {
            List<string> data = new List<string>();
            OpenConect();
            string query = "select MaMH from MatHang";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                //Thêm dữ liệu từ cột vào list
                data.Add(dr[0].ToString());
            }
            CloseConect();
            return data;
        }

        public string LoadCTHDTenMH(string mamh)
        {
            string tenmh = "";
            OpenConect();
            string query = "select TenMH from MatHang where MaMH = @ma";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("ma", mamh);
            object result = cmd.ExecuteScalar();
            if (result != null)
            {
                tenmh = result.ToString();
            }
            CloseConect();
            return tenmh;
        }

        public string LoadCTHDDonGiaMH(string mamh)
        {
            string dongia = "";
            OpenConect();
            string query = "select DonGiaBan from MatHang where MaMH = @ma";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("ma", mamh);
            object result = cmd.ExecuteScalar();
            if (result != null)
            {
                dongia = result.ToString();
            }
            CloseConect();
            return dongia;
        }

        public string LoadCTHDSLMH(string mamh)
        {
            string soluong = "";
            OpenConect();
            string query = "select SoLuong from ChiTietHoaDonBan where MaMH = @ma";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("ma", mamh);
            object result = cmd.ExecuteScalar();
            if (result != null)
            {
                soluong = result.ToString();
            }
            CloseConect();
            return soluong;
        }
        public void AddCTHDMH(string mahd, string mamh, string soluong)
        {
            OpenConect();
            string query = "insert into ChiTietHoaDonBan(MaDonBan, MaMH, SoLuong) values(@MaDonBan, @MaMH, @SoLuong)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("MaMH", mamh);
            cmd.Parameters.AddWithValue("MaDonBan", mahd);
            cmd.Parameters.AddWithValue("SoLuong", soluong);
            cmd.ExecuteNonQuery();
            string query2 = "update MatHang set SoLuongTonKho = SoLuongTonKho - @sl where MaMH = @ma";
            SqlCommand cmd2 = new SqlCommand(query2, conn);
            cmd2.Parameters.AddWithValue("sl", soluong);
            cmd2.Parameters.AddWithValue("ma", mamh);
            cmd2.ExecuteNonQuery();
            CloseConect();
        }
        public void DelCTHoaDonBan(string mamh, string mahd, string soluong)
        {
            OpenConect();
            string query = "delete ChiTietHoaDonBan where MaMH = @ma and MaDonBan = @madon";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("ma", mamh);
            cmd.Parameters.AddWithValue("madon", mahd);
            cmd.ExecuteNonQuery();
            string query2 = "update MatHang set SoLuongTonKho = SoLuongTonKho + @sl where MaMH = @ma";
            SqlCommand cmd2 = new SqlCommand(query2, conn);
            cmd2.Parameters.AddWithValue("sl", soluong);
            cmd2.Parameters.AddWithValue("ma", mamh);
            cmd2.ExecuteNonQuery();
            CloseConect();
        }
        public void ChangeCTHoaDonBan(string mamh, string soluong, string madonban, string tong, string soluong2)
        {
            OpenConect();
            string query = "update ChiTietHoaDonBan set SoLuong = @sl where MaMH = @ma and MaDonBan = @madon";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("ma", mamh);
            cmd.Parameters.AddWithValue("sl", soluong);
            cmd.Parameters.AddWithValue("madon", madonban);
            cmd.ExecuteNonQuery();
            string query2 = "update MatHang set SoLuongTonKho = SoLuongTonKho - @sl where MaMH = @ma";
            SqlCommand cmd2 = new SqlCommand(query2, conn);
            cmd2.Parameters.AddWithValue("sl", soluong2);
            cmd2.Parameters.AddWithValue("ma", mamh);
            cmd2.ExecuteNonQuery();
            string query1 = "update HoaDonBan set TongTien = @tongtien where MaDonBan = @madon";
            SqlCommand cmd1 = new SqlCommand(query1, conn);
            cmd1.Parameters.AddWithValue("tongtien", tong);
            cmd1.Parameters.AddWithValue("madon", madonban);
            cmd1.ExecuteNonQuery();
            CloseConect();
        }
        public bool CheckCTHoaDonBan(string mamh)
        {
            OpenConect();
            string query = "select * from ChiTietHoaDonBan where MaMH = @ma";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("ma", mamh);
            SqlDataReader dr2 = cmd.ExecuteReader();
            bool kt = false;
            if (dr2.HasRows) kt = true;
            CloseConect();
            return kt;
        }
        //TIM KIEM KHACH HANG
        public DataTable TimKiemKhachHang(string ma)
        {
            OpenConect();
            string query = "select KhachHang.MaKH, KhachHang.HoTenKH, HoaDonBan.MaDonBan, KhachHang.DiaChi, KhachHang.SoDienThoai, HoaDonBan.TongTien as ThanhToan\r\nfrom KhachHang, HoaDonBan\r\nwhere KhachHang.MaKH = HoaDonBan.MaKH\r\nand HoaDonBan.MaKH = @makh";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("makh", ma.Trim());
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            CloseConect();
            return dt;
        }

        //TIM KIEM MAT HANG
        public DataTable TimKiemMatHang(string ma)
        {
            OpenConect();
            string query = "select distinct MatHang.MaMH, MatHang.TenMH, MatHang.HangSX, MatHang.DonGiaBan, MatHang.MauSac, ChiTietPhieuMua.SoLuong - ChiTietHoaDonBan.SoLuong as SoLuongTonKho\r\nfrom MatHang, ChiTietPhieuMua, ChiTietHoaDonBan\r\nwhere MatHang.MaMH = ChiTietPhieuMua.MaMH\r\nand ChiTietPhieuMua.MaMH = ChiTietHoaDonBan.MaMH\r\nand MatHang.MaMH = @mamh";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("mamh", ma.Trim());
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            CloseConect();
            return dt;
        }

        //TIM KIEM HOA DON BAN
        public DataTable TimKiemHoaDonBan(string ma)
        {
            OpenConect();
            string query = "select HoaDonBan.MaDonBan, ChiTietHoaDonBan.MaMH, HoaDonBan.NgayBan, HoaDonBan.MaKH, HoaDonBan.MaNV, ChiTietHoaDonBan.SoLuong*MatHang.DonGiaBan as ThanhTien\r\nfrom HoaDonBan, ChiTietHoaDonBan, MatHang\r\nwhere HoaDonBan.MaDonBan = ChiTietHoaDonBan.MaDonBan\r\nand ChiTietHoaDonBan.MaMH = MatHang.MaMH\r\nand HoaDonBan.MaDonBan = @mahd";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("mahd", ma.Trim());
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            CloseConect();
            return dt;
        }

        //HOA DON MUA
        //Mã nhân viên
        public List<string> HoaDonMuaCBNhanVien()
        {
            List<string> data = new List<string>();
            OpenConect();
            string query = "select MaNV from NhanVien";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                //Thêm dữ liệu từ cột vào list
                data.Add(dr[0].ToString());
            }
            CloseConect();
            return data;
        }

        public string LoadHDMTenNV(string manv)
        {
            string tennv = "";
            OpenConect();
            string query = "select HoTen from NhanVien where MaNV = @ma";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("ma", manv);
            object result = cmd.ExecuteScalar();
            if (result != null)
            {
                tennv = result.ToString();
            }
            CloseConect();
            return tennv;
        }

        public DataTable HoaDonMua(string ma)
        {
            OpenConect();
            string query = "select HoaDonMua.MaDonMua, HoaDonMua.SoPhieuMua, HoaDonMua.MaNV, NhanVien.HoTen, PhieuMuaHang.Ngay, HoaDonMua.TongTien, HoaDonMua.GhiChu\r\nfrom HoaDonMua, NhanVien, PhieuMuaHang\r\nwhere HoaDonMua.SoPhieuMua = PhieuMuaHang.SoPhieuMua\r\nand HoaDonMua.MaNV = NhanVien.MaNV\r\nand HoaDonMua.SoPhieuMua = @sophieumua";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("sophieumua", ma.Trim());
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            CloseConect();
            return dt;
        }
        public bool CheckHoaDonMua(string sophieu)
        {
            OpenConect();
            string query = "select * from ChiTietPhieuMua where SoPhieuMua = @ma";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("ma", sophieu);
            SqlDataReader dr2 = cmd.ExecuteReader();
            bool kt = false;
            if (dr2.HasRows) kt = true;
            CloseConect();
            return kt;
        }
        public void ChangeHoaDonMua(string sophieu, string madon, string nv, DateTime date, string note)
        {
            OpenConect();
            string query = "update HoaDonMua set MaDonMua = @madonmua, MaNV = @tennv, NgayMua = @ngay, GhiChu = @ghichu where SoPhieuMua = @ma";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("ma", sophieu);
            cmd.Parameters.AddWithValue("sophieumua", madon);
            cmd.Parameters.AddWithValue("tennv", nv);
            cmd.Parameters.AddWithValue("madonmua", madon);
            cmd.Parameters.AddWithValue("ngay", date);
            cmd.Parameters.AddWithValue("ghichu", note);
            cmd.ExecuteNonQuery();
            CloseConect();
        }
        public void AddHoaDonMua(string madon, string sophieumua, string manv, DateTime ngay, string note)
        {
            OpenConect();
            string query = "insert into HoaDonMua(MaDonMua, SoPhieuMua, MaNV, NgayMua, GhiChu) values(@MaDonMua, @SoPhieuMua, @MaNV, @NgayMua, @GhiChu)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("SoPhieuMua", sophieumua);
            cmd.Parameters.AddWithValue("MaDonMua", madon);
            cmd.Parameters.AddWithValue("MaNV", manv);
            cmd.Parameters.AddWithValue("NgayMua", ngay);
            cmd.Parameters.AddWithValue("GhiChu", note);
            cmd.ExecuteNonQuery();
            CloseConect();
        }

        //PHIEU MUA HANG

        public List<string> PhieuMuaHangCBNhanVien()
        {
            List<string> data = new List<string>();
            OpenConect();
            string query = "select MaNV from NhanVien";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                //Thêm dữ liệu từ cột vào list
                data.Add(dr[0].ToString());
            }
            CloseConect();
            return data;
        }

        public string LoadPMHTenNV(string manv)
        {
            string tennv = "";
            OpenConect();
            string query = "select HoTen from NhanVien where MaNV = @ma";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("ma", manv);
            object result = cmd.ExecuteScalar();
            if (result != null)
            {
                tennv = result.ToString();
            }
            CloseConect();
            return tennv;
        }
        public DataTable PhieuMuaHang()
        {
            OpenConect();
            string query = "select PhieuMuaHang.SoPhieuMua, PhieuMuaHang.MaNV, NhanVien.HoTen, PhieuMuaHang.TenNhaCungCap, PhieuMuaHang.Ngay\r\nfrom PhieuMuaHang, NhanVien\r\nwhere PhieuMuaHang.MaNV = NhanVien.MaNV";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            CloseConect();
            return dt;
        }
        public void DelPhieuMuaHang(string sopm)
        {
            OpenConect();
            string query = "DELETE FROM ChiTietPhieuMua\r\nWHERE SoPhieuMua = @ma DELETE FROM HoaDonMua\r\nWHERE SoPhieuMua = @ma DELETE FROM PhieuMuaHang\r\nWHERE SoPhieuMua = @ma ";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("ma", sopm);
            cmd.ExecuteNonQuery();
            CloseConect();
        }
        public void ChangePhieuMuaHang(string sophieumua, string manv, DateTime ngayban, string nhacungcap)
        {
            OpenConect();
            string query = "update PhieuMuaHang set MaNV = @nv, Ngay = @ngaypm, TenNhaCungCap = @ncc where SoPhieuMua = @ma";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("ma", sophieumua);
            cmd.Parameters.AddWithValue("nv", manv);
            cmd.Parameters.AddWithValue("ncc", nhacungcap);
            cmd.Parameters.AddWithValue("ngaypm", ngayban);
            cmd.ExecuteNonQuery();
            CloseConect();
        }
        public bool CheckPhieuMuaHang(string sophieumua)
        {
            OpenConect();
            string query = "select * from PhieuMuaHang where SoPhieuMua = @ma";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("ma", sophieumua);
            SqlDataReader dr2 = cmd.ExecuteReader();
            bool kt = false;
            if (dr2.HasRows) kt = true;
            CloseConect();
            return kt;
        }
        public void AddPhieuMuaHang(string sophieumua, string manv, DateTime ngayban, string nhacungcap)
        {
            OpenConect();
            string query = "insert into PhieuMuaHang values(@MaNV, @SoPhieuMua, @TenNhaCungCap, @Ngay)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("SoPhieuMua", sophieumua);
            cmd.Parameters.AddWithValue("MaNV", manv);
            cmd.Parameters.AddWithValue("TenNhaCungCap", nhacungcap);
            cmd.Parameters.AddWithValue("Ngay", ngayban);
            cmd.ExecuteNonQuery();
            CloseConect();
        }

        //CHI TIET PHIEU MUA
        //Ma Mat Hang
        public List<string> DataCBCTPhieuMua()
        {
            List<string> data = new List<string>();
            OpenConect();
            string query = "select MaMH from MatHang";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                //Thêm dữ liệu từ cột vào list
                data.Add(dr[0].ToString());
            }
            CloseConect();
            return data;
        }

        public string LoadCTPMTenMH(string mamh)
        {
            string tenmh = "";
            OpenConect();
            string query = "select TenMH from MatHang where MaMH = @ma";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("ma", mamh);
            object result = cmd.ExecuteScalar();
            if (result != null)
            {
                tenmh = result.ToString();
            }
            CloseConect();
            return tenmh;
        }

        public string LoadCTPMDonGiaMH(string mamh)
        {
            string dongia = "";
            OpenConect();
            string query = "select DonGiaBan from MatHang where MaMH = @ma";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("ma", mamh);
            object result = cmd.ExecuteScalar();
            if (result != null)
            {
                dongia = result.ToString();
            }
            CloseConect();
            return dongia;
        }

        public string LoadCTPMSLMH(string mamh)
        {  
            string soluong = "";
            OpenConect();
            string query = "select SoLuong from ChiTietHoaDonBan where MaMH = @ma";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("ma", mamh);
            object result = cmd.ExecuteScalar();
            if (result != null)
            {
                soluong = result.ToString();
            }
            CloseConect();
            return soluong;
        }
        public DataTable ChiTietPhieuMua(string ma)
        {
            OpenConect();
            string query = "select\tChiTietPhieuMua.SoPhieuMua, ChiTietPhieuMua.MaMH, MatHang.TenMH, ChiTietPhieuMua.DonGiaMua, ChiTietPhieuMua.SoLuong, ChiTietPhieuMua.SoLuong*ChiTietPhieuMua.DonGiaMua as ThanhTien\r\nfrom ChiTietPhieuMua, MatHang\r\nwhere ChiTietPhieuMua.MaMH = MatHang.MaMH\r\nand ChiTietPhieuMua.SoPhieuMua = @sophieumua";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("sophieumua", ma.Trim());
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            CloseConect();
            return dt;
        }
        public void DelCTPhieuMuaHang(string mamh, string sophieu, string soluong)
        {
            OpenConect();
            string query = "delete ChiTietPhieuMua where MaMH = @ma and SoPhieuMua = @sophieumua";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("ma", mamh);
            cmd.Parameters.AddWithValue("sophieumua", sophieu);
            cmd.ExecuteNonQuery();
            string query2 = "update MatHang set SoLuongTonKho = SoLuongTonKho - @sl where MaMH = @ma";
            SqlCommand cmd2 = new SqlCommand(query2, conn);
            cmd2.Parameters.AddWithValue("sl", soluong);
            cmd2.Parameters.AddWithValue("ma", mamh);
            cmd2.ExecuteNonQuery();
            CloseConect();
        }
        public void ChangeCTPhieuMuaHang(string mamh, string soluong, string tong, string sophieumua, string soluong2)
        {
            OpenConect();
            string query = "update ChiTietPhieuMua set SoLuong = @sl where MaMH = @ma and SoPhieuMua = @sophieu";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("ma", mamh);
            cmd.Parameters.AddWithValue("sl", soluong);
            cmd.Parameters.AddWithValue("sophieu", sophieumua);
            cmd.ExecuteNonQuery();
            string query1 = "update HoaDonMua set TongTien = @tongtien where SoPhieuMua = @sophieu"; 
            SqlCommand cmd1 = new SqlCommand(query1, conn);
            cmd1.Parameters.AddWithValue("tongtien", tong);
            cmd1.Parameters.AddWithValue("sophieu", sophieumua);
            cmd1.ExecuteNonQuery();
            string query2 = "update MatHang set SoLuongTonKho = SoLuongTonKho + @sl where MaMH = @ma";
            SqlCommand cmd2 = new SqlCommand(query2, conn);
            cmd2.Parameters.AddWithValue("sl", soluong2);
            cmd2.Parameters.AddWithValue("ma", mamh);
            cmd2.ExecuteNonQuery();
            CloseConect();
        }
        public int GetSL(string ma)
        {
            OpenConect();
            string query = "select SoLuongTonKho from MatHang where MaMH = @mamh";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("mamh", ma);
            object result = cmd.ExecuteScalar();

            // Kiểm tra nếu kết quả là null hoặc không phải là số nguyên
            if (result != null && int.TryParse(result.ToString(), out int soLuongTonKho))
            {
                return soLuongTonKho;
            }
            else
            {
                // Nếu không thành công, bạn có thể xử lý theo cách phù hợp
                // Ví dụ: log lỗi, thông báo lỗi, hoặc trả về một giá trị mặc định
                return -1; // Giá trị mặc định nếu không thể lấy được số lượng tồn kho
            }
            CloseConect();
        }
        public void AddCTPhieuMuaHang(string sophieumua, string mamh, string dongia,string sluong)
        {
            OpenConect();
            string query = "insert into ChiTietPhieuMua(SoPhieuMua, MaMH, DonGiaMua, SoLuong) values(@SoPhieuMua, @MaMH, @DonGiaMua, @SoLuong)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("SoPhieuMua", sophieumua);
            cmd.Parameters.AddWithValue("MaMH", mamh);
            cmd.Parameters.AddWithValue("DonGiaMua", dongia);
            cmd.Parameters.AddWithValue("SoLuong", sluong);
            cmd.ExecuteNonQuery();
            string query2 = "update MatHang set SoLuongTonKho = SoLuongTonKho + @sl where MaMH = @ma";
            SqlCommand cmd2 = new SqlCommand(query2, conn);
            cmd2.Parameters.AddWithValue("sl", sluong);
            cmd2.Parameters.AddWithValue("ma", mamh);
            cmd2.ExecuteNonQuery();
            CloseConect();
        }
        public bool CheckChiTietPhieuMua(string mamh)
        {
            OpenConect();
            string query = "select * from ChiTietPhieuMua where MaMH = @ma";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("ma", mamh);
            SqlDataReader dr2 = cmd.ExecuteReader();
            bool kt = false;
            if (dr2.HasRows) kt = true;
            CloseConect();
            return kt;
        }

        //THỐNG KÊ DOANH THU
        public DataTable ThongKeDoanhThu()
        {
            OpenConect();
            string query = "select distinct ChiTietHoaDonBan.MaMH, MatHang.TenMH, MatHang.HangSX, ChiTietHoaDonBan.SoLuong, HoaDonBan.NgayBan, HoaDonBan.TongTien as TongThu\r\nfrom ChiTietHoaDonBan, MatHang, HoaDonBan, ChiTietPhieuMua\r\nwhere ChiTietHoaDonBan.MaMH = MatHang.MaMH\r\nand ChiTietHoaDonBan.MaDonBan = HoaDonBan.MaDonBan\r\nand ChiTietHoaDonBan.MaMH = ChiTietPhieuMua.MaMH";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            CloseConect();
            return dt;
        }
        
    }
}
