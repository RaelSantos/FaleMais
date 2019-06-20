using FaleMais.Dominio.User.Entities;
using FaleMais.Dominio.User.Repositories;
using FaleMais.UI.Models;
using Newtonsoft.Json;
using System;
using System.Web.Mvc;

namespace FaleMais.UI.Controllers
{
    public class PlanController : Controller
    {
        #region ['Context']
        private readonly IPlanRepository _contextPlan;        
        private readonly IAreaCodeSourceRepository _contextAreaCodeSource;
        private readonly IAreaCodeDestinyRepository _contextAreaCodeDestiny;
        private readonly IAreaCodeValueMinuteRepository _contextAreaCodeValueMinute;

        #endregion

        #region ['Ctor']
        public PlanController(IPlanRepository contextPlan, IAreaCodeSourceRepository contextAreaCodeSource, IAreaCodeDestinyRepository contextAreaCodeDestiny, IAreaCodeValueMinuteRepository contextAreaCodeValueMinute)
        {
            _contextPlan = contextPlan;
            _contextAreaCodeSource = contextAreaCodeSource;
            _contextAreaCodeDestiny = contextAreaCodeDestiny;
            _contextAreaCodeValueMinute = contextAreaCodeValueMinute;

        }

        #endregion

        // GET: Plan
        public ActionResult Index()
        {
            PlanViewModel _vm = new PlanViewModel();
            _vm.Plans = new SelectList(_contextPlan.GetAll(), "Id", "Name");
            _vm.Source = new SelectList(_contextAreaCodeSource.GetAll(), "Id", "Code");
            _vm.Destiny = new SelectList(_contextAreaCodeDestiny.GetAll(), "Id", "Code");

            return View(_vm);
        }

        public JsonResult Calculate(string sourceId, string destinyId, string planId, string time)
        {
            try
            {
                var _areaCodeValueMin = _contextAreaCodeValueMinute.ValueMin(int.Parse(sourceId), int.Parse(destinyId));
                var _plan = _contextPlan.GetById(int.Parse(planId));
                var _speakMore = SpeakMore.CalculateRate(_areaCodeValueMin, _plan, int.Parse(time));

                var json = JsonConvert.SerializeObject(_speakMore);

                return Json(json, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json( new { error = true, responseText = ex.Message }, JsonRequestBehavior.AllowGet);
            }
        }
    }   
}