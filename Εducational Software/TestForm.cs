using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Εducational_Software.Services;

namespace Εducational_Software
{
    public partial class TestForm : Form
    {
        private AuthenticationService auth;
        private StatisticsService statisticsService;
        private string quiz_id;
        private int[] unit;
        private List<Panel> panelQuestionList;
        private Random random;
        private List<bool> answerList;
        private int questionCount, maxNumberOfQuestions, failures = 0;
        private List<int> randomNumberMultiplier;
        private bool mandatoryTest;

        public TestForm(AuthenticationService _auth, StatisticsService _statisticsService, string _quiz_id, int[] _unit, bool _mandatoryTest)
        {
            InitializeComponent();
            this.auth = _auth;
            this.statisticsService = _statisticsService;
            this.quiz_id = _quiz_id;
            this.unit = _unit;
            this.mandatoryTest = _mandatoryTest;
            panelQuestionList = new List<Panel>() { panel_fillTheBlank, panel_trueOrFalse, panel_multipleChoice };
            random = new Random();
            answerList = new List<bool>();
            if (quiz_id.Equals("revision"))
            {
                this.maxNumberOfQuestions = 10;
                label_Test.Text = "Επαναληπτικό Τεστ";
            }
            else
            {
                this.maxNumberOfQuestions = 5;
            }
        }

        private void TestForm_Load(object sender, EventArgs e)
        {
            if (quiz_id.Equals("revision"))
            {
                pictureBox_helper.Image = (Image)Properties.Resources.ResourceManager.GetObject("revision");
            }
            else
            {
                pictureBox_helper.Image = (Image)Properties.Resources.ResourceManager.GetObject(unit[0].ToString());
            }
            if (mandatoryTest)
            {
                backToolStripMenuItem.Visible = false;
                backToolStripMenuItem.Enabled = false;
            }
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            pictureBox_message.Image = (Image)Properties.Resources.ResourceManager.GetObject("messageCloud");
            button_start.Visible = false;
            button_next_end.Visible = true;
            if (!quiz_id.Equals("revision"))
            {
                randomNumberMultiplier = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            }
            questionCount = 1;
            label_correctLabel.Visible = false;
            label_correct.Visible = false;
            answerList.Clear();
            GenerateQuestion(unit);
        }

