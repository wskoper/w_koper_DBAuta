
using Microsoft.AspNetCore.Mvc;
using w_koper_DBAuta.Logika;

namespace w_koper_DBAuta
{
    public class AutaController : Controller
    {
        public IActionResult Index()
        {
            AutaManager autaManager = new AutaManager();
            AutaModel auta = new AutaModel()
            {
                Id = 1,
                Marka = "Ford",
                Model = "Focus",
                Rocznik = 2022,
                Dostepnosc = 1,
            };
            autaManager.AddAuto(auta);
            return View();
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(AutaModel autaModel)
        {
            AutaManager autaManager = new AutaManager();
            autaManager.AddAuto(autaModel);
            return RedirectToAction("Index");
        }
    }
}