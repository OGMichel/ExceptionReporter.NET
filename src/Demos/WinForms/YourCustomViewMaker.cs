using ExceptionReporting.Core;
using System.Windows.Forms;

namespace Demo.WinForms
{
	/// <summary>
	/// A sample implementation of IViewMaker used to switch the view used by ExceptionReporter
	/// </summary>
	public class YourCustomViewMaker : IViewMaker
	{
		public IExceptionReportView Create()
		{
			return new YourCustomReporterView();
		}

		public void ShowError(string message)
		{
			MessageBox.Show(message);
		}
	}
}