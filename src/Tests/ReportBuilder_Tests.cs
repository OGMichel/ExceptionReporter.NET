using Autofac.Extras.Moq;
using ExceptionReporting.Report;
using ExceptionReporting.SystemInfo;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace ExceptionReporting.Tests
{
  public class ReportBuilder_Tests
  {
	[Test]
	public void Can_Build_Basic_Model_Properties()
	{
	  var moqer = AutoMock.GetLoose();
	  var reportBuilder = moqer.Create<ReportBuilder>();

	  var info = moqer.Mock<ExceptionReportInfo>().Object;
	  info.AppName = "TestApp";
	  info.AppVersion = "1.0";
	  info.MainException = new TestException();

	  var model = reportBuilder.ReportModel();

	  Assert.That(model.App.Name, Is.EqualTo("TestApp"));
	  Assert.That(model.App.Version, Is.EqualTo("1.0"));
	  Assert.That(model.Error.Message, Is.EqualTo(TestException.ErrorMessage));
	}

	[Test]
	public void Can_Invoke_Dependencies()
	{
	  var moqer = AutoMock.GetLoose();
	  var reportBuilder = moqer.Create<ReportBuilder>();

	  moqer.Mock<IAssemblyDigger>().Setup(ad => ad.GetAssemblyRefs()).Returns(new List<AssemblyRef>
			{
				new AssemblyRef
				{
					Name = "Assembly1",
					Version = "2.1"
				}
			});
	  moqer.Mock<ISysInfoResultMapper>().Setup(si => si.SysInfoString()).Returns("fake tree");
	  moqer.Mock<IStackTraceMaker>().Setup(st => st.FullStackTrace()).Returns("fake stack trace");

	  var model = reportBuilder.ReportModel();

	  Assert.That(model.App.AssemblyRefs.First().Name, Is.EqualTo("Assembly1"));
	  Assert.That(model.SystemInfo, Is.EqualTo("fake tree"));
	  Assert.That(model.Error.FullStackTrace, Is.EqualTo("fake stack trace"));
	}
  }
}