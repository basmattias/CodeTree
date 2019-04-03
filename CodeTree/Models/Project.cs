using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTree.Models
{
    public class Project
    {
        public List<Theme> Themes { get; set; }
        public List<Category> Categories { get; set; }
        public List<Code> Codes { get; set; }
        public List<CondensedMeaningUnit> CondensedMeaningUnits { get; set; }

        public Project()
        {
            CondensedMeaningUnits = new List<CondensedMeaningUnit>();
            Codes = new List<Code>();
            Categories = new List<Category>();
            Themes = new List<Theme>();
        }
    }
}
