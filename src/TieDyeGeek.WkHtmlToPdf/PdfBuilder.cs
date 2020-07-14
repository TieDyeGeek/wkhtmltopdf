using System.IO;

namespace TieDyeGeek.WkHtmlToPdf
{
	public class PdfBuilder
	{
		private readonly PdfConvertEnvironment _environment;
		private readonly PdfDocument _document;
		private readonly PdfOutput _output;

		public PdfBuilder()
		{
			_environment = new PdfConvertEnvironment
			{
				TempFolderPath = Path.GetTempPath()
			};
			_document = new PdfDocument
			{
				PaperType = PaperType.Letter
			};
			_output = new PdfOutput();
		}

		public PdfBuilder UsingTempFolder(string tempFolderPath)
		{
			_environment.TempFolderPath = tempFolderPath;
			return this;
		}

		public PdfBuilder WithPdfGenerationTimeout(int milliseconds)
		{
			_environment.Timeout = milliseconds;
			return this;
		}

		public PdfBuilder WithWkHtmlToPdfPath(string path)
		{
			_environment.WkHtmlToPdfPath = path;
			return this;
		}







		public void GeneratePdf()
		{
			PdfConvert.ConvertHtmlToPdf(_document, _environment, _output);
		}
	}
}
