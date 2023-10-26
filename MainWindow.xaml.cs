﻿using System;
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

    } // class

} // namespace

// Rich Text Box
// 2 Text Box
// 2 Button

//> **Part 1 * *-Display Text
//> 1.Create a new wpf project, name it GA_***YourName***_RTB
//> 2. Add a Rich Text Box and give the `Run` a name.
//> 3. Add a regular text box and a button ( Content = "Display" ), and give it click event.
//> 4. On Click Add **Display** the text from your textbox to your Rich Text Box.  
//> ***This should replace previous text in the rich text box.***  

//> **Result**: When you click your button, the text in the text box should appear in your rich text box

//> --- 
//> **Part 2**  - Append Text
//>
//> 5. Add another text box and button, give it another event.
//> 6. On Click have the Text from your new text box **Append * *to the text box.  
//> ***Append means add onto, +=***
//>
//> **Result**: When you click the button, the text from you new text box should be **Added** to the Rich Text Box. Not Replace it.

//> ---
//> **Part 3**  - Display Text From one RTB to Another
//>
//> 7. Add a new `Rich Text Box`, and give the `Run` a name.
//> 8. Add another button and click event.
//> 9. On click **Append** the text from your **New** `Rich Text Box` to your **First** `Rich Text Box`
//>
//> **Result**: When you click the button, the text from your **New** Rich Text Box should be appened to your **First** Rich Text Box.

//> ---
//> **Part 4**  - Clear Text
//>
//> 10. Add a new button(Content = "Clear").
//> 11.On click, have the Button clear BOTH Rich Text Boxes.
//>
//> **Result**: On Click, both Rich Text Boxes should be empty.
//>
//> ---
//> **Submission : Submit your GitHub Repo URL**
