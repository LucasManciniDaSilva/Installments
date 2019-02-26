using System;
namespace Installments.Entities
{
    public class Installment
    {

        //DEFINED THE VARIABLES
        public DateTime DueDate { get; private set; }
        public double Amount { get; private set; }

        //CREATE A CONSTRUCTOR WITH ARGUMENTS
        public Installment(DateTime dueDate, double amount)
        {
            DueDate = dueDate;
            Amount = amount;
        }
        //CONVERTED THE CLASS INTO A STRING
        public override string ToString()
        {
            return  DueDate.ToString("dd/MM/yyyy")
                   + ", "
                   + Amount;

        }
    }
}
