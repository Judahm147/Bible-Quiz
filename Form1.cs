using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Judah_s_Bible_Quiz
{
    public partial class Form1 : Form
    {

        Quiz quiz;
        private int questionNumber;
        private int numCorrect;
   

        public Form1()
        {
            InitializeComponent();
            quiz = new Quiz("C:/Users/Home/source/repos/Judah's Bible Quiz/Judah's Bible Quiz/Questions List.txt");
        }

        private void choiceOne_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void UpdateQuiz()
        {
            decideButton.Visible = true;
            nextButton.Visible = false;
            questionNumberLabel.Text = "Question " + questionNumber;
            choiceOne.Checked = true;
            Question currentQuestion = quiz.questions[questionNumber - 1];
            answerTextBox.Text = currentQuestion.QuestionDescription;
            choiceOne.Text = currentQuestion.Choices[0];
            choiceTwo.Text = currentQuestion.Choices[1];
            choiceThree.Text = currentQuestion.Choices[2];
            choiceFour.Text = currentQuestion.Choices[3];
            answerTextBox.ForeColor = Color.DarkGoldenrod;
        }

        private void StartQuiz()
        {
            quiz.Shuffle();
            questionNumber = 1;
            numCorrect = 0;
            nextButton.Text = "Next Question";
            nextButton.Visible = true;
            restartButton.Visible = false;
            questionNumberLabel.Visible = true;
            choiceOne.Visible = true;
            choiceTwo.Visible = true;
            choiceThree.Visible = true;
            choiceFour.Visible = true;
            answerTextBox.Visible = true;
            startLabel.Visible = false;
            decideButton.Visible = true;
            UpdateQuiz();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (nextButton.Text == "Start Quiz")
                StartQuiz();
            else if (questionNumber < quiz.questions.Count)
            {
                questionNumber++;
                UpdateQuiz();
            }
            else
            {
                EndGame();
            }
        }

        private void EndGame()
        {
            startLabel.Visible = true;

            startLabel.Text = "Quiz Completed";
            choiceOne.Visible = false;
            choiceTwo.Visible = false;
            choiceThree.Visible = false;
            choiceFour.Visible = false;
            answerTextBox.Visible = false;
            decideButton.Visible = false;
            nextButton.Visible = false;
            restartButton.Visible = true;
            questionNumberLabel.Text = "You answered " + numCorrect + " questions correctly out of " + questionNumber;
        }

        private void decideButton_Click(object sender, EventArgs e)
        {
            decideButton.Visible = false;
            nextButton.Visible = true;
            string result;
            string choice = "1";
            if (choiceOne.Checked)
                choice = choiceOne.Text;
            if (choiceTwo.Checked)
                choice = choiceTwo.Text;
            if (choiceThree.Checked)
                choice = choiceThree.Text;
            if (choiceFour.Checked)
                choice = choiceFour.Text;
            Question currentQuestion = quiz.questions[questionNumber - 1];

            if (currentQuestion.Answer == choice)
            {
                result = "Correct!";
                answerTextBox.ForeColor = Color.Lime;
                numCorrect++;
            }
            else
            {
                result = "Wrong! Answer is option " + currentQuestion.Answer + ".";
                answerTextBox.ForeColor = Color.Red;
            }
            answerTextBox.Text = result + " " + currentQuestion.AnswerDescription;
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            StartQuiz();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void answerTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void startLabel_Click(object sender, EventArgs e)
        {

        }

        private void choiceFour_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void questionNumberLabel_Click(object sender, EventArgs e)
        {

        }

        private void choiceTwo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
