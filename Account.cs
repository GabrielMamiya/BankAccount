using System;
using System.Globalization;

namespace bankAccount
{
    public class Account
    {

        public int account { get; private set; }
        public string name { get; set; }
        public double saldo { get; private set; }

        public Account(int account, string name, double saldo)
        {
            this.account = account;
            this.name = name;
            this.saldo = saldo;
        }

        public Account(int account, string name){
            this.account = account;
            this.name = name;
            this.saldo = 0;
        }

        public void showNewClient(){
            Console.WriteLine();
            Console.WriteLine("Account has been created.");
            Console.WriteLine("Account: " + account);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Balance: " + saldo.ToString("F2", CultureInfo.InvariantCulture));
        }

        public void addMoney(double deposit){

            saldo += deposit;

            Console.WriteLine();
            Console.WriteLine("Account atualizada.");
            Console.WriteLine("Account: " + account);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Balance: " + saldo.ToString("F2", CultureInfo.InvariantCulture));
        }

        public void sacarMoney(double value){

            saldo = (saldo - value) - 5;

            Console.WriteLine();
            Console.WriteLine("Account atualizada.");
            Console.WriteLine("Account: " + account);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Balance: " + saldo.ToString("F2", CultureInfo.InvariantCulture));
            
        }
    }
}
