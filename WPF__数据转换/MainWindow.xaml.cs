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
using WPF__数据校验与转换;

namespace WPF__数据转换
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            initValidationBinding();
        }

        void initValidationBinding()
        {
            var binding = new Binding();
            binding.Source = this.slider;
            binding.Path = new PropertyPath("Value");

            // 添加自定义校验
            binding.ValidationRules.Add(new MySliderValidation() { ValidatesOnTargetUpdated = true});
            // 开启校验失败通知，默认是false
            binding.NotifyOnValidationError = true; 
            
            // 添加校验失败事件
            this.txtSlider.AddHandler(Validation.ErrorEvent ,new RoutedEventHandler(txtSlider_ErrorEvent));
            this.txtSlider.SetBinding(TextBox.TextProperty, binding);
        }

        private void txtSlider_ErrorEvent(object sender, RoutedEventArgs e)
        {
            var errors = Validation.GetErrors(txtSlider);

            if(errors.Count > 0)
            {
                txtSlider.ToolTip = errors[0].ErrorContent as string;
            }

            //// 获取事件参数
            //var args = e as ValidationErrorEventArgs;
            //string error = args.Error.ErrorContent as string;
            //if (error != null) { 
            //    txtSlider.ToolTip = error;
            //}
        }
    }
}