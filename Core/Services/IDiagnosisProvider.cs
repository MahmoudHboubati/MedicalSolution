using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    public interface IDiagnosisProvider
    {
        IEnumerable<Diagnosis> GetAllDiagnosis();
        IEnumerable<Drug> GetDiagnosisDrugs(int DiagnosisId);

        bool AddNew(Diagnosis diagnosis);

        bool AddNewDrug(Drug drug);
    }
}
