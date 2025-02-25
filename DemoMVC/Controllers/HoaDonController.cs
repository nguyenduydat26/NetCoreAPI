using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DemoMVC.Models;

namespace DemoMVC.Controllers
{
    public class HoaDonController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult TinhTien(HoaDonModel model)
        {
            // Tính thành tiền
            model.ThanhTien = model.SoLuong * model.DonGia;

            // Gửi thông báo về View
            ViewBag.ThongBao = "Thành tiền của mặt hàng " + model.TenHang + " là: " + model.ThanhTien;

            return View("Index");
        }
    }
}