using Core;
using Core.Repositories;
using Infrastructure;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class MedicalRepository : RepositoryBase, IMedicalRepository
    {
        DiagnosisDBEfContext context { get; set; }

        public MedicalRepository(DiagnosisDBEfContext context)
        {
            this.context = context;
        }

        public IEnumerable<Diagnosis> GetDiagnosis(Func<Diagnosis, bool> conditions)
        {
            return context.Diagnosises.Where(conditions).ToList();
        }
        public IEnumerable<Drug> GetDrus(Func<Drug, bool> conditions)
        {
            return context.Drugs.Where(conditions).ToList();
        }

        public bool AddNewDiagnosis(Diagnosis diagnosis)
        {
            context.Diagnosises.Add(diagnosis);
            bool saved = context.SaveChanges() > 0;
            return saved;
        }

        public bool AddNewDrug(Drug drug)
        {
            context.Drugs.Add(drug);
            bool saved = context.SaveChanges() > 0;
            return saved;
            //return SP_SaveDrug(drug);
        }
    }
}