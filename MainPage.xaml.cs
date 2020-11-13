using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace QuizApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        //array of questions
        //array of answers
        //answer logic

        int score = 0;
        string question = "";
        //true button
        void Handle_True(object sender, System.EventArgs e)
        {
            score += 1;
            question += Questions.Questioner(question);
            theQuestion.Text = question;
            //when clicked, keep answer, go to next question

        }
        //false button
        void Handle_False(object sender, System.EventArgs e)
        {
            //when clicked, keep answer, go to next question
        }

        void Handle_Start(object sender, System.EventArgs e)
        {
            start.IsVisible = false;
            trueButton.IsVisible = true;
            falseButton.IsVisible = true;
            question += Questions.Questioner(question);
            theQuestion.Text = question;
            
        }
        //question place - Questions.Questioner
        //theQuestions += Questions.Questioner(*local variable here*)
        //theQuestion.Text = theQuestions;

    }
}
