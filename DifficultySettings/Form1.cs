using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DifficultySettings
{
    public partial class Form1 : Form
    {
        string username;
        string difficulty;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            difficulty = "medium";

            easyButton.BackColor = Color.Black;
            mediumButton.BackColor = Color.Coral;
            hardButton.BackColor = Color.Black;
        }

        private void easyButton_Click(object sender, EventArgs e)
        {
            difficulty = "easy";

            easyButton.BackColor = Color.LimeGreen;
            mediumButton.BackColor = Color.Black;
            hardButton.BackColor = Color.Black;
        }

        private void beginButton_Click(object sender, EventArgs e)
        {
            username = userInput.Text;
            outputLabel.Text = $"Farewell, {username}!";
            outputLabel.Text += $"\nI wish you the best of luck on the {difficulty} path!";

        }

        private void hardButton_Click(object sender, EventArgs e)
        {
            difficulty = "hard";

            easyButton.BackColor = Color.Black;
            mediumButton.BackColor = Color.Black;
            hardButton.BackColor = Color.Firebrick;

        }
    }
}
