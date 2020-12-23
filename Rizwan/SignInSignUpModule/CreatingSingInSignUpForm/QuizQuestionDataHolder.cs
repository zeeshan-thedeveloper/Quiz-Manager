using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace CreatingSingInSignUpForm
{
    class QuizQuestionDataHolder
    {
      public  String question { get; set; }
      public  ArrayList options { get; set; }

       public QuizQuestionDataHolder(String question, ArrayList options)
        {
            this.question = question;
            this.options = options;
        }

    }
}
