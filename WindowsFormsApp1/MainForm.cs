using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Globalization;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;

namespace WindowsFormsApp1
{

    public partial class MainForm : Form
    {

        string FilePath = null;

        public MainForm()
        {
           InitializeComponent();
        }

        //경로 선택
        private void FilePath_Btn_Click(object sender, EventArgs e)
        {
            FilePath_TextBox.Clear();

            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            if(folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                FilePath_TextBox.Text = FilePath = folderBrowserDialog.SelectedPath;
            }

        }

        //파일 생성
        private void Create_Btn_Click(object sender, EventArgs e)
        {
            if (FilePath == null || MyName_TextBox.TextLength == 0 || MyTask_TextBox.TextLength == 0 || MyPlan_TextBox.TextLength == 0)
            {
                MessageBox.Show("정보를 다 입력해주세요!");
                return;
            }

            ExcelHelper Helper = new ExcelHelper();
            Helper.SetTaskAndPlan(MyName_TextBox.Text,MyTask_TextBox.Text,MyPlan_TextBox.Text, FilePath);

            //Application.Exit();
          
        }
    }

    public class ExcelHelper
    {
        public string[] MyCell;
        public Excel.Application ExcelApp = null;
        public Excel.Workbook wb = null;
        public Excel.Worksheet ws = null;
        DateTime Today;

        public ExcelHelper()
        {
            ExcelApp = new Excel.Application();
            wb = ExcelApp.Workbooks.Open(Environment.CurrentDirectory + "\\Template.xlsx");
            ws = wb.Worksheets[1];
            MyCell = new string[] { "G4", "K4", "N4", "Q4", "G5", "D7", "D25", "D33" };

            Today = DateTime.Now;

            CultureInfo cultures = CultureInfo.CreateSpecificCulture("ko-KR");

            ws.Range[MyCell[0]].Value = Today.Year;
            ws.Range[MyCell[1]].Value = Today.Month;
            ws.Range[MyCell[2]].Value = Today.Day;
            ws.Range[MyCell[3]].Value = Today.ToString(string.Format("ddd", cultures));

        }

        public void SetTaskAndPlan(string Name, string Task, string Plan, string FilePath)
        {
            ws.Range[MyCell[4]].Value = Task;
            ws.Range[MyCell[5]].Value = Plan;

            wb.SaveAs(FilePath + $"\\{Name} {Today.Year}.{Today.Month}.{Today.Day} 일일 업무 보고서.xlsx");

            wb.Close();
            ExcelApp.Quit();

            Marshal.ReleaseComObject(wb);
            Marshal.ReleaseComObject(ExcelApp);
        }


    }
}
