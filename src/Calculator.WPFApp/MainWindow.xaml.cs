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
using Calculator.UIBusiness.ViewModel;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ArithmeticViewModel avm;
        
        public MainWindow()
        {          
           
            InitializeComponent();           
            avm = (ArithmeticViewModel)base.DataContext;
        }

        void SetViewModel(string Content)
        {
            avm.UpdateNumber = double.Parse(Content.ToString());
        }
        
        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            SetViewModel(btn7.Content.ToString());
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            SetViewModel(btn8.Content.ToString());
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            SetViewModel(btn9.Content.ToString());
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            SetViewModel(btn4.Content.ToString());
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            SetViewModel(btn5.Content.ToString());
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            SetViewModel(btn6.Content.ToString());
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            SetViewModel(btn1.Content.ToString());
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            SetViewModel(btn2.Content.ToString());
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            SetViewModel(btn3.Content.ToString());
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            SetViewModel(btn0.Content.ToString());
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            avm.RunAdd();
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            avm.RunClearAll();
        }

        private void equal_Click(object sender, RoutedEventArgs e)
        {
            avm.RunEquals();
        }

        private void Multiply_Click(object sender, RoutedEventArgs e)
        {
            avm.RunMultiply();
        }

        private void Subtract_Click(object sender, RoutedEventArgs e)
        {
            avm.RunSubtract();
        }

        private void Divide_Click(object sender, RoutedEventArgs e)
        {
            avm.RunDivide();
        }
    }
}
