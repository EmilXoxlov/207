using System;
using System.Windows.Forms;

namespace ПР4
{
    public partial class Form1 : Form
    {
        Random randomizer = new Random();
        int addend1;
        int addend2;
        int minuend;
        int subtrahend;
        int multiplicand;
        int multiplier;
        int dividend;
        int divisor;
        int timeLeft;

        public void StartTheQuiz()
        {
            addend1 = randomizer.Next(51);
            addend2 = randomizer.Next(51);
            labelPlusLeft.Text = addend1.ToString();
            labelPlusRight.Text = addend2.ToString();
            numericUpDownSum.Value = 0;

            minuend = randomizer.Next(1, 101);
            subtrahend = randomizer.Next(1, minuend);
            labelMinusLeft.Text = minuend.ToString();
            labelMinusRight.Text = subtrahend.ToString();
            numericUpDownDifference.Value = 0;
            
            multiplicand = randomizer.Next(2, 11);
            multiplier = randomizer.Next(2, 11);
            labelTimesLeft.Text = multiplicand.ToString();
            labelTimesRight.Text = multiplier.ToString();
            numericUpDownProduct.Value = 0;
            
            divisor = randomizer.Next(2, 11);
            int temporaryQuotient = randomizer.Next(2, 11);
            dividend = divisor * temporaryQuotient;
            labelDividedLeft.Text = dividend.ToString();
            labelDividedRight.Text = divisor.ToString();
            numericUpDownQuotient.Value = 0;

            timeLeft = 30;
            labelTime.Text = "30 секунд";
            timer1.Start();
        }

        private bool CheckTheAnswer()
        {
            if ((addend1 + addend2 == numericUpDownSum.Value)
                && (minuend - subtrahend == numericUpDownDifference.Value)
                && (multiplicand * multiplier == numericUpDownProduct.Value)
                && (dividend / divisor == numericUpDownQuotient.Value))
                return true;
            else
                return false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CheckTheAnswer())
            {
                timer1.Stop();
                MessageBox.Show("Ю гот олл зе ансверс райт!", "Конгратюлейшнс!");
                buttonStart.Enabled = true;
            }
            else if (timeLeft > 0)
            {
                timeLeft = timeLeft - 1;
                labelTime.Text = timeLeft + " секунд";
            }
            else
            {
                timer1.Stop();
                labelTime.Text = "Тайм`с ап";
                MessageBox.Show("Ю дидн`т финиш ин тайм.", "Сори!");
                numericUpDownSum.Value = addend1 + addend2;
                numericUpDownDifference.Value = minuend - subtrahend;
                numericUpDownProduct.Value = multiplicand * multiplier;
                numericUpDownQuotient.Value = dividend / divisor;
                buttonStart.Enabled = true;
            }

        }

        private void Answer_Enter(object sender, EventArgs e)
        {
            NumericUpDown answerBox = sender as NumericUpDown;
            if (answerBox != null)
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonStart_Click_1(object sender, EventArgs e)
        {
            StartTheQuiz();
            buttonStart.Enabled = false;
        }
    }
}
