using System.Windows;

namespace WPF__事件和路由事件
{
    public class ReportTimeEventArgs : RoutedEventArgs
    {
        public ReportTimeEventArgs(RoutedEvent routedEvent, object source) : base(routedEvent, source)
        {}

        public DateTime clickedTime { get; set; }
    }
}
