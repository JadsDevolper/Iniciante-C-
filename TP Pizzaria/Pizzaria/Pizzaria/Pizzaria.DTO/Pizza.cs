using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.DTO
{
    public class Pizza
    {
        private int id;
        private string nome;
        private string telefone;
        private string endereco;
        private string email;
        private int codproduto;
        private string categoria;
        private string nomeproduto;
        private float valorproduto;      


        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
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
        public int Codproduto
        {
            get
            {
                return codproduto;
            }
            set
            {
                codproduto = value;
            }
        }
        public string Categoria
        {
            get
            {
                return categoria;
            }
            set
            {
                categoria = value;
            }
        }
        public string Nomeproduto
        {
            get
            {
                return nomeproduto;
            }
            set
            {
                nomeproduto = value;
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


    }
}

