using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Εducational_Software.Services;

namespace Εducational_Software
{
    public partial class TestForm : Form
    {
        private AuthenticationService auth;
        private StatisticsService statisticsService;
        private int unit;
        private List<Panel> panelQuestionList;
        private Random random;
        private List<bool> answerList;
        private int questionCount;

        public TestForm(AuthenticationService _auth, StatisticsService _statisticsService, int _unit)
        {
            InitializeComponent();
            this.auth = _auth;
            this.statisticsService = _statisticsService;
            this.unit = _unit;
            panelQuestionList = new List<Panel>() { panel_fillTheBlank, panel_trueOrFalse, panel_multipleChoice };
            random = new Random();
            answerList = new List<bool>();
        }

        private void TestForm_Load(object sender, EventArgs e)
        {
            pictureBox_helper.Image = (Image)Properties.Resources.ResourceManager.GetObject(unit.ToString());
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            button_start.Visible = false;
            button_check.Visible = true;
            questionCount = 1;
            GenerateQuestion(unit);
        }

        private void GenerateQuestion(int unitNumber)
        {
            //Randomly pick a type of Question through the panelQuestionList
            int index = random.Next(panelQuestionList.Count);
            Panel panel = panelQuestionList.ElementAt(index);
            panel.Visible = true;

            //Randomly pick the number that will get multiplied with the unit number
            int randomNumber = random.Next(1, 11);
            int resultNumber = unitNumber * randomNumber;
            FillQuestion(panel, unitNumber, randomNumber, resultNumber);
        }

        private void FillQuestion(Panel panel, int unitNumber, int randomNumber, int resultNumber)
        {
            var panelLabels = panel.Controls.OfType<Label>().Where(n => n.Name.Contains("label_number")).OrderBy(t => t.TabIndex);
            panelLabels.ElementAt(0).Text = unitNumber.ToString();
            panelLabels.ElementAt(1).Text = randomNumber.ToString();
            if (panel.Name.Equals("panel_trueOrFalse"))
            {
                int setTrueOrFalse = random.Next(2);
                if (setTrueOrFalse.Equals(0))
                {
                    panelLabels.ElementAt(2).Text = resultNumber.ToString();
                }
                else
                {
                    panelLabels.ElementAt(2).Text = random.Next(unit, unit * 10).ToString();
                }
            } else if (panel.Name.Equals("panel_multipleChoice"))
            {
                var radioButtons = panel.Controls.OfType<RadioButton>();
                int index = random.Next(3);
                radioButtons.ElementAt(index).Text = resultNumber.ToString(); 
                int randomNumber1 = random.Next(unit, (unit/2) * 10);
                int randomNumber2 = random.Next((unit/2) * 10, (unit * 10) + 1);
                if (radioButton_choice1.Text.Equals("_") && radioButton_choice2.Text.Equals("_"))
                {
                    radioButton_choice1.Text = randomNumber1.ToString();
                    radioButton_choice2.Text = randomNumber2.ToString();
                }
                else if (radioButton_choice2.Text.Equals("_") && radioButton_choice3.Text.Equals("_"))
                {
                    radioButton_choice2.Text = randomNumber2.ToString();
                    radioButton_choice3.Text = randomNumber1.ToString();
                } else if (radioButton_choice1.Text.Equals("_") && radioButton_choice3.Text.Equals("_"))
                {
                    radioButton_choice1.Text = randomNumber1.ToString();
                    radioButton_choice3.Text = randomNumber2.ToString();
                }
            }
        }

        private void button_check_Click(object sender, EventArgs e)
        {
            button_next_end.Visible = true;
            if (panel_fillTheBlank.Visible)
            {
                int result = Int32.Parse(label_number1.Text) * Int32.Parse(label_number2.Text);
                if (result.Equals(Int32.Parse(textBox_result.Text)))
                {
                    //answerList.Add(true);
                    MessageBox.Show("YES");
                } else
                {
                    //answerList.Add(false);
                    MessageBox.Show("NO");
                }
            } else if (panel_trueOrFalse.Visible)
            {
                int result = Int32.Parse(label_numberA.Text) * Int32.Parse(label_numberB.Text);
                if (result.Equals(Int32.Parse(label_numberC.Text)) && radioButton_true.Checked)
                {
                    MessageBox.Show("YES");
                } else if (!result.Equals(Int32.Parse(label_numberC.Text)) && radioButton_false.Checked)
                {
                    MessageBox.Show("YES");
                } else
                {
                    MessageBox.Show("NO");
                }
            } else if (panel_multipleChoice.Visible)
            {
                int result = Int32.Parse(label_numberI.Text) * Int32.Parse(label_numberII.Text);
                if(radioButton_choice1.Checked && radioButton_choice1.Text.Equals(result.ToString()))
                {
                    MessageBox.Show("YES");
                } else if(radioButton_choice2.Checked && radioButton_choice2.Text.Equals(result.ToString()))
                {
                    MessageBox.Show("YES");
                } else if (radioButton_choice3.Checked && radioButton_choice3.Text.Equals(result.ToString()))
                {
                    MessageBox.Show("YES");
                } else
                {
                    MessageBox.Show("NO");
                }
            }

        }

        private void radiobutton_choice_Checked(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            label_numberIII.Text = radioButton.Text;
        }

        private void button_next_end_Click(object sender, EventArgs e)
        {
            panel_fillTheBlank.Visible = false;
            textBox_result.Clear();
            panel_trueOrFalse.Visible = false;
            foreach (RadioButton rb in panel_trueOrFalse.Controls.OfType<RadioButton>())
            {
                rb.Checked = false;
            }
            panel_multipleChoice.Visible = false;
            foreach (RadioButton rb in panel_multipleChoice.Controls.OfType<RadioButton>())
            {
                rb.Checked = false;
            }
            label_numberIII.Text = "_";
            radioButton_choice1.Text.Equals("_");
            radioButton_choice2.Text.Equals("_");
            radioButton_choice2.Text.Equals("_");
            button_next_end.Visible = false;

            questionCount++;
            GenerateQuestion(unit);
        }

        private void panel_testForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_test_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
