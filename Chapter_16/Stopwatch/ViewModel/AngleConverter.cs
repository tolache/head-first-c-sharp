﻿using System;
using System.Globalization;
using System.Windows.Data;

namespace Stopwatch.ViewModel
{
    public class AngleConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            double parsedValue;
            if (value != null && parameter != null && double.TryParse(value.ToString(), out parsedValue))
            {
                switch (parameter.ToString())
                {
                    case "Hours" : return parsedValue * 30;
                    case "Minutes" :
                    case "Seconds" :
                        return parsedValue * 6;
                }
            }

            return 0;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}