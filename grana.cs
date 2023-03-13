using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atvAED3
{
    public class grana
    {
        public string nome;
        public double salarioFixo;
        public double totalVendas;

        public double Grana()
        {
            return (totalVendas * 0.15) + salarioFixo;
        }
    }
}
