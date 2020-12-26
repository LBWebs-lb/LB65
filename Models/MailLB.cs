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
        public string dnommail { get; set; }
        public string mailuser { get; set; }
        public string passmail { get; set; }
        public string lnkmail { get; set; }
        public string cusualt { get; set; }
        public DateTime faltrto { get; set; }
        public string cusumod { get; set; }
        public string fmod { get; set; }
        public string hmod { get; set; }
    }
}
