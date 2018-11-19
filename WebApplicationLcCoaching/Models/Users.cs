using System;
using System.Collections.Generic;

namespace WebApplicationLcCoaching.Models
{
    public partial class Users
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public int? Age { get; set; }
    }
}
