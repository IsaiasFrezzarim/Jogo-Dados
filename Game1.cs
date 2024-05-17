using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GameDados_com_interface
{
   
   
    public partial class Game1 : Form
    {
        public static bool bu = false; //valor boleano para ser obrigado a selecionar ao menos um botao

        public Game2 game2; //para deixar publica a proxima tela


        public Game1()
        {
            InitializeComponent();
           game2 = new Game2(); //para chamar game2
        }
        public void NomeJogadores(string nomeJ1, string nomeJ2) //recebe os nomes feitos na primeira tela
        {     
            lb_j1.Text = nomeJ1; //manipula o textbox para ter o nome
            lb_j2.Text = nomeJ2;           
            game2.NomeJogadores(nomeJ1, nomeJ2); //passa para a proxima tela os nomes

        }

        public void Game1_Load(object sender, EventArgs e)
        {

        }

        private void lb_j1_Click(object sender, EventArgs e)
        {
           
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            bu = true; //significa que selecionou algum botao
            game2.Partidas(2); //passa o numero de partidas
            
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            bu = true;
            game2.Partidas(3);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            bu = true;
            game2.Partidas(4);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            bu = true;
            game2.Partidas(5);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            bu = true;
            game2.Partidas(6);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            bu = true;
            game2.Partidas(7);
        }
       
        private void btn_coninuar_Click(object sender, EventArgs e)
        {
            //verifica se foi selecionado algum botao
            if (bu != false)
            {
                this.Hide();
                game2.Show();
            }
            else 
            {
                MessageBox.Show("Por favor selecione ao menos um numero de partida");
            }   
        }
    }
  
}
