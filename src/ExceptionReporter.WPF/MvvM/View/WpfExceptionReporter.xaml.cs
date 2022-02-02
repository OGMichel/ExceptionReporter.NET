using ExceptionReporting.WPF.MvvM.ViewModel;
using System;
using System.Windows.Controls;

// ReSharper disable CheckNamespace
namespace ExceptionReporting.WPF.MvvM.View
{
  /// <summary>
  /// Interaction logic for WpfExceptionReporter
  /// </summary>
  public partial class WpfExceptionReporter : UserControl
  {
	public WpfExceptionReporter(Exception exception, ExceptionReportInfo info)
	{
	  InitializeComponent();

	  info.MainException = exception;
	  this.DataContext = new ExceptionReporterViewModel(info);
	}
  }
}