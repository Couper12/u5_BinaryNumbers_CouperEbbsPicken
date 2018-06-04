/*
 * Couper EbbsPicken
 * 6/4/2018
 * write decimals as binary
 */
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

namespace u5_BinaryNumbers_CouperEbbsPicken
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            txtDecimal.Text += "Decimal" + "\r" + "\n";
            txtBinary.Text += "Binary" + "\r" + "\n";

            for (int i = 1; i < 21; i++)
            {
                txtDecimal.Text += i.ToString() + "\r" + "\n";
                txtBinary.Text += Convert.ToString(i, 2) + "\r" + "\n";
            }

        }
    }
}
