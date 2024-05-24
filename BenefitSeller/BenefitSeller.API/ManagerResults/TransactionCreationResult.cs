namespace BenefitSeller.API.ManagerResults
{
    /// <summary>
    /// Represents the result of a transaction creation operation.
    /// </summary>
    public class TransactionCreationResult
    {
        /// <summary>
        /// Gets or sets a value indicating whether the transaction creation operation was successful.
        /// </summary>
        public bool IsSuccess { get; set; }

        /// <summary>
        /// Gets or sets the error message if the transaction creation operation failed.
        /// </summary>
        public string ResponseMessage { get; set; }
    }
}
