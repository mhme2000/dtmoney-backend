using DtMoneyBackend.Application.DTOs;
using DtMoneyBackend.Application.Interfaces;
using DtMoneyBackend.Data.Interfaces;
using DtMoneyBackend.Entities;

namespace DtMoneyBackend.Application.Services;
public class TransactionService : ITransactionService
{
    private readonly ITransactionRepository _repository;
    public TransactionService(ITransactionRepository repository)
    {
        _repository = repository;
    }
    public void Add(TransactionDTO dto)
    {
        var model = new Transaction(dto.Title, dto.Value, dto.TransactionType, dto.Date, dto.CategoryId);
        _repository.Add(model);
        _repository.SaveChanges();
    }
}
