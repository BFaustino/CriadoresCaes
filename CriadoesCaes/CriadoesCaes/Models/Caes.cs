using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CriadoesCaes.Models
{
    /// <summary>
    /// descrição de cada um dos cães
    /// </summary>
    public class Caes
    {
        /// <summary>
        /// Identificador de cada Cão
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nome do cão
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// Sexo do Cão
        /// </summary>
        public char Sexo { get; set; }

        /// <summary>
        /// Data de Nascimento do cão
        /// </summary>
        public DateTime DataNasc { get; set; }

        /// <summary>
        /// Data de compra do cão
        /// </summary>
        public DateTime DataCompra { get; set; }

        /// <summary>
        /// Registo do cão no Livro de Origens Portuguesas(LOP)
        /// </summary>
        public string LOP { get; set; }
    }
}
