using ExceptionReporting.Core;
using ExceptionReporting.Mail;
using ExceptionReporting.Network.Events;

namespace ExceptionReporting.Network.Senders
{
  internal class DefaultMailSender : MailSender, IReportSender
  {
	public DefaultMailSender(ExceptionReportInfo reportInfo, IReportSendEvent sendEvent, IScreenShooter screenShooter) :
		base(reportInfo, sendEvent, screenShooter)
	{ }

	public override string Description => "Email Client";
	public override string ConnectingMessage => $"Launching {Description}...";

	/// <summary>
	/// Try send via installed Email client
	/// Uses Simple-MAPI.NET library - https://github.com/PandaWood/Simple-MAPI.NET
	/// </summary>
	public void Send(string report)
	{
	  if (_config.EmailReportAddress.IsEmpty())
	  {
		_sendEvent.ShowError("EmailReportAddress not set", new ConfigException("EmailReportAddress"));
		return;
	  }
	  DefaultMail sender = new(_config.EmailReportAddress);
	  _attacher.AttachFiles(new AttachAdapter(sender));

	  sender.Send(EmailSubject, report);
	}
  }
}