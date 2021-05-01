using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G.Alb
{
    public class Fornecedor:Cliente
    {
        //Propriedades e encapsulamento
        private string cnpj;
        public string Cnpj
        {
            get { return cnpj; }
            set { cnpj = value; }
        }
        private string nomeFantasia;
        public string NomeFantasia
        {
            get { return nomeFantasia; }
            set { nomeFantasia = value; }
        }
        private string razaoSocial;
        public string RazaoSocial
        {
            get { return razaoSocial; }
            set { razaoSocial = value; }
        }
        private string site;
        public string Site
        {
            get { return site; }
            set { site = value; }
        }
        private string telefoneComercial;
        public string TelefoneComercial
        {
            get { return telefoneComercial; }
            set { telefoneComercial = value; }
        }
    }
}
