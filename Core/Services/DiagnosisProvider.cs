using Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    public class DiagnosisProvider : IDiagnosisProvider
    {
        IMedicalRepository repository { get; set; }

        public DiagnosisProvider(IMedicalRepository repository)
        {
            this.repository = repository;
        }

        public IEnumerable<Diagnosis> GetAllDiagnosis()
        {
            return repository.GetDiagnosis(w => 1 == 1);
        }

        public IEnumerable<Drug> GetDiagnosisDrugs(int DiagnosisId)
        {
            return repository.GetDrus(w => w.DiagnosisId == DiagnosisId);
        }


        public bool AddNew(Diagnosis diagnosis)
        {
            return repository.AddNewDiagnosis(diagnosis);
        }


        public bool AddNewDrug(Drug drug)
        {
            return repository.AddNewDrug(drug);
        }
    }
}
