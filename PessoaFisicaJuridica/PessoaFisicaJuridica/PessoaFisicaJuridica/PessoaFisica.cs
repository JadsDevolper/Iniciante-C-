using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PessoaFisicaJuridica
{
    public class PessoaFisica:Pessoa //herdando da classe pessoa
    {
        public string Cpf { get; set; }
        public string Rg { get; set; }

        public void Sacar(float valor)
        {
            Saldo = Saldo - valor;
        }

        public PessoaFisica()
        {

        }

        public PessoaFisica(string _Nome, string _Telefone, float _Saldo, string _Nacionalidade, bool _LinkedIn, bool _Site, string _Cpf, string _Rg) : base(_Nome, _Telefone, _Saldo, _Nacionalidade, _LinkedIn, _Site)
        {
            this.Cpf = _Cpf;
            this.Rg = _Rg;
        }
    }
}
