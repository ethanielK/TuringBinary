using System.ComponentModel.DataAnnotations;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit__Mvvm_Demo.Properties;

namespace CommunityToolkit__Mvvm_Demo.ViewModels
{
    public partial class ObservableValidatorViewModel : ObservableValidator
    {
        [ObservableProperty]
        [Range(1, 168)]
        [Required]
        //[RegularExpression("dddd")]
        private int _age;

        partial void OnAgeChanged(int value)
        {
            ValidateProperty(value, nameof(Age));   // 前台校验
        }

        [ObservableProperty]
        [Required(ErrorMessageResourceName = "EmptyEmailError", ErrorMessageResourceType = typeof(Lang))]
        [EmailAddress(ErrorMessageResourceName = "EmailError", ErrorMessageResourceType = typeof(Lang))]
        private string _email;

        [ObservableProperty]
        private string? errMessage;

        [RelayCommand]
        void Submit()
        {
            ValidateAllProperties();    // 后台校验

            ErrMessage= HasErrors ? string.Join(Environment.NewLine,GetErrors().Select(e=> e.ErrorMessage)) : "No error occurred.";
        }
    }
}
