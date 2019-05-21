using FaleMais.Dominio.User.Repositories;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
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
        
        public JsonResult Calcular(string Source, string Destiny, string Plan, string Time)
        {
            var obj = new Plano { ValorUM = 10, ValorDOIS = 20 };

            var json = JsonConvert.SerializeObject(obj);

            return Json(json, JsonRequestBehavior.AllowGet);
        }      
    }

    public class Plano
    {
        public decimal ValorUM { get; set; }
        public decimal ValorDOIS { get; set; }
    }
}