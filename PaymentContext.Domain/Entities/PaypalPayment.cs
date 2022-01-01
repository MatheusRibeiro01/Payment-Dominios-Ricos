using PaymentContext.Domain.ValueObjects;
using Document = System.Reflection.Metadata.Document;

namespace PaymentContext.Domain.Entities;

public class PaypalPayment : Payment
{
    public PaypalPayment(DateTime paidDate, DateTime expireDate, decimal total, decimal totalPaid, string payer, 
        Document document, Adress adress, Email email, string transactionCode) 
        : base(paidDate, expireDate, total, totalPaid, payer, document, adress, email)
    {
        TransactionCode = transactionCode;
    }

    public string TransactionCode { get; private set; }
}