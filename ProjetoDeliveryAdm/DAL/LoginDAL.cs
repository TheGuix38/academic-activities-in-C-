using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDeliveryAdm.DAL
{
    class LoginDAL
    {

        public bool tem = false;
        public String mensagem = "";
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;
        public bool verificarLogin(String loginAdm, String senhaAdm)
        {
            //comando sql para verificar se tem no banco
            cmd.CommandText = "select * from TBCadastroAdm where LoginAdm = @login and SenhaAdm = @senha";
            cmd.Parameters.AddWithValue("@login", loginAdm);
            cmd.Parameters.AddWithValue("@senha", senhaAdm);

            try
            {
                cmd.Connection = con.Conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)//se foi encontrado
                {
                    tem = true;
                }
            }
            catch (SqlException)
            {
                this.mensagem = "Erro com o Banco de Dados!";
            }
            return tem;
        }



        public String cadastrar(String email, String senha, String confSenha)
        {
            //comandos para inserir no banco
            return mensagem;
        }
    }
}
