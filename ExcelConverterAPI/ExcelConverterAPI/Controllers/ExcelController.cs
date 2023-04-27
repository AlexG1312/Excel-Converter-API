using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExcelConverterAPI.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ExcelConverterAPI.Controllers
{
    public class ExcelController : Controller
    {
        private readonly IExcelService _excelService;

        public ExcelController(IExcelService excelService)
        {
            _excelService = excelService;
        }

        [HttpGet("number/{columnTitle}")]
        public int ExcelColumnNumber(string columnTitle)
        {
            return _excelService.ConvertTitleToNumber(columnTitle);
        }

        [HttpGet("name/{columnNumber}")]
        public string ExcelColumnName(int columnNumber)
        {
            return _excelService.ConvertNumberToTitle(columnNumber);
        }
    }
}

