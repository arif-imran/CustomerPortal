﻿using System;
using System.Globalization;
using Xamarin.Forms;

namespace CustomerPortalApp.Converter
{
    public class CurrencyConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
            {
                if (((string)parameter) == "true")
                {
                    return ((double)value) > 0 ? String.Format(new CultureInfo("en-GB"), "+{0:C2}", ((double)value)) : String.Format(new CultureInfo("en-GB"), "{0:C2}", ((double)value));
                }
                else
                {
                    return String.Format(new CultureInfo("en-GB"), "{0:C2}", ((double)value));
                }
            }
            else
                return "";

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class CarouselItemSelectedEventArgsConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var selectedItemChangedEventArgs = value as SelectedItemChangedEventArgs;
            if (selectedItemChangedEventArgs == null)
            {
                throw new ArgumentException("Expected value to be of type ItemTappedEventArgs", nameof(value));
            }
            return selectedItemChangedEventArgs.SelectedItem;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
