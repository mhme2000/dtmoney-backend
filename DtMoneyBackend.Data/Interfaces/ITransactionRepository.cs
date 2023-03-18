using DtMoneyBackend.Entities;

namespace DtMoneyBackend.Data.Interfaces;
public interface ITransactionRepository
{
    void Add(Transaction model);
    void SaveChanges();
}
