namespace ExceptionReporting.SystemInfo
{
	// ReSharper disable once ClassNeverInstantiated.Global
	internal class SysInfoQueries
	{
		public static readonly SysInfoQuery OperatingSystem = new("Operating System", "Win32_OperatingSystem", false);
		public static readonly SysInfoQuery Machine = new("Machine", "Win32_ComputerSystem", true);
	}
}