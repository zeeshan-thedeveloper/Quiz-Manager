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
    public partial class SinInAndSinUpScreen : Form
    {
        public static String topicName;
       
        //Declaring instance of StudentPortal Form
        FormStudentPortal studentForm;

        //Declaring instance of TeacherPortal Form
        TeacherPortal teacherPortal;
        DatabaseConnector databaseConnector;// = new DatabaseConnector();

        public SinInAndSinUpScreen()
        {
            InitializeComponent();
        }



        private void SinInAndSinUpScreen_Load(object sender, EventArgs e)
        {
            databaseConnector = new DatabaseConnector();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            panelSininUpOption.Location = new Point(55, 351);
            panelCreateAccount.BringToFront();
            panelCreateAccount.Visible = true;
            panelCreateAccount.Location = new Point(27, 73);
        }

        

        private void button3_Click_1(object sender, EventArgs e)
        {
            panelSininUpOption.Location = new Point(55, 351);
            panelSinIn.BringToFront();
            panelCreateAccount.Visible = false;
            panelSinIn.Location = new Point(41, 95);
        }

        private void buttonCreateAccount_Click(object sender, EventArgs e)
        {
            String fname = textBoxClientFName.Text;
            string lname = textBoxClinetLName.Text;
            string email = textBoxClientEmail.Text;
            string mbl = textBoxClientMobileNumber.Text;
            string category = "";
            
            
            if (radioButtonNewStudent.Checked)
                category = radioButtonNewStudent.Text;
            else
             category = radioButtonNewTeacher.Text;



            databaseConnector.CreateNewAccount(textBoxClientFName.Text, textBoxClinetLName.Text, textBoxClientEmail.Text, textBoxClientMobileNumber.Text, category);
            
               
            // Console.WriteLine("Account Sucessfully Created");
            

        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            string email = "";
            string userpassword = "";
            string category = "";
            email = textUserName.Text;
            userpassword = textBoxUserPass.Text;
            
            if (radioButtonStudent.Checked)
            {
                category = radioButtonNewStudent.Text;
            }
            if (radioButtonTeacher.Checked)
            {
                category = radioButtonTeacher.Text;
            }

            databaseConnector.SinIn_Method(email, userpassword, category);

            /*
            if (DatabaseConnector.SinIn_Method(email, userpassword, category))
            {
                Console.WriteLine("Access Gruanted");
                Console.WriteLine(email +" --"+ userpassword + "--- " + category);
                 this.Visible = false;
                if (radioButtonStudent.Checked)
                {
                    studentForm = new FormStudentPortal();
                    studentForm.Visible = true;
                   
                }
                else if(radioButtonTeacher.Checked)
                {
                   teacherPortal = new TeacherPortal();
                   teacherPortal.ShowDialog();
                   Console.WriteLine("Returned value : "+topicName);
                  
                }
            }
            else if(!DatabaseConnector.SinIn_Method(username, userpassword, category))
            {
                
                Console.WriteLine("Acess Denied");
            }
                     */

        }


    }
}
