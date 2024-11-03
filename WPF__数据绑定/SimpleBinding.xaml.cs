using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPF__数据绑定
{
    /// <summary>
    /// SimpleBinding.xaml 的交互逻辑
    /// </summary>
    public partial class SimpleBinding : Window
    {
        Employee employee = new Employee() { Name = "Default Name" };
        public SimpleBinding()
        {
            InitializeComponent();

            Binding binding = new Binding()
            {
                Source = employee,
                Path = new PropertyPath("Name"),
                Mode = BindingMode.OneWay
            };
            this.txtName.SetBinding(TextBox.TextProperty, binding);
        }

        private void btnChangeName_Click(object sender, RoutedEventArgs e)
        {
            employee.Name = this.txtTempName.Text;
        }
    }
}
