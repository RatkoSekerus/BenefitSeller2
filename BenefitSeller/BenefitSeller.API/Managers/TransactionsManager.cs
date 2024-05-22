using AutoMapper;
using BenefitSeller.API.Contracts;
using BenefitSeller.API.Models;
using BenefitSeller.API.ViewModels;

namespace BenefitSeller.API.Managers
{
    public class TransactionsManager : ITransactionsManager
    {
        private readonly ITransactionsRepository _repository;
        private readonly IMapper _mapper;
        public TransactionsManager(ITransactionsRepository repository, IMapper mapper)
        {
            this._repository = repository;
            this._mapper = mapper;
        }
        public async Task<List<Transaction>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<bool> CreateAsync(TransactionViewModel transactionViewModel) {
            
            Transaction transaction = _mapper.Map<Transaction>(transactionViewModel);
            Transaction res = await _repository.CreateAsync(transaction);

        }
    }
}
