using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G.Alb
{
    public class Funcionario : Cliente
    {

        //Propriedades e encapsulamento
       
        private string setor;
        public string Setor
        {
            get { return setor; }
            set { setor = value; }
        }
        private string cargo;
        public string Cargo
        {
            get { return cargo; }
            set { cargo = value; }
        }
        private double salario;
        public double Salario
        {
            get { return salario; }
            set { salario = value; }
        }
        private string status;
        public string Status
        {
            get { return status; }
            set { status = value; }
        }



    }


}
