using System;
using System.IO;

namespace TieDyeGeek.WkHtmlToPdf
{
	public class PdfOutput
	{
		public string OutputFilePath { get; set; }
		public Stream OutputStream { get; set; }
		public Action<PdfDocument, byte[]> OutputCallback { get; set; }
	}
}
