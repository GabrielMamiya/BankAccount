using System;
using System.Globalization;

namespace bankAccount
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Account person1;

            Console.Write("Digite o numero da conta: ");
            int account = int.Parse(Console.ReadLine());
            Console.Write("Digite o nome do Titular da conta: ");
            string name = Console.ReadLine();
            Console.Write("Havera deposito inicial ? (S/N): ");
            char response = char.Parse(Console.ReadLine());

            if(response == 'S'){
                Console.Write("Digite o deposito inicial da conta: ");
                double saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                person1 = new Account(account, name, saldo);
                person1.showNewClient();
                Console.Write("Digite um valor para deposito: ");
                double deposit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                person1.addMoney(deposit);
                Console.Write("Digite um valor para saque: ");
                double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                person1.sacarMoney(value);
            } else if (response == 'N'){
                person1 = new Account(account, name);
                person1.showNewClient();
                Console.Write("Digite um valor para deposito: ");
                double deposit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                person1.addMoney(deposit);
                Console.Write("Digite um valor para saque: ");
                double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                person1.sacarMoney(value);
            }





        }
    }
}
