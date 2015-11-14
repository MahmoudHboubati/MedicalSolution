using Core.Services;
using DAL.Repositories;
using MedicalSolution.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MedicalSolution.Controllers
{
    public class DiagnosisController : Controller
    {
        readonly IDiagnosisProvider provider;

        public DiagnosisController()
        {
            provider = new DiagnosisProvider(new MedicalRepository(new Infrastructure.DiagnosisDBEfContext()));
        }

        //
        // GET: /Diagnosis/
        public ActionResult Index()
        {
            DiagnosisViewModel model = new DiagnosisViewModel(provider);
            return View(model);
        }

        public ActionResult DiagnosisListPartial()
        {
            DiagnosisViewModel model = new DiagnosisViewModel(provider);
            return PartialView(model);
        }

        public ActionResult DrugsListPartial(int id)
        {
            DiagnosisDrugsViewModel model = new DiagnosisDrugsViewModel(id, provider);
            return PartialView(model);
        }

        public ActionResult NewPartial()
        {
            DiagnosisNewViewModel model = new DiagnosisNewViewModel(provider);
            return PartialView(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult New(DiagnosisNewViewModel model)
        {
            if (ModelState.IsValid)
                if (model.Add(provider))
                {
                    DiagnosisViewModel listModel = new DiagnosisViewModel(provider);
                    return PartialView("DiagnosisListPartial", listModel);
                }
            return PartialView(model);
        }

        public ActionResult NewDrugPartial(int id)
        {
            DrugNewViewModel model = new DrugNewViewModel(provider, id);
            return PartialView(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NewDrug(DrugNewViewModel model)
        {
            if (ModelState.IsValid)
                if (model.Add(provider))
                {
                    DiagnosisDrugsViewModel listModel = new DiagnosisDrugsViewModel(model.DiagnosisId, provider);
                    return PartialView("DrugsListPartial", listModel);
                }
            return PartialView(model);
        }
    }
}
