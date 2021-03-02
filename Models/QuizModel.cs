using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Channels;

namespace WebAPI_Lab07.Models
{

    public class QuizAnswers
    {

        public AppUser UserQuesting { get; set; }
        public string Quest1 { get; set; }
        public string Quest1AnswerRight { get; set; }
        public string Quest2 { get; set; }
        public string Quest2AnswerRight { get; set; }
        //public string Quest2 { get; set; }

        public string CheckQuiz(QuizAnswers model)
        {
            string resultQuiz = "Fail!";
              

                if (model.Quest1 == "answer1")
                {
                    model.Quest1AnswerRight = "Correct!";                    
                }
                else
                {
                    model.Quest1AnswerRight = "Incorrect!";
                }
                if (model.Quest2 == "answer2")
                {
                    model.Quest2AnswerRight = "Correct!";
                }
               else
               {
                   model.Quest2AnswerRight = "Incorrect!";
               }
            if (model.Quest1 == "answer1" && model.Quest2 == "answer2" && model.UserQuesting.Name != null)
                    resultQuiz = " Pass!";

          
            return resultQuiz;
        }


    }



}
