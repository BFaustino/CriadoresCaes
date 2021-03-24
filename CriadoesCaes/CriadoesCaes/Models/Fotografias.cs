using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CriadoesCaes.Models
{
    public class Fotografias
    {
        /// <summary>
        /// Identificador
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Data da Foto
        /// </summary>
        public DateTime DataFoto { get; set; }

        /// <summary>
        /// Local da foto
        /// </summary>
        public string LocalFotografia { get; set; }
    }
}
