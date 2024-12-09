using System.Windows;

namespace WPF__样式模板深入
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

        private void btnTrigger_Click(object sender, RoutedEventArgs e)
        {
            TriggerWindow window = new TriggerWindow();
            window.Show();
        }

        private void btnMultiTrigger_Click(object sender, RoutedEventArgs e)
        {   
            MultiTriggerWindow window = new MultiTriggerWindow();
            window.Show();
        }
    }
}