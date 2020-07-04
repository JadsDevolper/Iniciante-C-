using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.DTO
{
    public class Pizza
    {
        private int cdcliente;
        private int cdproduto;
        private int cdpedido;
        private string nome;
        private string telefone;
        private string endereco;
        private string email;
        private string cep;
        private float valorproduto;
        private float valortotal;

        public int Cdcliente
        {
            get
            {
                return cdcliente;
            }
            set
            {
                cdcliente = value;
            }
        }
        public int Cdproduto
        {
            get
            {
                 return cdproduto;
            }
            set
            {
                cdproduto = value;
            }
        }

        public int Cdpedido
        {
            get
            {
                return cdpedido;
            }
            set
            {
                cdpedido = value;
            }
        }
        public string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                nome = value;
            }
        }
        public string Telefone
        {
            get
            {
                return telefone;
            }
            set
            {
                telefone = value;
            }
        }
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }
        public string Endereco
        {
            get
            {
                return endereco;
            }
            set
            {
                endereco = value;
            }
        }
        public string Cep
        {
            get
            {
                return cep;      
            }
            set
            {
                cep = value;
            }
        }
        public float Valorproduto
        {
            get
            {
                return valorproduto;
            }
            set
            {
                valorproduto = value;
            }
        }
        public float Valortotal
        {
            get
            {
                return valortotal;
            }
            set
            {
                valortotal = value;
            }
        }

    }

}

