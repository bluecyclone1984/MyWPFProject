using System;
using System.Globalization;
using System.Windows.Data;

namespace MyWPFProject.UI
{
    public class EnumToBoolConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!Enum.IsDefined(typeof(SelectType), value)) return null;
            return Enum.Parse(typeof(SelectType), value.ToString()).Equals(Enum.Parse(typeof(SelectType), parameter.ToString()));
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null && value is bool)
            {
                if (System.Convert.ToBoolean(value))
                {
                    return Enum.Parse(targetType, parameter.ToString());
                }
                return null;
            }
            return null;
        }
    }
}
