using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace plus_game
{
    public partial class GameForm : Form
    {
        int GuessedNum = 15;
        int UserNum = 1;
        int CurrentSteps = 0;

        int BestStepsCount = 0;

       

        public GameForm()
        {
            InitializeComponent();
        }

        public int BestStepsCountfunc(int num)
        {
            int ans_num = num;

            while (ans_num != 1)
            {
                if (ans_num % 2 == 0)
                {
                    ans_num = ans_num / 2;

                }
                else
                {
                    ans_num = ans_num - 1;

                }

                BestStepsCount += 1;

            }
            return BestStepsCount;
        }




        private void labelCurrentSteps_Click(object sender, EventArgs e)
        {
            labelCurrentSteps.Text = BestStepsCountfunc(GuessedNum).ToString();
        }

       

        private void pictureBoxPlus_Click(object sender, EventArgs e)
        {
            CurrentSteps += 1;
            labelStepsCounter.Text = "Количество шагов: " + CurrentSteps.ToString();

            UserNum = UserNum + 1;
            labelCurrentSteps.Text = UserNum.ToString();
            if (UserNum == GuessedNum)
            {
                MessageBox.Show("ты выйграл :3 маладес");

                UserNum = 1;
                CurrentSteps = 0;

                labelStepsCounter.Text = "Количество шагов: " + CurrentSteps.ToString();
                labelCurrentSteps.Text = UserNum.ToString();

            }

            else if (UserNum > GuessedNum)
            {
                MessageBox.Show("ты проиграл :(");

                UserNum = 1;
                CurrentSteps = 0;

                labelStepsCounter.Text = "Количество шагов: " + CurrentSteps.ToString();
                labelCurrentSteps.Text = UserNum.ToString();
            }

        }

        private void pictureMult_Click(object sender, EventArgs e)
        {
            CurrentSteps += 1;
            labelStepsCounter.Text = "Количество шагов: " + CurrentSteps.ToString();

            UserNum = UserNum * 2;
            labelCurrentSteps.Text = UserNum.ToString();

            if (UserNum == GuessedNum)
            {
                MessageBox.Show("ты выйграл :3 маладес");

                UserNum = 1;
                CurrentSteps = 0;

                labelStepsCounter.Text = "Количество шагов: " + CurrentSteps.ToString();
                labelCurrentSteps.Text = UserNum.ToString();

            }
                


            else if (UserNum > GuessedNum)
            {
                MessageBox.Show("ты проиграл :(");

                UserNum = 1;
                CurrentSteps = 0;

                labelStepsCounter.Text = "Количество шагов: " + CurrentSteps.ToString();
                labelCurrentSteps.Text = UserNum.ToString();
            }
        }

        private void GameForm_Load(object sender, EventArgs e)
        {

        }

        private void labelGuessedNum_Click(object sender, EventArgs e)
        {

        }

        private void labelStepsCounter_Click(object sender, EventArgs e)
        {

        }

        private void buttonRandom_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int randomNum = random.Next(15, 500);
            GuessedNum = randomNum;
            labelGuessedNum.Text = GuessedNum.ToString();
        }

        private void buttonThrowOff_Click(object sender, EventArgs e)
        {
            GuessedNum = 15;
            UserNum = 1;
            CurrentSteps = 0;

            labelGuessedNum.Text = GuessedNum.ToString();
            labelStepsCounter.Text = "Количество шагов: " + CurrentSteps.ToString();
            labelCurrentSteps.Text = UserNum.ToString();

        }
    }
}
