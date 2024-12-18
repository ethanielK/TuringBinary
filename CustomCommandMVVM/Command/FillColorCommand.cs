using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace CustomCommandMVVM.Command
{
    public partial class FillColorCommand : ICommand
    {
        private string hexColor;

        public string HexColor
        {
            get { return hexColor; }
            set { hexColor = value; }
        }

        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            if (parameter is string parameterStr)   // 模式匹配，判断并解构为 string 类型
            {
                return parameterStr.StartsWith("#") && parameterStr.Length == 7;
            }
            return false;
        }

        public void Execute(object? parameter)
        {
            if (parameter is string parameterStr)
            {
                HexColor = parameterStr;
                IColorable colorable = parameter as IColorable;
                if (colorable != null)
                {
                    try
                    {
                        Color color = (Color)ColorConverter.ConvertFromString(HexColor);
                        colorable.FillColor(color);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("不合法的 Hex 值", "Invalid color string.", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
            }
        }
    }
}
