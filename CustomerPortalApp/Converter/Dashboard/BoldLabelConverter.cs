using System;
using System.Globalization;
using Xamarin.Forms;
namespace CustomerPortalApp.Converter
{
	public class BoldLabelConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			var f =  (string)value == (string)parameter ? FontAttributes.Bold : FontAttributes.None;
			return f;
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			return FontAttributes.None;
		}
	}
}
