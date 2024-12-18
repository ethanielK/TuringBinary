using System.Windows.Input;

namespace CustomCommandMVVM.Command
{
    public partial class ClearColorCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            IColorable colorable = parameter as IColorable; // 方法接收一个参数，这个参数被期望为 IColorable 接口的对象
            if (colorable != null)
            {
                colorable.ClearColor();
            }
        }
    }
}
