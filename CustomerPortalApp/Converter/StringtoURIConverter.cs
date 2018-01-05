using System;
using System.Globalization;
using Xamarin.Forms;

namespace CustomerPortalApp.Converter
{
	public class StringtoURIConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			return new Uri((string)value);
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
