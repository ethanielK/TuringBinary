using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF__数据绑定
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Employee employee = new Employee() { Name = "Default Name" };
        public MainWindow()
        {
            InitializeComponent();        
        }

        private void btnSimpleBinding_Click(object sender, RoutedEventArgs e)
        {
            SimpleBinding simpleBinding = new SimpleBinding();
            simpleBinding.Show();
        }

        private void btnSliderDemo_Click(object sender, RoutedEventArgs e)
        {
            SliderDemo demo = new SliderDemo();
            demo.Show();
        }

        private void btnDataContext_Click(object sender, RoutedEventArgs e)
        {
            DataContext dataContext = new DataContext();
            dataContext.Show();
        }
    }
}