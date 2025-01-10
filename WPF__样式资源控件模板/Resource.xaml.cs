using System.Windows;
using System.Windows.Media;

namespace WPF__样式资源控件模板
{
    /// <summary>
    /// Resource.xaml 的交互逻辑
    /// </summary>
    public partial class Resource : Window
    {
        public Resource()
        {
            InitializeComponent();
        }

        private void btnChangeColor1_Click(object sender, RoutedEventArgs e)
        {
            this.Resources["PresentColor1"] = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#89c26e"));
        }

        private void btnChangeColor2_Click(object sender, RoutedEventArgs e)
        {
            LinearGradientBrush brush = new LinearGradientBrush()   // 对象初始化器
            {
                StartPoint = new Point(0, 0),
                EndPoint = new Point(1, 1),
                GradientStops = new GradientStopCollection
                {
                    new GradientStop{Offset =0,Color = (Color)ColorConverter.ConvertFromString("#f02fc2")},
                    new GradientStop{Offset =1,Color = (Color)ColorConverter.ConvertFromString("#6094ea")}
                }
            };
            this.Resources["PresentColor2"] = brush;
        }
    }
}
