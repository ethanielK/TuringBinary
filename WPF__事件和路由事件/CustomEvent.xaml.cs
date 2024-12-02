using System.Windows;

namespace WPF__事件和路由事件
{
    /// <summary>
    /// CustomEvent.xaml 的交互逻辑
    /// </summary>
    public partial class CustomEvent : Window
    {
        public CustomEvent()
        {
            InitializeComponent();

            this.BaseGrid.AddHandler(TimeButton.ReportTimeEvent,new EventHandler<ReportTimeEventArgs>(BaseGrid_ReportTime));
        }

        private void BaseGrid_ReportTime(object sender, ReportTimeEventArgs e)
        {
            FrameworkElement element = sender as FrameworkElement;

            string timeStr = e.clickedTime.ToString();
            string content = string.Format("点击时间：{0}；元素：{1}", timeStr, element.Name);

            this.listBox.Items.Add(content);
        }
    }
}
