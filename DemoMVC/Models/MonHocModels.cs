using System.ComponentModel.DataAnnotations;

namespace DemoMVC.Models
{
    public class MonHocModels
    {
        public string TenMonHoc { get; set; } = string.Empty;
        public float DiemA { get; set; }
        public float DiemB { get; set; }
        public float DiemC { get; set; }
        public float DiemTong { get; set; }
        public string KetQua { get; set; } = string.Empty;
    }
}