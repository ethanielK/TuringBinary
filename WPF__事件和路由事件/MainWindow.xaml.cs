using System.Windows;

namespace WPF__事件和路由事件
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnModel_Click(object sender, RoutedEventArgs e)
        {
            ResponseModel model = new ResponseModel();
            model.Show();
        }

        private void btnEvent_Click(object sender, RoutedEventArgs e)
        {
            CustomEvent customEvent = new CustomEvent();
            customEvent.Show();
        }
    }
}