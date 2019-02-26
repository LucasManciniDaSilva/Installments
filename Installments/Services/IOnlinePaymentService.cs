using System;
namespace Installments.Services
{
    public interface IOnlinePaymentService
    {
        //DEFINED THE METHODS OF INTERFACE
        double PaymentFee(double amount);
        double Interest(double amount, int months);
       
    }
}
