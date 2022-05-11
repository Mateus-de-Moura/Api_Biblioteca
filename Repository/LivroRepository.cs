using Api_Biblioteca.Model;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Api_Biblioteca.Repository
{
    public class LivroRepository : InterfaceLivros
    {
        private IDbConnection _Con;           
        public LivroRepository() 
        {
            _Con = new SqlConnection(@"Data Source=DESKTOP-GPICHSB\SQLEXPRESS;Initial Catalog=Livros_Ti;Integrated Security=True");
        }     
        public List<LivrosModel> Get()
        {
            return _Con.Query<LivrosModel>("SELECT * FROM Livros ORDER BY id ASC").ToList();
        }
        public void Post(LivrosModel Livro)
        {
            string sql = "INSERT INTO livros (titulo,editora,foto,autores)VALUES(@titulo,@editora,@foto,@autores)";
            _Con.Execute(sql, Livro);
        }
        public void Put(LivrosModel Livro)
        {
            string sql = $"UPDATE Livros set titulo = @titulo, editora = @editora, foto = @foto, autores = @autores  WHERE id = {Livro.id}";
            _Con.Execute(sql,Livro);
        }
        public void Delete(int id)
        {
            string sql = $"DELETE FROM Livros WHERE id={id}";
            _Con.Execute(sql, id);
        }
    }
}
