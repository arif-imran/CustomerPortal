using System;
using System.Collections.ObjectModel;
using System.Globalization;
using CustomerPortalApp.ViewModels;
using Xamarin.Forms;

namespace CustomerPortalApp.Converter
{
	class PropertyCountConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			return ((ObservableCollection<PropertyViewModel>)value).Count;
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			return 0;
		}
	}
}