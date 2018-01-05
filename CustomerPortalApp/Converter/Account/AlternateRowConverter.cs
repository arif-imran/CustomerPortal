using System;
using System.Globalization;
using Xamarin.Forms;

namespace CustomerPortalApp.Converter
{
    public class AlternateRowConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int index = 0;

            int.TryParse(value.ToString(), out index);

            return (index % 2 == 0) ? Color.FromHex("#f6f6f6") : Color.White;
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
