using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
namespace Base_project
{
   partial class CreateQuizParentWindow
    {
       
        private void panelAddNewQuestion_Paint(object sender, PaintEventArgs e)
        {
           
            labelQuestionNumber.Text = "Question  Number: " + GlobalStaticVariablesAndMethods.currentQuectionNumber;

     
        }

        private void CQBold_BTN_Click(object sender, EventArgs e)
        {

        }

        private void CQUnderLine_BTN_Click(object sender, EventArgs e)
        {

        }

        private void CQItalic_BTN_Click(object sender, EventArgs e)
        {

        }

        private void CQHighLight_BTN_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxCQFontSize_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxFontFaimily_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonCQSaveQuestion_Click(object sender, EventArgs e)
        {
            //Before saving a question we need to check few things.
            //1. is any option from options is selected.
            //2. is only one option is selected.

            //Accessing the collection of objects from flow panel.
            if(doesFlowLayoutContainRadioButton() && comboBoxCOptionsType.SelectedIndex==0)
            {
                comboBoxCOptionsType.SelectedIndex = 1;
            }

            if (comboBoxCOptionsType.SelectedIndex == 0)
            {
                //Becuase this is only for mcqs not true false.
                bool isChec = true, isOneChecked = false;
                int index = 0;
                if (comboBoxCOptionsType.SelectedIndex == 0)
                {
                    foreach (CheckBox controls in flowLayoutPanelCQOptions.Controls)
                    {
                        if (controls.Checked)
                        {
                            isChec = false;
                            index++;
                        }
                        if (index >= 2)
                        {
                            isOneChecked = true;
                            break;
                        }

                    }
                }

                if (flowLayoutPanelCQOptions.Controls.Count == 0)
                {
                    //this means no options are added
                    GlobalStaticVariablesAndMethods.CreateErrorMessage(GlobalStaticVariablesAndMethods.NotAddedOptionsErrorMessage);
                }
                else if (isOneChecked)
                {
                    //this means more than one check box are selected.
                    GlobalStaticVariablesAndMethods.CreateErrorMessage(GlobalStaticVariablesAndMethods.MultipleOptionSelectedErrorMessage);
                }
                else if (isChec)
                {
                    //this means no option from list is selected;
                    GlobalStaticVariablesAndMethods.CreateErrorMessage(GlobalStaticVariablesAndMethods.UnSelectedErrorMessage);
                }

                else
                {
                    //Here we will add question in current dataset

                    //so we need to do 2 things here
                    //1. generate a string having all options seprated with ';'

                    String asnwers = "";
                    String rightAnswer = ""; 
                    foreach (var controls in flowLayoutPanelCQOptions.Controls)
                    {
                        if (controls is RadioButton)
                        {
                            RadioButton radioButton = controls as RadioButton;
                            //if options are true and false.
                            asnwers += radioButton.Text + ";";
                            if (radioButton.Checked)
                            {
                                rightAnswer = radioButton.Text;
                            }
                        }
                        else
                        {
                            //if mcsqs
                            CheckBox checkBox = controls as CheckBox;
                            asnwers += checkBox.Text + ";";
                            if (checkBox.Checked)
                            {
                                rightAnswer = checkBox.Text;
                            }
                        }
                    }

                    // DatasetManager.insertRowInTable(ref questionDataTable, textBoxQuestionText.Text, asnwers, rightAnswer);


                    DatasetManager.insertRowInTable(GlobalStaticVariablesAndMethods.currentDataTableUsedForHoldingQuestions, textBoxQuestionText.Text,asnwers, rightAnswer);

                    Console.WriteLine("Zis"+GlobalStaticVariablesAndMethods.currentDataSetUsedForHoldingQuestions.Tables[0].Rows.Count);
                    //Here we will store in dataset.
                        CLEARALL();

                   

                }

            }
            else if (comboBoxCOptionsType.SelectedIndex == 1)
            {
                String asnwers = "";
                String rightAnswer="";
                foreach (var controls in flowLayoutPanelCQOptions.Controls)
                {
                    if (controls is RadioButton)
                    {
                        RadioButton radioButton = controls as RadioButton;
                        //if options are true and false.
                        asnwers += radioButton.Text + ";";
                        if(radioButton.Checked)
                         rightAnswer = radioButton.Text;
                    }
                    else
                    {
                        //if mcsqs
                        CheckBox checkBox = controls as CheckBox;
                        asnwers += checkBox.Text + ";";
                        if (checkBox.Checked)
                            rightAnswer = checkBox.Text;
                        
                    }
                }

                //Here we will store in dataset.
              
                    CLEARALL();

                    GlobalStaticVariablesAndMethods.currentQuectionNumber = GlobalStaticVariablesAndMethods.currentQuectionNumber+1;

                    labelQuestionNumber.Text = "Question Number: " + GlobalStaticVariablesAndMethods.currentQuectionNumber;
              
               

            }
            else if (comboBoxCOptionsType.SelectedIndex < 0)
            {
                GlobalStaticVariablesAndMethods.CreateErrorMessage(GlobalStaticVariablesAndMethods.NoOptionTypeSelectedErrorMessage);
            }


        }

