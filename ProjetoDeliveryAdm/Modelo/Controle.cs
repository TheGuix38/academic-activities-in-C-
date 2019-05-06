using ProjetoDeliveryAdm.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDeliveryAdm.Modelo
{
    public class Controle
    {
        public bool tem;
        public String mensagem = "";
        public bool acessar(String login, String senha)
        {
            LoginDAL loginDAL = new LoginDAL();
            tem = loginDAL.verificarLogin(login, senha);

            //if (!loginDAL.mensagem.Equals(""))
            if (!loginDAL.mensagem.Equals(""))
            {
                this.mensagem = loginDAL.mensagem;
            }
            return tem;
        }
        public String cadastrar(String email, String senha, String confSenha)
        {
            return mensagem;
        }
    }
}
