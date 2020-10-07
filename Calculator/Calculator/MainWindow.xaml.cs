using System;
using System.Windows;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double FirstNumber;
        string Operation;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            if (textBox1.Text != null)
            {
                textBox1.Text = textBox1.Text + "1";
            }
            else
            {
                textBox1.Text = "1";
            }
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            if (textBox1.Text != null)
            {
                textBox1.Text = textBox1.Text + "2";
            }
            else
            {
                textBox1.Text = "2";
            }
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            if (textBox1.Text != null)
            {
                textBox1.Text = textBox1.Text + "3";
            }
            else
            {
                textBox1.Text = "3";
            }
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            if (textBox1.Text != null)
            {
                textBox1.Text = textBox1.Text + "4";
            }
            else
            {
                textBox1.Text = "4";
            }
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            if (textBox1.Text != null)
            {
                textBox1.Text = textBox1.Text + "5";
            }
            else
            {
                textBox1.Text = "5";
            }
        }

        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            if (textBox1.Text != null)
            {
                textBox1.Text = textBox1.Text + "6";
            }
            else
            {
                textBox1.Text = "6";
            }
        }

        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            if (textBox1.Text != null)
            {
                textBox1.Text = textBox1.Text + "7";
            }
            else
            {
                textBox1.Text = "7";
            }
        }

        private void Button8_Click(object sender, RoutedEventArgs e)
        {
            if (textBox1.Text != null)
            {
                textBox1.Text = textBox1.Text + "8";
            }
            else
            {
                textBox1.Text = "8";
            }
        }

        private void Button9_Click(object sender, RoutedEventArgs e)
        {
            if (textBox1.Text != null)
            {
                textBox1.Text = textBox1.Text + "9";
            }
            else
            {
                textBox1.Text = "9";
            }
        }

        private void Button0_Click(object sender, RoutedEventArgs e)
        {
            if (textBox1.Text != null)
            {
                textBox1.Text = textBox1.Text + "0";
            }
            else
            {
                textBox1.Text = "0";
            }
        }

        private void ButtonPlus_Click(object sender, RoutedEventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            Operation = "+";
            textBox1.Text = textBox1.Text + "+";
        }

        private void ButtonMinus_Click(object sender, RoutedEventArgs e)
        {
            if (textBox1.Text == null||textBox1.Text== "ABS()")
            {
                textBox1.Text =textBox1.Text+ "-";
                if (Operation != "A")
                {
                    Operation = "-";
                }
            }
            else
            {
                Operation = "-";
                textBox1.Text = textBox1.Text + "-";
            }
        }

        private void ButtonTimes_Click(object sender, RoutedEventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            Operation = "*";
            textBox1.Text = textBox1.Text + "*";
        }

        private void ButtonDivide_Click(object sender, RoutedEventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            Operation = "/";
            textBox1.Text = textBox1.Text + "/";
        }

        private void ButtonDecimal_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = textBox1.Text + ",";
        }

        private void ButtonAbs_Click(object sender, RoutedEventArgs e)
        {
            if (textBox1.Text != null)
            {
                textBox1.Text = textBox1.Text + "ABS()";
            }
            else
            {
                textBox1.Text = "ABS()";
            }
            Operation = "A";
        }

        private void ButtonDelete_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length-1);

        }

        private void ButtonDeleteAll_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = null;
        }

        private void ButtonPotentiation_Click(object sender, RoutedEventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            if (textBox1.Text != null)
            {
                textBox1.Text = textBox1.Text + "^";
            }
            else
            {
                textBox1.Text = "^";
            }
            Operation = "^";
        }

        private void ButtonRoot_Click(object sender, RoutedEventArgs e)
        {
            if (textBox1.Text != null)
            {
                textBox1.Text = textBox1.Text + "SQRT:";
            }
            else
            {
                textBox1.Text = "SQRT:";
            }
            Operation = "S";
        }

        private void ButtonPercentage_Click(object sender, RoutedEventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            if (textBox1.Text != null)
            {
                textBox1.Text = textBox1.Text + "%";
            }
            else
            {
                textBox1.Text = "%";
            }
            Operation = "%";
        }

        private void ButtonOptions_Click(object sender, RoutedEventArgs e)
        {
            // this button is left for future upgrades like unit converter, more calculator options... 
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double Result;
            double SecondNumber;

            if (Operation != "A" && Operation != "S")
            {
                string[] numbers = textBox1.Text.Split(Operation);
                SecondNumber = Convert.ToDouble(numbers[1]);
            }
            else
            {
                SecondNumber = 0;
            }

            if (Operation == "+")
            {
                Result = (FirstNumber + SecondNumber);
                textBox1.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "-")
            {
                Result = (FirstNumber - SecondNumber);
                textBox1.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "*")
            {
                Result = (FirstNumber * SecondNumber);
                textBox1.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "/")
            {
                if (SecondNumber == 0)
                {
                    textBox1.Text = "Cannot divide by zero";

                }
                else
                {
                    Result = (FirstNumber / SecondNumber);
                    textBox1.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }
            }
            if (Operation == "^")
            {
                Result = 1;
                for (int i = 1; i <= SecondNumber; i++)
                {
                    Result *= FirstNumber;
                }
                textBox1.Text = Convert.ToString(Result);
            }
            if (Operation == "%")
            {
                Result = FirstNumber % SecondNumber;
                textBox1.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "S")
            {
                string[] solution = textBox1.Text.Split(':');
                Result = Math.Sqrt(Convert.ToDouble(solution[1]));
                textBox1.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "A")
            {
                string[] solution = textBox1.Text.Split(')');
                if (solution[1].StartsWith('-'))
                {
                    Result = Convert.ToDouble(solution[1].Substring(1));
                }
                else
                {
                    Result = Convert.ToDouble(solution[1]);
                }
                textBox1.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
        }
    }
}
