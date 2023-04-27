namespace ExcelConverterAPI.Services
{
	public interface IExcelService
	{
		public int ConvertTitleToNumber(string columnTitle);
		public string ConvertNumberToTitle(int columnNumber);
	}
}

