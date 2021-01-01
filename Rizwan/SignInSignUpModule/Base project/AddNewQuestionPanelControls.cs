using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Base_project
{
   partial class CreateQuizParentWindow
    {


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

        }

        private void buttonCQAddoption_Click(object sender, EventArgs e)
        {
            //Here we will add choice options
            if (comboBoxCOptionsType.SelectedIndex == 0)
            {
                //Mcqs
                CheckBox checkBox = new CheckBox();
                checkBox.Text = richTextBoxOptiontext.Text;
                checkBox.Width = ((checkBox.Text).Length)*50;
                checkBox.Height = 20;
                flowLayoutPanelCQOptions.Controls.Add(checkBox);
                    
            }
            else
            {
                //True/False
                RadioButton rbTrue = new RadioButton();
                RadioButton rbFalse = new RadioButton();

                rbTrue.Width = 100;
                rbTrue.Height = 20;
                rbTrue.Text = "True";
                rbTrue.Checked= radioButtonTrueOption.Checked;

                flowLayoutPanelCQOptions.Controls.Add(rbTrue);

                
                rbFalse.Width = 100;
                rbFalse.Height = 20;
                rbFalse.Text = "False";
                rbFalse.Checked = radioButtonFalseOption.Checked;

                flowLayoutPanelCQOptions.Controls.Add(rbFalse);

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

    }
}
