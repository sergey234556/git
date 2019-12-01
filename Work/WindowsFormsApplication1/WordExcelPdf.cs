using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using excel = Microsoft.Office.Interop.Excel;
using PDF = Microsoft.Office.Interop.Word;
using word = Microsoft.Office.Interop.Word;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class WordExcelPdf : Form
    {
        public WordExcelPdf()
        {
            InitializeComponent();
        }

        private void Document_Word(string Reg_znak, string Identity_Num, string Model_Dvig, string Type_Dvig, string Category_TS, string Year_TS, string Date_Registration)
        {
            word.Application application = new word.Application();
            word.Document document = application.Documents.Add(Visible: true);
            word.Range range = document.Range(0, 0);
            string file_name = Application.StartupPath + "\\Отчёты\\Word\\Характеристика автомобиля" + DateTime.Now.ToString("_hh_mm_ss_dd_MM_yyyy") + ".docx";
            try
            {
                document.Sections.PageSetup.LeftMargin
                    = application.CentimetersToPoints(Convert.ToSingle(1.5));
                document.Sections.PageSetup.RightMargin
                    = application.CentimetersToPoints(2);
                document.Sections.PageSetup.TopMargin
                    = application.CentimetersToPoints(1);
                document.Sections.PageSetup.BottomMargin
                    = application.CentimetersToPoints(1);
                range.Text = "Название организации";
                range.ParagraphFormat.Alignment
                    = word.WdParagraphAlignment.wdAlignParagraphCenter;
                range.ParagraphFormat.SpaceAfter = 1;
                range.ParagraphFormat.SpaceBefore = 1;
                range.ParagraphFormat.LineSpacingRule = word.WdLineSpacing.wdLineSpaceSingle;
                range.Font.Name = "Times New Roman";
                range.Font.Size = 12;
                document.Paragraphs.Add();
                document.Paragraphs.Add();
                word.Paragraph Name_Doc = document.Paragraphs.Add();
                Name_Doc.Format.Alignment = word.WdParagraphAlignment.wdAlignParagraphCenter;
                Name_Doc.Range.Font.Name = "Times New Roman";
                Name_Doc.Range.Font.Size = 16;
                Name_Doc.Range.Text = "Характеристика автомобиля";
                document.Paragraphs.Add();
                document.Paragraphs.Add();
                document.Paragraphs.Add();
                word.Paragraph pTable = document.Paragraphs.Add();
                word.Table Check = document.Tables.Add(pTable.Range, 7,
                    2);
                Check.Borders.InsideLineStyle = word.WdLineStyle.wdLineStyleSingle;
                Check.Borders.OutsideLineStyle = word.WdLineStyle.wdLineStyleSingle;
                
                Check.Cell(1, 1).Range.Text = "Регистрационный знак";
                Check.Cell(2, 1).Range.Text = "Идентификационный номер";
                Check.Cell(3, 1).Range.Text = "Модель двигателя";
                Check.Cell(4, 1).Range.Text = "Тип двигателя";
                Check.Cell(5, 1).Range.Text = "Категория ТС";
                Check.Cell(6, 1).Range.Text = "Год выпуска ТС";
                Check.Cell(7, 1).Range.Text = "Дата регистрации";
                Check.Range.Font.Size = 11;
                Check.Range.Font.Name = "Times New Roman";
                Check.Columns[1].AutoFit();
                Check.Cell(1, 2).Range.Text = Reg_znak;
                Check.Cell(2, 2).Range.Text = Identity_Num;
                Check.Cell(3, 2).Range.Text = Model_Dvig;
                Check.Cell(4, 2).Range.Text = Type_Dvig;
                Check.Cell(5, 2).Range.Text = Category_TS;
                Check.Cell(6, 2).Range.Text = Year_TS;
                Check.Cell(7, 2).Range.Text = Date_Registration;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                document.SaveAs2(file_name, word.WdSaveFormat.wdFormatDocumentDefault);
                document.Close();
                application.Quit();
                MessageBox.Show("Документ сформирован! Путь:" + Application.StartupPath + "\\Отчёты\\Word\\Характеристика автомобиля" + DateTime.Now.ToString("_hh_mm_ss_dd_MM_yyyy") + ".docx");
            }
        }

        private void ButWord_Click(object sender, EventArgs e)
        {
            Document_Word("123456", "123456","HDX", "Карбюраторный", "Легковой автомобиль", "2017", "27.06.2017");
        }

        private void Document_PDF(string Prib, string NameFam_Client, string MestoOtpr, string stoimost)
        {
            PDF.Application application = new PDF.Application();
            PDF.Document document = application.Documents.Add(Visible: true);
            PDF.Range range = document.Range(0, 0);
            string file_name = Application.StartupPath + "\\Отчёты\\PDF\\Чек_" + DateTime.Now.ToString("_hh_mm_ss_dd_MM_yyyy");
            try
            {
                document.Sections.PageSetup.LeftMargin
                    = application.CentimetersToPoints(Convert.ToSingle(1.5));
                document.Sections.PageSetup.RightMargin
                    = application.CentimetersToPoints(2);
                document.Sections.PageSetup.TopMargin
                    = application.CentimetersToPoints(1);
                document.Sections.PageSetup.BottomMargin
                    = application.CentimetersToPoints(1);
                range.Text = "Название организации";
                range.ParagraphFormat.Alignment
                    = PDF.WdParagraphAlignment.wdAlignParagraphCenter;
                range.ParagraphFormat.SpaceAfter = 1;
                range.ParagraphFormat.SpaceBefore = 1;
                range.ParagraphFormat.LineSpacingRule = PDF.WdLineSpacing.wdLineSpaceSingle;
                range.Font.Name = "Times New Roman";
                range.Font.Size = 12;
                document.Paragraphs.Add();
                document.Paragraphs.Add();
                PDF.Paragraph Name_Doc = document.Paragraphs.Add();
                Name_Doc.Format.Alignment = PDF.WdParagraphAlignment.wdAlignParagraphCenter;
                Name_Doc.Range.Font.Name = "Times New Roman";
                Name_Doc.Range.Font.Size = 16;
                Name_Doc.Range.Text = "Чек";
                document.Paragraphs.Add();
                document.Paragraphs.Add();
                document.Paragraphs.Add();
                PDF.Paragraph pTable = document.Paragraphs.Add();
                PDF.Table Check = document.Tables.Add(pTable.Range, 4,
                    2);
                Check.Borders.InsideLineStyle = PDF.WdLineStyle.wdLineStyleSingle;
                Check.Borders.OutsideLineStyle = PDF.WdLineStyle.wdLineStyleSingle;
                Check.Cell(1, 1).Range.Text = "Точка прибытия";
                Check.Cell(2, 1).Range.Text = "Пассажир";
                Check.Cell(3, 1).Range.Text = "Точка отправки";
                Check.Cell(4, 1).Range.Text = "Стоимость услуги";
                Check.Range.Font.Size = 11;
                Check.Range.Font.Name = "Times New Roman";
                Check.Columns[1].AutoFit();
                Check.Cell(1, 2).Range.Text = Prib;
                Check.Cell(2, 2).Range.Text = NameFam_Client;
                Check.Cell(3, 2).Range.Text = MestoOtpr;
                Check.Cell(4, 2).Range.Text = stoimost;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                document.Saved = true;
                document.SaveAs(file_name + ".pdf", PDF.WdExportFormat.wdExportFormatPDF);
                document.Close();
                application.Quit();
                MessageBox.Show("Документ сформирован Путь:" + Application.StartupPath + "\\Отчёты\\PDF\\Чек_" + DateTime.Now.ToString("_hh_mm_ss_dd_MM_yyyy"));
            }
        }

        private void ButPDF_Click(object sender, EventArgs e)
        {
            Document_PDF("12 дом, Пражская улица, 13 подъезд", "Иванов Иван", "15 дом, Ленинская площадь, 10 подъезд", "2000");
        }

        private void Document_Excel(string FIO_sotr, string Dolj, string Login_sotr, string Password_sotr)
        {
            string name = Application.StartupPath + "\\Отчёты\\Excel\\Карта сотрудника" + DateTime.Now.ToString("_hh_mm_ss_dd_MM_yyyy") + ".xlsx";
            excel.Application application = new excel.Application();
            excel.Workbook workbook = application.Workbooks.Add();
            excel.Worksheet worksheet = (excel.Worksheet)workbook.ActiveSheet;
            try
            {
                excel.Range _excelCells = (excel.Range)worksheet.get_Range("A1", "B2").Cells;
                // Производим объединение
                _excelCells.Merge(Type.Missing);
                worksheet.Name = "Карта сотрудника";
                worksheet.Columns[1].ColumnWidth = 21;
                worksheet.Columns[2].ColumnWidth = 21;
                worksheet.Cells[1, 1] = "Название организации";
                worksheet.Cells[1, 1].HorizontalAlignment = excel.XlHAlign.xlHAlignCenter;
                worksheet.Cells[1, 1].VerticalAlignment = excel.XlHAlign.xlHAlignCenter;
                worksheet.get_Range("A1", "B6").Borders.LineStyle = excel.XlLineStyle.xlContinuous;
                worksheet.Cells[3, 1] = "ФИО сотрудника";
                worksheet.Cells[4, 1] = "Должность сотрудника";
                worksheet.Cells[5, 1] = "Логин сотрудника";
                worksheet.Cells[6, 1] = "Пароль сотрудника";

                worksheet.Cells[3, 2].HorizontalAlignment = excel.XlHAlign.xlHAlignCenter;
                worksheet.Cells[4, 2].HorizontalAlignment = excel.XlHAlign.xlHAlignCenter;
                worksheet.Cells[5, 2].HorizontalAlignment = excel.XlHAlign.xlHAlignCenter;
                worksheet.Cells[6, 2].HorizontalAlignment = excel.XlHAlign.xlHAlignCenter;

                worksheet.Cells[3, 2] = FIO_sotr;
                worksheet.Cells[4, 2] = Dolj;
                worksheet.Cells[5, 2] = Login_sotr;
                worksheet.Cells[6, 2] = Password_sotr;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                workbook.SaveAs(name, application.DefaultSaveFormat);
                workbook.Close();
                application.Quit();
                MessageBox.Show("Документ сформирован Путь:" + Application.StartupPath + "\\Отчёты\\Excel\\Карта сотрудника" + DateTime.Now.ToString("_hh_mm_ss_dd_MM_yyyy") + ".xlsx");

            }
        }

        private void ButExc_Click(object sender, EventArgs e)
        {
            Document_Excel("Иванов Иван Иванович", "Супервайзер", "Supervaiser", "Supervaiser123");
        }

        private void WordExcelPdf_FormClosed(object sender, FormClosedEventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
        }

        private void WordExcelPdf_Load(object sender, EventArgs e)
        {
            this.BackColor = AuthRegConnect.col;
        }
    }
}
