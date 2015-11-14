using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalSolution.Models
{
    public class DiagnosisNewViewModel : BaseViewModel
    {
        private Core.Services.IDiagnosisProvider provider;

        [Obsolete("Model binding only")]
        public DiagnosisNewViewModel() { }
        public DiagnosisNewViewModel(Core.Services.IDiagnosisProvider provider)
        {
            this.provider = provider;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public bool Add(Core.Services.IDiagnosisProvider provider)
        {
            return provider.AddNew(CreateDiagnosisFromProperties());
        }

        private Diagnosis CreateDiagnosisFromProperties()
        {
            return new Diagnosis
            {
                Name = Name,
                Description = Description,
            };
        }
    }
}
