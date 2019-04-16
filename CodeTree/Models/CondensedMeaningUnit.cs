using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTree.Models
{
    public class CondensedMeaningUnit
    {
        public CondensedMeaningUnit()
        {
            CodeNames = new List<string>();
        }

        public int CondensedMeaningUnitId { get; set; }
        public string InterviewNumber { get; set; }
        public string Name { get; set; }
        public List<MeaningUnit> MeaningUnits { get; set; }

        public string CodeName { get; set; }
        public List<string> CodeNames { get; set; }
    }
}
