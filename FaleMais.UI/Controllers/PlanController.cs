using FaleMais.Dominio.User.Repositories;
using FaleMais.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FaleMais.UI.Controllers
{
    public class PlanController : Controller
    {
        private readonly IPlanRepository _context;
        private readonly IAreaCodeRepository _contextAreaCode;

        public PlanController(IPlanRepository context, IAreaCodeRepository contextAreaCode)
        {
            _context = context;
            _contextAreaCode = contextAreaCode;

        }
        // GET: Plan
        public ActionResult Index()
        {
            var _sourceAndDestiny = _contextAreaCode.GetAllAreaCode();

            PlanViewModel _vm = new PlanViewModel();
            _vm.Plans = new SelectList(_context.GetAllPlan(), "Id", "Name");
            _vm.Source = new SelectList(_sourceAndDestiny, "Id", "Code");
            _vm.Destiny = new SelectList(_sourceAndDestiny, "Id", "Code");

            return View(_vm);
        }
    }
}