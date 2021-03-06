﻿using System;
using System.Globalization;
using System.Windows.Data;

namespace GrandTheftMultiplayer.Launcher.Converters
{
    public class PingToFormattedPing : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value != null && (int) value != -1 ? value : "-";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
