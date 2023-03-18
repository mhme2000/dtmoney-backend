using DtMoneyBackend.Entities;

namespace DtMoneyBackend.Application.DTOs;
public class TransactionDTO
{
    public int TransactionId { get; set; }
    public string Title { get; set; }
    public decimal Value { get; set; }
    public int CategoryId { get; set; }
    public DateTime Date { get; set; }
    public EnumTransactionType TransactionType { get; set; }
}
