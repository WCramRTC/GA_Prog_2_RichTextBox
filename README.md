# GA_Prog_2_RichTextBox
---
## Control

The Rich Text Box is a control that lets the user enter in long form text into our application. Unlike a TextBox, where only a small piece of information is usually entered ( a single name, or an address, or phone number ) a Rich Text Box can be used for Paragraphs ( A Letter of Reccomendation, Explination for an Accident or Return, etc... )

Rich Text Boxes can become complex as they allow you to format your Application with formatted text, colors, styles, and even images. We are not touching on that now. We are taking the basic route.

***NAME THE `Run`, DO NOT NAME YOUR `RichTextBox`***
This is because our controls have multiple parts to them. The `RichTextBox` does not control the text being display, but the `Run` tag inside of it does. By Giving it a name we can interact with the element interacting with the text.

***Designer***
```
<RichTextBox> // Don't Name This
    <FlowDocument>
        <Paragraph>
            <Run x:Name="rtbDisplay" Text="Give Run a Name"/> // <--- Name this
        </Paragraph>
    </FlowDocument>
</RichTextBox>
```

***Code***
```
    Get : string variable = rtbDisplay.Text; // Retrieves text 
    Set : rtbDisplay.Text = "Change the text; // Changes Text
```


### TL:DR - Quick Assignment Goals



**Part 1** - Display Text
1. Create a new wpf project, name it GA_***YourName***_RTB
2. Add Controls: ( Give Any Control you plan to interact with a name. )   
    1. Rich Text Box and give the `Run` a name, suggested `rtbDisplay`.
    2. Regular text box ( For the user to type a message )
    3. Lable ( Content = "Type a Message" )
    4. Button ( Content = "Display" ), and give it click event.
3. On Click Add **Display** the text from your textbox to your Rich Text Box.  
***This should replace previous text in the rich text box.***  

**Result**: When you click your button, the text in the text box should appear in your rich text box


