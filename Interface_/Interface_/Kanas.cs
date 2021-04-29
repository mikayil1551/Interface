using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_
{
    class Kanas : AtesliSilahlar, IYakinlasdirilaBilir
    {
        public string Yakinlastir()
        {
            return "Yakinlastirildi!";
        }
    }
}
