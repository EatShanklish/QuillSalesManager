using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;

namespace QuillFinal
{
    class ExcelWrite
    {
        public ExcelWrite(string total, string bussinessname, string address)
        {
            string fileTest = "C:\\temp\\ExcelTest\\test.xlsx";
           
            Excel.Application oApp;
            Excel.Worksheet oSheet;
            Excel.Workbook oBook;

            oApp = new Excel.Application();
            oBook = oApp.Workbooks.Add();
            oSheet = (Excel.Worksheet)oBook.Worksheets.get_Item(1);

           
            oSheet.Cells[1, 1] = "Business";
            oSheet.Cells[1, 5] = "Address";
            oSheet.Cells[1, 7] = "Total";

            oSheet.Cells[1, 1] = bussinessname;
            oSheet.Cells[1, 5] = address;
            oSheet.Cells[1, 7] = total;
            

            oBook.SaveAs(fileTest);
            oBook.Close();
            oApp.Quit();

            
        }

    }
}
