using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
namespace Base_project
{
    public partial class QuizQuestionListItem : UserControl
    {
        public QuizQuestionListItem()
        {
            InitializeComponent();
        }

        #region  
        private string _Quiztitle;
        private string _QuizSubject;
        private string _QuestionData;
        private ArrayList _options;

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
        public String QuizQuestionData
        {
            get { return _QuestionData; }
            set { _QuestionData = value; richTextBoxListItemQuestion.Text = value; }
        }

        [Category("Custom Prop")]
        public ArrayList Options
        {
            get { return _options; }
            set { _options = value;

                ArrayList innnerOptions = value;

                foreach (CheckBox checkBox in innnerOptions)
                {
                    flowLayoutPanelListoptionHolder.Controls.Add(checkBox);
                }
                
            }
        }



        #endregion

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deleting "+_Quiztitle);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Editing " + _Quiztitle);
        }
    }
}
