using System;
using ExcelConverterAPI.Services;

namespace ExcelConverterTests
{
	public class ServiceTests
	{
        private IExcelService _excelService;

        public ServiceTests()
		{
            _excelService = new ExcelService();
		}

        [Test]
        public void TestConvertNumberToTitle_WithValidInput()
        {
            string title = _excelService.ConvertNumberToTitle(1);

            Assert.AreEqual("A", title);
        }

        [Test]
        public void TestConvertNumberToTitle_WithInvalidInput()
        {
            Assert.Throws<FormatException>(() => _excelService.ConvertNumberToTitle(0));
        }

        [Test]
        public void TestConvertTitleToNumber_WithValidInput()
        {
            int result = _excelService.ConvertTitleToNumber("AA");

            Assert.AreEqual(27, result);
        }

        [Test]
        public void TestConvertTitleToNumber_WithInvalidInput()
        {
            Assert.Throws<FormatException>(() => _excelService.ConvertTitleToNumber("123"));
        }
    }
}

