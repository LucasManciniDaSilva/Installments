using System;
using Installments.Entities;
namespace Installments.Services
{
    public class ContractService
    {

        //INSTANTIADED AN INTERFACE
        private IOnlinePaymentService _onlinePaymentService;

        //CONSTRUCTOR OF THE INTERFACE
        public ContractService(IOnlinePaymentService onlinePaymentService)
        {
            _onlinePaymentService = onlinePaymentService;
        }

        //CREATED A METHOD TO CALCULATE THE QUOTAS
        public void ProcessContract(Contract contract, int months)
        {
            double quota = contract.TotalValue / months;

            for(int i=1; i<= months; i++)
            {
                DateTime date = contract.Date.AddMonths(i);
                double updateQuota = quota + _onlinePaymentService.Interest(quota, i);
                double fullQuota = updateQuota + _onlinePaymentService.PaymentFee(updateQuota);
                contract.AddInstallments(new Installment(date, fullQuota));




            }
        }
    }
}
