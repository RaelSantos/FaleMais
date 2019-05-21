using FaleMais.Dominio.User.Repositories;
using FaleMais.Web.Models;
using System.Web.Mvc;

namespace FaleMais.Web.Controllers
{
    public class PlanoController : Controller
    {
        private readonly IPlanRepository _context;
        private readonly IAreaCodeRepository _contextAreaCode;

        public PlanoController(IPlanRepository context, IAreaCodeRepository contextAreaCode)
        {
            _context = context;
            _contextAreaCode = contextAreaCode;

        }

        // GET: Plano
        public ActionResult Index()
        {
            var _sourceAndDestiny = _contextAreaCode.GetAllAreaCode();

            PlanoViewModel _vm = new PlanoViewModel();
            _vm.Plans = new SelectList(_context.GetAllPlan(), "Id", "Name");
            _vm.Source = new SelectList(_sourceAndDestiny, "Id", "Code");
            _vm.Destiny = new SelectList(_sourceAndDestiny, "Id", "Code");

            return View(_vm);
        }

        [HttpPost]
        public ActionResult Index(PlanoViewModel model)
        {
            if (ModelState.IsValid)
            {

            }

            return View("Index");
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