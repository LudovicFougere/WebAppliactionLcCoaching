using System;
using System.Collections.Generic;

namespace WebApplicationLcCoaching.Models
{
    public partial class FormulaireSeance
    {
        public int Id { get; set; }
        public int IdUser { get; set; }
        public string TestConditionPhysique { get; set; }
        public string NiveauTechniqueMusculation { get; set; }
        public string Gainage { get; set; }
        public string Posture { get; set; }
        public string BilanSanguin { get; set; }
        public string TourTaille { get; set; }
        public string Contrat { get; set; }
        public byte[] Photos { get; set; }
    }
}
