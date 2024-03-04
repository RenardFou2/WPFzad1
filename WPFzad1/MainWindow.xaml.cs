using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
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

namespace WPFzad1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CouponMachine machine = new CouponMachine();
        public MainWindow()
        {

            InitializeComponent();
            UpdateLabel();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            inputTB.Text = machine.DrawCoupon();
            UpdateLabel();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            machine.AddCoupon(inputTB.Text);
            UpdateLabel();
        }

        private void UpdateLabel()
        {
            displayLabel.Content = "Wszystkie kupony w maszynie:\n" + string.Join("\n", machine.ViewAllCoupons()); ;
        }
    }
}
