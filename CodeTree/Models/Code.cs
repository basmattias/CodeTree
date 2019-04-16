using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTree.Models
{
    public class Code
    {
        public Code()
        {
            CategoryNames = new List<string>();
        }

        public int CodeId { get; set; }
        public string Name { get; set; }
        
        public string CategoryName { get; set; }
        public List<string> CategoryNames { get; set; }
    }
}
