using System;
namespace Installments.Services
{
    public class PaypalService : IOnlinePaymentService
    {

        //DEFINED THE VARIABLES FOR THIS SERVICE
        private const double Interests = 0.01;
        private const double Fee = 0.02;


        //INTERFACE METHOD
        public double PaymentFee(double amount)
        {
            return amount * Fee;
        }

        //INTERFACE METHOD
        public double Interest(double amount, int months)
        {
            return amount * Interests * months;
        }
    }
}
