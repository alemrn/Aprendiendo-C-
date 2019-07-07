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

namespace SummonersAplication
{
    /// <summary>
    /// Lógica de interacción para ExpenseItHome.xaml
    /// </summary>
    public partial class ExpenseItHome : Page
    {
        public ExpenseItHome()
        {
            InitializeComponent();
        }
        private void Arenaclick(object sender, RoutedEventArgs e)
        {
            // View Expense Report
            ExpenseReportPage expenseReportPage = new ExpenseReportPage();
            this.NavigationService.Navigate(expenseReportPage);

        }
        private void GWClick(object sender, RoutedEventArgs e)
        {
            // View Expense Report
            GW gwclass = new GW();
            this.NavigationService.Navigate(gwclass);

        }
        private void ToAClick(object sender, RoutedEventArgs e)
        {
            // View Expense Report
            Toa toaclass = new Toa();
            this.NavigationService.Navigate(toaclass);

        }
        private void TartarussClick(object sender, RoutedEventArgs e)
        {
            // View Expense Report
            Tartaruss tartaruss = new Tartaruss();
            this.NavigationService.Navigate(tartaruss);

        }
        private void CloseClick(object sender, RoutedEventArgs e)
        {
            // View Expense Report
            ExpenseReportPage expenseReportPage = new ExpenseReportPage();
            this.NavigationService.Navigate(expenseReportPage);

        }
    }
   

}
