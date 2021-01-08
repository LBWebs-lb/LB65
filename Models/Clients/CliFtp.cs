using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LB.Models.Clients
{
    public class ClientsFtp
    {
        [Key]
        public int iftp { get; set; }
        [Display(Name = "Usuari FTP")]
        public string userftp { get; set; }
        [Display(Name = "Password FTP")]
        public string passftp { get; set; }
        [Display(Name = "Ip Server")]
        public string ipserver { get; set; }
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
