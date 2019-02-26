using System;
using System.Globalization;
using Installments.Entities;
using Installments.Services;

namespace Installments
{
    class Program
    {
        static void Main(string[] args)
        {

            //CREATED THE INTERACTION WITH THE USER
            Console.WriteLine("Enter the contract: ");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contract Value: ");
            double contract = double.Parse(Console.ReadLine());
            Console.Write("Enter the numbers of installments: ");
            int months = int.Parse(Console.ReadLine());

            Contract myContract = new Contract(number, date, contract);
            ContractService contractService = new ContractService(new PaypalService());


            contractService.ProcessContract(myContract, months);


            Console.WriteLine("Installments: ");
            foreach (Installment installment in myContract.Installment)
            {
                Console.WriteLine(installment);
            }


        }
    }
}
