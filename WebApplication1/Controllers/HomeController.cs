using FaleMais.Dominio.User.Repositories;
using FaleMais.Infra.Persistence.Contexts;
using FaleMais.Infra.Repositories.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPlanRepository _context;
        private readonly IAreaCodeRepository _contextAreaCode;


        public HomeController(IPlanRepository context, IAreaCodeRepository contextAreaCode)
        {
            _context = context;
            _contextAreaCode = contextAreaCode;
        }
         

        public ActionResult Index()
        {
            var _sourceAndDestiny = _contextAreaCode.GetAllAreaCode();
            PlanoViewModel _vm = new PlanoViewModel();
            _vm.Plans = new SelectList(_context.GetAllPlan(), "Id", "Name");
            _vm.Source = new SelectList(_sourceAndDestiny, "Id", "Code");
            _vm.Destiny = new SelectList(_sourceAndDestiny, "Id", "Code");

            return View(_vm);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpGet]
        public JsonResult Calcular(string Source, string Destiny, string Plan)
        {
            var retorno = RetornoJson();

            return Json(new { FaleMais = retorno, Type = "success", JsonRequestBehavior.AllowGet });


        }

        public PlanoViewModel RetornoJson()
        {
            return new PlanoViewModel { ValueWithOutPlan = 10, ValueWithPlan = 100 };
        }
    }
}