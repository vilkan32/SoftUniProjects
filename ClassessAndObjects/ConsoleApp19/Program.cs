using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(@"C:\Users\Acer\Desktop\sample_table.xlsx");
            Excel._Worksheet xlWorksheet = xlWorkbook.ActiveSheet;
            Excel.Range xlRange = xlWorksheet.UsedRange;

            int rowCount = xlRange.Rows.Count;
            int colCount = xlRange.Columns.Count;
            List<string> Output = new List<string>();
            List<string> Test = new List<string>();
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= colCount; j++)
                {
                    if (xlRange.Cells[i, j] != null && xlRange.Cells[i, j].Value2 != null)
                        Console.Write(xlRange.Cells[i, j].Value2.ToString() + "|");
                    Output.Add(xlRange.Cells[i, j].Value2.ToString());
                }
                string resultadd = string.Join("|", Output);
                Test.Add(string.Join("|", Output) + "|");
                Output = new List<string>();
                Console.WriteLine();
            }
            System.IO.File.WriteAllLines(@"C:\Users\Acer\Desktop\result.txt", Test);
        }
    }
}