        private void GenerateQuestion(int[] unit)
        {
            //Randomly pick a type of Question through the panelQuestionList
            int index = random.Next(panelQuestionList.Count);
            Panel panel = panelQuestionList.ElementAt(index);
            panel.Visible = true;
            int unitNumber = 0;
            int randomNumber = 0;

            //Pick the unitNumber
            if (quiz_id.Equals("revision"))
            {
                index = random.Next(unit.Length);
                unitNumber = unit[index];
                randomNumber = random.Next(1, 11);
            } 
            else
            {
                unitNumber = unit[0];
                index = random.Next(randomNumberMultiplier.Count);
                randomNumber = randomNumberMultiplier.ElementAt(index);
                randomNumberMultiplier.RemoveAt(index); // TODO This fails after 2 failures. Needs fixing.
            }

            //Randomly pick the number that will get multiplied with the unit number
            
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
                    panelLabels.ElementAt(2).Text = random.Next(unitNumber, unitNumber * 10).ToString();
                }
            } else if (panel.Name.Equals("panel_multipleChoice"))
            {
                var radioButtons = panel.Controls.OfType<RadioButton>();
                int index = random.Next(3);
                radioButtons.ElementAt(index).Text = resultNumber.ToString(); 

                int randomNumber1 = random.Next(unitNumber, (unitNumber * 10) + 1);
                int randomNumber2 = random.Next(unitNumber, (unitNumber * 10) + 1);
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

        private void button_next_end_Click(object sender, EventArgs e)
        {
            bool answerChecked = CheckQuestion();
            if (answerChecked)
            {
                //See if it's the end of the Test.
                if (questionCount.Equals(maxNumberOfQuestions))
                {
                    // Count the correct answers
                    int correctAnswers = answerList.Where(answer => answer.Equals(true)).Count();

                    //Calculate success percentage for Test
                    double successPer = ((double)correctAnswers / (double)maxNumberOfQuestions) * 100;
                    if (successPer <= 50)
                    {
                        pictureBox_message.Image = (Image)Properties.Resources.ResourceManager.GetObject("messageCloudFailed");
                        button_start.Visible = true;
                        ClearQuestions();

                        // If the student fails 3 times, suggest them to revise the theory of the unit
                        if (++failures >= 3 && !quiz_id.Equals("revision"))
                        {
                            MessageBox.Show("Μια επανάληψη στην προπαίδεια του " + unit[0].ToString() + " θα σε βοηθήσει να τα πας καλύτερα! \nΜετά την επανάληψη πρέπει να ξανακάνεις ένα 'Τεστ Αυτοαξιολόγησης'!");
                            this.Hide();
                            TheoryForm theoryForm = new TheoryForm(auth, statisticsService, unit[0], true);
                            theoryForm.ShowDialog();
                            this.Close();
                        }
                    }
                    else
                    {
                        pictureBox_message.Image = successPer <= 70 ? (Image)Properties.Resources.ResourceManager.GetObject("messageCloudBravo") :
                            (Image)Properties.Resources.ResourceManager.GetObject("messageCloudExcellent");
                        button_start.Visible = true;
                        button_start.Text = "ΤΕΛΟΣ";
                        button_start.BackColor = Color.BurlyWood;
                        button_start.Enabled = false;
                        backToolStripMenuItem.Visible = true;
                        backToolStripMenuItem.Enabled = true;
                    }

                    // Hide all the question panels
                    panelQuestionList.ForEach(panel => panel.Visible = false);
                    button_next_end.Visible = false;
                    label_correctLabel.Visible = true;
                    label_correct.Visible = true;
                    label_correct.Text = correctAnswers.ToString() + "/" + maxNumberOfQuestions.ToString();
 
                    // Store the sucess percentage for statistics
                    statisticsService.InsertScore(quiz_id, successPer);
                }
                else
                {
                    NextQuestion(unit);
                }
            }
        }

        private bool CheckQuestion()
        {
            if (panel_fillTheBlank.Visible)
            {
                //Check if user gave an answer 
                if (!textBox_result.Text.Length.Equals(0) && Regex.IsMatch(textBox_result.Text, @"^\d+$"))
                {
                    int result = Int32.Parse(label_number1.Text) * Int32.Parse(label_number2.Text);
                    if (result.Equals(Int32.Parse(textBox_result.Text)))
                    {
                        answerList.Add(true);
                    }
                    else
                    {
                        answerList.Add(false);
                    }
                    return true;
                }
                else
                {
                    MessageBox.Show("Πρέπει να συμπληρώσεις το πεδίο με έναν ακέραιο αριθμό!");
                    textBox_result.Clear();
                    return false;
                }
            }
            else if (panel_trueOrFalse.Visible)
            {
                //Check if user gave an answer
                if (radioButton_false.Checked || radioButton_true.Checked)
                {
                    int result = Int32.Parse(label_numberA.Text) * Int32.Parse(label_numberB.Text);
                    if (result.Equals(Int32.Parse(label_numberC.Text)) && radioButton_true.Checked)
                    {
                        answerList.Add(true);
                    }
                    else if (!result.Equals(Int32.Parse(label_numberC.Text)) && radioButton_false.Checked)
                    {
                        answerList.Add(true);
                    }
                    else
                    {
                        answerList.Add(false);
                    }
                    return true;
                } else
                {
                    MessageBox.Show("Πρέπει να επιλέξεις είτε 'Σωστό' ή 'Λάθος'!");
                    return false;
                } 
            }
            else if (panel_multipleChoice.Visible)
            {
                //Check if user gave an answer
                if (radioButton_choice1.Checked || radioButton_choice2.Checked || radioButton_choice3.Checked)
                {
                    int result = Int32.Parse(label_numberI.Text) * Int32.Parse(label_numberII.Text);
                    if (radioButton_choice1.Checked && radioButton_choice1.Text.Equals(result.ToString()))
                    {
                        answerList.Add(true);
                    }
                    else if (radioButton_choice2.Checked && radioButton_choice2.Text.Equals(result.ToString()))
                    {
                        answerList.Add(true);
                    }
                    else if (radioButton_choice3.Checked && radioButton_choice3.Text.Equals(result.ToString()))
                    {
                        answerList.Add(true);
                    }
                    else
                    {
                        answerList.Add(false);
                    }
                    return true;
                } else
                {
                    MessageBox.Show("Πρέπει να επιλέξεις μία από τις επιλογές!");
                    return false;
                }
            }
            return true;
        }

        private void NextQuestion(int[] unit)
        {
            //Clear question panels 
            ClearQuestions();

            questionCount++;
            GenerateQuestion(unit);
        }

        private void ClearQuestions()
        {
            //Clear question panels 
            foreach (Panel panel in panelQuestionList)
            {
                panel.Visible = false;
            }
            textBox_result.Clear();
            foreach (RadioButton rb in panel_trueOrFalse.Controls.OfType<RadioButton>())
            {
                rb.Checked = false;
            }
            foreach (RadioButton rb in panel_multipleChoice.Controls.OfType<RadioButton>())
            {
                rb.Checked = false;
            }
            label_numberIII.Text = "_";
            radioButton_choice1.Text.Equals("_");
            radioButton_choice2.Text.Equals("_");
            radioButton_choice2.Text.Equals("_");
        }

        private void radiobutton_choice_Checked(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            label_numberIII.Text = radioButton.Text;
        }

        private void button_help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Πάτα το κουμπί 'Έναρξη' για να ξεκινήσεις το τεστ. Επέλεξε μία απάντηση για κάθε " +
                "ερώτηση και πάτα το κουμπί 'Επόμενο' που θα εμφανιστεί, μόλις ξεκινήσει το τεστ. \n" +
                "Στο τέλος του τεστ θα εμφανιστεί στο συννεφάκι από το ζωάκι και στο χώρο του τέστ μήνυμα αντίστοιχο με τη απόδοσή σου στο τεστ.\n" +
                "Εάν περάσεις τότε θα εμφανιστεί ένα 'Τελος' στο χώρο των ερωτήσεων και πατώντας το 'Πίσω' μπορείς να πας " +
                "στην αρχική σελίδα και να συνεχίσεις στην επόμενη ενότητα.\n" +
                "Εάν έχεις αποτύχει θα σου δοθεί η ευκαιρία να ξαναδοκιμάσεις το τεστ πατώντας το κουμπί 'Έναρξη' ξανά.\n" +
                "Τέλος για να δεις συνοπτικά τη λειτουργία της εφαρμογής μπορείς να πατήσεις το κουμπί του μενού 'Βοήθεια'.");
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm(auth);
            mainForm.ShowDialog();
            this.Close();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            HelpForm helpForm = new HelpForm();
            helpForm.ShowDialog();
            this.Show();
        }
    }
}
