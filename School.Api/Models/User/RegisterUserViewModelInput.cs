using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace School.Api.Models {
    public class RegisterUserViewModelInput {
        [Required(ErrorMessage = "*")]
            public string Login{
            get; set;
        }
        [Required(ErrorMessage = "*")]
            public string Email{
            get; set;
        }

        [Required(ErrorMessage = "*")]
            public string Password {
            get; set;
        }
    }
}
