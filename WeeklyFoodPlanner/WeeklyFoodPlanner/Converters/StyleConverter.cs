using System;
using System.Globalization;

using Xamarin.Forms;

namespace WeeklyFoodPlanner.Helpers
{
    public class DayToStyleConverter : IValueConverter
    {
        public Style DefaultStyle { get; set; }
        public Style CurrentDayStyle { get; set; }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var val = value as DayOfWeek?;

            var parsed = Enum.TryParse(parameter?.ToString(), out DayOfWeek day);

            return parsed && val == day ? CurrentDayStyle : DefaultStyle;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
