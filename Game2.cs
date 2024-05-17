using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameDados_com_interface
{
    public partial class Game2 : Form
    {
        public static int pontosj1;  //para amarzenar os pontos
        public static int pontosj2;
        public static string Nomej1; //para receber os nomes
        public static string Nomej2;

        
        

        public static int Dadosj1() //gera numeros aleatorios e amarzena eles
        {
            Random dados = new Random(); //geração aleatoria de numeros
            int res = dados.Next(1, 7); //ate que numeros pode gerar
            pontosj1 += res; //faz a soma do dado atual com o dado anterior
            return res; // retorna o valor do resultado
        }
        public static int Dadosj2()
        {
            Random dados = new Random();
            int res = dados.Next(1, 7);
            pontosj2 += res;
            return res;
        }
        public Game2()
        {
            InitializeComponent();
            btn_res.Enabled = false; //deixa os botoes inviseis ate o fim do loop
            btn_Jogardenovo.Enabled = false;
        }
       public void NomeJogadores (string j1, string j2)
        {
            Nomej1 = j1; //recebe o nome dos jogadores e os torna publicos
            Nomej2 = j2; 
            lb_j1.Text = j1;
            lb_j2.Text = j2;
        }
          
        //onde a magica acontece
        public void Partidas(int partidas) //recebe o numero de partidas selecionado no botao anterior
        {
            label2.Text = partidas.ToString(); //diz quantas partidas foram seleciondas
            
            for (int i = 0; i < partidas; i++)//loop para rodar todas as partidas
            {
                label6.Text = "Partida: " + (i+1).ToString(); //apresentar a partida atual
               lb_jogador.Text = Nomej1; //apresenta o jogador que vai jogar
                btn_lancar1.Enabled = true; //deixa o botao clicavel para o lancar
                while (btn_lancar1.Enabled) //faz a confirmação se foi clicado ou nao
                {
                    Application.DoEvents(); //´para receber qualquer evento no botao
                }                         
               lb_jogador.Text = Nomej2;
               btn_lancar2.Enabled = true;    
                while(btn_lancar2.Enabled)
                {
                    Application.DoEvents();
                }            
            }
            btn_res.Enabled = true; //aciona o botao de ver resultado
            btn_Jogardenovo.Enabled = true; //aciona o botao para jogar de novo
        }
        public void button3_Click(object sender, EventArgs e)
        {
            btn_lancar1.Enabled = false; //deixa o botao do jogador 1 invisivel
            int res = Dadosj1(); //pega o retorno "res" do DadosJ1 para apresentar na tela o numero do dado
            btn_dadoj1.Text = res.ToString(); //apresenta no botao o numero do dado
            label4.Text = "Pontos " + Nomej1 + ": " + pontosj1; //apresenta o nome e pontos concatenados
           
        }

        private void btn_lancar2_Click(object sender, EventArgs e)
        {
            btn_lancar2.Enabled = false;
            int res = Dadosj2 ();
            btn_dadoj2 .Text = res.ToString();
            label5.Text = "Pontos " + Nomej2 + ": " + pontosj2;
           
        }
        private void btn_res_Click(object sender, EventArgs e)
        {
           //verifica quem esta com mais pontos para apresentar o ganhador
                if (pontosj1 > pontosj2)
                {
                    MessageBox.Show($"{Nomej1} Venceu o jogo com\n{pontosj1} pontos\nParabens!!");

                }
                else if (pontosj1 < pontosj2)
                {
                    MessageBox.Show($"{Nomej2} Venceu o jogo com\n{pontosj2} pontos\nParabens!!");
                }
                else
                {
                    MessageBox.Show($"O jogo empatou:\n{Nomej1} com {pontosj1} Pontos\n{Nomej2} com {pontosj2} Pontos ");
                Partidas(+1);//aciona mais uma partida para o desempate
                }
        }
        private void button1_Click(object sender, EventArgs e)
        {
          this.Close(); //fecha o form atual
          Game1 game1 = new Game1(); //abre novamene o form anterior
          game1.Show();
        }
    }
}

