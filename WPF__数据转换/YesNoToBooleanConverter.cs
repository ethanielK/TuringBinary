using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace WPF__数据校验与转换
{
    class YesNoToBooleanConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            //throw new NotImplementedException();
            switch(value.ToString().ToLower())
            {
                case "yes":
                case "ok":
                case "copy":
                    return true;
                case "no":
                case "nope":
                    return false;
                default:
                    return false;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            //throw new NotImplementedException();
            if(value is bool)
            {
                if((bool)value)
                {
                    return "yes";
                }
                else
                {
                    return "no";
                }
            }

            return "no";
        }
    }
}
