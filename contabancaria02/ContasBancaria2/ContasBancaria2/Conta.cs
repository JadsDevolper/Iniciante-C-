using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContasBancaria2
{
    public class Conta
    {
        public string tipo { get; set; }
        public string cliente { get; set; }
        public int conta { get; set; }
        public int agencia { get; set; }
        public int telefone {get; set;}
        public double saldo { get; set; }

    }
    public class ContaPoupanca : Conta
    {
    }


}

