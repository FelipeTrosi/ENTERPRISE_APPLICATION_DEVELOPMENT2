﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _07_Fiap.Web.AspNet.Models
{
    public class Cela
    {
        public int CelaId { get; set; }
        [Required,StringLength(30)]
        public string Nome { get; set; }
        public float Area { get; set; }
        public int QuantidadeMaxima { get; set; }
        public IList<Presidiario> Presidiarios { get; set; }
    }
}
