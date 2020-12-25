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

        }

        private void buttonRemoveOptionsFromlist_Click(object sender, EventArgs e)
        {

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
