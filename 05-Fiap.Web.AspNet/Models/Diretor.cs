using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace _05_Fiap.Web.AspNet.Models
{
    [Table("T_ASP_DIRETOR")]
    public class Diretor
    {
        [Column("Id"),HiddenInput]
        public int DiretorId { get; set; }
        [Required,MaxLength(50)]
        public string Nome{ get; set; }
        [Display(Name = "Data de Nascimento"), Required, DataType(DataType.Date)]
        public DateTime DataNascimento { get; set; }
        public Sexo Genero { get; set; }
    }
}
