namespace PaymentContext.Domain.Entities;

public class PaypalPayment : Payment
{
    public PaypalPayment(DateTime paidDate, DateTime expireDate, decimal total, decimal totalPaid, string payer, string document, string adress, string email, string transactionCode) : base(paidDate, expireDate, total, totalPaid, payer, document, adress, email)
    {
        TransactionCode = transactionCode;
    }

    public string TransactionCode { get; private set; }
}