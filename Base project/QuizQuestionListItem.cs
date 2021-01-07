using System;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Base_project
{
    public partial class QuizQuestionListItem : UserControl
    {
        private int _dataSetIndex;

        private int _listIndex;

        private ArrayList _options;

        private string _QuestionData;

        private string _QuizSubject;

        private string _Quiztitle;

        private string _TableRowId;

        public QuizQuestionListItem()
        {
            InitializeComponent();
            richTextBoxListItemQuestion.Enabled = false;
        }

        #region

        [Category("Custom Prop")]
        public int DataSetIndex
        {
            get { return _dataSetIndex; }
            set
            {
                _dataSetIndex = value;
            }
        }

        [Category("Custom Prop")]
        public int ListIndex
        {
            get { return _listIndex; }
            set
            {
                _listIndex = value;
            }
        }

        [Category("Custom Prop")]
        public ArrayList Options
        {
            get { return _options; }
            set
            {
                _options = value;

                ArrayList innnerOptions = value;

                foreach (CheckBox checkBox in innnerOptions)
                {
                    checkBox.Enabled = false;
                    flowLayoutPanelListoptionHolder.Controls.Add(checkBox);
                }
            }
        }

        [Category("Custom Prop")]
        public String QuizQuestionData
        {
            get { return _QuestionData; }
            set { _QuestionData = value; richTextBoxListItemQuestion.Text = value; }
        }

        [Category("Custom Prop")]
        public string QuizSubject
        {
            get { return _QuizSubject; }
            set { _QuizSubject = value; labelQuizSubject.Text = value; }
        }

        [Category("Custom Prop")]
        public string QuizTitle
        {
            get { return _Quiztitle; }
            set { _Quiztitle = value; labelQuizTitle.Text = value; }
        }

        [Category("Custom Prop")]
        public String TableRowId
        {
            get { return _TableRowId; }
            set
            {
                _TableRowId = value;
                labelRowId.Text = value;
            }
        }

        #endregion

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (_TableRowId == null || _TableRowId.Length == 0)
            {
                DatasetManager.deleteQuestionFromDataSet(_listIndex);
                CreateQuizParentWindow.QuestionsListFlowLoayoutPanel.Controls.RemoveAt(_listIndex);//this will update the list.
                GlobalStaticVariablesAndMethods.CreateErrorMessage(GlobalStaticVariablesAndMethods.QuestionDeletedInfoMessage);
            }
            else
            {
                DatasetManager.deleteQuestionFromDataBase(Int32.Parse(_TableRowId));//this will delete question from dataset.

                GlobalStaticVariablesAndMethods.CreateErrorMessage(GlobalStaticVariablesAndMethods.QuestionDeletedInfoMessage);
                CreateQuizParentWindow.QuestionsListFlowLoayoutPanel.Controls.RemoveAt(_listIndex);//this will update the list.
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            buttonSaved.Enabled = true;
            richTextBoxListItemQuestion.Enabled = true;
            foreach (CheckBox checkBox in _options)
            {
                checkBox.Enabled = true;
            }
        }

        private void buttonSaved_Click(object sender, EventArgs e)
        {
            bool isChec = true, isOneChecked = false;
            int index = 0;

            //befor saving changes .... lets checkfew things.
            foreach (CheckBox controls in _options)
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

            if (CreateQuizParentWindow.QuestionsListFlowLoayoutPanel.Controls.Count == 0)
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
                foreach (var controls in _options)
                {
                    if (controls is RadioButton)
                    {
                        RadioButton radioButton = controls as RadioButton;
                        //if options are true and false.
                        asnwers += radioButton.Text + GlobalStaticVariablesAndMethods.seperatorCharactor;
                        if (radioButton.Checked)
                        {
                            rightAnswer = radioButton.Text;
                        }
                    }
                    else
                    {
                        //if mcsqs
                        CheckBox checkBox = controls as CheckBox;
                        asnwers += checkBox.Text + GlobalStaticVariablesAndMethods.seperatorCharactor;
                        if (checkBox.Checked)
                        {
                            rightAnswer = checkBox.Text;
                        }
                    }
                }

                //Here we will update dataset.
                DatasetManager.upddateDataSet(richTextBoxListItemQuestion.Text, asnwers, rightAnswer, Int32.Parse(TableRowId));
                GlobalStaticVariablesAndMethods.CreateInfoMesssage(GlobalStaticVariablesAndMethods.ChangesSavedInDataseInfoMessage);
            }
        }
    }
}