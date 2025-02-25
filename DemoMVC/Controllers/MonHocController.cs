using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DemoMVC.Models;

namespace DemoMVC.Controllers
{
    public class MonHocController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult TinhDiem(MonHocModel model)
        {
            // Tính điểm tổng
            model.DiemTong = model.DiemA * 0.6f + model.DiemB * 0.3f + model.DiemC * 0.1f;

            // Đánh giá kết quả
            if (model.DiemTong >= 8)
            {
                model.KetQua = "Giỏi";
            }
            else if (model.DiemTong >= 6.5)
            {
                model.KetQua = "Khá";
            }
            else if (model.DiemTong >= 5)
            {
                model.KetQua = "Trung bình";
            }
            else
            {
                model.KetQua = "Trượt";
            }

            // Gửi thông báo về View
            ViewBag.ThongBao = "Điểm tổng của môn " + model.TenMonHoc + " là: " + model.DiemTong + ", " + model.KetQua;

            return View("Index");
        }
    }
}