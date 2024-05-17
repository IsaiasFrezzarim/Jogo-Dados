using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameDados_com_interface
{
    public partial class Form1 : Form
    {
        //amarzenar nomes digitados
        public  string nomeJ1; 
        public  string nomeJ2; 

        public Form1()
        {
            InitializeComponent();                  
        }


        private void btn_continuar_Click(object sender, EventArgs e)
        {
            //receber nomes escritos 
            nomeJ1 = tb_j1.Text;          
            nomeJ2 = tb_j2.Text;

            //para verificar se nao ha nomes em branco ou repetidos
            if (nomeJ1 == "" || nomeJ2 == "")
            {
                MessageBox.Show("Não pode haver nomes em branco!!");
               
            }else if(nomeJ1 == nomeJ2)
            {
                MessageBox.Show("Não pode haver nomes repetidos!\nPor favor renomeie jogador 2");
                tb_j2.Focus();//foca no segundo nome e limpa o texto para digitar novamente
                tb_j2.Clear();
            }
            else
            {                       
                    this.Hide();//fecha a primeira tela
                    Game1 game1 = new Game1();//abre a instancia do da tela de partidas
                    game1.NomeJogadores(nomeJ1, nomeJ2); //passa como parametro para game 1 o nome dos jogadores
                    game1.ShowDialog();      //para abrir a nova tela        
            }

          
        }      
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
