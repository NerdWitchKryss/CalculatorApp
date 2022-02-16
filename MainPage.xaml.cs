using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace CalculatorApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void goodbyeButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(goodbyePage));
        }

        private void additionButton_Click(object sender, RoutedEventArgs e)
        {
            int box1Num, box2Num, answerNum;
            box1Num = Convert.ToInt32(textBox1.Text);
            box2Num = Convert.ToInt32(textBox2.Text);
            answerNum = box1Num + box2Num;
            answerBox.Text = Convert.ToString(answerNum);
            if(answerNum < 0)
            {
                answerBox.Foreground = new SolidColorBrush(Windows.UI.Colors.Red);
            }
            else if (answerNum > 0)
            {
                answerBox.Foreground = new SolidColorBrush(Windows.UI.Colors.Black);
            }
        }

        private void multiplyButton_Click(object sender, RoutedEventArgs e)
        {
            int box1Num, box2Num, answerNum;
            box1Num = Convert.ToInt32(textBox1.Text);
            box2Num = Convert.ToInt32(textBox2.Text);
            answerNum = box1Num * box2Num;
            answerBox.Text = Convert.ToString(answerNum);
            if(answerNum < 0)
            {
                answerBox.Foreground = new SolidColorBrush(Windows.UI.Colors.Red);
            }
            else if(answerNum > 0)
            {
                answerBox.Foreground = new SolidColorBrush(Windows.UI.Colors.Black);
            }
        }

        private void resetButton_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
            answerBox.Text = "0";
            int box1Num = 0, box2Num = 0, answerNum = 0;
            box1Num = Convert.ToInt32(textBox1.Text);
            box2Num = Convert.ToInt32(textBox2.Text);
            answerNum = Convert.ToInt32(answerBox.Text);
            if (answerNum < 0)
            {
                answerBox.Foreground = new SolidColorBrush(Windows.UI.Colors.Red);
            }
            else if (answerNum > 0)
            {
                answerBox.Foreground = new SolidColorBrush(Windows.UI.Colors.Black);
            }
        }
    }
}
