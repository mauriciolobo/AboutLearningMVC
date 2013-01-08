using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AboutNinjectManually.Models
{
    public class PabloEscobar : IDrugDealer
    {
        public string Name { get { return "Pablito"; } }
        public string[] Drugs { get { return new[] { "Cocaine", "Marijuana", "Opium" }; } }
    }
}