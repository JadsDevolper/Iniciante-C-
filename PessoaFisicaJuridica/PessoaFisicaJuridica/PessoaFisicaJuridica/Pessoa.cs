using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PessoaFisicaJuridica
{
    public class Pessoa 
    {
        public string Nome { get; set; }            //arrea de atributos
        public string Telefone { get; set; }
        public float Saldo { get; set; }
        public string Nacionalidade { get; set; }
        public bool LinkedIn { get; set; }
        public bool Site { get; set; }

        public Pessoa()
        {
        }

        public Pessoa(string _Nome, string _Telefone, float _Saldo, string _Nacionalidade, bool _LinkedIn, bool _Site)
        {
            this.Nome           = _Nome;
            this.Telefone       = _Telefone;
            this.Saldo          = _Saldo;
            this.Nacionalidade  = _Nacionalidade;
            this.LinkedIn       = _LinkedIn;
            this.Site           = _Site;
        }

        public float ObterSaldo()
        {
            return Saldo;
        }

        public void Depositar(float valor)
        {
            Saldo = Saldo + valor;
        }
    }
}
