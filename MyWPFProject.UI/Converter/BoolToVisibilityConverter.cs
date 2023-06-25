using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace MyWPFProject.UI
{
    public class BoolToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
            {
                return Visibility.Visible;
            }
            if (value is bool)
            {
                if (System.Convert.ToBoolean(value))
                {
                    return Visibility.Visible;
                }
                return Visibility.Collapsed;
            }
            return Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!Enum.IsDefined(typeof(Visibility), value)) return null;
            return Enum.Parse(typeof(Visibility), value.ToString()).Equals(Visibility.Visible);
        }
    }
}
