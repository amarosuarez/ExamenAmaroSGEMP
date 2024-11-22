using BL;
using DAL;
using ENT;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UI.Models;
using UI.Models.VM;

namespace UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            IActionResult result;

            try
            {
                clsListadoMisionesCandidatoVM vm = new clsListadoMisionesCandidatoVM();
                result = View(vm);
            }
            catch (Exception ex) {
                ViewBag.Mensaje = ex.Message;
                result = View("Error");
            }

            return View();
        }

        [HttpPost]
        public IActionResult Index(int id)
        {
            IActionResult result;

            try
            {

                clsListadoMisionesCandidatoVM vm = new clsListadoMisionesCandidatoVM(id);

                result = View(vm);

            }
            catch (Exception ex)
            {
                ViewBag.Mensaje = ex.Message;
                result = View("Error");
            }

            return View();
        }

        public IActionResult Details(int id)
        {
            IActionResult result;

            try
            {

                clsCandidato? candidato = clsListadoCandidatoBL.obtenerCandidatoPorIdBL(id);

                if (candidato == null || candidato.Id == 0)
                {
                    result = View("Error");
                } else {
                    result = View(candidato);
                }


            }
            catch (Exception ex)
            {
                ViewBag.Mensaje = ex.Message;
                result = View("Error");
            }

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
