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
	  Stream fileStream = new FileStream(zipFile, FileMode.Create);
	  ZipArchive archive = new(fileStream);
	  foreach (string file in files)
		archive.CreateEntryFromFile(file, Path.GetFileName(file), CompressionLevel.Optimal);
	}
  }
}
