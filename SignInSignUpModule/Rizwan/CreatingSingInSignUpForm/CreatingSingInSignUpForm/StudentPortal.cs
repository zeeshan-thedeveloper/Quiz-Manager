using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreatingSingInSignUpForm
{
    public partial class FormStudentPortal : Form
    {
        public FormStudentPortal()
        {
            InitializeComponent();
        }
        public string CurrentStudent
        {
            get { return labelCurrentStdName.Text; }
            set { labelCurrentStdName.Text = value; }
        }
    }
}
