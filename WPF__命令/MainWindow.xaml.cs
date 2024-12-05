using System.Windows;
using System.Windows.Input;

namespace WPF__命令
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.InitializeCommand();
        }

        // 声明并定义命令
        private RoutedCommand clearCmd = new RoutedCommand("Clear",typeof(MainWindow));

        // 声明命令初始化的方法，包括命令赋值、命令关联等
        private void InitializeCommand()
        {
            // 为命令额外添加快捷键触发方式
            this.clearCmd.InputGestures.Add(new KeyGesture(Key.C, ModifierKeys.Alt));

            // 为命令源指定命令和目标
            this.btnCommand.Command = this.clearCmd;
            this.btnCommand.CommandTarget = this.textBox;

            // 创建命令关联
            // ①创建实例
            CommandBinding cb = new CommandBinding();
            // ②指定命令
            cb.Command = this.clearCmd;
            // ③将CanExecute和Execute订阅相应的事件处理程序
            cb.CanExecute += new CanExecuteRoutedEventHandler(cb_CanExecute);
            cb.Executed += new ExecutedRoutedEventHandler(cb_Execute);

            // 设置命令关联的位置
            this.stackPanel.CommandBindings.Add(cb);
        }

        // 判断事件是否可执行的事件处理器
        private void cb_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if(string.IsNullOrEmpty(this.textBox.Text))
            {
                e.CanExecute= false;
            }
            else
            {
                e.CanExecute= true;
            }

            //避免向上继续执行而降低性能
            e.Handled= true;
        }

        // 命令到达目标后要执行的事件处理器
        private void cb_Execute(object sender, ExecutedRoutedEventArgs e)
        {
            this.textBox.Clear();

            //避免向上继续执行而降低性能
            e.Handled = true;
        }
    }
}