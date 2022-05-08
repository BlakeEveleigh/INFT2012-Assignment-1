using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlakeEastwoodAssgt
{
    public class PlayerInfo
    {

        Random Rnd = new Random();
        //number of dice player has left
        int PlayerDiceLeft;
        //array that hold the value of each dice
        int[] PlayerRolls;

        //differentiates the player:
        // 0: eliminated player
        // 1: human player
        // 3: AI player
        int PlayerState;

        int NoOfDiceBet = 0;
        int DiefaceBet = 0;


        //determines if the player is the current player taking their turn
        bool CurrPlayer;


        //contructor for the PlayerInfo class
        //the boolean AiTrue differentiates between a human player or an AI player
        //upon instantiation of a new PlayerInfo
        public PlayerInfo(int PlayerStateIn, bool CurrPlayerIn)
        {
            PlayerDiceLeft = 5;
            PlayerRolls = new int[PlayerDiceLeft];
            for (int i = 0; i < PlayerDiceLeft; i++)
            {
                PlayerRolls[i] = Roll();
            }
            switch (PlayerStateIn)
            {
                case 0: { PlayerState = 0; break; } // 0 = eliminated player
                case 1: { PlayerState = 1; break; } // 1 = human player
                case 2: { PlayerState = 2; break; } // 2 = AI player
            }
            if (CurrPlayerIn == true) { CurrPlayer = true; }
            else { CurrPlayer = false; }
        }
        public bool GetCurrentPlayer()
        {
            return CurrPlayer;
        }
        public int GetNoOfDiceBet()
        {
            return NoOfDiceBet;
        }

        public int GetDieFaceBet()
        {
            return DiefaceBet;
        }

        public void SetNoOfDice(int ValueIn)
        {
            NoOfDiceBet = ValueIn;
        }

        public void SetDieFaceBet(int ValueIn)
        {
            DiefaceBet = ValueIn;
        }
        //internal function to pick a number between 1 and 6 for dice
        private int Roll()
        {

            int RandInt = Rnd.Next(1, 7);
            return RandInt;
        }

        public int GetPlayerDiceLeft()
        {
            return PlayerDiceLeft;
        }

        public void SetCurrentPlayer(bool currentin)
        {
            if (currentin == true) { CurrPlayer = true; }
            else
            { CurrPlayer = false; }

        }

        //a function to be called when a player needs their dice to be rolled
        public void RollDice()
        {
            PlayerRolls = new int[PlayerDiceLeft];

            for (int i = 0; i < PlayerDiceLeft; i++)
            {
                PlayerRolls[i] = Roll();
            }
        }

        //gets a certain roll value from the array
          public int GetRolls(int NumIn)
        {
            
            return PlayerRolls[NumIn];
            
        }


        //prints all values of the dice in a string
        public String PrintRolls()
        {
            String TempString = "";
            for (int i = 0; i < PlayerDiceLeft; i++)
            {
                TempString += PlayerRolls[i];
            }
            return TempString;
        }
        // a function to be called for when a player loses the game and will then have less dice
        public void LoseDice()
        {
            if (PlayerDiceLeft == 0)
            {
                PlayerState = 0;
            }
            else
            {
                PlayerDiceLeft -= 1;
            }
                
        }

    }
}
