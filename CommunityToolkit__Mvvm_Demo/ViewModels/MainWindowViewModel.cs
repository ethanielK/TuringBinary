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
        void RestoreInformation()
        {
            Age = 18;
        }

        // TaskNotifier
        [ObservableProperty]
        private string? title = "TaskNotifier";

        private TaskNotifier? changeTitleTask;

        public Task? ChangeTitleRequest
        {
            get => changeTitleTask;
            set => SetPropertyAndNotifyOnCompletion(ref changeTitleTask, value);
        }

        [RelayCommand]
        private void ChangeTitle()
        {
            ChangeTitleRequest = Task.Run(async () =>
            {
                await Task.Delay(2000);
                Title = "图灵课程更新啦。";
            });
        }
    }
}
