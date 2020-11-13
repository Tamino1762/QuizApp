using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Schema;

namespace QuizApp
{
    public class Questions
    {
        private static string[] questions = new string[] {
                "There are 3 sharps in the key of A Major.", "An F7 chord includes a C", "A minor chord includes a lowered 3rd.",
                "The key of C minor has 3 flats","A Concerto consists of 3 movements."};


        public Questions()
        {

        }

        public static string Questioner(string question)
        {
            int score = 0;
            string q = "?";

            //get question - loop through questions, get answer
            for (int i = 0; i < questions.Length; i++)
            {
                
                q = questions[i];
                break;
               
            }
            return q + 1;
                //check answer
                //if answer is correct, add to score
                //when questions are done, display score
        }



        //public static string Questioner(string question)
        //{
        //    bool result;
        //    for (int i = 0; i < questions.Length; i++)
        //    {
        //        if (questions[i].Equals(questions))
        //        {
        //            result = answers[i];
        //            break;
        //        }
        //    }
        //    return;
        //}
    }
}
