using System.Windows;

namespace WPF__基本绘图与动画
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            BrushWindow brushWindow = new BrushWindow();
            brushWindow.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ShapeWindow shapeWindow = new ShapeWindow();
            shapeWindow.Show();
        }
    }
}