        private void buttonCQAddoption_Click(object sender, EventArgs e)
        {
            if (richTextBoxOptiontext.Text.Length <= 0)
            {
                GlobalStaticVariablesAndMethods.CreateErrorMessage(GlobalStaticVariablesAndMethods.NoTextFoundInOptionTextBoxErrorMessage);

                return;
            }

            //Here we will add choice options
            if (comboBoxCOptionsType.SelectedIndex == 0 && ! doesFlowLayoutContainRadioButton())
            {

                //Mcqs
                CheckBox checkBox = new CheckBox();
                checkBox.Text = richTextBoxOptiontext.Text;
                checkBox.Width = ((checkBox.Text).Length) * 50;
                checkBox.Height = 30;
                flowLayoutPanelCQOptions.Controls.Add(checkBox);

            }
            else if (flowLayoutPanelCQOptions.Controls.Count == 0 && comboBoxCOptionsType.SelectedIndex == 1)
            {

                //True/False
                RadioButton rbTrue = new RadioButton();
                RadioButton rbFalse = new RadioButton();

                rbTrue.Width = 100;
                rbTrue.Height = 30;
                rbTrue.Text = "True";
                rbTrue.Checked = radioButtonTrueOption.Checked;

                flowLayoutPanelCQOptions.Controls.Add(rbTrue);


                rbFalse.Width = 100;
                rbFalse.Height = 30;
                rbFalse.Text = "False";
                rbFalse.Checked = radioButtonFalseOption.Checked;

                flowLayoutPanelCQOptions.Controls.Add(rbFalse);

            }
            else
            {
                GlobalStaticVariablesAndMethods.CreateErrorMessage(GlobalStaticVariablesAndMethods.CantAddMultipleTrueFalseErrorMessage);
            }

        }

        private void buttonRemoveOptionsFromlist_Click(object sender, EventArgs e)
        {
            int index = 0;
            foreach (var control in flowLayoutPanelCQOptions.Controls)
            {
                if (control is RadioButton)
                {
                    flowLayoutPanelCQOptions.Controls.Clear();
                    break;
                }
                else
                {
                    CheckBox checkBox = control as CheckBox;
                    if (checkBox.Checked)
                    {
                        flowLayoutPanelCQOptions.Controls.RemoveAt(index);
                    }
                }
                index++;
            }
        }

        private void comboBoxCOptionsType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCOptionsType.SelectedIndex == 0)
            {
                groupBoxAddOptionsPanel.Controls.Add(panelMsqsTypeOptions);

                panelMsqsTypeOptions.Location = new Point(19, 73);
                panelMsqsTypeOptions.BringToFront();
                panelMsqsTypeOptions.Visible = true;

            }
            else if (comboBoxCOptionsType.SelectedIndex == 1)
            {
                groupBoxAddOptionsPanel.Controls.Add(panelTrueFalseOptions);

                panelTrueFalseOptions.Location = new Point(19, 73);
                panelTrueFalseOptions.BringToFront();
                panelTrueFalseOptions.Visible = true;
            }


        }

        //Functions of Test editor
        public void Bold_Function(RichTextBox richTextbox_text_processor)
        {
            richTextbox_text_processor.SelectionFont = new Font(SystemFonts.DefaultFont.FontFamily, SystemFonts.DefaultFont.Size, FontStyle.Bold);
        }

        //HighLight Function
        public void HighLight_Function(RichTextBox richTextbox_text_processor)
        {
            richTextbox_text_processor.SelectionBackColor = Color.Yellow;
        }

        // Italic Function
        public void Italic_Function(RichTextBox richTextbox_text_processor)
        {
            richTextbox_text_processor.SelectionFont = new Font(SystemFonts.DefaultFont.FontFamily, SystemFonts.DefaultFont.Size, FontStyle.Italic);
        }

        //UnderLine Function
        public void UnderLine_Function(RichTextBox richTextbox_text_processor)
        {
            richTextbox_text_processor.SelectionFont = new Font(SystemFonts.DefaultFont.FontFamily, SystemFonts.DefaultFont.Size, FontStyle.Underline);
        }

        // there function are passed to to combo box event to get selected value from combo box and edit rich text box according to that
        //font type  Set Functions
        public void SetFont_Function(RichTextBox richTextbox1)
        {
            string Font = comboBoxFontFaimily.SelectedItem.ToString();
            richTextbox1.SelectionFont = new System.Drawing.Font(Font, SystemFonts.DefaultFont.Size, SystemFonts.DefaultFont.Style);
        }

        //Text size Set Function
        public void SetSize_Function(RichTextBox richTextBox)
        {
            if (comboBoxCQFontSize.SelectedItem != null)
            {
                int size = Int32.Parse(comboBoxCQFontSize.SelectedItem.ToString());
                richTextBox.SelectionFont = new Font(SystemFonts.DefaultFont.FontFamily, size, SystemFonts.DefaultFont.Style);
            }
            else
            {
                richTextBox.SelectionFont = new Font(SystemFonts.DefaultFont.FontFamily, SystemFonts.DefaultFont.Size, SystemFonts.DefaultFont.Style);
            }
        }

        //Utiliy funtions...

        private bool doesFlowLayoutContainRadioButton()
        {
            foreach (var control in flowLayoutPanelCQOptions.Controls)
            {
                if (control is RadioButton)
                {
                    return true;
                }
            }
            return false;
        }

        private void CLEARALL()
        {
            flowLayoutPanelCQOptions.Controls.Clear();
            textBoxQuestionText.Text = "";

        }
    }
}
