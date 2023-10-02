namespace Question1.Models
{
    public class RegistrationInformation
    {
        public string tenDonViTuyen { get; set; }
        public string loaiHinhDoanhNghiep { get; set; }
        public int soLuongNhanVien { get; set; }
        public string diaChi { get; set; }
        public string nguoiLienHe { get; set; }
        public string sdt { get; set; }
        public string fax { get; set; }
        public string email { get; set; }
        public string diaChiWebsite { get; set; }
        public string tenDangNhap { get; set; }
        public string password { get; set; }
        public string retypePassword { get; set; }
        public bool nhanThuDienTu { get; set; }

        public RegistrationInformation() { }
    }
}
