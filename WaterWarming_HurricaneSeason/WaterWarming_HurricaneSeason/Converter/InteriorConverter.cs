using Syncfusion.UI.Xaml.Charts;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace WaterWarming_HurricaneSeason
{
    public class InteriorConverter : IValueConverter
    {
        object IValueConverter.Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var segment = value as ChartSegment;

            if (segment != null)
            {
                if ((segment.Item as YearlyTemperatureAnomaly).Temperature > 0)
                {
                    return new SolidColorBrush(Color.FromRgb(252, 47, 28));
                }
                else
                {
                    return new SolidColorBrush(Color.FromRgb(16, 167, 227));
                }

            }

            return new SolidColorBrush(Colors.Gray);
        }

        object IValueConverter.ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (object)value;
        }
    }

    public class TrackBallInterior : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var segment = value as ChartPointInfo;

            if (segment != null && segment.Item != null)
            {
                if ((segment.Item as YearlyTemperatureAnomaly).Temperature > 0)
                {
                    return new SolidColorBrush(Color.FromRgb(252, 47, 20));
                }
                else
                {
                    return new SolidColorBrush(Color.FromRgb(16, 167, 227));
                }

            }

            return new SolidColorBrush(Colors.Gray);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
