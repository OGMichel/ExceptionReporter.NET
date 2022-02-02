using NUnit.Framework;

namespace ExceptionReporting.Tests
{
  /// <summary>
  /// Testing ExceptionReporter is mostly a case of integration testing (ie using the demo)
  /// However, we test all the logical inputs and return values here
  /// </summary>
  public class ExceptionReporter_ManualTests
  {
	[Test]
	[Ignore("UI")]
	[TestCase("en")]
	[TestCase("ru")]

	public static void ManualLocalizationTest(string languageTag)
	{
	  //var thread = new Thread(() =>
	  //{
	  //  Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfoByIetfLanguageTag(languageTag);
	  //  Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfoByIetfLanguageTag(languageTag);
	  //  var er = new WinFormExceptionReporter
	  //	{
	  //		Config =
	  //		{
	  //			// test that this style of initialization (settings properties directly on config) remains possible
	  //			//TitleText = "=_=",
	  //			AppName = "PhotoFuzz",
	  //			AppVersion = "1.0",
	  //			CompanyName = "photofuzz",
	  //			SendMethod = ReportSendMethod.MailClient,
	  //			EmailReportAddress = "PhotoFuzz@gmail.com",
	  //			//RegionInfo = "Region",
	  //			//ShowButtonIcons = true,
	  //			ShowLessDetailButton = true,
	  //			TakeScreenshot = true,
	  //			ReportTemplateFormat = TemplateFormat.Markdown,
	  //			ReportCustomTemplate = "Done!",
	  //			AttachmentFilename = $"{DateTime.UtcNow.ToString("dd-MM-yy_HH-mm")}_report",
	  //			FilesToAttach = new[] {"app.log"}
	  //		}
	  //	};
	  //	var ex = new Exception("Test Exception");
	  //	er.Show(ex);
	  //});
	  //thread.SetApartmentState(ApartmentState.STA);
	  //thread.Start();
	  //thread.Join();
	}
  }
}