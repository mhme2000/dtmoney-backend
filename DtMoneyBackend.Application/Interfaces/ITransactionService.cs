using DtMoneyBackend.Application.DTOs;

namespace DtMoneyBackend.Application.Interfaces;
public interface ITransactionService
{
    void Add(TransactionDTO dto);
}
