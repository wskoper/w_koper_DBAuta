
using Microsoft.AspNetCore.Mvc;
using w_koper_DBAuta.Logika;

namespace w_koper_DBAuta
{
    public class AutaController : Controller
    {
        public IActionResult Index()
        {
            //AutaManager autaManager = new AutaManager();
            //AutaModel auta = new AutaModel()
            //{
            //    Id = 1,
            //    Marka = "Ford",
            //    Model = "Focus",
            //    Rocznik = 2022,
            //    Dostepnosc = 1,
            //};
            //autaManager.AddAuto(auta);
            return View();
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        public IActionResult Remove()
        {
            return View();
        }

        public IActionResult GetA()
        {
        return View();
        }
        public IActionResult GetLista()
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

        //public IActionResult Remove(1)
        //{
        //   AutaManager autaManager = new AutaManager();
        //    autaManager.RemoveAuto(1);
        //    return RedirectToAction("Index");
        //}
        public IActionResult GetA(AutaModel autaModel)
        {
            AutaManager autaManager = new AutaManager();
            autaManager.GetAuta(autaModel.Id);
           return  RedirectToAction("Index");

        }

            public IActionResult GetLista(AutaModel  autaModel)
        {
            AutaManager autaManager = new AutaManager();
            autaManager.GetAutas();
            return RedirectToAction("Index");
        }

    }
}