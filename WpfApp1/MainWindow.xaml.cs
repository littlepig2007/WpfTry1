using System.Collections.Specialized;
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

namespace WpfApp1
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

        private void txtUserNumber_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnCheckNumber_Click(object sender, RoutedEventArgs e)
        {
            string number = txtUserNumber.Text;
            string res = number switch
            {
                "101" => "101",
                "102" => "102",
                "103" => "103",
                _ => "hall",
            };
            MessageBox.Show($"您进入了{res}");
        }

        private void btnArray_Click(object sender, RoutedEventArgs e)
        {
            string[] strings = { "hello", "world", "!" };
            for (int i = 0; i < strings.Length; i++)
            {
                MessageBox.Show(strings[i]);
            }
        }

        private void btnWatermelon_Click(object sender, RoutedEventArgs e)
        {
            var count = Double.Parse(txtUserNumber.Text);
            const double price = 1.9;
            const double discount = 0.75;
            double totalPrice = price * count;
            var totalDiscountPrice = 10 * (int)(totalPrice / 10) * (1-discount);
            totalPrice -= totalDiscountPrice;
            MessageBox.Show(totalPrice.ToString());
        }
    }
}