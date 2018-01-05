using System;
using Xamarin.Forms;
using CustomerPortalApp.ViewModels;
using System.Globalization;
using System.Collections.ObjectModel;

namespace CustomerPortalApp.Converter
{
	public class GridCellTextConverter :IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			try
			{
				var obj = (ObservableCollection<GridEntry>)value;
				return obj[int.Parse((string)parameter)].Title;
			}
			catch
			{
				return null;
			}
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
