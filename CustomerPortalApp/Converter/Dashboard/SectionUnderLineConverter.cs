using System;
using System.Globalization;
using Xamarin.Forms;
namespace CustomerPortalApp.Converter
{
	public class SectionUnderLineConverter:IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			var f = (string)value == (string)parameter ? true : false;
			return f;
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
