# GA_Prog_2_RichTextBox
---
## Goal
The goal here is to 

### TL:DR - Quick Assignment Goals

***Designer***
```
<RichTextBox Margin="247,129,247,158">
    <FlowDocument>
        <Paragraph>
            <Run x:Name="rtbDisplay" Text="Give Run a Name"/>
        </Paragraph>
    </FlowDocument>
</RichTextBox>
```

***Code***
```
    Get : string variable = rtbDisplay.Text;
    Set : rtbDisplay.Text = "Change the text;
```

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
## Control

### How it works

> This
> That
>
> Everything else


---
## Step By Step