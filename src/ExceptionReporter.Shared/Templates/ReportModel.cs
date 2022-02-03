using System.Globalization;

// ReSharper disable AutoPropertyCanBeMadeGetOnly.Global
// ReSharper disable UnusedAutoPropertyAccessor.Global
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedMember.Global

// ReSharper disable once CheckNamespace
namespace ExceptionReporting.Report
{
  /// <summary>
  /// The top-level model/object passed to report templates
  /// </summary>
  public class ReportModel
  {
	public App App { get; set; }
	public Error Error { get; set; }
	public string SystemInfo { get; set; } = String.Empty;
  }

  public class App
  {
	public string Name { get; set; } = String.Empty;
	public string Version { get; set; } = String.Empty;
	public string Region { get; set; } = CultureInfo.CurrentCulture.DisplayName;

	/// <summary> eg used in HTML lang attribute </summary>
	public string Language { get; set; } = "en";

	/// <summary> Title of the report </summary>
	public string Title { get; set; } = "Exception Report";

	/// <summary> optional - will not show field at all if empty </summary>
	public string User { get; set; } = String.Empty;

	public IEnumerable<AssemblyRef> AssemblyRefs { get; set; }
  }

  public class Error
  {
	//===== required variables =====

	/// <summary> DateTime of exception - defaults is 'Now' but would normally be set via config </summary>
	public DateTime When { get; set; } = DateTime.Now;

	/// <summary> Full stack trace string, including any and all inner exceptions and/or multiple exceptions </summary>
	public string FullStackTrace { get; set; } = String.Empty;

	/// <summary> Optional - user input </summary>
	public string Explanation { get; set; } = String.Empty;

	/// <summary> an ID to uniquely identify this particular report (defaults to a generated GUID) </summary>
	public string ID { get; set; } = Guid.NewGuid().ToString();

	//===== calculated variables
	public Exception Exception { get; set; }

	public string Message { get { return Exception.Message; } }

	public string Date { get { return When.ToShortDateString(); } }

	public string Time { get { return When.ToShortTimeString(); } }
	//=====
  }

  public class AssemblyRef
  {
	public string Name { get; set; } = String.Empty;
	public string Version { get; set; } = String.Empty;
  }
}