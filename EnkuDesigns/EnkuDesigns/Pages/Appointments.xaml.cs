using EnkuDesigns.Models;
using EnkuDesigns.Utility;
using Exel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using Microsoft.Office.Interop.Excel;
using System;
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
    /// Interaction logic for Appointments.xaml
    /// </summary>
    public partial class Appointments : UserControl
    {
        EnkuDesignDBContext mydb = new EnkuDesignDBContext();

        public Appointments()
        {
            InitializeComponent();
            LoadAppointmentsTable();
        }

        private void AppointButtonClick(object sender, RoutedEventArgs e)
        {
            try { 
            Appointment appointmentgiven = new Appointment
            {
                Name = customername.Text.ToString(),
                Phone = customerphone.Text.ToString(),
                Id = 12,
                Price = Double.Parse(appointmentprice.Text.ToString()),
                PaidAmount = Double.Parse(appointmentpaidamount.Text.ToString()),
                RemainingAmount = (Double)(Double.Parse(appointmentprice.Text.ToString()) - Double.Parse(appointmentpaidamount.Text.ToString())),
                AppointmentDate = string.Format("{0:D}", (DateTime)appointmentdate.SelectedDate)
            };
            mydb.Appointments.Add(appointmentgiven);
            mydb.SaveChanges();
            LoadAppointmentsTable();
                //AppAddedSnackbar.Visibility = Visibility.Visible;
            }
            catch (Exception) { }
        }
        public void LoadAppointmentsTable()
        {
            AppointmentsDataGrid.ItemsSource = new EnkuDesignDBContext().Appointments.ToList();
        }

        private void Teset(object sender, RoutedEventArgs e)
        {
            Console.WriteLine(string.Format("{0:D}", (DateTime)appointmentdate.SelectedDate));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AppointmentsExport(object sender, RoutedEventArgs e)
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

                for (int i = 0; i < new EnkuDesignDBContext().Appointments.ToList().ToArray().Length; i++)
                {
                    for (int j = 0; j < AppointmentsDataGrid.Columns.Count; j++)
                    {
                        if (cellRowIndex == 1)
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = AppointmentsDataGrid.Columns[j].Header.ToString();
                        }

                        TextBlock textBlock = AppointmentsDataGrid.Columns[j].GetCellContent(AppointmentsDataGrid.Items[i]) as TextBlock;
                        worksheet.Cells[cellRowIndex + 1, cellColumnIndex] = textBlock.Text;

                        cellColumnIndex++;
                    }
                    cellColumnIndex = 1;
                    cellRowIndex++;
                }
                
                workbook.SaveAs("Appointments.xlsx");
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

        private void RefreshPage(object sender, RoutedEventArgs e)
        {
            LoadAppointmentsTable();
        }

        private void SaveChanges(object sender, RoutedEventArgs e)
        {
            try
            {
                using (EnkuDesignDBContext context = new EnkuDesignDBContext())
                {

                    Appointment item = AppointmentsDataGrid.SelectedItem as Appointment;
                    Appointment mem = context.Appointments.Where(b => b.Id == item.Id).Single();
                    mem.Name = (AppointmentsDataGrid.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;
                    mem.Phone = (AppointmentsDataGrid.SelectedCells[1].Column.GetCellContent(item) as TextBlock).Text;
                    //mem.LastName = (AppointmentsDataGrid.SelectedCells[3].Column.GetCellContent(item) as TextBlock).Text;
                    mem.Price = double.Parse((AppointmentsDataGrid.SelectedCells[2].Column.GetCellContent(item) as TextBlock).Text);
                    mem.PaidAmount = double.Parse((AppointmentsDataGrid.SelectedCells[3].Column.GetCellContent(item) as TextBlock).Text);
                    mem.RemainingAmount = double.Parse((AppointmentsDataGrid.SelectedCells[4].Column.GetCellContent(item) as TextBlock).Text);
                    context.SaveChanges();
                    AppointmentsDataGrid.ItemsSource = context.Appointments.ToList();
                };
                TableUpdateSnackbar.Visibility = Visibility.Visible;
            }
            catch (Exception) { }
        }

        private void HideScakBars(object sender, RoutedEventArgs e)
        {
            TableUpdateSnackbar.Visibility = Visibility.Hidden;
        }

        private void LoadFilteredTable() {
            try { 
            string newDate = string.Format("{0:D}", AppointmentDateSelector.SelectedDate);
            List<Appointment> appointments = new EnkuDesignDBContext().Appointments.ToList().Where(a => a.AppointmentDate.ToString().Equals(newDate)).ToList();
            AppointmentsDataGrid.ItemsSource = appointments;
            }
            catch (Exception) { }
        }

        private void ChangeMainTable(object sender, SelectionChangedEventArgs e)
        {
            LoadFilteredTable();
        }

        private void searchAppointment(object sender, KeyEventArgs e)
        {
            using (EnkuDesignDBContext context = new EnkuDesignDBContext())
            {
                var filltedMember = new EnkuDesignDBContext().Appointments.ToList().Where(x => x.Name.ToString().Contains(searchTextBox.Text));
                AppointmentsDataGrid.ItemsSource = filltedMember.ToList();
            }
        }

        private void DressDelivered(object sender, RoutedEventArgs e)
        {
            using (EnkuDesignDBContext context = new EnkuDesignDBContext())
            {
                try
                {
                    Console.WriteLine("this is in the deliver dress function * before manipulation");
                    string IdMemeber = ((AppointmentsDataGrid.SelectedItem as Appointment).Name).ToString();
                    Appointment delivereddress = (from r in context.Appointments where (r.Name.ToString()) == IdMemeber select r).SingleOrDefault();
                    context.Appointments.Remove(delivereddress);
                    context.SaveChanges();
                    AppointmentsDataGrid.ItemsSource = context.Appointments.ToList();
                    Console.WriteLine("this is in the deliver dress function");
                }
                catch (Exception ) { }
            }
        }
    }
}