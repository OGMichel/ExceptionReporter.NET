using System;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;

// ReSharper disable once CheckNamespace
namespace ExceptionReporting.WPF.Converters
{
  public class IconToImageSourceConverter : IValueConverter
  {
	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
	  if (value is not Icon icon)
	  {
		Trace.TraceWarning("Attempted to convert {0} instead of Icon object in IconToImageSourceConverter", value);
		return null;
	  }

	  ImageSource imageSource = Imaging.CreateBitmapSourceFromHIcon(
		  icon.Handle,
		  Int32Rect.Empty,
		  BitmapSizeOptions.FromEmptyOptions());
	  return imageSource;
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
	  throw new NotImplementedException();
	}
  }
}