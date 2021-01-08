using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LB.Models.Clients
{
    public class ClientsAcces
    {
        [Key]
        public int icliacc { get; set; }
        [Display(Name = "Client Usuari WP")]
        public string userWp { get; set; }
        [Display(Name = "Contrasenya")]
        public string passWd { get; set; }
        [Display(Name = "Link")]
        public string linkWp { get; set; }
        [Display(Name = "Acces")]
        public string acc { get; set; }
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
