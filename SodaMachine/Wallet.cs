using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class Wallet
    {
        //Member Variables (Has A)
        public List<Coin> Coins;
        //Constructor (Spawner)
        public Wallet()
        {
            Coins = new List<Coin>();
            FillWallet();
        }
        //Member Methods (Can Do)
        //Fills wallet with starting money
        private void FillWallet()
        {
            AddQuartersToWallet(30); //$7.50 with 30 quarters
            AddDimesToWallet(15); //$1.50 with 15 dimes
            AddNickelsToWallet(20); //$1.00 with 20 nickels
            AddPenniesToWallet(50); //$0.50 with 50 pennies
        }
        private void AddQuartersToWallet(int startingQuarters)
        {
            for (int i = 0; i < startingQuarters; i++)
            {
                Quarter quarter = new Quarter();
                Coins.Add(quarter);
            }
        }
        private void AddDimesToWallet(int startingDimes)
        {
            for (int i = 0; i < startingDimes; i++)
            {
                Dime dime = new Dime();
                Coins.Add(dime);
            }
        }
        private void AddNickelsToWallet(int startingNickels)
        {
            for (int i = 0; i < startingNickels; i++)
            {
                Nickel nickel = new Nickel();
                Coins.Add(nickel);
            }
        }
        private void AddPenniesToWallet(int startingPennies)
        {
            for (int i = 0; i < startingPennies; i++)
            {
                Penny penny = new Penny();
                Coins.Add(penny);
            }
        }
    }
}
