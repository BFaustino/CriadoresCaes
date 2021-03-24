using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CriadoesCaes.Models
{
    public class Criadores
    {
        /// <summary>
        /// Identificador
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// nome
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// nome comercial
        /// </summary>
        public string NomeComercial { get; set; }

        /// <summary>
        /// morada
        /// </summary>
        public string Morada { get; set; }

        /// <summary>
        /// codigo postal
        /// </summary>
        public string CodPostal { get; set; }

        /// <summary>
        /// Telemóvel
        /// </summary>
        public string Telemovel { get; set; }

        /// <summary>
        /// Email
        /// </summary>
        public string Email { get; set; }
    }
}
