using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using atvAED3;

namespace atvAED3
{
    internal class Funcionario
    {
        static void Main(string[] args)
        {


            string nome;
            double salarioFixo;
            double totalVendas;
            double totalRecebido;

            Console.WriteLine("digite o nome do vendedor");
            nome = Console.ReadLine();


            Console.WriteLine("digite o salario do vendedor");
            salarioFixo = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("digite o total de vendas em reais do vendedor");
            totalVendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            grana money = new grana();
            money.totalVendas = totalVendas;
            money.salarioFixo = salarioFixo;

            totalRecebido = money.Grana();
            Console.WriteLine("o total recebido foi: " + totalRecebido.ToString("F2"));
        }
    }
}

