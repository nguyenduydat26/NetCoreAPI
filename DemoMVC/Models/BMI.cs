using System.ComponentModel.DataAnnotations;

namespace DemoMVC.Models
{
    public class BMIModel
    {
        [Key]
        public float ChieuCao { get; set; }
        public float CanNang { get; set; }
        public float ChiSoBMI { get; set; }
        public string KetQua { get; set; }= string.Empty;
    }
}