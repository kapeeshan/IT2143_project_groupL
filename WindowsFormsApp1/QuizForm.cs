using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class QuizForm : Form
    {
        private List<Problems> problems; // List to store all problems from database
        private int index = 0;           // Current question index
        private int score = 0;           // Score tracker
        Connection connection = new Connection(); // Your custom connection class

        public QuizForm()
        {
            InitializeComponent();
        }

        private void QuizForm_Load(object sender, EventArgs e)
        {
            // Initially hide the quiz components
            Problem.Hide();
            Choice1.Hide();
            Choice2.Hide();
            Choice3.Hide();
            Choice4.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            problems = new List<Problems>(); // Initialize list of problems

            string sql = "SELECT * FROM problems"; // Query to get all problems from DB

            using (var con = connection.GetConnection()) // Get connection from custom Connection class
            {
                con.Open();
                using (var cmd = new MySqlCommand(sql, con))
                using (var reader = cmd.ExecuteReader())
                {
                    // Read all rows and add problems to the list
                    while (reader.Read())
                    {
                        problems.Add(new Problems
                        {
                            Id = reader.GetInt32("id"),
                            Question = reader.GetString("question"),
                            Choice1 = reader.GetString("choice1"),
                            Choice2 = reader.GetString("choice2"),
                            Choice3 = reader.GetString("choice3"),
                            Choice4 = reader.GetString("choice4"),
                            CorrectAnswer = reader.GetInt32("correct_answer") // Store correct answer
                        });
                    }
                }
            }

            // Show the quiz components
            Problem.Show();
            Choice1.Show();
            Choice2.Show();
            Choice3.Show();
            Choice4.Show();

            DisplayCurrentQuestion(); // Display the first question
        }

        private void DisplayCurrentQuestion()
        {
            // Clear any previously selected answers
            ClearPreviousAnswer();

            if (index < problems.Count)
            {
                var current = problems[index]; // Get current problem

                // Display the current problem's question and choices
                Problem.Text = current.Question;
                Choice1.Text = current.Choice1;
                Choice2.Text = current.Choice2;
                Choice3.Text = current.Choice3;
                Choice4.Text = current.Choice4;
            }
            else
            {
                // Quiz finished, show score
                MessageBox.Show($"You've completed the quiz! Your score is: {score}");
            }
        }

        // This method clears the previous selected answers
        private void ClearPreviousAnswer()
        {
            Choice1.Checked = false; // Deselect Choice1
            Choice2.Checked = false; // Deselect Choice2
            Choice3.Checked = false; // Deselect Choice3
            Choice4.Checked = false; // Deselect Choice4
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            // Record answer before moving to the next question
            int userAnswer = GetSelectedAnswer(); // Get the selected answer (1, 2, 3, or 4)
            RecordAnswer(userAnswer); // Compare and update score

            index++; // Move to the next question
            DisplayCurrentQuestion(); // Update the display with the next question
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // This button also progresses the quiz
            int userAnswer = GetSelectedAnswer();
            RecordAnswer(userAnswer);
            index++;
            DisplayCurrentQuestion();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // You can add functionality here (e.g., to reset the quiz or something else)
        }

        // This method gets the selected answer (1 to 4)
        private int GetSelectedAnswer()
        {
            if (Choice1.Checked)
                return 1;
            else if (Choice2.Checked)
                return 2;
            else if (Choice3.Checked)
                return 3;
            else if (Choice4.Checked)
                return 4;
            else
                return 0; // No answer selected, handle this case as needed
        }

        // This method records the user's answer and updates the score if correct
        private void RecordAnswer(int userAnswer)
        {
            var currentProblem = problems[index]; // Get the current problem

            // Check if the selected answer is correct
            if (userAnswer == currentProblem.CorrectAnswer)
            {
                score++; // Increment the score if the answer is correct
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            studentPanel stp = new studentPanel();
            stp.Show();
        }
    }
}
