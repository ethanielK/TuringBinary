using System.Windows;
using System.Windows.Controls;

namespace WPF__事件和路由事件
{
    /// <summary>
    /// ResponseModel.xaml 的交互逻辑
    /// </summary>
    public partial class ResponseModel : Window
    {
        public ResponseModel()
        {
            InitializeComponent();

            this.LeftCanvas.AddHandler(Button.ClickEvent, new RoutedEventHandler(this.Button_Clicked));
            this.baseGrid.AddHandler(Button.ClickEvent, new RoutedEventHandler(this.Button_Clicked));
        }

        private void Button_Clicked(object sender, RoutedEventArgs e)
        {
            //Button? button = (Button?)sender;   // Exception : Unable to cast object of type 'Canvas' to type 'Button'
            Button? button = e.OriginalSource as Button;
            if (button != null)
            {
                MessageBox.Show("You clicked on Button: " + button.Content);
                e.Handled = true;
            }
        }
    }
}
