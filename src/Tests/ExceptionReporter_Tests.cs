using ExceptionReporting.Core;
using ExceptionReporting.Report;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace ExceptionReporting.Tests
{
	/// <summary>
	/// Testing ExceptionReporter is mostly a case of integration testing (ie using the demo)
	/// However, we test all the logical inputs and return values here
	/// </summary>
	public class ExceptionReporter_Tests
	{
		[Test]
		public void Can_Init_App_Assembly()
		{
			var er = new WinFormExceptionReporter();
			Assert.That(er.Config.AppAssembly, Is.Null);
		}

		[TestCase(null,                     ExpectedResult = false)]
		[TestCase(default(List<Exception>), ExpectedResult = false)]
		public bool Can_Prevent_Showing_If_Null_Exception(params Exception[] exceptions)
		{
			var er = new WinFormExceptionReporter
			{
				ViewMaker = new Mock<IViewMaker>().Object
			};
			return er.Show(exceptions);
		}

		[Test]
		public void Can_Show()
		{
			var viewMock = new Mock<IViewMaker>();
			viewMock.Setup(v => v.Create()).Returns(new Mock<IExceptionReportView>().Object);

			var er = new WinFormExceptionReporter
			{
				ViewMaker = viewMock.Object
			};
			Assert.That(er.Show(new TestException()), Is.True);
		}

		[Test]
		public void Can_Not_Show_If_No_Exception()
		{
			var er = new WinFormExceptionReporter
			{
				ViewMaker = new Mock<IViewMaker>().Object
			};
			Assert.That(er.Show(), Is.False);
		}

		[Test]
		public void Can_Init_Config_Using_Object_Initializer()
		{
			var er = new WinFormExceptionReporter
			{
				Config =
				{	// test that this style of initialization (settings properties directly on config) remains possible
					AppName = "PhotoFuzz",
					AppVersion = "1.0",
					CompanyName = "photofuzz",
					SendMethod = ReportSendMethod.WebService,
					WebServiceUrl = "http://photofuzz/apiv1", 
					FilesToAttach = new[] {"app.log"}
				}
			};

			er.Show();
		}
	}
}