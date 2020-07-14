using System.Collections.Generic;
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
				PaperType = PaperType.Letter,
				Cookies = new Dictionary<string, string>(),
				ExtraParams = new Dictionary<string, string>()
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

		public PdfBuilder WithPaperType(PaperType paperType)
		{
			_document.PaperType = paperType;
			return this;
		}

		public PdfBuilder WithUrl(string url)
		{
			_document.Url = url;
			return this;
		}

		public PdfBuilder WithHtml(string html)
		{
			_document.Html = html;
			return this;
		}

		public PdfBuilder WithHeaderUrl(string url)
		{
			_document.HeaderUrl = url;
			return this;
		}

		public PdfBuilder WithFooterUrl(string url)
		{
			_document.FooterUrl = url;
			return this;
		}

		public PdfBuilder WithHeaderLeft(string text)
		{
			_document.HeaderLeft = text;
			return this;
		}

		public PdfBuilder WithHeaderCenter(string text)
		{
			_document.HeaderCenter = text;
			return this;
		}

		public PdfBuilder WithHeaderRight(string text)
		{
			_document.HeaderRight = text;
			return this;
		}

		public PdfBuilder WithFooterLeft(string text)
		{
			_document.FooterLeft = text;
			return this;
		}

		public PdfBuilder WithFooterCenter(string text)
		{
			_document.FooterCenter = text;
			return this;
		}

		public PdfBuilder WithFooterRight(string text)
		{
			_document.FooterRight = text;
			return this;
		}

		public PdfBuilder WithHeaderFontSize(double size)
		{
			_document.HeaderFontSize = size.ToString();
			return this;
		}

		public PdfBuilder WithFooterFontSize(double size)
		{
			_document.FooterFontSize = size.ToString();
			return this;
		}

		public PdfBuilder WithHeaderFontName(string name)
		{
			_document.HeaderFontName = name;
			return this;
		}

		public PdfBuilder WithFooterFontName(string name)
		{
			_document.FooterFontName = name;
			return this;
		}

		public PdfBuilder WithJavaScriptDelay(int milliseconds)
		{
			_document.JavaScriptDelay = milliseconds.ToString();
			return this;
		}

		public PdfBuilder WithCookie(string key, string value)
		{
			_document.Cookies.Add(key, value);
			return this;
		}

		public PdfBuilder WithCookies(Dictionary<string, string> cookies)
		{
			_document.Cookies = cookies;
			return this;
		}

		public PdfBuilder WithParameter(string parameterName, string value)
		{
			_document.ExtraParams.Add(parameterName, value);
			return this;
		}

		public PdfBuilder SendToFilePath(string path)
		{
			_output.OutputFilePath = path;
			return this;
		}

		public PdfBuilder SendToStream(Stream stream)
		{
			_output.OutputStream = stream;
			return this;
		}

		public void GeneratePdf()
		{
			PdfConvert.ConvertHtmlToPdf(_document, _environment, _output);
		}
	}
}
