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
        String question { get; set; }
        ArrayList options { get; set; }

        QuizQuestionDataHolder(String question, ArrayList options)
        {
            this.question = question;
            this.options = options;
        }

    }
}
