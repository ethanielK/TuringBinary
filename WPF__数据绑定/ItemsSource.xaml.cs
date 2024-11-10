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
    /// ItemsSource.xaml 的交互逻辑
    /// </summary>
    public partial class ItemsSource : Window
    {
        public ItemsSource()
        {
            InitializeComponent();
            InitItemList();
        }

        private void InitItemList()
        {
            var employeeList = new List<Employee>()
            {
                new Employee() {Id =1,Name = "Employee 1" ,Level =0},
                new Employee() {Id =2,Name = "Employee 2" ,Level =1},
                new Employee() {Id =3,Name = "Employee 3" ,Level =2},
                new Employee() {Id =4,Name = "Employee 4" ,Level =3},
                new Employee() {Id =5,Name = "Employee 5" ,Level =4},
                new Employee() {Id =6,Name = "Employee 6" ,Level =5},
            };

            
            this.employeeListBox.ItemsSource = employeeList;
            //this.employeeListBox.ItemsSource = employeeList.Where(x => x.Level % 2 == 0); // 使用 LINQ 查询结果做数据源

            //this.employeeListBox.DisplayMemberPath = "Name";  // 无法同时设置 DisplayMemberPath 和 ItemTemplate。
        }
    }
}
