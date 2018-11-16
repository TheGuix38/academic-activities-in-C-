using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;

namespace ProjetoEvilGenius
{
    public partial class frmGenius : Form
    {
        List<string> sequenciaCores = new List<string>();
        List<string> sequenciaJogador = new List<string>();
        int listaIndex, pontos;
        const float brilho = 0.80f;
        string atualCor;
        string[] cores = { "R", "G", "B", "Y" };
        bool podeJogar;
        Random rdn = new Random();
        SoundPlayer[] audios = { new SoundPlayer(Application.StartupPath + "\\audio02\\beep01.wav"), new SoundPlayer(Application.StartupPath + "\\audio02\\beep02.wav"), new SoundPlayer(Application.StartupPath + "\\audio02\\beep03.wav"), new SoundPlayer(Application.StartupPath + "\\audio02\\beep04.wav") };

        public frmGenius()
        {
            InitializeComponent();
        }

        private void MostrarCor(PictureBox pic, Color corClara, Color corEscura, SoundPlayer som)
        {
            pic.BackColor = corClara;
            som.Play();
            Application.DoEvents();
            Thread.Sleep(250);
            pic.BackColor = corEscura;
        }

        private void ProcurarCor(string tagPic)
        {
            foreach (var corEncontrada in Controls.OfType<PictureBox>())
            {
                if (corEncontrada.Tag.ToString() == tagPic)
                {
                    string tag = corEncontrada.Tag.ToString();

                    Color piscar = ControlPaint.Light(corEncontrada.BackColor, brilho);
                    SoundPlayer som = tag == "R" ? audios[0] : (tag == "G" ? audios[1] : (tag == "B" ? audios[2] : audios[3]));
                    MostrarCor(corEncontrada, piscar, corEncontrada.BackColor, som);

                }
            }
        }

        private void SortearCor()
        {
            atualCor = cores[rdn.Next(0, cores.Length)];
            sequenciaCores.Add(atualCor);

            foreach (var cor in sequenciaCores)
            {
                Application.DoEvents();
                Thread.Sleep(50);
                ProcurarCor(cor);
            }

            podeJogar = true;
        }

        private void Clique(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;

            if (podeJogar)
            {
                podeJogar = false;
                atualCor = pb.Tag.ToString();
                sequenciaJogador.Add(atualCor);
                ProcurarCor(atualCor);

                if (sequenciaJogador[listaIndex] == sequenciaCores[listaIndex])
                {
                    pontos++;
                    lblPontos.Text = "Pontuação: " + pontos.ToString();
                    listaIndex++;
                    Checar();
                }
                else
                {
                    MessageBox.Show("Sequência Incorreta! \n Fim de Jogo!");
                }
            }
        }
        private void Checar()
        {
            if (listaIndex == sequenciaCores.Count)
            {
                listaIndex = 0;
                sequenciaJogador.Clear();
                SortearCor();
            }
            else
            {
                podeJogar = true;
            }
        }

        private void Opcoes(object sender, EventArgs e)
        {
            sequenciaCores.Clear();
            sequenciaJogador.Clear();

            ToolStripMenuItem menu = (ToolStripMenuItem)sender;

            switch (menu.Text)
            {
            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            sequenciaCores.Clear();
            sequenciaJogador.Clear();
            pontos = 0; lblPontos.Text = "Pontuação: "; sequenciaJogador.Clear();
            podeJogar = false; listaIndex = 0; SortearCor();
        }

        private void btnSobre_Click(object sender, EventArgs e)
        {
            string info = "\t\tEvil Genius \nDesenvolvido por Guilherme Oliveira e Daniel Formigoni \n\t\tCopyright 2018";
            MessageBox.Show(info);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
