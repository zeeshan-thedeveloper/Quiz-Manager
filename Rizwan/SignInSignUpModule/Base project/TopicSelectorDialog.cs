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
namespace Base_project
{
    public partial class TopicSelectorDialog : Form
    {

        Form1 form1;
        CreateQuizParentWindow createQuizParentWindow;
        OpenQuizParentWindow openQuizParentWindow;
        public TopicSelectorDialog(Form1 form1,CreateQuizParentWindow createQuizParentWindow,OpenQuizParentWindow openQuizParentWindow)
        {
            InitializeComponent();
            listBox1.SelectionMode = SelectionMode.One;
            this.form1 = form1;
            this.createQuizParentWindow = createQuizParentWindow;
            this.openQuizParentWindow = openQuizParentWindow;
        }

        private void TopicSelectorDialog_Load(object sender, EventArgs e)
        {
            foreach (String subject in GlobalStaticVariablesAndMethods.GetTableNames())
            {
                comboBoxSubjects.Items.Add(subject);
            }

        }

        private void comboBoxSubjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            String subject = comboBoxSubjects.SelectedItem.ToString();
            ArrayList  topics = DatabaseManager.GetAllQuizTopics(subject);

            GlobalStaticVariablesAndMethods.currentSubjectName = subject;

            foreach (String topic in topics)
            {
                listBox1.Items.Add(topic);
            }


        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count > 0)
            {
                

                createQuizParentWindow.MdiParent = form1;
                createQuizParentWindow.Show();
                createQuizParentWindow.BringToFront();
                createQuizParentWindow.Dock = DockStyle.Top;



                //setting the isQuizSavedflag;

                GlobalStaticVariablesAndMethods.isCurrentQuizTopicSaved = false;

                //Create a dataset to hold the questions...

                GlobalStaticVariablesAndMethods.currentQuectionNumber = 1;

                GlobalStaticVariablesAndMethods.currentDataSetUsedForHoldingQuestions = DatasetManager.createDataSetForHoldingQuestions(GlobalStaticVariablesAndMethods.currentSubjectName);
                GlobalStaticVariablesAndMethods.currentSizeOfDataSet = GlobalStaticVariablesAndMethods.currentDataSetUsedForHoldingQuestions.Tables[0].Rows.Count;

                //We will now use this gloabl variable to store questions.
                this.Hide();


            }
            else
            {
                GlobalStaticVariablesAndMethods.CreateErrorMessage(GlobalStaticVariablesAndMethods.NoTopicSelectedErrorMessage);
            }
        }

       

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {

               GlobalStaticVariablesAndMethods.currentDataSetUsedForHoldingQuestions = DatasetManager.createDataSetForHoldingQuestions(GlobalStaticVariablesAndMethods.currentSubjectName);

                openQuizParentWindow.MdiParent = form1;
               openQuizParentWindow.Show();
               openQuizParentWindow.BringToFront();
               openQuizParentWindow.Dock = DockStyle.Top;

              


                this.Hide();
            }
            else
            {
                GlobalStaticVariablesAndMethods.CreateErrorMessage(GlobalStaticVariablesAndMethods.NoTopicSelectedErrorMessage);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count > 0)
            {
                GlobalStaticVariablesAndMethods.currentTopicName = listBox1.SelectedItem.ToString();
            }
        }
    }
}
