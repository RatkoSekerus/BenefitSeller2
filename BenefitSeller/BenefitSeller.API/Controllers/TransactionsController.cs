using BenefitSeller.API.Contracts;
using BenefitSeller.API.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BenefitSeller.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionsController : ControllerBase
    {
        ITransactionsManager _transactionsManager;
        public TransactionsController(ITransactionsManager transactionsManager)
        {
            this._transactionsManager = transactionsManager;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var res = await _transactionsManager.GetAllAsync();
            return Ok(res);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] TransactionViewModel transaction)
        {
            bool res = await _transactionsManager.CreateAsync(transaction);
            return res ? Ok(res) : BadRequest();
        }
    }
}
