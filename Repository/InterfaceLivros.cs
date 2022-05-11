using Api_Biblioteca.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_Biblioteca.Repository
{
    interface InterfaceLivros
    {
        public List<LivrosModel> Get();
        public void Post(LivrosModel Livro);
        public void Put(LivrosModel Livro);
        public void Delete(int id);

    }
}
