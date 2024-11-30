using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using WPF__数据校验与转换;

namespace WPF__数据转换
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        List<EmployeeSatisfaction> satisfactions = new List<EmployeeSatisfaction>()
        {
            new EmployeeSatisfaction(){ Name = "光头强", Satisfaction = SatisfactionType.Anxious },
            new EmployeeSatisfaction(){ Name = "超人强", Satisfaction = SatisfactionType.Nerd },
            new EmployeeSatisfaction(){ Name = "小玉", Satisfaction = SatisfactionType.Smiling },
            new EmployeeSatisfaction(){ Name = "牛战士", Satisfaction = SatisfactionType.Nerd },
            new EmployeeSatisfaction(){ Name = "老爹", Satisfaction = SatisfactionType.Sos },
        };

        public MainWindow()
        {
            InitializeComponent();
            initValidationBinding();

            //this.DataContext = satisfactions;

            this.lbSatisfaction.ItemsSource = satisfactions;
        }

        void initValidationBinding()
        {
            var binding = new Binding();
            binding.Source = this.slider;
            binding.Path = new PropertyPath("Value");

            // 添加自定义校验
            binding.ValidationRules.Add(new MySliderValidation() { ValidatesOnTargetUpdated = true });
            // 开启校验失败通知，默认是false
            binding.NotifyOnValidationError = true;

            // 添加校验失败事件
            this.txtSlider.AddHandler(Validation.ErrorEvent, new RoutedEventHandler(txtSlider_ErrorEvent));
            this.txtSlider.SetBinding(TextBox.TextProperty, binding);
        }
        private void txtSlider_ErrorEvent(object sender, RoutedEventArgs e)
        {
            var errors = Validation.GetErrors(txtSlider);

            if (errors.Count > 0)
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