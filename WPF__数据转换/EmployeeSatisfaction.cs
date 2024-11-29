using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF__数据校验与转换
{
    public class EmployeeSatisfaction
    {
        public string Name { get; set; }
        public Satisfaction SatisfactionFromEmployee { get; set; }
    }

    public enum Satisfaction
    {
        Anxious,
        Cold,
        Nerd,
        Smiling,
        Sos
    };
}
