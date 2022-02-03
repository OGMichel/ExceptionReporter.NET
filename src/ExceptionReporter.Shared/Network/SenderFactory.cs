using ExceptionReporting.Core;
using ExceptionReporting.Network.Events;
using ExceptionReporting.Network.Senders;
using ExceptionReporting.Report;

namespace ExceptionReporting.Network
{
	public class SenderFactory
	{
		private readonly ExceptionReportInfo _config;
		private readonly IReportSendEvent _sendEvent;
		private readonly IScreenShooter _screenShooter;

		public SenderFactory(ExceptionReportInfo config, IReportSendEvent sendEvent, IScreenShooter screenShooter)
		{
			_config = config;
			_sendEvent = sendEvent;
			_screenShooter = screenShooter;
		}

		public IReportSender Get()
		{
			return _config.SendMethod switch
			{
				ReportSendMethod.WebService => new WebServiceSender(_config, _sendEvent),
				ReportSendMethod.SMTP => new SmtpMailSender(_config, _sendEvent, _screenShooter),
				ReportSendMethod.MailClient => new DefaultMailSender(_config, _sendEvent, _screenShooter),
				ReportSendMethod.None => new GhostSender(),
				_ => new GhostSender(),
			};
		}
	}
}