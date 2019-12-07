using System;
using System.Globalization;
using System.Windows.Data;
using AForge.Video;

namespace VideoStreamClientApplication.Converters
{
    [ValueConversion(typeof(MJPEGStream), typeof(string))]
    public class MjpegStreamUriToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }


        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return new MJPEGStream(value as string);
        }
    }
}