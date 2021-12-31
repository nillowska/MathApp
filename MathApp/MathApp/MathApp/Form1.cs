using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathApp
{
    public partial class Form1 : Form
    {

        int firstNumber;
        int secondNumber;
        int result;
        string answer;
        int score;
        public Form1()
        {
            InitializeComponent();
        }

        Random random = new Random();   
        private void Form1_Load(object sender, EventArgs e)
        {
            CreateCalculation();
            DisplayCalculation();
            ScoreTrue();
            ScoreFalse();
            ShowHelp();
        }
        public void CreateCalculation()
        {
            firstNumber = random.Next(1, 10);
            secondNumber = random.Next(1, 10);
            result = firstNumber * secondNumber;
        }
        public void DisplayCalculation()
        {
            displaytask.Text = firstNumber + " x " + secondNumber + " = ";
        }
        public void DisplayScore()
        {
            score = 0;
            displaysc.Text = score.ToString();
        }
        public void ScoreTrue()
        {
            score++;
            displaysc.Text = score.ToString();
        }
        public void ScoreFalse()
        {
            score--;
            displaysc.Text = score.ToString();
        }
        public void ShowHelp()
        {
            displayhelp.Text = "";
        }

        private void check_Click(object sender, EventArgs e)
        {
            answer = putanswer.Text;
            if (answer == result.ToString())
            {
                check.ForeColor = Color.Green;
                ScoreTrue();
                check.Enabled = false;
                next.Enabled = true;
            }
            else
            {
                if (String.IsNullOrEmpty(putanswer.Text))
                {
                    next.Enabled = false;
                }
                else
                {
                    next.Enabled = true;
                    putanswer.ForeColor = Color.Red;
                    ScoreFalse();
                }
            }
        }
        private void help_Click(object sender, EventArgs e)
        {
            displayhelp.Text = result.ToString();
            DisplayScore();
            check.Enabled = false;
            next.Enabled = true;
        }

        private void next_Click(object sender, EventArgs e)
        {
            CreateCalculation();
            DisplayCalculation();
            putanswer.Text = "";
            check.ForeColor = Color.Black;
            check.Enabled = true;

            if (String.IsNullOrEmpty(putanswer.Text))
            {
                next.Enabled = false;
            }
            else
            {
                next.Enabled = true;
                putanswer.ForeColor = Color.Red;
                ScoreFalse();
            }
        }
    }
}
