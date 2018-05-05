using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaCshap
{
    public class PositionClass
    {

        public int x;
        public int y;
        public override string ToString()
        {
            return "X = " + x.ToString() + ", Y = " + y.ToString();
        }
    }

    public struct PositionStruct
    {
        public int x;
        public int y;

        public override string ToString()
        {
            return "X = " + x.ToString() + ", Y = " + y.ToString();
        }

    }

    public enum Role
    {
        Red = 0,
        Green = 1,
        blue = 2
    }

    public enum FormasPagamento
    {
        Boleto,cartao,cheque
    }

    class Program
    {
        static void Main(string[] args)
        {
            PositionClass pos1 = new PositionClass();
            pos1.x = 10;
            pos1.y = 20;
            PositionStruct pos2 = new PositionStruct();
            pos2.x = 30;
            pos2.y = 40;

            FormasPagamento formas = FormasPagamento.Boleto;
            Role role = Role.blue;
            Console.WriteLine(pos1);
            Console.WriteLine(pos2.ToString());
            Console.Write(role)
            Console.WriteLine(role);
            Console.ReadKey();




        }
    }
}
