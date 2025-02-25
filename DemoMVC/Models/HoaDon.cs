using System.ComponentModel.DataAnnotations;

namespace DemoMVC.Models
{
    public class HoaDonModel
    {
        public string TenHang { get; set; }
        public int SoLuong { get; set; }
        public float DonGia { get; set; }
        public float ThanhTien { get; set; }
    }
}