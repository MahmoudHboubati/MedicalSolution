using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalSolution.Models
{
    public class DiagnosisDrugsViewModel : BaseViewModel
    {
        public int Id { get; set; }
        private Core.Services.IDiagnosisProvider provider;

        public DiagnosisDrugsViewModel(int id, Core.Services.IDiagnosisProvider provider)
        {
            this.Id = id;
            this.provider = provider;

            LoadDagnosisData();
        }

        private void LoadDagnosisData()
        {
            DrugsList = provider.GetDiagnosisDrugs(Id);
        }

        public IEnumerable<Drug> DrugsList { get; private set; }
    }
}
