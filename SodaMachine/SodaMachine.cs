using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class SodaMachine
    {
        //Member Variables (Has A)
        private List<Coin> _register;
        private List<Can> _inventory;

        //Constructor (Spawner)
        public SodaMachine()
        {
            _register = new List<Coin>();
            _inventory = new List<Can>();

            FillRegister();
            FillInventory();
        }

        //Member Methods (Can Do)

        //A method to fill the sodamachines register with coin objects.
        public void FillRegister()
        {
            AddQuartersToRegister(20);
            AddDimesToRegister(10);
            AddNickelsToRegister(20);
            AddPenniesToRegister(50);
        }

        private void AddQuartersToRegister(int startingQuaters)
        {
            for (int i = 0; i < startingQuaters; i++)
            {
                Quarter quarter = new Quarter();
                _register.Add(quarter);
            }
        }

        private void AddDimesToRegister(int startingDimes)
        {
            for (int i = 0; i < startingDimes; i++)
            {
                Dime dime = new Dime();
                _register.Add(dime);
            }
        }

        private void AddNickelsToRegister(int startingNickels)
        {
            for (int i = 0; i < startingNickels; i++)
            {
                Nickel nickel = new Nickel();
                _register.Add(nickel);
            }
        }

        private void AddPenniesToRegister(int startingPennies)
        {
            for (int i = 0; i < startingPennies; i++)
            {
                Penny penny = new Penny();
                _register.Add(penny);
            }
        }

        //A method to fill the sodamachines inventory with soda can objects.
        public void FillInventory()
        {
            FillRootBeer(5);
            FillCola(3);
            FillOrangeSoda(1);
        }

        private void FillRootBeer(int startingRootBeer)
        {
            for (int i = 0; i < startingRootBeer; i++)
            {
                RootBeer rootBeer = new RootBeer();
                _inventory.Add(rootBeer);
            }
        }

        private void FillCola(int startCola)
        {
            for (int i = 0; i < startCola; i++)
            {
                Cola cola = new Cola();
                _inventory.Add(cola);
            }
        }

        private void FillOrangeSoda(int startingOrangeSoda)
        {
            for (int i = 0; i < startingOrangeSoda; i++)
            {
                OrangeSoda orangeSoda= new OrangeSoda();
                _inventory.Add(orangeSoda);
            }
        }

        //Method to be called to start a transaction.
        //Takes in a customer which can be passed freely to which ever method needs it.
        public void BeginTransaction(Customer customer)
        {
            bool willProceed = UserInterface.DisplayWelcomeInstructions(_inventory);
            if (willProceed)
            {
                Transaction(customer);
            }
        }
        
        //This is the main transaction logic think of it like "runGame".  This is where the user will be prompted for the desired soda.
        //grab the desired soda from the inventory.
        //get payment from the user.
        //pass payment to the calculate transaction method to finish up the transaction based on the results.
        private void Transaction(Customer customer)
        {
            //display list of sodas available
            string selectedSoda = UserInterface.SodaSelection(_inventory);
            GetSodaFromInventory(selectedSoda);
            //move to payment method 
            UserInterface.CoinSelection(selectedSoda, );

            //magical stuff to calculate the actual purchase. add/remove coins/cans to/from soda machine register and customer/backback
        }
        //Gets a soda from the inventory based on the name of the soda.
        private Can GetSodaFromInventory(string nameOfSoda)
        {
            //stage soda to be removed from _inventory to be removed after successful payment _inventory.Remove(nameOfSoda);
            
            

            RootBeer notActualValue = new RootBeer();
            return notActualValue;
        }

        //This is the main method for calculating the result of the transaction.
        //It takes in the payment from the customer, the soda object they selected, and the customer who is purchasing the soda.
        //This is the method that will determine the following:
        //If the payment is greater than the price of the soda, and if the sodamachine has enough change to return: Dispense soda, and change to the customer.
        //If the payment is greater than the cost of the soda, but the machine does not have ample change: Dispense payment back to the customer.
        //If the payment is exact to the cost of the soda:  Dispense soda.
        //If the payment does not meet the cost of the soda: dispense payment back to the customer.
        private void CalculateTransaction(List<Coin> payment, Can chosenSoda, Customer customer)
        {
           
        }
        //Takes in the value of the amount of change needed.
        //Attempts to gather all the required coins from the sodamachine's register to make change.
        //Returns the list of coins as change to despense.
        //If the change cannot be made, return null.
        private List<Coin> GatherChange(double changeValue)
        {
            List<Coin> changeCoins = null;
            while (changeValue > 0)
            {
                if (changeValue > 0.25)
                {
                    Coin quarter = GetCoinFromRegister("Quarter");
                    changeCoins.Add(quarter);
                    changeValue -= .25;
                }
                else if (changeValue >= .10)
                {
                    Coin dime = GetCoinFromRegister("Dime");
                    changeCoins.Add(dime);
                    changeValue -= .10;
                }
                else if (changeValue >= .05)
                {
                    Coin nickel = GetCoinFromRegister("Nickel");
                    changeCoins.Add(nickel);
                    changeValue -= .05;
                }
                else if (changeValue >= 0)
                {
                    Coin penny = GetCoinFromRegister("Penny");
                    changeCoins.Add(penny);
                    changeValue -= .01;
                }
            }
            return changeCoins;
        }
        //Reusable method to check if the register has a coin of that name.
        //If it does have one, return true.  Else, false.
        private bool RegisterHasCoin(string name)
        {
            bool notActualValue = true;
            return notActualValue;
        }
        //Reusable method to return a coin from the register.
        //Returns null if no coin can be found of that name.
        private Coin GetCoinFromRegister(string name)
        {
            Coin notActualValue = new Coin();
            return notActualValue;
        }
        //Takes in the total payment amount and the price of can to return the change amount.
        private double DetermineChange(double totalPayment, double canPrice)
        {
            double notActualValue = 0;
            return notActualValue;
        }
        //Takes in a list of coins to return the total value of the coins as a double.
        private double TotalCoinValue(List<Coin> payment)
        {
            double notActualValue = 0;
            return notActualValue;
        }
        //Puts a list of coins into the soda machines register.
        private void DepositCoinsIntoRegister(List<Coin> coins)
        {
            for (int i = 0; i < coins.Count; i++)
            {
                _register.Add(coins[i]);
            }
        }
    }
}
