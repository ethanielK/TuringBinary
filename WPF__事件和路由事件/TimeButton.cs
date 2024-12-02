using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WPF__事件和路由事件
{
    public class TimeButton : Button
    {
        // 声明路由事件

        public static readonly RoutedEvent ReportTimeEvent =
            EventManager.RegisterRoutedEvent(
                "Report Time",  // 事件名称
                RoutingStrategy.Bubble, // 事件路由策略
                typeof(EventHandler<ReportTimeEventArgs>),  // 事件处理程序类型
                typeof(TimeButton));    // 事件类型拥有者

        // 定义路由事件 （CLR事件包装器）
        public event RoutedEventHandler ReportTime
        {
            add { this.AddHandler(ReportTimeEvent, value); }
            remove { this.RemoveHandler(ReportTimeEvent, value); }
        }

        // 重写点击事件
        protected override void OnClick()
        {
            base.OnClick();

            ReportTimeEventArgs args = new ReportTimeEventArgs(ReportTimeEvent, this);
            args.clickedTime = DateTime.Now;

            this.RaiseEvent(args);
        }
    }
}
