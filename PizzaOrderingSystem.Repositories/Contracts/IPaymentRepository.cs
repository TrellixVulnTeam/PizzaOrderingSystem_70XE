﻿namespace ProjectAssignment.Repositories.Contracts
{
    public interface IPaymentRepository
    {
        bool Pay(double amount, string OrderId);
        void PaymentSuccessCallback(string transaction, string OrderId);
        void PaymentFailureCallback(string error, string OrderId);
        bool Refund(double amount, string OrderId);
        void RefundSuccessCallback(string transaction, string OrderId);
        void RefundFailureCallback(string error, string OrderId);

    }
}
