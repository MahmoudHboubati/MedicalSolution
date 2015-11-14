using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalSolution.Models
{
    public class DiagnosisViewModel : BaseViewModel
    {
        private Core.Services.IDiagnosisProvider provider;

        public DiagnosisViewModel(Core.Services.IDiagnosisProvider provider)
        {
            this.provider = provider;

            LoadDagnosisData();
        }

        private void LoadDagnosisData()
        {
            DiagnosisList = provider.GetAllDiagnosis();
        }

        public IEnumerable<Diagnosis> DiagnosisList { get; private set; }
    }
}
