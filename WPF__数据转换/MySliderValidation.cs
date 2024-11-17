using System.Globalization;
using System.Windows.Controls;

namespace WPF__数据校验与转换
{
    class MySliderValidation : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            if (value == null) return new ValidationResult(false, "请输入数字");

            bool res = int.TryParse(value.ToString(), out int result);

            if (res)
            {
                if (result > 40 || result < -10)
                    return new ValidationResult(false, "请输入-10到40之间的数字");
                else
                    return new ValidationResult(true,null);
            }
            else
            {
                return new ValidationResult(false, "请输入数字");
            }
        }
    }
}
