using System;
using System.Collections.Generic;

namespace Exercise_ContractsPayment.Services
{
    interface IOnlinePaymentService
    {
        public double PaymentFee(double amount);
        public double Interest(double amount, int months);
    }
}
