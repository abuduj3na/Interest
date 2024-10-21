using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Interest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        double capital;
        double desiredCapital;
        double years;
        double totalMoney;
        double interest;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            years = 0;
            capital = double.Parse(startCapitalTextBox.Text);
            desiredCapital = double.Parse(desiredCapitalTextBox.Text);
            interest = double.Parse(InterestTextBox.Text)/100;
            totalMoney = 0;
            
            while (capital < desiredCapital) {

                capital += capital * interest;
                //capital *= desiredCapital;

                years++;
            outputTextBox.Text += $"Waarde na {years} jaren: € {string.Format("{0:0.00}", capital)}\n";
            }
            


        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            outputTextBox.Clear();
            startCapitalTextBox.Clear();
            desiredCapitalTextBox.Clear();
            InterestTextBox.Clear();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}