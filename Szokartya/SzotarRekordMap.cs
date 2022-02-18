using CsvHelper.Configuration;
using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szokartya
{
    internal sealed class SzotarRekordMap : ClassMap<SzotarRekord>
    {
        public SzotarRekordMap()
        {
            Map(m => m.Anyanyelv).Index(0);
            Map(m => m.Idegennyelv).Index(1);
            Map(m => m.Suly).Index(2);
        }
    }
}



