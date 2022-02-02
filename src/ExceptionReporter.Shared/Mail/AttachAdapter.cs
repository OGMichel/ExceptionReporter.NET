namespace ExceptionReporting.Mail
{
  internal interface IAttach
  {
	void Attach(string filename);
  }

  /// <summary>
  /// Provide a plug between incompatible classes that nevertheless need the same "attach" treatment
  /// </summary>
  internal class AttachAdapter : IAttach
  {
	readonly System.Net.Mail.MailMessage? _mailMessage;
	readonly DefaultMail? _defaultMailSender;

	public AttachAdapter(System.Net.Mail.MailMessage mailMessage)
	{
	  _mailMessage = mailMessage;
	}

	public AttachAdapter(DefaultMail sender)
	{
	  _defaultMailSender = sender;
	}

	public void Attach(string filename)
	{
	  if (_mailMessage != null) _mailMessage.Attachments.Add(new System.Net.Mail.Attachment(filename));
	  if (_defaultMailSender != null) _defaultMailSender.Attach(filename);
	}
  }
}
