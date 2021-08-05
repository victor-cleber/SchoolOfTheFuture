using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using School.Api.Models;
using System.Linq;

namespace School.Api.Filters {
    public class ValidateCusomisedModelState:ActionFilterAttribute {

        public override void OnResultExecuting(ResultExecutingContext context) {
            if (!context.ModelState.IsValid) {
                var validateFielViewModel = new ValidateFieldsViewModelOutput(context.ModelState.SelectMany(sm => sm.Value.Errors).Select(s => s.ErrorMessage));

                context.Result = new BadRequestObjectResult(validateFielViewModel);
                 
                }
            }
        }
    }

