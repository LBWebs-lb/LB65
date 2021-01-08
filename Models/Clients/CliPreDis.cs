using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LB.Models.Clients
{
    public class ClientsPreDisseny
    {
        [Key]
        public int ipredis { get; set; }
        [Display(Name = "Tema")]
        public string ptheme { get; set; }
        [Display(Name = "Enviat client")]
        public bool envcli { get; set; }
        [Display(Name = "Tema comprat?")]
        public bool themebuy { get; set; }
        [Display(Name = "Preu tema")]
        public int pctheme { get; set; }
        [Display(Name = "Comprat per")]
        public string bouby { get; set; }
        [Display(Name = "Cobrat")]
        public bool paid { get; set; }
        [HiddenInput(DisplayValue = false)]
        public string cusualt { get; set; }
        [HiddenInput(DisplayValue = false)]
        public DateTime faltrto { get; set; }
        [HiddenInput(DisplayValue = false)]
        public string cusumod { get; set; }
        [HiddenInput(DisplayValue = false)]
        public string fmod { get; set; }
        [HiddenInput(DisplayValue = false)]
        public string hmod { get; set; }
    }
}
