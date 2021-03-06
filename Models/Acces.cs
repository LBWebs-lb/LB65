﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LB.Models
{
    public class Acces
    {
        [Key]
        public int idlb { get; set; }

        [Display(Name = "Usuari")]
        public string userWp { get; set; }
        [Display(Name = "Contrasenya")]
        public string passWd { get; set; }
        [Display(Name = "Link")]
        public string linkWp { get; set; }
        [Display(Name = "Acces")]
        public string acc { get; set; }
        public string cusualt { get; set; }
        public DateTime faltrto { get; set; }
        public string cusumod { get; set; }
        public string fmod { get; set; }
        public string hmod { get; set; }
    }
}
