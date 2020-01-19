using EnkuDesigns.Models;
using EnkuDesigns.Utility;
using System;
using Exel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using Microsoft.Office.Interop.Excel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EnkuDesigns.Pages
{
    /// <summary>
    /// Interaction logic for DailyTransaction.xaml
    /// </summary>
    public partial class DailyTransaction : UserControl
    {

        EnkuDesignDBContext mydb = new EnkuDesignDBContext();
        public DailyTransaction()
        {
            InitializeComponent();
            LoadDailyReportsTable();
            LoadWeeklyReportsTable();
        }

        private void AddSalesButtonClicked(object sender, RoutedEventArgs e)
        {
            try
            {
                Transaction dailysaletransaction = new Transaction
                {
                    Id = 111,
                    Item = solddress.Text.ToString(),
                    Price = Double.Parse(sellprice.Text.ToString()),
                    Cashier = cashiersell.Text.ToString(),
                    Date = string.Format("{0:D}", (DateTime)Selldate.SelectedDate),
                    Type = "SALE"
                };

                mydb.Transactions.Add(dailysaletransaction);
                mydb.SaveChanges();
                LoadDailyReportsTable();
                UpdateWeeklyReport(dailysaletransaction);
                String dressid = dailysaletransaction.Item;
                UpdateDressAmount(dressid);
            }
            catch (Exception) { }
        }

        private void UpdateDressAmount(string dressid)
        {
            try
            {
                using (EnkuDesignDBContext context = new EnkuDesignDBContext())
                {
                    Dress dress = context.Dresses.Where(dd => dd.Id.ToString().Equals(dressid)).Single();
                    if (dress.Amount == 1)
                    {
                        Dress dresstoremove = context.Dresses.Where(dd => dd.Id.ToString().Equals(dressid)).Single();
                        context.Dresses.Remove(dresstoremove);
                    }
                    else
                    {
                        dress.Amount = dress.Amount - 1;
                    }

                    context.SaveChanges();
                }
            }
            catch (Exception) { }
        }

        private void AddExpensesButtonClicked(object sender, RoutedEventArgs e)
        {
            try
            {
                Transaction dailyexpensetransaction = new Transaction
                {
                    Id = 111,
                    Item = itemname.Text.ToString(),
                    Price = Double.Parse(expenditure.Text.ToString()),
                    Cashier = cashierexpense.Text.ToString(),
                    Date = string.Format("{0:D}", (DateTime)Expensedate.SelectedDate),
                    Type = "EXPENSE"
                };

                mydb.Transactions.Add(dailyexpensetransaction);
                mydb.SaveChanges();
                LoadDailyReportsTable();
                UpdateWeeklyReport(dailyexpensetransaction);
            }
            catch (Exception) { }
        }

        public void LoadDailyReportsTable()
        {
            try
            {
                using (EnkuDesignDBContext context = new EnkuDesignDBContext())
                {
                    DataGrid.ItemsSource = context.Transactions.ToList();
                }
            }
            catch (Exception) { }
        }

        private void UpdateWeeklyReport(Transaction dailytransaction)
        {
            using (EnkuDesignDBContext context = new EnkuDesignDBContext())
            {
                String date = dailytransaction.Date.ToString();
                Console.WriteLine($"The date passed is : {date}");
                try
                {

                    TransactionReport treport = context.TransactionReports.Where(tr => tr.Date.ToString().Equals(date)).Single();

                    Console.WriteLine($"The date extracted is : {treport.Date.ToString()}");
                    if (dailytransaction.Type == "SALE")
                    {
                        Console.WriteLine($"Inside the if");
                        treport.Sale = treport.Sale + dailytransaction.Price;
                        treport.Net = treport.Net + dailytransaction.Price;
                        context.SaveChanges();
                        LoadWeeklyReportsTable();
                    }
                    else if (dailytransaction.Type == "EXPENSE")
                    {
                        treport.Expense = treport.Expense + dailytransaction.Price;
                        treport.Net = treport.Net - dailytransaction.Price;
                        context.SaveChanges();
                        LoadWeeklyReportsTable();
                    }

                }
                catch (Exception)
                {
                    
                    if (dailytransaction.Type == "SALE")
                    {

                        Console.WriteLine($"Inside the exception if ");
                        context.TransactionReports.Add(new TransactionReport()
                        {
                            Date = dailytransaction.Date,
                            Sale = dailytransaction.Price,
                            Expense = 0.0,
                            Net = dailytransaction.Price
                        });
                        context.SaveChanges();
                        LoadWeeklyReportsTable();
                    }
                    else if (dailytransaction.Type == "EXPENSE")
                    {
                        context.TransactionReports.Add(new TransactionReport()
                        {
                            Date = dailytransaction.Date,
                            Sale = 0.0,
                            Expense = dailytransaction.Price,
                            Net = -1 * dailytransaction.Price
                        });
                        context.SaveChanges();
                        LoadWeeklyReportsTable();
                    }
                }
            }
        }

        private void Test(Transaction T)
        {
            DateTime d = DateTime.Now;
            String date = string.Format("{0:D}", d);
            Double sale = 90.00;
            Double expense = 7639.9;
            Double net = 10;

            TransactionReport a = new TransactionReport
            {
                Date = date,
                Sale = sale,
                Expense = expense,
                Net = net
            };

            mydb.TransactionReports.Add(a);
            mydb.SaveChanges();
            LoadWeeklyReportsTable();
        }
        public void LoadWeeklyReportsTable()
        {
            try
            {
                using (EnkuDesignDBContext context = new EnkuDesignDBContext())
                {
                    WeeklyDataGrid.ItemsSource = null;
                    WeeklyDataGrid.ItemsSource = context.TransactionReports.ToList();
                }
            }
            catch (Exception) { }
        }

        private void roweventhandler(object sender, DataGridRowEventArgs e)
        {
            try
            {
                TransactionReport cm = (TransactionReport)e.Row.DataContext;
                if (cm.Net < 0)
                {
                    e.Row.Background = new SolidColorBrush(Colors.LightPink);
                }
                else
                {
                    e.Row.Background = new SolidColorBrush(Colors.LightGreen);

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void DailyReportExcel(object sender, RoutedEventArgs e)
        {
            _Application excel = new Exel.Application();
            _Workbook workbook = excel.Workbooks.Add(Type.Missing);
            _Worksheet worksheet = null;

            try
            {
                worksheet = workbook.ActiveSheet;
                worksheet.Name = "ExportedFromDatGrid";

                int cellRowIndex = 1;
                int cellColumnIndex = 1;

                for (int i = 0; i < new EnkuDesignDBContext().Transactions.ToList().ToArray().Length; i++)
                {
                    Console.WriteLine("First for");
                    for (int j = 0; j < DataGrid.Columns.Count; j++)
                    {

                        Console.WriteLine("*******Second for");
                        if (cellRowIndex == 1)
                        {

                            Console.WriteLine("iiiiiiIIIIFFFFFF");
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = DataGrid.Columns[j].Header.ToString();
                        }

                        TextBlock textBlock = DataGrid.Columns[j].GetCellContent(DataGrid.Items[i]) as TextBlock;
                        worksheet.Cells[cellRowIndex + 1, cellColumnIndex] = textBlock.Text;

                        cellColumnIndex++;
                    }
                    cellColumnIndex = 1;
                    cellRowIndex++;
                }

                Console.WriteLine("----------------------Out of the loops");

                workbook.SaveAs("Daily.xlsx");
                MessageBox.Show("Exported Successfully!!");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                excel.Quit();
                workbook = null;
                excel = null;
            }

        }

        private void refreshTableDaily(object sender, RoutedEventArgs e)
        {
            LoadDailyReportsTable();
        }

        private void RefreshWeek(object sender, RoutedEventArgs e)
        {
            LoadWeeklyReportsTable();
        }

        private void weekToExcel(object sender, RoutedEventArgs e)
        {
            _Application excel = new Exel.Application();
            _Workbook workbook = excel.Workbooks.Add(Type.Missing);
            _Worksheet worksheet = null;

            try
            {
                worksheet = workbook.ActiveSheet;
                worksheet.Name = "ExportedFromDatGrid";

                int cellRowIndex = 1;
                int cellColumnIndex = 1;

                for (int i = 0; i < new EnkuDesignDBContext().TransactionReports.ToList().ToArray().Length; i++)
                {
                    for (int j = 0; j < WeeklyDataGrid.Columns.Count; j++)
                    {
                        if (cellRowIndex == 1)
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = WeeklyDataGrid.Columns[j].Header.ToString();
                        }

                        TextBlock textBlock = WeeklyDataGrid.Columns[j].GetCellContent(WeeklyDataGrid.Items[i]) as TextBlock;
                        worksheet.Cells[cellRowIndex + 1, cellColumnIndex] = textBlock.Text;

                        cellColumnIndex++;
                    }
                    cellColumnIndex = 1;
                    cellRowIndex++;
                }

                workbook.SaveAs("Weekly.xlsx");
                MessageBox.Show("Exported Successfully!!");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                excel.Quit();
                workbook = null;
                excel = null;
            }

        }

        private void SearchWeek(object sender, KeyEventArgs e)
        {
            using (EnkuDesignDBContext context = new EnkuDesignDBContext())
            {
                var filltedMember = new EnkuDesignDBContext().TransactionReports.ToList().Where(x => x.Date.ToString().Contains(WeekTextBox.Text));
                WeeklyDataGrid.ItemsSource = filltedMember.ToList();
            }
        }

        private void ChangereportTable(object sender, SelectionChangedEventArgs e)
        {
            string newDate = string.Format("{0:D}", ReportDateSelector.SelectedDate);
            List<Transaction> appointments = new EnkuDesignDBContext().Transactions.ToList().Where(a => a.Date.ToString().Equals(newDate)).ToList();
            DataGrid.ItemsSource = appointments;
        }
    }
}
