using System.Diagnostics;

namespace ExceptionReporting.Mail
{
  internal class DefaultMail
  {
	readonly List<string> _mailAttachments = new();
	readonly string _recipient;

	public DefaultMail(string recipient)
	{
	  _recipient = recipient;
	}

	public void Attach(string fileName)
	{
	  _mailAttachments.Add(fileName);
	}

	public void Send(string subject, string body)
	{
	  // mailto does not support attachment, we are looking for a way to support it, but we don't have the solution yet
	  string mailto = string.Format("mailto:{0}?Subject={1}&Body={2}", _recipient, subject, Uri.EscapeDataString(body));
	  Process.Start(new ProcessStartInfo(mailto) { UseShellExecute = true });
	}

  }
}
