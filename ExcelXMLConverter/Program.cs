//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
using System.Runtime.InteropServices;
//using System.Text;
//using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

static void readExcelFile()
{

    // create COM Objects
    Excel.Application xlApp = new Excel.Application();
    Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(@"C:\Users\Nick\source" +
@"\repos\ExcelXMLConverter\data\sheet.xlsx");
    Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
    Excel.Range xlRange = xlWorksheet.UsedRange;

    int rowCount = xlRange.Rows.Count;
    int colCount = xlRange.Columns.Count;

    // print file
    for (int i = 1; i <= rowCount; i++)
    {
        for (int j = 1; j <= colCount; j++)
        {
            if (j == 1)
                Console.Write("\r\n");

            if (xlRange.Cells[i, j] != null && xlRange.Cells[i, j].Value2 != null)
                Console.Write(xlRange.Cells[i, j].Value2.ToString() + "\t");
        }
    }

    // cleanup - ???
    GC.Collect();
    GC.WaitForPendingFinalizers();

    // rule of thumb for releasing com objects:
    // never use two dots, all COM objects must be referenced and released individually
    // ex: [something].[something].[something] is bad

    // release com objects to fully kill excel process from running in the background
    Marshal.ReleaseComObject(xlRange);
    Marshal.ReleaseComObject(xlWorksheet);

    // close and release
    xlWorkbook.Close();
    Marshal.ReleaseComObject(xlWorkbook);

    // quit and release
    xlApp.Quit();
    Marshal.ReleaseComObject(xlApp);
}

readExcelFile();

Console.ReadKey();