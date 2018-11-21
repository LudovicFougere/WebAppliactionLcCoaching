using System;
using System.Collections.Generic;

namespace WebApplicationLcCoaching.Models
{
    public partial class Users
    {
        public Users()
        {
            FormulaireInit = new HashSet<FormulaireInit>();
            FormulaireSeance = new HashSet<FormulaireSeance>();
        }

        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public int Age { get; set; }
        public string Sexe { get; set; }

        public ICollection<FormulaireInit> FormulaireInit { get; set; }
        public ICollection<FormulaireSeance> FormulaireSeance { get; set; }
    }
}
