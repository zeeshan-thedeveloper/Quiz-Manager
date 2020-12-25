using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Base_project
{
    public partial class Form1 : Form
    {
        CreateQuizParentWindow createQuizParentWindow;
        OpenQuizParentWindow openQuizParentWindow;
        PrintQuizParentWindow printQuizParentWindow;
        public Form1()
        {
            InitializeComponent();
            createQuizParentWindow = new CreateQuizParentWindow();
            openQuizParentWindow = new OpenQuizParentWindow();
            printQuizParentWindow = new PrintQuizParentWindow();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonCreateNewQuiz_Click(object sender, EventArgs e)
        {

            
            HideChild();
            createQuizParentWindow.MdiParent = this;
            createQuizParentWindow.Show();
            createQuizParentWindow.BringToFront();
            createQuizParentWindow.Dock = DockStyle.Top;
        }

        private void buttonOpenQuiz_Click(object sender, EventArgs e)
        {
            HideChild();
            openQuizParentWindow.MdiParent = this;
            openQuizParentWindow.Show();
            openQuizParentWindow.BringToFront();
            openQuizParentWindow.Dock = DockStyle.Top;
        }
        private void buttonPrint_Click(object sender, EventArgs e)
        {
            HideChild();
            printQuizParentWindow.MdiParent = this;
            printQuizParentWindow.Show();
            printQuizParentWindow.BringToFront();
            printQuizParentWindow.Dock = DockStyle.Top;
        }
        private void HideChild()
        {
            createQuizParentWindow.Hide();
            openQuizParentWindow.Hide();
            printQuizParentWindow.Hide();
        }

     
    }
}
