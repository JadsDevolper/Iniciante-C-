using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PessoaFisicaJuridica
{
    class PessoaJuridica:Pessoa  //herdando da classe pessosa
    {
        public string Cnpj { get; set; }
        public string Ie { get; set; }

        public PessoaJuridica() //construtor padrao
        {
            
        }

        public PessoaJuridica(string _Nome, string _Telefone, float _Saldo, string _Nacionalidade, bool _LinkedIn, bool _Site, string _Cnpj, string _Ie) : base(_Nome, _Telefone, _Saldo, _Nacionalidade, _LinkedIn, _Site) //utilizou base.() para herdar o metodo da classe pai 
        {
            this.Cnpj = _Cnpj;
            this.Ie = _Ie;
        }

        public void Sacar(float valor)
        {
            Saldo = Saldo - (valor + (valor * 0.01f));
        }
    }
}
