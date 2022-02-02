using ExceptionReporter.Shared.Properties;
using ExceptionReporting.Report;
using HandlebarsDotNet;

namespace ExceptionReporting.Templates
{
  internal class TemplateRenderer
  {
	private readonly object _model;     // model object is kept generic but we force a kind of typing via constructors
	private readonly string _name;

	public TemplateRenderer(EmailIntroModel model)
	{
	  _model = model;
	  _name = "EmailIntroTemplate";
	}

	public TemplateRenderer(ReportModel model)
	{
	  _model = model;
	  _name = "ReportTemplate";
	}

	private string Render(string template)
	{
	  var compile = Handlebars.Compile(template);
	  var report = compile(_model);
	  return report;
	}

	public string RenderPreset(TemplateFormat format = TemplateFormat.Text)
	{
	  var template = GetTemplate(format);
	  return this.Render(template);
	}

	public string RenderCustom(string template)
	{
	  return this.Render(template);
	}

	private string GetTemplate(TemplateFormat format)
	{
	  switch (_name)
	  {
		case "EmailIntroTemplate":
		  return Resources.EmailIntroTemplate_text;
		case "ReportTemplate":
		  switch (format.ToString().ToLower())
		  {
			case "html":
			  return Resources.ReportTemplate_html;
			case "text":
			  return Resources.ReportTemplate_text;
			case "markdown":
			  return Resources.ReportTemplate_markdown;
		  }
		  break;
	  }
	  return String.Empty;
	}
  }
}