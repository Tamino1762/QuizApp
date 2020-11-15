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
        int score = 0;
        
        private static string[] questions = new string[] {
                "There are 3 sharps in the key of A Major.", "An F7 chord includes a C", "A minor chord includes a lowered 3rd.",
                "The key of C minor has 3 flats","A Concerto consists of 3 movements."};
        int counter;


        //true button
        void Handle_True(object sender, System.EventArgs e)
        {
            score ++;

            theQuestion.Text = questions[counter++ % questions.Length];

            if (counter == 5) {
                finalScore.IsVisible = true;
                geniusLevel.IsVisible = true;
                theQuestion.IsVisible = false;
                trueButton.IsVisible = false;
                falseButton.IsVisible = false;
                finalScore.Text = ($"You got {score} of 5!");

                if(score == 5)
                {
                    geniusLevel.Text = "🎉You are a theory genius!";
                }
                else if (score == 4)
                {
                    geniusLevel.Text = "Almost got it! Go practice.";
                }
                else if (score == 3)
                {
                    geniusLevel.Text = "Not bad for an amateur.";
                }
                else if (score == 2)
                {
                    geniusLevel.Text = "You're a beginner, aren't you?";
                }
                else if (score == 1)
                {
                    geniusLevel.Text = "😖";
                }
                else
                {
                    geniusLevel.Text = "Maybe you should try needlepoint.";
                }
                again.IsVisible = true;
            }
        }
        //false button
        void Handle_False(object sender, System.EventArgs e)
        {
            theQuestion.Text = questions[counter++ % questions.Length];

            if (counter == 5)
            {
                finalScore.IsVisible = true;
                geniusLevel.IsVisible = true;
                theQuestion.IsVisible = false;
                trueButton.IsVisible = false;
                falseButton.IsVisible = false;
                again.IsVisible = false;
                finalScore.Text = ($"You got {score} of 5!");
                if (score == 5)
                {
                    geniusLevel.Text = "You are a theory genius!";
                }
                else if (score == 4)
                {
                    geniusLevel.Text = "Almost got it! Maybe a review would help.";
                }
                else if (score == 3)
                {
                    geniusLevel.Text = "Not bad for an amateur.";
                }
                else if (score == 2)
                {
                    geniusLevel.Text = "You're a beginner, aren't you?";
                }
                else if (score == 1)
                {
                    geniusLevel.Text = "😖";
                }
                else
                {
                    geniusLevel.Text = "Maybe you should try needlepoint.";
                }
                again.IsVisible = true;
            }
        }

        void Handle_Start(object sender, System.EventArgs e)
        {
            
            start.IsVisible = false;
            trueButton.IsVisible = true;
            falseButton.IsVisible = true;
            foreach (string item in questions)
            {
                theQuestion.Text = item;
            }
        }

        void Handle_Again(object sender, System.EventArgs e)
        {
            counter = 0;
            score = 0;
            start.IsVisible = false;
            again.IsVisible = false;
            finalScore.IsVisible = false;
            geniusLevel.IsVisible = false;
            trueButton.IsVisible = true;
            falseButton.IsVisible = true;
            
            
            foreach (string item in questions)
            {
                theQuestion.IsVisible = true;
                theQuestion.Text = item;
            }
        }
    }
}
