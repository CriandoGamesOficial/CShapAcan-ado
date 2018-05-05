using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constutores_Overloads
{

    public class Contato
    {
        public string Tipo;
        public string Descricao;

    }

    public class Cliente
    {
        public int Codigo;
        public string nome;
        public Contato contato;

        public Cliente()
        {
            this.Codigo = 0;
            this.nome = "Sem Nome";
            this.contato = new Contato();
        }

        public Cliente(int codigo)
        {
            this.Codigo = codigo;
            this.nome = "Sem Nome";
            this.contato = new Contato();
        }

        public Cliente(int codigo, string nome)
        {
            this.Codigo = codigo;
            this.nome = nome;
            this.contato = new Contato();
        }

        public override string ToString()
        {
            return "Codigo: " + Codigo + ", Nome: " + nome;
        }

    }


    public class ClienteVip : Cliente
    {
        public int tempo;

        public ClienteVip(int codigo, string nome):base(codigo,nome)
        {
            this.tempo = 19;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();
            cliente.Codigo = 123;
            cliente.nome = "Carlos";
            cliente.contato.Tipo = "Telefone";
            cliente.contato.Descricao = "21-98001-6604";


            Cliente cliente2 = new Cliente(456, "Wallace");
            ClienteVip clienteVip = new ClienteVip(999,"foda");
            Console.WriteLine(cliente.ToString());
            Console.WriteLine(cliente2.ToString());
            Console.WriteLine( clienteVip.ToString());
            Console.ReadLine();
        }
    }
}
