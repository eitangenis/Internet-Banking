using System.ComponentModel.DataAnnotations;

namespace InternetBanking.Core.Application.Enums
{
    public enum ProductType
    {
        [Display(Name = "Savings account")]
         SavingAccount = 1,
        [Display(Name = "Credit card")]
         CreditCard,
        [Display(Name = "Loan")]
         Loan
    }
}
