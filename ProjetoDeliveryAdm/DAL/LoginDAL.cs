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
                con.Desconectar();
                dr.Close();
            }
            catch (SqlException)
            {
                this.mensagem = "Erro com o Banco de Dados!";
            }
            return tem;
        }

        internal string cadastrar(string admLogin, string admSenha, string confSenha)
        {
            throw new NotImplementedException();
        }

        public String cadastrar(String admNome, String admLogin, String admSenha, String confSenha, String admEmail, String admCpf, String admEndereco, String admEstado, String admCidade, String admBairro, String admCep, String admTelefone, String admCelular)
        {
            tem = false;
            //comandos para inserir no banco
            if (admSenha.Equals(confSenha))
            {
                cmd.CommandText = "insert into login values (@admNome,@admLogin,@admSenha,@admEmail,admCpf,admEndereco,admEstado,admCidade,admBairro,admCep,admTelefone,admCelular);";
                cmd.Parameters.AddWithValue("@admLogin", admNome);
                cmd.Parameters.AddWithValue("@admLogin", admLogin);
                cmd.Parameters.AddWithValue("@admSenha", admSenha);
                cmd.Parameters.AddWithValue("@admEmail", admEmail);
                cmd.Parameters.AddWithValue("@admCpf", admCpf);
                cmd.Parameters.AddWithValue("@admEndereco", admEndereco);
                cmd.Parameters.AddWithValue("@admEstado", admEstado);
                cmd.Parameters.AddWithValue("@admCidade", admCidade);
                cmd.Parameters.AddWithValue("@admBairro", admBairro);
                cmd.Parameters.AddWithValue("@admCep", admCep);
                cmd.Parameters.AddWithValue("@admTelefone", admTelefone);
                cmd.Parameters.AddWithValue("@admCelular", admCelular);

                try
                {
                    cmd.Connection = con.Conectar();
                    cmd.ExecuteNonQuery();
                    con.Desconectar();
                    this.mensagem = "Cadastrado com Sucesso";
                    tem = true;
                }
                catch (SqlException)
                {
                    this.mensagem = "Erro com Banco de Dados";
                }
            }
            else
            {
                this.mensagem = "Senhas não correspondem!";
            }
           
            return mensagem;
        }
    }
}
