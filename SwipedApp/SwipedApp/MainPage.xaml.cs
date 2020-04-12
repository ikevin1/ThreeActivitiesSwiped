using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SwipedApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        int index = 0;

        public List<string> questions = new List<String>

        {

            "Spanish is Espanol","The sky is blue.", "Jesus was baptized by John D' Baptise", "Waukesha is a county in Wisconsin", "Wisconsin is the business capital of the US."
            
        };

        //private void prev()
        //{
        //    showQuiz.Text = questions[index--];

        //    if (index <= questions.Count())

        //    {

        //        index = questions.Count - 1;

        //    }
        //}

        //private void next()
        //{
        //    showQuiz.Text = questions[index++];

        //    if (index >= questions.Count())

        //    {

        //        index = 0;

        //    }
        //}

        //public void OnSwipe(Object sender, SwipedEventArgs e)
        //{
        //    if (e.Direction == SwipeDirection.Right)
        //    {
        //        next();
        //    }
        //    else if (e.Direction == SwipeDirection.Left)
        //    {
        //        prev();
        //    }
        //}

        public void OnSwipe(object sender, SwipedEventArgs e)
        {
            switch (e.Direction)
            {
                case SwipeDirection.Left:
                    // Handle the swipe
                    showQuiz.Text = questions[index--];

                    if (index <= questions.Count())

                    {

                        index = questions.Count - 1;

                    }
                    break;
                case SwipeDirection.Right:
                    // Handle the swipe
                    showQuiz.Text = questions[index++];

                    if (index >= questions.Count())

                    {

                        index = 0;

                    }
                    break;
            }
        }

    }
}

