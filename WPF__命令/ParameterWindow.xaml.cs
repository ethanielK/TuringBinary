using System.Windows;
using System.Windows.Input;

namespace WPF__命令
{
    /// <summary>
    /// ParameterWindow.xaml 的交互逻辑
    /// </summary>
    public partial class ParameterWindow : Window
    {
        public ParameterWindow()
        {
            InitializeComponent();
        }

        private void CommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if(string.IsNullOrEmpty(this.txtName.Text))
            {
                e.CanExecute = false;
            }
            else
            {
                e.CanExecute = true;
            }
        }

        private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            string name = this.txtName.Text;
            if (e.Parameter.Equals("Teacher"))
            {
                this.listBox.Items.Add(string.Format("New teacher:{0}, 学而不厌，诲人不倦", name));
            }
            else {
                this.listBox.Items.Add(string.Format("New student:{0}, 好好学习，天天向上", name));
            }

            this.txtName.Clear();

            e.Handled = true;
        }
    }
}
