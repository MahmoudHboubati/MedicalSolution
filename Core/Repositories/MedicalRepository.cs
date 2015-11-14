using Core;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repositories
{
    public interface IMedicalRepository
    {
        IEnumerable<Diagnosis> GetDiagnosis(Func<Diagnosis, bool> conditions);
        IEnumerable<Drug> GetDrus(Func<Drug, bool> conditions);

        bool AddNewDiagnosis(Diagnosis diagnosis);

        bool AddNewDrug(Drug drug);
    }
}