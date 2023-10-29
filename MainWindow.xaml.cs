using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GA_Prog_2_RichTextBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        } // MainWindow()

        // Part 1 - Display a message
        private void btnDisplay_Click(object sender, RoutedEventArgs e)
        {
            // Button Display message from
            // txtDisplay to rtbDisplay REPLACING the message
            string message = txtSingleMessageDisplay.Text;

            rtbDisplay.Text = message;

        } // btnDisplay_Click

        // Part 2 - Append a Message
        private void btnAppend_Click(object sender, RoutedEventArgs e)
        {
            // Appends message from text box to the rtbDisplay
            string messageToAppend = txtAppendMessage.Text;

            // Doing \n to newline
            rtbDisplay.Text += "\n" + messageToAppend;
        }

        // Part 3 - Append from a Rich Text Box
        private void btnAppendNewRtb_Click(object sender, RoutedEventArgs e)
        {
            string fullMessage = rtbNewRtb.Text;

            rtbDisplay.Text += "\n" + fullMessage;
        }

        // Part 4 - Clears Boxes
        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            rtbNewRtb.Text = "";
            rtbDisplay.Text = "";
        }

  
    } // class

} // namespace

