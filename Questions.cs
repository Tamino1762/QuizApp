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
            //var arrayItem = "";

            foreach(string item in questions)
            {
                q = item;
                continue;
                
            }

            //get question - loop through questions, get answer
            //for (int i = 0; i < questions.Length; i++)
            //{
                
            //    q = questions[i];
            //    //break;
            //    //continue;
            //    string next = questions[i + 1];
               
            //}
            return q;
                //check answer
                //if answer is correct, add to score
                //when questions are done, display score
        }


    }
}
