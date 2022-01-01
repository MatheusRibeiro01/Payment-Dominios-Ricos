using PaymentContext.Domain.ValueObjects;
using Document = System.Reflection.Metadata.Document;

namespace PaymentContext.Domain.Entities;

public class BoletoPayment : Payment
{
    public BoletoPayment(DateTime paidDate, DateTime expireDate, decimal total, decimal totalPaid, string payer, 
        Document document, Adress adress, Email email, string barCode, string boletoNumber) 
        : base(paidDate, expireDate, total, totalPaid, payer, document, adress, email)
    {
        BarCode = barCode;
        BoletoNumber = boletoNumber;
    }

    public string BarCode { get; private set; }
    public string BoletoNumber { get; private set; }
}