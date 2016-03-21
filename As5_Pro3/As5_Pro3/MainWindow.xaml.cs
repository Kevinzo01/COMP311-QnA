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

namespace As5_Pro3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public double savingBal = 1;
        public double chequingBal = 5000.00;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void clickButton_Click(object sender, RoutedEventArgs e)
        {
            double amount;
            //Deposit in savings 
            if (saveradbtn.IsChecked == true &&
                DepRadBtn.IsChecked == true &&
                Double.TryParse(textBoxAmount.Text, out amount))
            {
                MessageBox.Show(String.Format("You are about to deposit to {0:c} to your saving account. Press OK to continue.", amount),
                "Savings/Deposit Transaction", MessageBoxButton.OK, MessageBoxImage.Information);
                textBoxAmount.Text = (String.Format("{0}", amount));
                savingBal += amount;
                textBoxBalance.Text = (String.Format("{0:c}", savingBal));
            }
            //Deposit in Chequing 
            else if (chequeradbtn.IsChecked == true &&
                    DepRadBtn.IsChecked == true &&
                    Double.TryParse(textBoxAmount.Text, out amount))
            {
                MessageBox.Show(String.Format("You are about to deposit to {0:c} to your Chequing Account. Press OK to continue.", amount),
              "Chequing/Deposit Transaction", MessageBoxButton.OK, MessageBoxImage.Information);
                textBoxAmount.Text = (String.Format("{0}", amount));
                chequingBal += amount;
                textBoxBalance.Text = (String.Format("{0:c}", chequingBal));
            }
            //Withdraw from savings
            else if (saveradbtn.IsChecked == true &&
                    WithRadBtn.IsChecked == true &&
                    Double.TryParse(textBoxAmount.Text, out amount))
            {
                MessageBox.Show(String.Format("You are about to withdraw to {0:c} to your Saving Account. Press OK to continue.", amount),
                "Savings/Withdraw Transaction", MessageBoxButton.OK, MessageBoxImage.Information);
                textBoxAmount.Text = (String.Format("{0}", amount));
                savingBal -= amount;
                if (savingBal == 0)
                {
                    MessageBox.Show(String.Format("You have a balance of $0.00 ",
                        "Balance", MessageBoxButton.OK, MessageBoxImage.Exclamation));
                }
                else if (savingBal < -1)
                {
                    MessageBox.Show(String.Format("Your balance is now in the negatives",
                    "Negative Balance", MessageBoxButton.OK, MessageBoxImage.Exclamation));
                }
                textBoxBalance.Text = (String.Format("{0:c}", savingBal));
            }
            //Withdrawing from Chequing 
            else if (chequeradbtn.IsChecked == true &&
                    WithRadBtn.IsChecked == true &&
                    Double.TryParse(textBoxAmount.Text, out amount))
            {
                MessageBox.Show(String.Format("You are about to withdraw to {0:c} to your chequing Account. Press OK to continue.", amount),
                "Withdraw/chequingBal Transaction", MessageBoxButton.OK, MessageBoxImage.Information);
                textBoxAmount.Text = (String.Format("{0}", amount));
                chequingBal -= amount;
                if (savingBal == 0)
                {
                    MessageBox.Show(String.Format("You have a balance of $0.00 ",
                        "Balance", MessageBoxButton.OK, MessageBoxImage.Exclamation));
                }
                else if (savingBal < -1)
                {
                    MessageBox.Show(String.Format("Your balance is now in the negatives",
                    "Negative Balance", MessageBoxButton.OK, MessageBoxImage.Exclamation));
                }
                textBoxBalance.Text = (String.Format("{0:c}", chequingBal));
            }

        }
       
        private void clickButton2_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        

    }
}
