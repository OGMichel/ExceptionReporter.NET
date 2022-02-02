using ExceptionReporting.Annotations;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ExceptionReporting.Plumbing
{
  public class ObservableObject : INotifyPropertyChanged
  {
	public event PropertyChangedEventHandler PropertyChanged;

	[NotifyPropertyChangedInvocator]
	protected void NotifyPropertyChanged([CallerMemberName] string propertyName = null)
	{
	  PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
	}
  }
}