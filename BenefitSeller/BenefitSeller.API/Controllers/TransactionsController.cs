using BenefitSeller.API.ActionFilters;
using BenefitSeller.API.Contracts.ManagerInterfaces;
using BenefitSeller.API.ManagerResults;
using BenefitSeller.API.Models.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BenefitSeller.API.Controllers
{
    /// <summary>
    /// Controller responsible for handling transactions.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionsController : ControllerBase
    {
        #region Private fields
        ITransactionsManager _transactionsManager;
        #endregion

        #region constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionsController"/> class.
        /// </summary>
        /// <param name="transactionsManager">The transactions manager service.</param>
        public TransactionsController(ITransactionsManager transactionsManager)
        {
            this._transactionsManager = transactionsManager;
        }
        #endregion

        #region Action methods
        /// <summary>
        /// Retrieves transactions associated with the specified user.
        /// </summary>
        /// <param name="userId">The unique identifier of the user.</param>
        /// <param name="filterFailed">Set to true to include only failed transactions.</param>
        /// <param name="pageNumber">The page number for pagination (default is 1).</param>
        /// <param name="pageSize">The page size for pagination (default is 100).</param>
        /// <returns>An HTTP response containing the list of transactions.</returns>
        [HttpGet]
        [Route("user/{userId:int}")]
        public async Task<IActionResult> GetAllByUserId([FromRoute] int userId, [FromQuery] bool? filterFailed,
            [FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 100)
        {
            var res = await _transactionsManager.GetAllByUserId(userId, filterFailed, pageNumber, pageSize);
            return Ok(res);
        }

        /// <summary>
        /// Creates a new transaction
        /// </summary>
        /// <param name="transaction">Transaction model</param>
        /// <returns>An HTTP response indicating the status of the transaction creation.</returns>
        [HttpPost]
        [ValidateModel]
        public async Task<IActionResult> Create([FromBody] TransactionViewModel transaction)
        {
                TransactionResult res = await _transactionsManager.CreateAsync(transaction);
                return res.IsSuccess ? Ok(res) : BadRequest(res);
        }
        #endregion
    }
}
