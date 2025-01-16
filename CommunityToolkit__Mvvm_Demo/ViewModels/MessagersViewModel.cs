using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;

namespace CommunityToolkit__Mvvm_Demo.ViewModels
{
    public partial class MessagersViewModel : ObservableObject
    {
        [ObservableProperty]
        private string _name = "Default Name";

        [RelayCommand]
        public void Submit()
        {
            WeakReferenceMessenger.Default.Send<NameMessage,string>(new NameMessage("Name has changed."),"tokenA");
        }

        [RelayCommand]
        public void SubmitWithTokenB()
        {
            WeakReferenceMessenger.Default.Send<NameMessage, string>(new NameMessage("Name has changed."), "tokenB");
        }

        public MessagersViewModel()
        {
            WeakReferenceMessenger.Default.Register<NameMessage,string>(this,"tokenB" ,(_, message) =>
            {
                Name = message.content;
            });
        }

        public record NameMessage(string content);
    }
}
