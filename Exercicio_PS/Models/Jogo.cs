using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Exercicio_PS.Models
{
    [Table("T_ASP_JOGO")]
    public class Jogo
    {
        [Column("Id")]
        public int JogoId { get; set; }
        [Required, MaxLength(60)]
        public string Nome { get; set; }
        [Display(Name = "Data de Lancamento"), DataType(DataType.Date)]
        public DateTime DataLancamento { get; set; }
        [Required]
        public Plataforma Plataforma { get; set; }
        public bool Disponivel { get; set; }
        public Genero Genero { get; set; }
        [Required]
        public int GeneroId { get; set; }
    }
}