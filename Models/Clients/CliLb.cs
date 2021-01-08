using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LB.Models.Clients
{
    public class ClientsLB
    {
        [Key]
        public int icli { get; set; }
        [ForeignKey("ihos")]
        public int? ihos { get; set; }
        [ForeignKey("ihos")]
        public virtual ClientHosting Host { get; set; }
        public int? iftp { get; set; }
        [ForeignKey("iftp")]
        public virtual ClientsFtp Ftp { get; set; }
        public int? ipredis { get; set; }
        [ForeignKey("ipredis")]
        public virtual ClientsPreDisseny PreDis { get; set; }
        [Display(Name = "Client")]
        public string dnom { get; set; }
        [Display(Name = "Mail")]
        public string dnommail { get; set; }
        [JsonConverter(typeof(JsonStringEnumConverter))]
        [Display(Name = "Estat")]
        public Estat est { get; set; }
        [Display(Name = "Observacions")]
        public string dobs { get; set; }
        [Display(Name = "Tipo Client")]
        public string tcli { get; set; }
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
        public int? icliacc { get; set; }
        [ForeignKey("icliacc")]
        public virtual ClientsAcces Acces { get; set; }
    }
}
public enum Estat
{
    Pressupostat,
    Predisseny,
    Desenvolupament,
    Mostrada,
    Entregada,
    RespostaClient
}
