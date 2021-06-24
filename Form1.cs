using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quizy_Games
{
    public partial class Form1 : Form
    {

        // quiz game variables

        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;

        public Form1()
        {
            InitializeComponent();

            askQuestion(questionNumber);

            totalQuestions = 5;
        }

        private void checkAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;

            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if (buttonTag == correctAnswer)
            {
                score++;
            }

            if (questionNumber == totalQuestions)
            {
                // work out the percentage

                percentage = (int)Math.Round((double)(score * 100) / totalQuestions);

                MessageBox.Show(
                    "Quiz Ended!" + Environment.NewLine +
                    "You have answered " + score + " questions correctly." + Environment.NewLine +
                    "Your total percentage is " + percentage + "%" + Environment.NewLine +
                    "Click OK to play again"
                    );

                score = 0;
                questionNumber = 0;
                askQuestion(questionNumber);

            }

            questionNumber++;
            askQuestion(questionNumber);

        }

        private void askQuestion(int qnum)
        {

            switch (qnum)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.r;

                    lblQuestion.Text = "how to declare a name in c# ?";

                    button1.Text = "string";
                    button2.Text = "char";
                    button3.Text = "int";
                    button4.Text = "float";

                    correctAnswer = 1;

                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.g;

                    lblQuestion.Text = "how to declare a decimal number?";

                    button1.Text = "int";
                    button2.Text = "float";
                    button3.Text = "string";
                    button4.Text = "char";

                    correctAnswer = 2;

                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources.e;

                    lblQuestion.Text = "where do you put CSS in html?";

                    button1.Text = "Body";
                    button2.Text = "Header";
                    button3.Text = "Paragraph";
                    button4.Text = "Style";

                    correctAnswer = 4;

                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources.s;

                    lblQuestion.Text = "what is the colour of sky?";

                    button1.Text = "Red";
                    button2.Text = "Yellow";
                    button3.Text = "Blue";
                    button4.Text = "pink";

                    correctAnswer = 3;

                    break;

                case 5:
                    pictureBox1.Image = Properties.Resources.k;

                    lblQuestion.Text = "which language is used as common language?";

                    button1.Text = "English";
                    button2.Text = "Sepedi";
                    button3.Text = "Tshivenda";
                    button4.Text = "Isizulu";

                    correctAnswer = 1;

                    break;

            }



        }

    }
}