using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LB.Models
{
    public class MailLB
    {
        [Key]
        public int idlbmail { get; set; }
        [Display(Name = "Nom")]
        public string dnommail { get; set; }
        [Display(Name = "Correu")]
        public string mailuser { get; set; }
        [Display(Name = "Password")]
        public string passmail { get; set; }
        [Display(Name = "Link")]
        public string lnkmail { get; set; }
        public string cusualt { get; set; }
        public DateTime faltrto { get; set; }
        public string cusumod { get; set; }
        public string fmod { get; set; }
        public string hmod { get; set; }
    }
}
