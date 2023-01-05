using System;
using System.Globalization;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;

namespace MetaCraftdaily
{
    class ExcelHelper
    {
        string[] MyCell;
        string Version = "1.0";
        string plan;
        ConsoleKeyInfo e;

        public ExcelHelper()
        {
            MyCell = new string[] { "G4", "K4", "N4", "Q4", "G5", "D7","D25","D33"};
        }

        public void PrintVesion()
        {
            Console.WriteLine("=====================================================");
            Console.WriteLine("==                                                 ==");
            Console.WriteLine($"==    메타크래프트 일일 업무 보고서 생성기 v{Version}    ==");
            Console.WriteLine("==                                                 ==");
            Console.WriteLine("=====================================================\n");
        }

        public void PrintMessage()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("=====================================================");
            Console.WriteLine("==                                                 ==");
            Console.WriteLine("==                  파일 생성중..                  ==");
            Console.WriteLine("==                                                 ==");
            Console.WriteLine("=====================================================\n");
        }


        private void clearCurrentLine(string newstring)
        {
            string s = "\r";
            s += new string(' ', Console.CursorLeft);
            s += "\r";
            Console.Write(s);
            Console.Write(newstring);
        }

        public void RunProgram()
        {
            string task;
 
            string Name;


            string filePath = Environment.CurrentDirectory + "\\Template.xlsx";

            PrintVesion();

            if (System.IO.File.Exists(filePath))
            {
                Console.WriteLine("이름을 입력 해주세요 :\n");
                Name = Console.ReadLine();

                Console.WriteLine("\n업무명을 입력 해주세요 :\n");
                task = Console.ReadLine();

                Console.WriteLine("\n업무 계획을 입력 해주세요 : (다 입력 후 F5를 누르세요!)\n");

                while(true)
                {

                    e = Console.ReadKey();

                    if (e.Key == ConsoleKey.F5)
                        break;

                    if(e.Key == ConsoleKey.Backspace)
                    {
                        plan = plan.Remove(plan.Length-1);
                        clearCurrentLine(plan);
                        continue;
                    }

                    if (e.Key == ConsoleKey.Enter)
                    {
                        plan += '\n';
                        Console.WriteLine();
                        continue;
                    }

                    plan += e.KeyChar;
                    Console.Write("");

                }

                PrintMessage();
            }
            else
            {
                Console.WriteLine("템플릿 파일이 없습니다!");
                return;
            }

            Excel.Application excelApp = null;
            Excel.Workbook wb = null;
            Excel.Worksheet ws = null;

            excelApp = new Excel.Application();
            wb = excelApp.Workbooks.Open(filePath);
            ws = wb.Worksheets[1];

            DateTime temp = DateTime.Now;
            CultureInfo cultures = CultureInfo.CreateSpecificCulture("ko-KR");

            ws.Range[MyCell[0]].Value = temp.Year;
            ws.Range[MyCell[1]].Value = temp.Month;
            ws.Range[MyCell[2]].Value = temp.Day;
            ws.Range[MyCell[3]].Value = temp.ToString(string.Format("ddd", cultures));
            ws.Range[MyCell[4]].Value = task;
            ws.Range[MyCell[5]].Value = plan;

            wb.SaveAs(Environment.CurrentDirectory + $"\\{Name} {temp.Month}월 {temp.Day}일 일일 업무 보고서.xlsx");

            wb.Close();
            excelApp.Quit();

            Marshal.ReleaseComObject(wb);
            Marshal.ReleaseComObject(excelApp);

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            ExcelHelper Helper = new ExcelHelper();
            Helper.RunProgram();
        }
    }
}
