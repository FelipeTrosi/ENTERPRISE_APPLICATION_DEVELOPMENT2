using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _07_Fiap.Web.AspNet.Models
{
    public class Presidiario
    {
        public int PresidiarioId { get; set; }
        public string Nome { get; set; }
        [Display(Name = "Data de Entrada"), DataType(DataType.Date)]
        public DateTime DataEntrada { get; set; }
        [Display(Name = "Data de Saida"), DataType(DataType.Date)]
        public DateTime DataSaida { get; set; }
        [Display(Name = "Nivel de Escolaridade")]
        public NivelEscolaridade NivelEscolaridade { get; set; }
        public bool SaidaTemporaria { get; set; }
        public Cela Cela { get; set; }
        public int CelaId { get; set; }
    }
}
