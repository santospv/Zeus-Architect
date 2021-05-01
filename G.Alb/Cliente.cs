using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G.Alb
{
    public class Cliente
    {
        
        //Propriedades e encapsulamento
        private int cod;
        public int Cod
        {
            get { return cod; }
            set { cod = value; }
        }

        private string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        private string cpf;
        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }
        private string endereco;
        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }
        private string complemento;
        public string Complemento
        {
            get { return complemento; }
            set { complemento = value; }
        }
        private string bairro;
        public string Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }
        private string cidade;
        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }
        private string estado;
        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }
        private string cep;
        public string Cep
        {
            get { return cep; }
            set { cep = value; }
        }

        private string telefone;
        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }
        private string email;
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        private string celular;
        public string Celular
        {
            get { return celular; }
            set { celular = value; }
        }
        private string numero;
        public string Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        private DateTime dataCadastro;
        public DateTime DataCadastro
        {
            get { return dataCadastro; }
            set { dataCadastro = value; }
        }
    }
}
