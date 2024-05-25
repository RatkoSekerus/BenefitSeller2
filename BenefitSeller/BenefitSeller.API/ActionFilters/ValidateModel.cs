using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace BenefitSeller.API.ActionFilters
{
    /// <summary>
    /// Action filter attribute for validating model state.
    /// </summary>
    public class ValidateModel: ActionFilterAttribute
    {
        /// <summary>
        /// Called before the action method starts executing
        /// </summary>
        /// <param name="context">The context for the action.</param>
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            if (!context.ModelState.IsValid) 
            {
                context.Result = new BadRequestResult();
            }
        }
    }
}
