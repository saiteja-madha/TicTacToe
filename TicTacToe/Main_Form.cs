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
            if (isX)
            {
                clickedButton.Text = "X";
                isX = false;
            } 
            
            else
            {
                clickedButton.Text = "O";
                isX = true;
            }
            checkit();
        }

        public void checkit()
        {
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
                        }
                        else
                        {
                            MessageBox.Show("Player O Wins!");
                        }

                    }
                }
            }
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
