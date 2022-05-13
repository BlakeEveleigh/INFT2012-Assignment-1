using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



/// ////////////////////////
//
// this form is for testing out snippets of code and some debugging
// DO NOT INCLUDE IN THE FINAL SUBMISSION
//
///////////////////////

namespace BlakeEastwoodAssgt
{
    public partial class testing : Form
    {
        MainMenu main = new MainMenu();
        Random Rnd = new Random();
        GameInfo game1;
        

        public testing(GameInfo gamein)
        {
            InitializeComponent();
            game1 = gamein;
            
        }

        private int Roll()
        {

            int RandInt = Rnd.Next(1, 7);
            return RandInt;
        }
        

        //this just tests whether the array manages to hold all the right values 
        private void StartRound(int players)
        {
            int[] playerdiceleft = new int[players];
            for (int i = 0; i < players; i++) { playerdiceleft[i] = Roll(); }
            int[,] PlayerRolls = new int[players, 6];
            for (int i = 0; i < players; i++)
            {
                OutcomeDisplay.Text += "player " + i + ":  ";
                for (int j = 0; j < playerdiceleft[i]; j++)
                {
                    PlayerRolls[i,j] = Roll();
                    OutcomeDisplay.Text += PlayerRolls[i, j] + ",";
                }
                OutcomeDisplay.Text += "\r\n";
            }
        }

        private void dicetest(int players)
        {

        }

        private void PlayerGen(int players, int ai)
        {

            PlayerInfo[] Players = new PlayerInfo[players];
            PlayerInfo[] AI = new PlayerInfo[ai];

            for (int i = 0; i < players; i++)
            {
                Players[i] = new PlayerInfo(1, false);
                //Players[i].RollDice();
                OutcomeDisplay.Text +="player " + i + ": " + Convert.ToString(Players[i].PrintRolls()) + "\r\n";

            }
            for (int i = 0; i < ai; i++)
            {
                AI[i] = new PlayerInfo(2 , false);
                //AI[i].RollDice();
                OutcomeDisplay.Text += "AI " + i + ": " + Convert.ToString(AI[i].PrintRolls()) + "\r\n";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //StartRound(6);
            PlayerGen(game1.PlayerCount, game1.AiCount);
        }

        private void testing_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
