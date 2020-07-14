namespace TieDyeGeek.WkHtmlToPdf
{
	public enum PaperType
	{
		A0,
		A1,
		A2,
		A3,
		A4,
		A5,
		A6,
		A7,
		A8,
		A9,
		B0,
		B1,
		B10,
		B2,
		B3,
		B4,
		B5,
		B6,
		B7,
		B8,
		B9,
		C5E,
		Comm10E,
		DLE,
		Executive,
		Folio,
		Ledger,
		Legal,
		Letter,
		Tabloid,
	}

	internal static class PaperTypesExtension
	{
		internal static string ToString(this PaperType paperType)
		{
			switch (paperType)
			{
				case PaperType.A0: return "A0";
				case PaperType.A1: return "A1";
				case PaperType.A2: return "A2";
				case PaperType.A3: return "A3";
				case PaperType.A4: return "A4";
				case PaperType.A5: return "A5";
				case PaperType.A6: return "A6";
				case PaperType.A7: return "A7";
				case PaperType.A8: return "A8";
				case PaperType.A9: return "A9";
				case PaperType.B0: return "B0";
				case PaperType.B1: return "B1";
				case PaperType.B10: return "B10";
				case PaperType.B2: return "B2";
				case PaperType.B3: return "B3";
				case PaperType.B4: return "B4";
				case PaperType.B5: return "B5";
				case PaperType.B6: return "B6";
				case PaperType.B7: return "B7";
				case PaperType.B8: return "B8";
				case PaperType.B9: return "B9";
				case PaperType.C5E: return "C5E";
				case PaperType.Comm10E: return "Comm10E";
				case PaperType.DLE: return "DLE";
				case PaperType.Executive: return "Executive";
				case PaperType.Folio: return "Folio";
				case PaperType.Ledger: return "Ledger";
				case PaperType.Legal: return "Legal";
				case PaperType.Letter: return "Letter";
				case PaperType.Tabloid: return "Tabloid";
				default: return "Letter";
			}
		}
	}
}
