using System.ComponentModel.DataAnnotations;

namespace DemoMVC.Models
{
    public class MonHocModel
    {
        public string TenMonHoc { get; set; }
        public float DiemA { get; set; }
        public float DiemB { get; set; }
        public float DiemC { get; set; }
        public float DiemTong { get; set; }
        public string KetQua { get; set; }
    }
}