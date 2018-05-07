using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inicializando_Objetos
{

    public class Filme
    {
        public string Nome;
        public int Ano;
        
    }

    public  class Ator
    {

        public int Codigo;
        public string Nome;
        public string Filme;
        public List<Filme> filmes;
        //public Ator(int codigo,string nome,string filme)
        //{
        //    this.Codigo = codigo;
        //    this.Nome = nome;
        //    this.Filme = filme;
        //}
    }
    class Program
    {
        static void Main(string[] args)
        {
            Ator a = new Ator()
            {
                Nome = "Carlos",
                Codigo = 12345,
                filmes = new List<Filme>()
                {
                    new Filme(){Nome = "Carlos 1"},
                    new Filme(){Nome ="Hall Fama",Ano = 1992}
                }
            };
        }
    }
}
