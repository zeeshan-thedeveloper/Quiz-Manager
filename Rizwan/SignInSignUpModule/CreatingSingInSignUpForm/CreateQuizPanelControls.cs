using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
namespace CreatingSingInSignUpForm
{
    public partial class TeacherPortal
    {
        /**
         * You have to create varaibles and the fields and properties and every thing in this...
         * */
        static ArrayList optionsList, questionsList;
        private void panelCreateNewQuiz_Paint(object sender, PaintEventArgs e)
        {
            //Here we need to write the actions which should be performed when foerm is loaded
            comboBoxCOptionsType.SelectedIndex = 0;
            optionsList = new ArrayList();
            questionsList = new ArrayList();
            ///labelStartingTextInCenter.Dock = DockStyle.Fill;
           // labelStartingTextInCenter.TextAlign = ContentAlignment.MiddleCenter;

        }

        private void CQBold_BTN_Click(object sender, EventArgs e)
        {

            Bold_Function(textBoxQuestionText);
           
        }

        private void CQUnderLine_BTN_Click(object sender, EventArgs e)
        {
            UnderLine_Function(textBoxQuestionText);

        }

        private void CQHighLight_BTN_Click(object sender, EventArgs e)
        {
            HighLight_Function(textBoxQuestionText);

        }

        private void CQItalic_BTN_Click(object sender, EventArgs e)
        {
            Italic_Function(textBoxQuestionText);
        }


        private void comboBoxCQFontSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetSize_Function(textBoxQuestionText);
        }

