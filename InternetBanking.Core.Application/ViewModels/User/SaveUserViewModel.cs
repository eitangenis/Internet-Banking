using InternetBanking.Core.Application.Enums;
using System.ComponentModel.DataAnnotations;

namespace InternetBanking.Core.Application.ViewModels.User
{
    public class SaveUserViewModel
    {
        public string? Id { get; set; }

        [Required(ErrorMessage = "El {0} es requerido")]
        [Display(Name = "Name")]
        [DataType(DataType.Text)]
        public string? FirstName { get; set; }

        [Required(ErrorMessage = "El {0} es requerido")]
        [Display(Name = "Last Name")]
        [DataType(DataType.Text)]
        public string? LastName { get; set; }

        [Required(ErrorMessage = "El {0} es requerido")]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "El {0} es requerido")]
        [Display(Name = "ID Number")]
        [DataType(DataType.Text)]
        public string? IdNumber { get; set; }

        [Display(Name = "User Name")]
        [DataType(DataType.Text)]
        public string UserName { get; set; }

        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        [Compare(nameof(Password), ErrorMessage = "Don't match")]
        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        public string? ConfirmPassword { get; set; }

        [Display(Name = "User Type")]
        public Roles UserType { get; set; }

        [DataType(DataType.Currency)]
        [Display(Name = "Initial Amount")]
        public double? InitialAmount { get; set; }
        public bool? IsActive { get; set; }
        public bool HasError { get; set; }
        public string? Error { get; set; }
    }
}
