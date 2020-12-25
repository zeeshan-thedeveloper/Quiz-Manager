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
        private Panel panelCreateNewQuiz;
        private Panel panelQuestionOptionHoler;
        private Panel panelTrueFasleOptions;
        private GroupBox groupBox3;
        private RadioButton radioButtonTrueOption;
        private RadioButton radioButtonFalseOptoin;
        private Label label4;
        private Panel panelCQMcqsOptionType;
        private RichTextBox textBoxCQOptionText;
        private Button buttonCQSaveQuestion;
        private GroupBox groupBoxAddOptionsPanel;
        private Label label5;
        private ComboBox comboBoxCOptionsType;
        private Button buttonRemoveOptionsFromlist;
        private Button buttonCQAddoption;
        private GroupBox groupBox2;
        private FlowLayoutPanel flowLayoutPanelCQOptions;
        private Label label8;
        private GroupBox groupBox1;
        private Button CQHighLight_BTN;
        private Button CQBold_BTN;
        private Label Font;
        private Button CQItalic_BTN;
        private ComboBox comboBoxFontFaimily;
        private Button CQUnderLine_BTN;
        private Label label9;
        private ComboBox comboBoxCQFontSize;
        private RichTextBox textBoxQuestionText;

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

        private void buttonSaveQuizInSystem_Click(object sender, EventArgs e)
        {
            panelSaveToDbOptionHoler.Location = new Point(3, 16);
            panelSaveToDbOptionHoler.BringToFront();

        }
        private void buttonCQSaveQuestion_Click(object sender, EventArgs e)
        {

        }

        private void buttonRemoveOptionsFromlist_Click(object sender, EventArgs e)
        {

        }

        private void buttonCQAShowNextQuestion_Click(object sender, EventArgs e)
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

        }


        private void buttonCQAddoption_Click(object sender, EventArgs e)
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

        private void InitializeComponent()
        {
            this.panelCreateNewQuiz = new System.Windows.Forms.Panel();
            this.panelQuestionOptionHoler = new System.Windows.Forms.Panel();
            this.panelTrueFasleOptions = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButtonTrueOption = new System.Windows.Forms.RadioButton();
            this.radioButtonFalseOptoin = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.panelCQMcqsOptionType = new System.Windows.Forms.Panel();
            this.textBoxCQOptionText = new System.Windows.Forms.RichTextBox();
            this.buttonCQSaveQuestion = new System.Windows.Forms.Button();
            this.groupBoxAddOptionsPanel = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxCOptionsType = new System.Windows.Forms.ComboBox();
            this.buttonRemoveOptionsFromlist = new System.Windows.Forms.Button();
            this.buttonCQAddoption = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanelCQOptions = new System.Windows.Forms.FlowLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CQHighLight_BTN = new System.Windows.Forms.Button();
            this.CQBold_BTN = new System.Windows.Forms.Button();
            this.Font = new System.Windows.Forms.Label();
            this.CQItalic_BTN = new System.Windows.Forms.Button();
            this.comboBoxFontFaimily = new System.Windows.Forms.ComboBox();
            this.CQUnderLine_BTN = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxCQFontSize = new System.Windows.Forms.ComboBox();
            this.textBoxQuestionText = new System.Windows.Forms.RichTextBox();
            this.panelCreateNewQuiz.SuspendLayout();
            this.panelQuestionOptionHoler.SuspendLayout();
            this.panelTrueFasleOptions.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panelCQMcqsOptionType.SuspendLayout();
            this.groupBoxAddOptionsPanel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCreateNewQuiz
            // 
            this.panelCreateNewQuiz.BackColor = System.Drawing.Color.Lavender;
            this.panelCreateNewQuiz.Controls.Add(this.panelQuestionOptionHoler);
            this.panelCreateNewQuiz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCreateNewQuiz.Location = new System.Drawing.Point(0, 0);
            this.panelCreateNewQuiz.Name = "panelCreateNewQuiz";
            this.panelCreateNewQuiz.Size = new System.Drawing.Size(1295, 743);
            this.panelCreateNewQuiz.TabIndex = 13;
            // 
            // panelQuestionOptionHoler
            // 
            this.panelQuestionOptionHoler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelQuestionOptionHoler.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelQuestionOptionHoler.Controls.Add(this.panelTrueFasleOptions);
            this.panelQuestionOptionHoler.Controls.Add(this.panelCQMcqsOptionType);
            this.panelQuestionOptionHoler.Controls.Add(this.buttonCQSaveQuestion);
            this.panelQuestionOptionHoler.Controls.Add(this.groupBoxAddOptionsPanel);
            this.panelQuestionOptionHoler.Controls.Add(this.groupBox2);
            this.panelQuestionOptionHoler.Controls.Add(this.label8);
            this.panelQuestionOptionHoler.Controls.Add(this.groupBox1);
            this.panelQuestionOptionHoler.Controls.Add(this.textBoxQuestionText);
            this.panelQuestionOptionHoler.Location = new System.Drawing.Point(31, 75);
            this.panelQuestionOptionHoler.Name = "panelQuestionOptionHoler";
            this.panelQuestionOptionHoler.Size = new System.Drawing.Size(894, 454);
            this.panelQuestionOptionHoler.TabIndex = 0;
            // 
            // panelTrueFasleOptions
            // 
            this.panelTrueFasleOptions.Controls.Add(this.groupBox3);
            this.panelTrueFasleOptions.Controls.Add(this.label4);
            this.panelTrueFasleOptions.Location = new System.Drawing.Point(731, 281);
            this.panelTrueFasleOptions.Name = "panelTrueFasleOptions";
            this.panelTrueFasleOptions.Size = new System.Drawing.Size(238, 142);
            this.panelTrueFasleOptions.TabIndex = 10;
            this.panelTrueFasleOptions.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTrueFasleOptions_Paint);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButtonTrueOption);
            this.groupBox3.Controls.Add(this.radioButtonFalseOptoin);
            this.groupBox3.Location = new System.Drawing.Point(10, 49);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(206, 91);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // radioButtonTrueOption
            // 
            this.radioButtonTrueOption.AutoSize = true;
            this.radioButtonTrueOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonTrueOption.Location = new System.Drawing.Point(136, 52);
            this.radioButtonTrueOption.Name = "radioButtonTrueOption";
            this.radioButtonTrueOption.Size = new System.Drawing.Size(56, 21);
            this.radioButtonTrueOption.TabIndex = 1;
            this.radioButtonTrueOption.TabStop = true;
            this.radioButtonTrueOption.Text = "True";
            this.radioButtonTrueOption.UseVisualStyleBackColor = true;
            // 
            // radioButtonFalseOptoin
            // 
            this.radioButtonFalseOptoin.AutoSize = true;
            this.radioButtonFalseOptoin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonFalseOptoin.Location = new System.Drawing.Point(27, 46);
            this.radioButtonFalseOptoin.Name = "radioButtonFalseOptoin";
            this.radioButtonFalseOptoin.Size = new System.Drawing.Size(60, 21);
            this.radioButtonFalseOptoin.TabIndex = 0;
            this.radioButtonFalseOptoin.TabStop = true;
            this.radioButtonFalseOptoin.Text = "False";
            this.radioButtonFalseOptoin.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Selete the right answer";
            // 
            // panelCQMcqsOptionType
            // 
            this.panelCQMcqsOptionType.Controls.Add(this.textBoxCQOptionText);
            this.panelCQMcqsOptionType.Location = new System.Drawing.Point(728, 123);
            this.panelCQMcqsOptionType.Name = "panelCQMcqsOptionType";
            this.panelCQMcqsOptionType.Size = new System.Drawing.Size(219, 140);
            this.panelCQMcqsOptionType.TabIndex = 9;
            // 
            // textBoxCQOptionText
            // 
            this.textBoxCQOptionText.Location = new System.Drawing.Point(3, 13);
            this.textBoxCQOptionText.Name = "textBoxCQOptionText";
            this.textBoxCQOptionText.Size = new System.Drawing.Size(213, 124);
            this.textBoxCQOptionText.TabIndex = 5;
            this.textBoxCQOptionText.Text = "";
            // 
            // buttonCQSaveQuestion
            // 
            this.buttonCQSaveQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCQSaveQuestion.Location = new System.Drawing.Point(62, 397);
            this.buttonCQSaveQuestion.Name = "buttonCQSaveQuestion";
            this.buttonCQSaveQuestion.Size = new System.Drawing.Size(310, 43);
            this.buttonCQSaveQuestion.TabIndex = 3;
            this.buttonCQSaveQuestion.Text = "Save";
            this.buttonCQSaveQuestion.UseVisualStyleBackColor = true;
            // 
            // groupBoxAddOptionsPanel
            // 
            this.groupBoxAddOptionsPanel.Controls.Add(this.label5);
            this.groupBoxAddOptionsPanel.Controls.Add(this.comboBoxCOptionsType);
            this.groupBoxAddOptionsPanel.Controls.Add(this.buttonRemoveOptionsFromlist);
            this.groupBoxAddOptionsPanel.Controls.Add(this.buttonCQAddoption);
            this.groupBoxAddOptionsPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxAddOptionsPanel.Location = new System.Drawing.Point(477, 170);
            this.groupBoxAddOptionsPanel.Name = "groupBoxAddOptionsPanel";
            this.groupBoxAddOptionsPanel.Size = new System.Drawing.Size(234, 270);
            this.groupBoxAddOptionsPanel.TabIndex = 6;
            this.groupBoxAddOptionsPanel.TabStop = false;
            this.groupBoxAddOptionsPanel.Text = "Add Option";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Type";
            // 
            // comboBoxCOptionsType
            // 
            this.comboBoxCOptionsType.FormattingEnabled = true;
            this.comboBoxCOptionsType.Items.AddRange(new object[] {
            "Mcqs",
            "True/False"});
            this.comboBoxCOptionsType.Location = new System.Drawing.Point(58, 20);
            this.comboBoxCOptionsType.Name = "comboBoxCOptionsType";
            this.comboBoxCOptionsType.Size = new System.Drawing.Size(148, 26);
            this.comboBoxCOptionsType.TabIndex = 7;
            this.comboBoxCOptionsType.Text = "Select type";
            // 
            // buttonRemoveOptionsFromlist
            // 
            this.buttonRemoveOptionsFromlist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemoveOptionsFromlist.Location = new System.Drawing.Point(48, 235);
            this.buttonRemoveOptionsFromlist.Name = "buttonRemoveOptionsFromlist";
            this.buttonRemoveOptionsFromlist.Size = new System.Drawing.Size(144, 29);
            this.buttonRemoveOptionsFromlist.TabIndex = 12;
            this.buttonRemoveOptionsFromlist.Text = "Remove Selected";
            this.buttonRemoveOptionsFromlist.UseVisualStyleBackColor = true;
            // 
            // buttonCQAddoption
            // 
            this.buttonCQAddoption.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCQAddoption.Location = new System.Drawing.Point(48, 198);
            this.buttonCQAddoption.Name = "buttonCQAddoption";
            this.buttonCQAddoption.Size = new System.Drawing.Size(144, 31);
            this.buttonCQAddoption.TabIndex = 7;
            this.buttonCQAddoption.Text = "Add";
            this.buttonCQAddoption.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.flowLayoutPanelCQOptions);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(363, 56);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(348, 107);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Options";
            // 
            // flowLayoutPanelCQOptions
            // 
            this.flowLayoutPanelCQOptions.AutoScroll = true;
            this.flowLayoutPanelCQOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelCQOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelCQOptions.Location = new System.Drawing.Point(3, 20);
            this.flowLayoutPanelCQOptions.Name = "flowLayoutPanelCQOptions";
            this.flowLayoutPanelCQOptions.Size = new System.Drawing.Size(342, 84);
            this.flowLayoutPanelCQOptions.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(24, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 25);
            this.label8.TabIndex = 2;
            this.label8.Text = "Question 01";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CQHighLight_BTN);
            this.groupBox1.Controls.Add(this.CQBold_BTN);
            this.groupBox1.Controls.Add(this.Font);
            this.groupBox1.Controls.Add(this.CQItalic_BTN);
            this.groupBox1.Controls.Add(this.comboBoxFontFaimily);
            this.groupBox1.Controls.Add(this.CQUnderLine_BTN);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.comboBoxCQFontSize);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(29, 183);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 181);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Text Editing tools";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // CQHighLight_BTN
            // 
            this.CQHighLight_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CQHighLight_BTN.Location = new System.Drawing.Point(238, 84);
            this.CQHighLight_BTN.Name = "CQHighLight_BTN";
            this.CQHighLight_BTN.Size = new System.Drawing.Size(143, 34);
            this.CQHighLight_BTN.TabIndex = 15;
            this.CQHighLight_BTN.Text = "High Light";
            this.CQHighLight_BTN.UseVisualStyleBackColor = true;
            // 
            // CQBold_BTN
            // 
            this.CQBold_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CQBold_BTN.Location = new System.Drawing.Point(33, 28);
            this.CQBold_BTN.Name = "CQBold_BTN";
            this.CQBold_BTN.Size = new System.Drawing.Size(143, 34);
            this.CQBold_BTN.TabIndex = 8;
            this.CQBold_BTN.Text = "Bold";
            this.CQBold_BTN.UseVisualStyleBackColor = true;
            // 
            // Font
            // 
            this.Font.AutoSize = true;
            this.Font.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Font.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Font.Location = new System.Drawing.Point(234, 140);
            this.Font.Name = "Font";
            this.Font.Size = new System.Drawing.Size(42, 20);
            this.Font.TabIndex = 14;
            this.Font.Text = "Font";
            // 
            // CQItalic_BTN
            // 
            this.CQItalic_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CQItalic_BTN.Location = new System.Drawing.Point(33, 84);
            this.CQItalic_BTN.Name = "CQItalic_BTN";
            this.CQItalic_BTN.Size = new System.Drawing.Size(143, 34);
            this.CQItalic_BTN.TabIndex = 9;
            this.CQItalic_BTN.Text = "Italic";
            this.CQItalic_BTN.UseVisualStyleBackColor = true;
            // 
            // comboBoxFontFaimily
            // 
            this.comboBoxFontFaimily.AutoCompleteCustomSource.AddRange(new string[] {
            "You will put all usefull font family"});
            this.comboBoxFontFaimily.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFontFaimily.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFontFaimily.FormattingEnabled = true;
            this.comboBoxFontFaimily.Items.AddRange(new object[] {
            "Calibri Light",
            "Georgia",
            "Informal Roman",
            "Freestyle Script",
            "Arial Black",
            "Brush Script MT",
            "Times New Roman"});
            this.comboBoxFontFaimily.Location = new System.Drawing.Point(291, 137);
            this.comboBoxFontFaimily.Name = "comboBoxFontFaimily";
            this.comboBoxFontFaimily.Size = new System.Drawing.Size(90, 28);
            this.comboBoxFontFaimily.TabIndex = 13;
            // 
            // CQUnderLine_BTN
            // 
            this.CQUnderLine_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CQUnderLine_BTN.Location = new System.Drawing.Point(238, 28);
            this.CQUnderLine_BTN.Name = "CQUnderLine_BTN";
            this.CQUnderLine_BTN.Size = new System.Drawing.Size(143, 34);
            this.CQUnderLine_BTN.TabIndex = 10;
            this.CQUnderLine_BTN.Text = "Under Line";
            this.CQUnderLine_BTN.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(29, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "Size";
            // 
            // comboBoxCQFontSize
            // 
            this.comboBoxCQFontSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCQFontSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCQFontSize.FormattingEnabled = true;
            this.comboBoxCQFontSize.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "30",
            "32",
            "34",
            "40",
            "48"});
            this.comboBoxCQFontSize.Location = new System.Drawing.Point(86, 134);
            this.comboBoxCQFontSize.Name = "comboBoxCQFontSize";
            this.comboBoxCQFontSize.Size = new System.Drawing.Size(90, 28);
            this.comboBoxCQFontSize.TabIndex = 11;
            // 
            // textBoxQuestionText
            // 
            this.textBoxQuestionText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxQuestionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxQuestionText.Location = new System.Drawing.Point(35, 66);
            this.textBoxQuestionText.Name = "textBoxQuestionText";
            this.textBoxQuestionText.Size = new System.Drawing.Size(322, 94);
            this.textBoxQuestionText.TabIndex = 0;
            this.textBoxQuestionText.Text = "Test";
            // 
            // TeacherPortal
            // 
            this.ClientSize = new System.Drawing.Size(1295, 743);
            this.Controls.Add(this.panelCreateNewQuiz);
            this.Name = "TeacherPortal";
            this.panelCreateNewQuiz.ResumeLayout(false);
            this.panelQuestionOptionHoler.ResumeLayout(false);
            this.panelQuestionOptionHoler.PerformLayout();
            this.panelTrueFasleOptions.ResumeLayout(false);
            this.panelTrueFasleOptions.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panelCQMcqsOptionType.ResumeLayout(false);
            this.groupBoxAddOptionsPanel.ResumeLayout(false);
            this.groupBoxAddOptionsPanel.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        private void panelShowAllQuestionsOptionHoler_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panelTrueFasleOptions_Paint(object sender, PaintEventArgs e)
        {

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
