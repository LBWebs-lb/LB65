using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LB.Models.Clients
{
    public class ClientHosting
    {
        [Key]
        public int ihos { get; set; }
        [Display(Name = "Usuari Hosting")]
        public string userhos { get; set; }
        [Display(Name = "Password Hosting")]
        public string passhos { get; set; }
        [Display(Name = "Link Hosting")]
        public string linkwphos { get; set; }
        [HiddenInput(DisplayValue = false)]
        [Display()]
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
