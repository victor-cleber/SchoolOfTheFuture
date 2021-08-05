using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School.Api.Models {
    public class ValidateFieldsViewModelOutput {
                
        public IEnumerable<string> Errors {
            get;
            private set;
        }

        public ValidateFieldsViewModelOutput(IEnumerable<string> errors) {
            Errors = errors;
        }
    }
}
