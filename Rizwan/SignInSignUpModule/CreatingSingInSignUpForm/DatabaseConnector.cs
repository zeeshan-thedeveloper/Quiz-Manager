using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;
using System.Windows.Forms;

namespace CreatingSingInSignUpForm
{
    /*
     * This class will contain the methods of firebase.
     */
    

    class DatabaseConnector
    {


        IFirebaseConfig firebaseConfig = new FirebaseConfig()
        {
            AuthSecret = "B8TF0CKoDilcxxfaCEwcoo5vR0Pj3and90JyojSm",
            BasePath = "https://demosigninsignup-75858-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient firebaseClient;

       public DatabaseConnector()
        {
            try 
            {
                firebaseClient = new FireSharp.FirebaseClient(firebaseConfig);

//                MessageBox.Show("Connection Build Successfully");

            }
            catch 
            {
               
              MessageBox.Show("Error in Building Connection");
                
            }
        }

        public void  SinIn_Method(string email, string password, string category)
        {
            Console.WriteLine("In SignIN");
            var get = firebaseClient.Get("@"+category +"/"+ email);
            StudentTeacherDataSenderToFirebase datareciever = new StudentTeacherDataSenderToFirebase();
        //    datareciever=get.ResultAs<>
            // Console.WriteLine(get.ToString());

        }

        public  void CreateNewAccount(string fname,string lname,string email,string mbl,string category)
        {
           


                
                StudentTeacherDataSenderToFirebase datasender = new StudentTeacherDataSenderToFirebase()
                {
                    FName = fname,
                    LName = lname,
                    Email = email,
                    Mobile = mbl
                };
     //       try
      //      {
                var set = firebaseClient.Set("@" + category + "/" + email, datasender);
                MessageBox.Show("Account has been successfully Created!");

        //    }

          //  catch 
          //  {
//                MessageBox.Show("There is Sending/Path Problem");


  //          }



        }
        /*
         * Here we will get the credentials.... as well.
         */

    }

     
    }


