using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DemoMVC.Models;

namespace DemoMVC.Controllers
{
    public class BMIController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult TinhBMI(BMIModel model)
        {
            // Tính chỉ số BMI
            model.ChiSoBMI = model.CanNang / ((model.ChieuCao / 100) * (model.ChieuCao / 100));

            // Đánh giá kết quả
            if (model.ChiSoBMI < 18.5)
            {
                model.KetQua = "Thiếu cân";
            }
            else if (model.ChiSoBMI < 25)
            {
                model.KetQua = "Bình thường";
            }
            else if (model.ChiSoBMI < 30)
            {
                model.KetQua = "Thừa cân";
            }
            else
            {
                model.KetQua = "Béo phì";
            }

            // Gửi thông báo về View
            ViewBag.ThongBao = "Chỉ số BMI của bạn là: " + model.ChiSoBMI + ", " + model.KetQua;

            return View("Index");
        }
    }
}