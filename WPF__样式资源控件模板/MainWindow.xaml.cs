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

namespace WPF__样式资源控件模板
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

        private void btnResource_Click(object sender, RoutedEventArgs e)
        {
            Resource resource = new Resource();
            resource.Show();
        }

        private void btnFontResource_Click(object sender, RoutedEventArgs e)
        {
            FontResource resource = new FontResource();
            resource.Show();
        }

        private void btnStyle_Click(object sender, RoutedEventArgs e)
        {
            Style style = new Style();
            style.Show();
        }

        private void btnControlTemplate_Click(object sender, RoutedEventArgs e)
        {
            ControlTemplate controlTemplate = new ControlTemplate();
            controlTemplate.Show();
        }
    }
}