> --- 
**Part 2**  - Append Text
>
4. Add controls :
    1. Text box ( To hold a second message )
    2. Label ( Content = "Message To Append )
    3. Button, give it another event.( Content = "Append" )
5. On Click have the Text from your new text box **Append** to the text box.  
***Append means add onto, +=***

**Result**: When you click the button, the text from you new text box should be **Added** to the Rich Text Box. Not Replace it.

---
**Part 3**  - Display Text From one RTB to Another

6. Add Controls:
    1. `Rich Text Box`, and give the `Run` a name.
    2. Button and click event. ( Content = "Appened Message to Rich Text Box" )
7. On click **Append** the text from your **New** `Rich Text Box` to your **First** `Rich Text Box`

**Result**: When you click the button, the text from your **New** Rich Text Box should be appened to your **First** Rich Text Box.

 ---
**Part 4**  - Clear Text

8. Add Controls : 
    1. Button ( Content = "Clear" ).
9. On click, have the Button clear BOTH Rich Text Boxes.

**Result**: On Click, both Rich Text Boxes should be empty.

---

**Submission : Submit your GitHub Repo URL**

---

## Step By Step

### Create a new WPF project and name it "GA_YourName_RTB."

### Part 1 - Display Text

1. Add the following controls to your main window:

* RichTextBox ( Run: Name="`rtbDisplay`" )
* TextBox ( Name=`txtDisplayMessage`).
* Label (Content = "`Type a Message`").
* Button (Name = `btnDisplayMessage`, Content=`Display`) Add a click event.

`Designer`
```xaml
    <Label Content="Type a Message"/>
    <TextBox x:Name="txtSingleMessageDisplay" />
    <Button Content="Display" Name="btnDisplay" Click="btnDisplay_Click"/>
    <RichTextBox>
        <FlowDocument>
            <Paragraph>
                <Run x:Name="rtbDisplay" />
            </Paragraph>
        </FlowDocument>
    </RichTextBox>
```


2. In the Click event handler of the "Display" button, add the following code to display the text from the TextBox into the RichTextBox, replacing the previous text:

> Similar to TextBoxes, assigning a value will replace the old value.  
> `richTextBox.Text = "New Message"`

`Code`
```csharp
    private void btnDisplay_Click(object sender, RoutedEventArgs e)
    {
        // Button Display message from
        // txtDisplay to rtbDisplay REPLACING the message
        string message = txtSingleMessageDisplay.Text;

        rtbDisplay.Text = message;

    } // btnDisplay_Click
```

***Result***
Run your application. Clicking the "Display" button should display the text entered in the TextBox in the RichTextBox, replacing any previous text.

---

### Part 2 - Append Text

1. Add the following controls to your project:

* TextBox ( Name="`txtAppendMessage` )
* Label (Content should be "Message To Append").
* Button (Content = "`Append Text`", x:Name="`btnAppend`").

`Designer`
```xml
    <Label Content="Message To Append"/>
    <TextBox x:Name="txtAppendMessage" />
    <Button Content="Append Text" x:Name="btnAppend" Click="btnAppend_Click"/>
```



2. In the Click event handler of the "Append" button, add the following code to append the text from the new TextBox to the RichTextBox:

> By using the `Compound Operator +=` you can APPEND to the current text string in the box. This does not replace the text, but adds to it.
> `richTextBox.Text += "Append Message"`  
> Use a `"\n"` at the end to go to the next line.

`Code`
```csharp
    // Part 2 - Append a Message
    private void btnAppend_Click(object sender, RoutedEventArgs e)
    {
        // Appends message from text box to the rtbDisplay
        string messageToAppend = txtAppendMessage.Text;

        // Doing \n to newline
        rtbDisplay.Text += "\n" + messageToAppend;
    }
```

***Result***

Run your application. Clicking the "Append" button should append the text from the second TextBox to the existing text in the RichTextBox.

---

### Part 3 - Display Text From One RTB to Another
1 . Add controls.

* Another RichTextBox control to your project (Run : Name="`rtbNewRtb`" )

* Button ( Name = "`btnAppendNewRtb`").

`Designer`
```xml
    
    <Button Content="Append Text" x:Name="btnAppendNewRtb" Click="btnAppendNewRtb_Click"/>

    <RichTextBox>
        <FlowDocument>
            <Paragraph>
                <Run x:Name="rtbNewRtb" />
            </Paragraph>
        </FlowDocument>
    </RichTextBox>
```

2. In the Click event handler of the new button, add the following code to append the text from the new RichTextBox to the first RichTextBox:

> You can ***Get*** the text using the `.Text` property, just like a text box.  
> `string message = richTextBox.Text;

`Code`
```csharp
    // Part 3 - Append from a Rich Text Box
        private void btnAppendNewRtb_Click(object sender, RoutedEventArgs e)
        {
            string fullMessage = rtbNewRtb.Text;

            rtbDisplay.Text += "\n" + fullMessage;
        }
```

***Result***

Run your application. Clicking the "Append Message to Rich TextBox" button should append the text from the new RichTextBox to the first RichTextBox.

---

### Part 4 - Clear Text
1 . Add 
* Button ( Name = `btnClear`, Content = ` Clear Both Rich Text Boxes`) and a click event.

`Designer`
```xml
    <Button Content="AClear Both Rich Text Boxes" x:Name="btnClear" Click="btnClear_Click"/>
```

In the Click event handler of this button, add the following code to clear both RichTextBox controls:

> There are 2 ways to clear your text box. You can either assign an empty string, or call the `.ClearValue()` method. Your choice.  
> 1. `richTextBox.Text = "";`  
> 2. `richTextBox.ClearValue();`

`Code`
```csharp
    // Part 4 - Clears Boxes
    private void btnClear_Click(object sender, RoutedEventArgs e)
    {
        rtbNewRtb.Text = "";
        rtbDisplay.Text = "";
    }
```

***Result***
Run your application. Clicking the "Clear" button should clear both RichTextBox controls.

---
## Submission
Push your finished Repo online, then submit your GitHub Repo URL to the text box