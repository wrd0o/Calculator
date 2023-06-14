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

namespace Calculator
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public double FirstNumber;
        public string Operation;
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }
        private void BtnX_Click(object sender, RoutedEventArgs e)
        {
          this.Close();
        }

        private void BtnMin_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void BtnPer_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnCE_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnC_Click(object sender, RoutedEventArgs e)
        {
            Screen.Clear();
        }

        private void BtnBackSpace_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnDivision_Click(object sender, RoutedEventArgs e)
        {
            FirstNumber = Convert.ToDouble(Screen.Text);
            Screen.Text = "0";
            Operation = "/";
        }

        private void BtnXS_Click(object sender, RoutedEventArgs e)
        {
            FirstNumber = Convert.ToDouble(Screen.Text);
            Screen.Text = "0";
            Operation = "*";
        }

        private void BtnMinus_Click(object sender, RoutedEventArgs e)
        {
            FirstNumber = Convert.ToDouble(Screen.Text);
            Screen.Text = "0";
            Operation = "-";
        }

        private void BtnPlus_Click(object sender, RoutedEventArgs e)
        {
            FirstNumber = Convert.ToDouble(Screen.Text);
            Screen.Text = "0";
            Operation = "+";
        }

        private void BtnEquals_Click(object sender, RoutedEventArgs e)
        {
            double SecondNumber;
            double Result;

            SecondNumber = Convert.ToDouble(Screen.Text);

            if (Operation == "+")
            {
                Result = (FirstNumber + SecondNumber);
                Screen.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "-")
            {
                Result = (FirstNumber - SecondNumber);
                Screen.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "*")
            {
                Result = (FirstNumber * SecondNumber);
                Screen.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "/")
            {
                if (SecondNumber == 0)
                {
                    Screen.Text = "Cannot divide by zero";

                }
                else
                {
                    Result = (FirstNumber / SecondNumber);
                    Screen.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }
            }
        }

        private void BtnDot_Click(object sender, RoutedEventArgs e)
        {
            if (!Screen.Text.Contains("."))
            {
                Screen.Text += ".";
            }
        }

        private void Btn0_Click(object sender, RoutedEventArgs e)
        {
            if (Screen.Text == "0" && Screen.Text != null)
            {
                Screen.Text = "0";
            }
            else
            {
                Screen.Text += "0";
            }
        }

        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            if (Screen.Text == "0" && Screen.Text != null)
            {
                Screen.Text = "1";
            }
            else
            {
                Screen.Text += "1";
            }
        }

        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            if (Screen.Text == "0" && Screen.Text != null)
            {
                Screen.Text = "2";
            }
            else
            {
                Screen.Text += "2";
            }
        }

        private void Btn3_Click(object sender, RoutedEventArgs e)
        {
            if (Screen.Text == "0" && Screen.Text != null)
            {
                Screen.Text = "3";
            }
            else
            {
                Screen.Text += "3";
            }
        }

        private void Btn4_Click(object sender, RoutedEventArgs e)
        {
            if (Screen.Text == "0" && Screen.Text != null)
            {
                Screen.Text = "4";
            }
            else
            {
                Screen.Text += "4";
            }
        }

        private void Btn5_Click(object sender, RoutedEventArgs e)
        {
            if (Screen.Text == "0" && Screen.Text != null)
            {
                Screen.Text = "5";
            }
            else
            {
                Screen.Text += "5";
            }
        }

        private void Btn6_Click(object sender, RoutedEventArgs e)
        {
            if (Screen.Text == "0" && Screen.Text != null)
            {
                Screen.Text = "6";
            }
            else
            {
                Screen.Text += "6";
            }
        }

        private void Btn7_Click(object sender, RoutedEventArgs e)
        {
            if (Screen.Text == "0" && Screen.Text != null)
            {
                Screen.Text = "7";
            }
            else
            {
                Screen.Text += "7";
            }
        }

        private void Btn8_Click(object sender, RoutedEventArgs e)
        {
            if (Screen.Text == "0" && Screen.Text != null)
            {
                Screen.Text = "8";
            }
            else
            {
                Screen.Text += "8";
            }
        }

        private void Btn9_Click(object sender, RoutedEventArgs e)
        {
            if (Screen.Text == "0" && Screen.Text != null)
            {
                Screen.Text = "9";
            }
            else
            {
                Screen.Text += "9";
            }
        }
    }
}
