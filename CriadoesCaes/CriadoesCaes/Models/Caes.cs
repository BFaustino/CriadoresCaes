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


        //*************************************************************

        /// <summary>
        /// FK para a Raça do Cão
        /// </summary>
        
        [ForeignKey(nameof(Raca)] //esta 'anotação' indica que o atributo 'RacaFK' está a executar o mesmo que o atributo raça e que representa uma FK para a classe Raca

        public int RacaFK { get; set; } // atributo para ser usado no SGBD e no C#. Reresenta a FK para a Raça do cão
        public Racas Raca { get; set; } // atributo para ser usado no SGBD. Reresenta a FK para a Raça do cão

    }

}