        private void comboBoxFontFaimily_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetFont_Function(textBoxQuestionText);
        }


        private void buttonCQAddNewQuestion_Click(object sender, EventArgs e)
        {
            panelQuestionOptionHoler.Location = new Point(3, 16);
            panelQuestionOptionHoler.BringToFront();

        }

        private void buttonCQADeleteQuestion_Click(object sender, EventArgs e)
        {

        }

        private void buttonSaveQuizInSystem_Click(object sender, EventArgs e)
        {
            panelSaveToDbOptionHoler.Location = new Point(3, 16);
            panelSaveToDbOptionHoler.BringToFront();

        }
        private void buttonCQSaveQuestion_Click(object sender, EventArgs e)
        {
            RightAnswerChooserDialog rightAnswerChooserDialog = new RightAnswerChooserDialog( ref optionsList);
            rightAnswerChooserDialog.ShowDialog();
            flowLayoutPanelCQOptions.Controls.Clear();
            foreach (var option in optionsList)
            {
                if (option is CheckBox) flowLayoutPanelCQOptions.Controls.Add(option as CheckBox);
                if (option is RadioButton) flowLayoutPanelCQOptions.Controls.Add(option as RadioButton);

            }

            questionsList.Add(new QuizQuestionDataHolder(textBoxCQOptionText.Text, optionsList));
            MessageBox.Show("Saved");
            ClearEveryThingForNewQuestion();
            //SlideQuestionPanelToLeft();

        }

        private void buttonRemoveOptionsFromlist_Click(object sender, EventArgs e)
        {
            int index = 0;
            foreach (CheckBox checkBox in optionsList.ToArray())
            {

                if (checkBox.Checked)
                {
                    flowLayoutPanelCQOptions.Controls.RemoveAt(index);
                    optionsList.RemoveAt(index);
                }

                index++;
            }

        }

        private void buttonCQAShowNextQuestion_Click(object sender, EventArgs e)
        {

        }

        private void buttonCQShowPrevQuestion_Click(object sender, EventArgs e)
        {

        }

        private void buttonCQShowAllQuestions_Click(object sender, EventArgs e)
        {
            panelShowAllQuestionsOptionHoler.Location = new Point(3, 16);
            panelShowAllQuestionsOptionHoler.BringToFront();

        }
        private void HighLight_BTN_Click(object sender, EventArgs e)
        {
           
        }

        //Listners of Options
        private void comboBoxCOptionsType_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBoxCOptionsType.SelectedItem.ToString().Equals("Mcqs"))
            {

                groupBoxAddOptionsPanel.Controls.Add(panelCQMcqsOptionType);
                panelCQMcqsOptionType.Location = new Point(13, 49);
                panelCQMcqsOptionType.BringToFront();

            }
            else if (comboBoxCOptionsType.SelectedItem.ToString().Equals("True/False"))
            {
                groupBoxAddOptionsPanel.Controls.Add(panelTrueFasleOptions);
                panelTrueFasleOptions.Location = new Point(13, 49);
                panelTrueFasleOptions.BringToFront();
            }
        }


        private void buttonCQAddoption_Click(object sender, EventArgs e)
        {

            if (comboBoxCOptionsType.SelectedItem.ToString().Equals("Mcqs"))
            {
                CheckBox optionDataHolder = new CheckBox();
                optionDataHolder.Text = textBoxCQOptionText.Text;
                optionDataHolder.Height = 50;
                optionDataHolder.Width = 120;
                optionsList.Add(optionDataHolder); //This array will be used when we will store the options along with question in Question array list.
                flowLayoutPanelCQOptions.Controls.Add(optionDataHolder);


            }
            else if (comboBoxCOptionsType.SelectedItem.ToString().Equals("True/False"))
            {


                RadioButton optionDataHolderTrue = new RadioButton();
                optionDataHolderTrue.Text = "True";
                optionDataHolderTrue.Height = 50;
                optionDataHolderTrue.Width = 120;
                if (radioButtonTrueOption.Checked) optionDataHolderTrue.Checked = true;
                optionsList.Add(optionDataHolderTrue); //This array will be used when we will store the options along with question in Question array list.
                flowLayoutPanelCQOptions.Controls.Add(optionDataHolderTrue);

                RadioButton optionDataHolderFalse = new RadioButton();
                optionDataHolderFalse.Text = "False";
                optionDataHolderFalse.Height = 50;
                optionDataHolderFalse.Width = 120;
                if (radioButtonFalseOptoin.Checked) optionDataHolderFalse.Checked = true;
                optionsList.Add(optionDataHolderFalse); //This array will be used when we will store the options along with question in Question array list.
                flowLayoutPanelCQOptions.Controls.Add(optionDataHolderFalse);

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
            richTextbox1.SelectionFont = new Font(Font, SystemFonts.DefaultFont.Size, SystemFonts.DefaultFont.Style);
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

        

        public void ClearEveryThingForNewQuestion()
        {
            optionsList = new ArrayList();
            textBoxCQOptionText.Text = "";
            textBoxQuestionText.Text = "";
            flowLayoutPanelCQOptions.Controls.Clear();

            timerMoveQuestionPanelToLeft.Interval = 5;
            timerMoveQuestionPanelToRight.Interval= 5;

        }

        public void SlideQuestionPanelToLeft()
        {
            timerMoveQuestionPanelToLeft.Tick += PanelMovertoleft_QuestionEditorPanel;
            timerMoveQuestionPanelToLeft.Start();
        }
        public void SlideQuestionPanelToRight()
        {
            timerMoveQuestionPanelToRight.Tick += PanelMoverToRight_QuestionEditorPanel;
            timerMoveQuestionPanelToRight.Start();
        }

        private void PanelMoverToRight_QuestionEditorPanel(object sender, EventArgs e)
        {
            if (panelQuestionOptionHoler.Left <= 40)
            {
                timerMoveQuestionPanelToRight.Stop();
            }
                panelQuestionOptionHoler.Left -= 10;
        }

        private void PanelMovertoleft_QuestionEditorPanel(object sender, EventArgs e)
        {
         if(panelQuestionOptionHoler.Left<=-800)
            {
                timerMoveQuestionPanelToLeft.Stop();
                panelQuestionOptionHoler.Left = 1000;
                
            }
            else
            {
                panelQuestionOptionHoler.Left -= 10;
            }
        }

    }
}
