using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DoveWeb.Utilities
{
    public class ReadExcel
    {
        public static string ReadExcelData(int Cell, int Rowvalue)
        {
            string path = @"C:\Users\mindc1may214\source\repos\DoveWeb\Utilities\SearchData.xlsx";
            XSSFWorkbook workbook = new XSSFWorkbook(File.Open(path, FileMode.Open));
            var sheet = workbook.GetSheetAt(0); //sheet number
            var row = sheet.GetRow(Rowvalue); //row number
            string Data = row.GetCell(Cell).StringCellValue.Trim(); //clm/cell number
            Console.WriteLine("the search data from excels is " + Data);
            return Data;

        }
    }
}
