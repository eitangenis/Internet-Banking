using InternetBanking.Core.Application.Enums;
using System.ComponentModel.DataAnnotations;

namespace InternetBanking.Core.Application.ViewModels.Payment
{
    public class PaymentViewModel
    {
        public int? Id { get; set; }

        [Display(Name = "Origin account")]
        public string SourceAccountNumber { get; set; }

        [Display(Name = "Destination account")]
        public string DestinationAccountNumber { get; set; }

        [Display(Name = "Amount")]
        public double Amount { get; set; }
        public PaymentType PaymentType { get; set; }
    }
}
