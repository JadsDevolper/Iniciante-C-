using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Criarconta
{
    class Pessoa
    {
        public string agencia { get; set; }
        public string conta { get; set; }
        public string titular { get; set; }
        public double saldo { get; set; }

        public void Sacar(double valor)
        {
            if(this.saldo >= valor)
            {
                this.saldo -= valor;
                //return true;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Saldo insuficiente!");
               // return false;
            }
        }
        public void Depositar(double valor)
        {
            this.saldo += valor;
        }
    }
}
