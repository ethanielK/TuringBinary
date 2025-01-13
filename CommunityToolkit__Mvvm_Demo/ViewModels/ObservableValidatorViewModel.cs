using System.ComponentModel.DataAnnotations;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace CommunityToolkit__Mvvm_Demo.ViewModels
{
    public partial class ObservableValidatorViewModel : ObservableValidator
    {
        [ObservableProperty]
        [Range(1, 168)]
        [Required]
        private int _age;

        partial void OnAgeChanged(int value)
        {
            ValidateProperty(value, nameof(Age));
        }

        [ObservableProperty]
        [Required]
        [EmailAddress]
        private string _email;

        [ObservableProperty]
        private string? errMessage;

        [RelayCommand]
        void Submit()
        {
            ValidateAllProperties();

            ErrMessage= HasErrors ? string.Join(Environment.NewLine,GetErrors().Select(e=> e.ErrorMessage)) : "No error occurred.";
        }
    }
}
