using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Exercicio_PS.Models
{
    [Table("T_ASP_JOGO")]
    public class Jogo
    {
        [Column("Id")]
        public int JogoId { get; set; }
        public string Nome { get; set; }
        public DateTime DataLancamento { get; set; }
        public Plataforma Plataforma { get; set; }
        public bool Disponivel { get; set; }
        public Genero Genero { get; set; }
    }
}