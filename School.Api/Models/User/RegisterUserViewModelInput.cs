using System.ComponentModel.DataAnnotations;

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
