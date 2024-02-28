using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace DevFreela.API.Filters;

public class ValidationFilter : IActionFilter
{
    // depois da requisicao
    public void OnActionExecuting(ActionExecutingContext context)
    {
        
    }

    // antes da action
    public void OnActionExecuted(ActionExecutedContext context)
    {
        if (!context.ModelState.IsValid)
        {
            var messages = context.ModelState
                .SelectMany(ms => ms.Value.Errors)
                .Select(e => e.ErrorMessage)
                .ToList();

            context.Result = new BadRequestObjectResult(messages);
        }
    }
}