using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace Practica_semana_16.Controllers
{
    public class Lucas : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Index2(string name, int age = 1)
        {
            ViewData["name"] = "Buenas tardes " + name;
            ViewData["edad"] = "Tienes " + age + "anios";
            return View();
        }

        public string? Parameters(string name, int age = 1)
        {
            return HtmlEncoder.Default.Encode($"Hola {name} tienes {age}, ya estás ruco xd");
        }
    }
}
