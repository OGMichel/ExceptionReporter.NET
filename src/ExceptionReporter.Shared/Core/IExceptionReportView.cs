using ExceptionReporting.Network.Events;

namespace ExceptionReporting.Core
{
  /// <summary>
  /// The interface (contract) for an ExceptionReport dialog/View
  /// </summary>
  public interface IExceptionReportView : IReportSendEvent
  {
	string ProgressMessage { set; }
	bool EnableEmailButton { set; }
	bool ShowProgressBar { set; }
	bool ShowFullDetail { get; set; }
	string UserExplanation { get; }

	void MapiSendCompleted();
	void SetInProgressState();
	void PopulateExceptionTab(IEnumerable<Exception> exceptions);
	void PopulateAssembliesTab();
	void PopulateSysInfoTab();
	void SetProgressCompleteState();
	void ToggleShowFullDetail();
	void ShowWindow();
  }
}