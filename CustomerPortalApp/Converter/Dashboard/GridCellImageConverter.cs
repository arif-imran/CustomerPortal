using System;
using System.Collections.ObjectModel;
using System.Globalization;
using Xamarin.Forms;
using CustomerPortalApp.ViewModels;
namespace CustomerPortalApp.Converter
{
	public class GridCellImageConverter:IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			try
			{
				var obj = (ObservableCollection<GridEntry>)value;
				return new Uri(obj[int.Parse((string)parameter)].ImagePath);
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
