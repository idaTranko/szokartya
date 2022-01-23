using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper.Configuration.Attributes;

namespace Szokartya
{
    internal class SzotarRekord
    {
        [Index(0)]
        public string Anyanyelv { get; set; } = String.Empty;
        
        [Index(1)]
        public string Idegennyelv { get; set; } = String.Empty;
        
        [Index(2)]
        public int Suly { get; set; } = 5;
    }
}
