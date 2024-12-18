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
            InitializeCommand();
        }

        // 声明并定义命令
        private RoutedCommand clearCmd = new RoutedCommand("Clear",typeof(MainWindow));

        // 声明命令初始化的方法，包括命令赋值、命令关联等
        private void InitializeCommand()
        {
            // 把命令赋值给命令源（发送者）并指定快捷键
            this.btnCommand.Command = this.clearCmd;
            this.clearCmd.InputGestures.Add(new KeyGesture(Key.C, ModifierKeys.Alt));

            // 为命令源指定命令目标
            this.btnCommand.CommandTarget = this.textBox;

            // 创建命令关联
            CommandBinding cb = new CommandBinding();
            cb.Command = this.clearCmd; // 只关注与clearCmd相关的事件
            // 订阅相应的事件处理程序
            cb.CanExecute += new CanExecuteRoutedEventHandler(cb_CanExecute);
            cb.Executed += new ExecutedRoutedEventHandler(cb_Execute);

            // 把命令安置在外围控件，设置命令关联的位置
            this.stackPanel.CommandBindings.Add(cb);
        }

        // CanExecuteRoutedEventHandler 事件处理器，判断事件是否可执行
        private void cb_CanExecute(object sender, CanExecuteRoutedEventArgs e)  // 当需要判断事件是否可执行时,此事件被调用
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

        // ExecutedRoutedEventHandler 事件处理器，执行事件
        // 命令到达目标后要执行的事件处理器
        private void cb_Execute(object sender, ExecutedRoutedEventArgs e)
        {
            this.textBox.Clear();

            //避免向上继续执行而降低性能
            e.Handled = true;
        }
    }
}