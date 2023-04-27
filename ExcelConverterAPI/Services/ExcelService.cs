namespace ExcelConverterAPI.Services
{
    public class ExcelService : IExcelService
    {
        public string ConvertNumberToTitle(int columnNumber)
        {
            if(columnNumber <= 0)
            {
                throw new FormatException();
            }

            string title = "";

            while (columnNumber > 0)
            {
                int remainder = (columnNumber - 1) % 26;
                title = (char)('A' + remainder) + title;
                columnNumber = (columnNumber - 1) / 26;
            }
            return title;
        }

        public int ConvertTitleToNumber(string columnTitle)
        {
            if (string.IsNullOrEmpty(columnTitle) || !columnTitle.All(char.IsLetter))
            {
                throw new FormatException();
            }

            int result = 0;
            for (int i = 0; i < columnTitle.Length; i++)
            {
                result = result * 26 + (columnTitle[i] - 'A' + 1);
            }
            return result;
        }
    }
}

