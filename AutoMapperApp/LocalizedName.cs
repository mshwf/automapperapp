using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMapperApp
{
    public class LocalizedItem
    {
        public LocalizedItem() { }
        public LocalizedItem(string en, string ar)
        {
            En = en;
            Ar = ar;
        }

        public string En { get; set; }
        public string Ar { get; set; }
    }
}
