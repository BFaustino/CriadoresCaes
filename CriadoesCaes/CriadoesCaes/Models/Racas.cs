using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CriadoesCaes.Models
{   
    /// <summary>
    /// Raça atribuida a um cão
    /// </summary>
    public class Racas
    {
        /// <summary>
        /// Indentificador de cada uma das Raças
        /// </summary>
        public int Id { get; set; }


        /// <summary>
        /// indentifica o nome da Raça
        /// </summary>
        public string Designacao { get; set; }
    }
}
