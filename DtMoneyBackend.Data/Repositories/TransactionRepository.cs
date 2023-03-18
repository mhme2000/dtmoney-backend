using DtMoneyBackend.Entities;

namespace DtMoneyBackend.Data.Interfaces;
public class TransactionRepository : ITransactionRepository
{
    public readonly DtMoneyBackendContext _context;
    public TransactionRepository(DtMoneyBackendContext context)
    {
        _context = context;
    }
    public void Add(Transaction model)
    {
        _context.Transaction.Add(model);
    }
    public void SaveChanges()
    {
        _context.SaveChanges();
    }
}
