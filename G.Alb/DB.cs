//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Data.SqlClient;

//namespace G.Alb
//{
//    class DB
//    {

//        public static void Main (string[] args)
//        {

//            string conexao = @"Data Source=PC-PV;Initial Catalog=Galb;Integrated Security=True";


//            SqlConnection objconexao = new SqlConnection(conexao);

//            SqlCommand objcmd = new SqlCommand("select * from Funcionario", objconexao);

//            try
//            {
            
//                objconexao.Open();

//                SqlDataReader objleitura = objcmd.ExecuteReader();

//                for(int i = 0; objleitura.Read(); i++)
//                {
//                    Console.WriteLine( objleitura["id_funcionario"] +" "+ objleitura["nome_funcionario"] + " " + objleitura["cpf"] + " " + objleitura["endereco"] + " " + objleitura["complemento"] + " " +
//                                        objleitura["bairro"] + " " + objleitura["cidade"] + " " + objleitura["estado"] + " " + objleitura["cep"] + " " + objleitura["telefone"] + " " + objleitura["email"] +" " +
//                                        objleitura["celular"] + " " + objleitura["setor"] + " " + objleitura["cargo"] + " " +  objleitura["salario"] + " " + objleitura["data_cadastro"] + " " + objleitura["status"]);

//                }


//                objconexao.Close();

//            }
//            catch(Exception e)
//            {
//                Console.WriteLine("Erro ao conectar" + e);
//            }

//        }
//    }
//}
