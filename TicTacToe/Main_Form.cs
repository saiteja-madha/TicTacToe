using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Main_Form : Form
    {

        private Boolean isX = true;
        private HashSet<Button[]> combinations;
        private string playerXName = "Player X";
        private string playerOName = "Player O";
        

        public Main_Form()
        {
            InitializeComponent();
            combinations = new HashSet<Button[]>();
            Button[] combination1 = { button1, button2, button3 };
            Button[] combination2 = { button4, button5, button6 };
            Button[] combination3 = { button7, button8, button9 };
            Button[] combination4 = { button1, button4, button7 };
            Button[] combination5 = { button2, button5, button8 };
            Button[] combination6 = { button3, button6, button9 };
            Button[] combination7 = { button1, button5, button9 };
            Button[] combination8 = { button3, button5, button7 };
            combinations.Add(combination1);
            combinations.Add(combination2);
            combinations.Add(combination3);
            combinations.Add(combination4);
            combinations.Add(combination5);
            combinations.Add(combination6);
            combinations.Add(combination7);
            combinations.Add(combination8);
        }

        private void updateButtonData(object sender)
        {
            Button clickedButton = sender as Button;
            clickedButton.Enabled = false;
            if (isX)
            {
                clickedButton.Text = "X";
                isX = false;
                updateNextTurn();
            } 
            
            else
            {
                clickedButton.Text = "O";
                isX = true;
                updateNextTurn();
            }
            checkGameComplete();
        }

        private void updateNextTurn()
        {
            if (isX)
                nextTurnLabel.Text = playerXName;
            else
                nextTurnLabel.Text = playerOName;
        }

        private void checkGameComplete()
        {
            // Check all combinations
            foreach(Button[] combination in combinations)
            {
                if (combination[0].Text != "" && combination[1].Text != "" && combination[2].Text != "")
                {
                    if (combination[0].Text == combination[1].Text && combination[0].Text == combination[2].Text)
                    {
                        combination[0].BackColor = Color.Green;
                        combination[1].BackColor = Color.Green;
                        combination[2].BackColor = Color.Green;
                        if (combination[0].Text == "X")
                        {
                            MessageBox.Show("Player X Wins!");
                            var a = Int32.Parse(playerXPointsTextBox.Text) + 1;
                            playerXPointsTextBox.Text = a.ToString();
                            newGame();
                        }
                        else
                        {
                            MessageBox.Show("Player O Wins!");
                            var a = Int32.Parse(playerOPointsTextBox.Text) + 1;
                            playerOPointsTextBox.Text = a.ToString();
                            newGame();
                        }

                    }
                }
                // Check if all buttons are clicked
                if (!button1.Enabled && !button2.Enabled && !button3.Enabled && !button4.Enabled && !button5.Enabled && !button6.Enabled && !button7.Enabled && !button8.Enabled && !button9.Enabled)
                {
                    MessageBox.Show("It's a tie!");
                    newGame();
                }
            }
        }

        private void newGame()
        {
            resetButton(button1);
            resetButton(button2);
            resetButton(button3);
            resetButton(button4);
            resetButton(button5);
            resetButton(button6);
            resetButton(button7);
            resetButton(button8);
            resetButton(button9);
            isX = true;
            updateNextTurn();
        }

        private void resetScores()
        {
            newGame();
            playerXPointsTextBox.Text = 0.ToString();
            playerOPointsTextBox.Text = 0.ToString();
        }

        private void resetButton(Button button)
        {
            button.BackColor = System.Drawing.SystemColors.Control;
            button.UseVisualStyleBackColor = true;
            button.ResetText();
            button.Enabled = true;
        }

        private void resetScoresButton_Click(object sender, EventArgs e)
        {
            resetScores();
        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            newGame();
        }

        //Button Click Events
        private void button1_Click(object sender, EventArgs e)
        {
            updateButtonData(sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            updateButtonData(sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            updateButtonData(sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            updateButtonData(sender);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            updateButtonData(sender);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            updateButtonData(sender);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            updateButtonData(sender);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            updateButtonData(sender);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            updateButtonData(sender);
        }

    }

}
