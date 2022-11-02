using System;
using System.Collections.Generic;
using System.Data;
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

namespace CALC
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            foreach (UIElement elmnt in Buttons.Children)
            {
                if(elmnt is Button)
                {
                    ((Button)elmnt).Click += ButtonClick;
                }
            }
        }

        private void ButtonClick(Object sender, RoutedEventArgs e)
        {
            string textButton = ((Button)e.OriginalSource).Content.ToString();
            if (textButton == "C")
            {
                value.Text ="";
            }
            else
            if (textButton == "x")
            {
                value.Text = value.Text.Substring(value.Text.Length - 1);
            }
            else if (textButton == "=")
            {
                value.Text = new DataTable().Compute(value.Text, null).ToString();
            }
            else value.Text += textButton;
        }
    }
}
