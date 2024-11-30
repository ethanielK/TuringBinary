using System.Globalization;
using System.Windows.Data;

namespace WPF__数据校验与转换
{
    public class SatisfactionConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            //throw new NotImplementedException();

            SatisfactionType type = (SatisfactionType)value;

            switch (type)
            {
                case SatisfactionType.Anxious:
                    return @"images\anxious.png";
                case SatisfactionType.Nerd:
                    return @"images\nerd.png";
                case SatisfactionType.Cold:
                    return @"images\cold.png";
                case SatisfactionType.Smiling:
                    return @"images\smiling.png";
                case SatisfactionType.Sos:
                    return @"images\sos.png";
                default:
                    return null;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            //throw new NotImplementedException();
           
            // 不需要实现反向转换
            return null;
        }
    }
}
