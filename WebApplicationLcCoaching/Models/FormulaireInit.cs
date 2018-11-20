using System;
using System.Collections.Generic;

namespace WebApplicationLcCoaching.Models
{
    public partial class FormulaireInit
    {
        public int Id { get; set; }
        public int IdUser { get; set; }
        public double? Poids { get; set; }
        public double? PourcentGraisseCorporelle { get; set; }
        public double? MasseMusculaire { get; set; }
        public double? Dej { get; set; }
        public int? AgeMetabolique { get; set; }
        public double? PourcentHydratation { get; set; }
        public double? MasseOsseuse { get; set; }
        public double? Imc { get; set; }
        public double? GraisseVisterale { get; set; }
    }
}
