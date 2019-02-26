using System;
using System.Collections.Generic;
namespace Installments.Entities
{
    public class Contract
    {

        //DEFINED THE VARIABLES
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double TotalValue { get; set; }
        public List<Installment> Installment { get; set; }


        //CREATED THE CONSTRUCTOR WITH ARGUMENTS
        public Contract(int number, DateTime date, double totalValue)
        {
            Number = number;
            Date = date;
            TotalValue = totalValue;
            Installment = new List<Installment>();
        }

        //CREATED A METHOD TO ADD THE NUMBERS OF INSTALLMENTS
        public void AddInstallments(Installment installment)
        {
            Installment.Add(installment);
        }


    }
}
