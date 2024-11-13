using InternetBanking.Core.Application.Enums;
using InternetBanking.Core.Application.ViewModels.Beneficiary;
using InternetBanking.Core.Application.ViewModels.Product;
using System.ComponentModel.DataAnnotations;

namespace InternetBanking.Core.Application.ViewModels.Payment
{
    public class SavePaymentViewModel
    {
        public int? Id { get; set; }

        [Display(Name = "Origin account")]
        public string SourceAccountNumber { get; set; }

        [Display(Name = "Destination account")]
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "The field {0} is required")]
        public string DestinationAccountNumber { get; set; }

        [Display(Name = "Amount")]
        [DataType(DataType.Currency)]
        public double Amount { get; set; }
        public PaymentType PaymentType { get; set; }
        public bool HasError { get; set; }
        public string? Error { get; set; }
        public List<ProductViewModel>? Products { get; set; }
        public List<ProductViewModel>? CreditCardsProducts { get; set; }
        public List<ProductViewModel>? LoanProducts { get; set; }
        public List<BeneficiaryViewModel>? Beneficiaries { get; set; }
    }
}
