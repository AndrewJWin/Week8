using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Timers;
using System.Windows.Forms;

/**********************************\
*                                  *
* Andrew Terwilliger 4/2/2020      *
* Minneapolis College              *
* ITEC 2505-60 C# Programming      *
*                                  *
\**********************************/

namespace GeoQuiz
{
    public partial class FormQuiz : Form
    {
        private DateTime startTime = DateTime.Now;

        // Global variables for question number and current score.
        private int QuestionNumber = -1;
        private int Score = 0;
        private readonly SortedList<string, string> questions = new SortedList<string, string>(){
                { "What is the state capital of California?", "Sacramento" },
                { "What is the tallest mountain in the world?", "Everest" },
                { "Which country has the furthest south extent?", "Chile" },
                { "What is the state capitol of Minnesota", "Saint Paul" }
            };

        public FormQuiz()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Forcing the program to load the first question.
            nextQuestion();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txbAnswer.Text))
            {
                checkAnswer();
                nextQuestion();
            }
            else
            {
                MessageBox.Show("Please enter your answer.", "Error");
            }
        }
        private void btnCheat_Click(object sender, EventArgs e)
        {
            KeyValuePair<string, string> question = questions.ElementAt(QuestionNumber);
            string correctAnswer = question.Value;

            // Create the form.
            FormCheating frmCheating = new FormCheating();
            // Set the tag as the current text in the Requests Form.
            frmCheating.Tag = correctAnswer;
            // Show the form as a dialog.
            DialogResult cheatingResults = frmCheating.ShowDialog();

            // The following waits for the Dialog to close before continuing.
            if (frmCheating.Tag is bool)
            {
                txbAnswer.Text = correctAnswer;
            }

        }
        
        // nextQuestion method, increments the current Question number and posts the new question.
        private void nextQuestion()
        {
            QuestionNumber++;

            // Checking if the question number is past the last question in the list, if not - We post the next question.
            if (QuestionNumber < questions.Count)
            {
                KeyValuePair<string, string> question = questions.ElementAt(QuestionNumber);
                string questionText = question.Key;
                lblQuestion.Text = questionText;

                // This sets both the checkboxes as unchecked.
                txbAnswer.Text = "";
            }
            else
            {
                // If we're past the last question in the quiz, the quiz is over.
                
                // Setting the TimeSpan interval between the startTime and the finishTime.
                DateTime finishTime = DateTime.Now;
                TimeSpan interval = finishTime - startTime;
                string timeMinutes = interval.Minutes.ToString();
                string timeSeconds = interval.Seconds.ToString();

                // Setting everything false, as the user doesn't need to interact with this anymore.
                btnCheat.Enabled = false;
                btnCheck.Enabled = false;
                txbAnswer.ReadOnly = true;
                txbAnswer.Text = "";
                lblQuestion.Text = "Quiz Over!";

                // Present the user their final score and how long they took to answer the quiz.
                MessageBox.Show($"Your score is {Score}\nYou took {timeMinutes} minutes and {timeSeconds} seconds.", "Quiz Over!");
                
                // Wait until the MessageBox is closed before finally closing the feild.
                Close();
            }
        }

        // checkAnswer method, reviews the current state of the radio button and checks if it is correct.
        private void checkAnswer()
        {

            if (QuestionNumber < questions.Count)
            {
                KeyValuePair<string, string> question = questions.ElementAt(QuestionNumber);
                string correctAnswer = question.Value;

                if (txbAnswer.Text.ToLower() == correctAnswer.ToLower())
                {
                    Score++;
                }
            }
        }
    }
}
