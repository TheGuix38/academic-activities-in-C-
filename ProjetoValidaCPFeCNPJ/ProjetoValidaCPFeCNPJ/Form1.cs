using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoValidaCPFeCNPJ
{
    public partial class Form1 : Form
    {
        //variáveis para cpf
        int[] mult1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 }; //declarando vetor com números já designados para cada espaço
        int[] mult2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
        int soma;
        int rest1;

        string auxCPF;
        string digito1;

        //variáveis para cnpj
        int[] mult3 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
        int[] mult4 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
        int soma1;
        int rest2;

        string auxCNPJ;
        string digito2;


        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        public void validaCPF() //metodo para validar cpf
        {
            string CPF = txtCPF.Text;
            string confereCPF = CPF.Substring(0, 10);

            CPF = CPF.Trim(); //remove todos os espaços em branco, no começo e no final
            CPF = CPF.Replace(".", "").Replace("-", ""); //remove todos os pontos e traços, substitui por nada

            auxCPF = CPF.Substring(0, 9); //aux do cpf pega todos os 9 primeiros digitos do valor digitado
            soma = 0;

            for (int i = 0; i < 9; i++)
            {
                soma += int.Parse(auxCPF[i].ToString()) * mult1[i]; //multiplica e soma ao msm tempo para economizar linha com o vetor mult1
            }

            rest1 = soma % 11; //descobre o resto da divisão

            if (rest1 < 2)
            {
                rest1 = 0; //se menor que 2 vai valer 0
            }
            else
            {
                rest1 = 11 - rest1; //se não, 11menos o rest1
            }

            digito1 = rest1.ToString(); //guarda o primeiro digito
            auxCPF = auxCPF + digito1; //passa para o auxiliar do cpf

            soma = 0;

            for (int i = 0; i < 10; i++)
            {
                soma += int.Parse(auxCPF[i].ToString()) * mult2[i]; //multiplica e soma ao msm tmp pelo vetor mult2
            }

            rest1 = soma % 11; //pega o resto da divisão

            if (rest1 < 2)
            {
                rest1 = 0;
            }
            else
            {
                rest1 = 11 - rest1;
            }

            auxCPF = auxCPF + rest1; //passa o ultimo digito que resta para comparar

            if (CPF == auxCPF) 
            {
                MessageBox.Show("CPF válido");
            }
            else
            {
                MessageBox.Show("CPF Inválido");
            }
        }

        private void btnValidaCPF_Click(object sender, EventArgs e)
        {
            validaCPF();
        }

        private void validaCNPJ() //metodo para validar CNPJ
        {
            string CNPJ = txtCNPJ.Text;

            CNPJ = CNPJ.Trim(); //remove todos os espaços em branco, no começo e no final
            CNPJ = CNPJ.Replace(".", "").Replace("-", "").Replace("/", ""); //remove todos os pontos e traços, substitui por nada

            auxCNPJ = CNPJ.Substring(0, 12); //aux do cnpj pega todos os 9 primeiros digitos do valor digitado
            soma1 = 0;

            for (int i = 0; i < 12; i++)
            {
                soma1 += int.Parse(auxCNPJ[i].ToString()) * mult3[i]; //multiplica e soma ao msm tempo para economizar linha com o vetor mult1
            }

            rest2 = soma1 % 11; //descobre o resto da divisão

            if (rest2 < 2)
            {
                rest2 = 0; //se menor que 2 vai valer 0
            }
            else
            {
                rest2 = 11 - rest2; //se não, 11 menos o rest1
            }

            digito2 = rest2.ToString(); //guarda o primeiro digito
            auxCNPJ = auxCNPJ + digito2; //passa para o auxiliar do cpf

            soma1 = 0;

            for (int i = 0; i < 13; i++)
            {
                soma1 += int.Parse(auxCNPJ[i].ToString()) * mult4[i]; //multiplica e soma ao msm tmp pelo vetor mult2
            }

            rest2 = soma1 % 11; //pega o resto da divisão

            if (rest2 < 2)
            {
                rest2 = 0;
            }
            else
            {
                rest2 = 11 - rest2;
            }

            auxCNPJ = auxCNPJ + rest2; //passa o ultimo digito que resta para comparar

            if (CNPJ == auxCNPJ)
            {
                MessageBox.Show("CNPJ válido");
            }
            else
            {
                MessageBox.Show("CNPJ Inválido");
            }
        }

        private void btnValidaCNPJ_Click(object sender, EventArgs e)
        {
            validaCNPJ();
        }
    }
}