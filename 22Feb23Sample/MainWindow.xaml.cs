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

namespace _22Feb23Sample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string message = "";
        private int limit = 5;
        private int count = 0;

        public MainWindow()
        {
            InitializeComponent();

            message = "Please input your name in the textbox!";
            changeWindowMessage();

            if(txtbInput.Text.Length == 0)
            {
                btnWelcome.IsEnabled = false;
            }

            something(btnWelcome);
        }

        private void changeWindowMessage()
        {
            myWindow.Title = message;
        }

        private void btnWelcome_Click(object sender, RoutedEventArgs e)
        {
            message = "Welcome! " + txtbInput.Text + ", this is my program!";
            changeWindowMessage();
            count++;

            if (count > limit)
                this.Close();

        }

        private void txtbInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            //MessageBox.Show("Value change!");
            if (txtbInput.Text.Length == 0)
                btnWelcome.IsEnabled = false;
            else
                btnWelcome.IsEnabled = true;
        }

        private void something(Button thisButton)
        {

        }
    }
}
