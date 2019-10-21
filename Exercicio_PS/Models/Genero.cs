using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio_PS.Models
{
    [Table("T_ASP_GENERO")]
    public class Genero
    {
        [Column("Id")]
        public int GeneroId { get; set; }
        public string Nome { get; set; }
        public IList<Jogo> ListaDeJogos { get; set; }
    }
}
