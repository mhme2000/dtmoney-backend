using System.ComponentModel;

namespace DtMoneyBackend.Entities;
public class Transaction
{
    private Transaction() { }
    public Transaction(string title, decimal value, EnumTransactionType transactionType, DateTime date, int categoryId)
    {
        Title = title;
        Value = value;
        TransactionType = transactionType;
        Date = date;
        InTrash = false;
        CategoryId = categoryId;
    }

    public int TransactionId { get; private set; }
    public string Title { get; private set; }
    public decimal Value { get; private set; }
    public int CategoryId { get; private set; }
    public EnumTransactionType TransactionType { get; private set; }
    public DateTime Date { get; private set; }
    public DateTime DeletedDate { get; private set; }
    public bool InTrash { get; private set; }
    public Category Category { get; set; }

    public void SendToTrash()
    {
        DeletedDate = DateTime.Now;
        InTrash = true;
    }
}
public enum EnumTransactionType
{
    [Description("Entrada")]
    Income = 1,
    [Description("Saída")]
    Outcome = 2
}
