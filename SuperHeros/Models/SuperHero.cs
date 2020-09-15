using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SuperHeros.Models
{
    public class SuperHero
    {
        //porperties for the object
        //will represent table in database
        [Key]
        public string name { get; set; }
        public string alterEgo { get; set; }
        public string primaryAbility { get; set; }
        public string secondaryAbility { get; set; }
        public string catchPhrase { get; set; }
    }
}
