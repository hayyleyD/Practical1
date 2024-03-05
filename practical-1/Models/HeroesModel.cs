using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace practical_1.Models
{
    public class HeroesModel
    {
        public  int Id { get; set; }
        public  string Name { get; set; }
        public int? Age { get; set; }
        public string Birthday { get; set; }
        public  string Height { get; set; }
        public  string Image { get; set; }
        public bool Alive { get; set; }
    }
}