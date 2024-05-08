using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Task1.Models;

namespace Task1.Controllers
{
    public class CalcController : Controller
    {
        public IActionResult Plus(double o1, double o2)
        {
            double result = o1 + o2;
            ViewBag.Result = $"{o1} + {o2} = {result}";
            return View();
        }

        public IActionResult Minus(double o1, double o2)
        {
            double result = o1 - o2;
            ViewBag.Result = $"{o1} - {o2} = {result}";
            return View();
        }

        public IActionResult Multiply(double o1, double o2)
        {
            double result = o1 * o2;
            ViewBag.Result = $"{o1} * {o2} = {result}";
            return View();
        }

        public IActionResult Divide(double o1, double o2)
        {
            double result = o1 / o2;
            ViewBag.Result = $"{o1} / {o2} = {result}";
            return View();
        }
    }
}
