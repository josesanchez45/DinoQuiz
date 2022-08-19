using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DinosaurQuiz
{
    public partial class SimpleDinoQuiz : Form
    {
        // quiz game variables

        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;
        public SimpleDinoQuiz()
        {
            InitializeComponent();

            AskQuestion(questionNumber);

            totalQuestions = 5;
        }

        private void label1_Click(object sender, EventArgs e)
        {

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
                //calculating percentage
                percentage = (int)Math.Round((double)(score * 100) / totalQuestions);

                MessageBox.Show(
                    "Quiz Complete!" + Environment.NewLine +
                    "You have answered " + score + " questions correctly" + Environment.NewLine +
                    "Your total percentage is " + percentage + "%" + Environment.NewLine +
                    "Click Ok to play again"
                    );

                score = 0;
                questionNumber = 0;
                AskQuestion(questionNumber);
            }

            questionNumber++;
            AskQuestion(questionNumber);

        }
        private void AskQuestion(int qNum)
        {
            switch (qNum)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.dime_jpg;

                    lblQuestion.Text = "This creature was not a dinosaur but still an ancient repltile. What was it called?";

                    button1.Text = "Dimetrodon";
                    button2.Text = "Sail o Saurus";
                    button3.Text = "Spinosaurus";
                    button4.Text = "Gallimimus";

                    correctAnswer = 1;

                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.raptor;

                    lblQuestion.Text = "Famously misrepresented in films, what is this dinosaur called?";

                    button1.Text = "This is a bird";
                    button2.Text = "Kroxigor";
                    button3.Text = "Postosuchus";
                    button4.Text = "Velociraptor";

                    correctAnswer = 4;

                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources.spino;

                    lblQuestion.Text = "Thought to have mostly lurked in the water, what animal is this?";

                    button1.Text = "Slann";
                    button2.Text = "Dread Saurian";
                    button3.Text = "Spinosaurus";
                    button4.Text = "Nightmare Fuel";

                    correctAnswer = 3;

                    break;

                case 4:
                    pictureBox1.Image = Properties.Resources.sue;

                    lblQuestion.Text = "This is arguably the most famous Dinosaur ever, what was that dinos name?";

                    button1.Text = "Sue";
                    button2.Text = "T Rex";
                    button3.Text = "Allosaurus";
                    button4.Text = "Stegosaurus";

                    correctAnswer = 2;

                    break;

                case 5:
                    pictureBox1.Image = Properties.Resources.trike;

                    lblQuestion.Text = "In the Land Before Time she was know as Sara";

                    button1.Text = "Pteredon";
                    button2.Text = "Stegosaurus";
                    button3.Text = "Triceratops";
                    button4.Text = "Velociraptor";

                    correctAnswer = 3;

                    break;




            }

        }
    }
}
