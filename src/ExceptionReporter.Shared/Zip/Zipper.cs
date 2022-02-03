using System.IO.Compression;

namespace ExceptionReporting.Zip
{
  public interface IZipper
  {
	void Zip(string zipFile, IEnumerable<string> files);
  }

  internal class Zipper : IZipper
  {
	public void Zip(string zipFile, IEnumerable<string> files)
	{
	  using (Stream zipFileStream = new FileStream(zipFile, FileMode.Create))
	  {
		using (ZipArchive archive = new ZipArchive(zipFileStream, ZipArchiveMode.Create))
		{
		  foreach (string file in files)
			archive.CreateEntryFromFile(file, Path.GetFileName(file), CompressionLevel.Fastest);
		}
	  }
	}
  }
}
