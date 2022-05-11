using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_Biblioteca.Model
{
    public class LivrosModel
    {
        public int id { get; set; }
        public  string titulo { get; set; }
        public string editora { get; set; }
        public string foto { get; set; }
        public string autores { get; set; }

    }
}
