using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace CommunityToolkit__Mvvm_Demo.ViewModels
{
    public partial class MainWindowViewModel : ObservableObject
    {
        [ObservableProperty]
        private int age = 18;

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(FullName))]
        private string firstName = "Stank";

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(FullName))]
        private string secondName = "Tony";

        public string FullName => $"{SecondName}·{FirstName}";

        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(ChangeAgeCommand))]
        private bool canChangeAge = false;

        [RelayCommand(CanExecute = nameof(CanChangeAge))]
        void ChangeAge()
        {
            Age = 20;
        }

        [RelayCommand]
        void RestoreInfomation()
        {
            Age = 18;
        }
    }
}
