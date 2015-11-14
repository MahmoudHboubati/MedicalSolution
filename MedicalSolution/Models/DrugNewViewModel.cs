using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalSolution.Models
{
    public class DrugNewViewModel
    {
        private Core.Services.IDiagnosisProvider provider;

        [Obsolete("Model binding only")]
        public DrugNewViewModel() { }
        public DrugNewViewModel(Core.Services.IDiagnosisProvider provider, int diagnosisId)
        {
            this.provider = provider;
            DiagnosisId = diagnosisId;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int DiagnosisId { get; set; }

        public bool Add(Core.Services.IDiagnosisProvider provider)
        {
            return provider.AddNewDrug(CreateDiagnosisFromProperties());
        }

        private Drug CreateDiagnosisFromProperties()
        {
            return new Drug
            {
                Name = Name,
                DiagnosisId = DiagnosisId
            };
        }
    }
}
