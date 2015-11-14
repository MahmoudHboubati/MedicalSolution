using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Diagnosis : Entity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual IEnumerable<Drug> Drugs { get; set; }
    }

    public class Drug : Entity
    {
        public int Id { get; set; }
        public int DiagnosisId { get; set; }
        public string Name { get; set; }
    }
}
