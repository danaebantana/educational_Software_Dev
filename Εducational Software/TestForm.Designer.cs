namespace Εducational_Software
{
    partial class TestForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label_Test = new System.Windows.Forms.Label();
            this.panel_testForm = new System.Windows.Forms.Panel();
            this.panel_test = new System.Windows.Forms.Panel();
            this.panel_trueOrFalse = new System.Windows.Forms.Panel();
            this.radioButton_false = new System.Windows.Forms.RadioButton();
            this.radioButton_true = new System.Windows.Forms.RadioButton();
            this.label_numberC = new System.Windows.Forms.Label();
            this.label_numberA = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_numberB = new System.Windows.Forms.Label();
            this.panel_multipleChoice = new System.Windows.Forms.Panel();
            this.radioButton_choice3 = new System.Windows.Forms.RadioButton();
            this.radioButton_choice2 = new System.Windows.Forms.RadioButton();
            this.radioButton_choice1 = new System.Windows.Forms.RadioButton();
            this.label_numberIII = new System.Windows.Forms.Label();
            this.label_numberI = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label_numberII = new System.Windows.Forms.Label();
            this.panel_fillTheBlank = new System.Windows.Forms.Panel();
            this.textBox_result = new System.Windows.Forms.TextBox();
            this.label_number1 = new System.Windows.Forms.Label();
            this.label_equal = new System.Windows.Forms.Label();
            this.label_multi = new System.Windows.Forms.Label();
            this.label_number2 = new System.Windows.Forms.Label();
            this.button_start = new System.Windows.Forms.Button();
            this.button_next_end = new System.Windows.Forms.Button();
            this.button_help = new System.Windows.Forms.Button();
            this.pictureBox_helper = new System.Windows.Forms.PictureBox();
            this.pictureBox_message = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.panel_testForm.SuspendLayout();
            this.panel_test.SuspendLayout();
            this.panel_trueOrFalse.SuspendLayout();
            this.panel_multipleChoice.SuspendLayout();
            this.panel_fillTheBlank.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_helper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_message)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(692, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(60, 25);
            this.backToolStripMenuItem.Text = "Πίσω";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(82, 25);
            this.helpToolStripMenuItem.Text = "Βοήθεια";
            // 
            // label_Test
            // 
            this.label_Test.AutoSize = true;
            this.label_Test.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Test.Location = new System.Drawing.Point(5, 39);
            this.label_Test.Name = "label_Test";
            this.label_Test.Size = new System.Drawing.Size(80, 39);
            this.label_Test.TabIndex = 1;
            this.label_Test.Text = "Τεστ";
            // 
            // panel_testForm
            // 
            this.panel_testForm.BackColor = System.Drawing.Color.Transparent;
            this.panel_testForm.Controls.Add(this.panel_test);
            this.panel_testForm.Controls.Add(this.button_help);
            this.panel_testForm.Controls.Add(this.pictureBox_helper);
            this.panel_testForm.Controls.Add(this.pictureBox_message);
            this.panel_testForm.Location = new System.Drawing.Point(12, 81);
            this.panel_testForm.Name = "panel_testForm";
            this.panel_testForm.Size = new System.Drawing.Size(668, 360);
            this.panel_testForm.TabIndex = 2;
            // 
            // panel_test
            // 
            this.panel_test.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_test.Controls.Add(this.panel_trueOrFalse);
            this.panel_test.Controls.Add(this.panel_multipleChoice);
            this.panel_test.Controls.Add(this.panel_fillTheBlank);
            this.panel_test.Controls.Add(this.button_start);
            this.panel_test.Controls.Add(this.button_next_end);
            this.panel_test.Location = new System.Drawing.Point(217, 34);
            this.panel_test.Name = "panel_test";
            this.panel_test.Size = new System.Drawing.Size(436, 306);
            this.panel_test.TabIndex = 10;
            // 
            // panel_trueOrFalse
            // 
            this.panel_trueOrFalse.Controls.Add(this.radioButton_false);
            this.panel_trueOrFalse.Controls.Add(this.radioButton_true);
            this.panel_trueOrFalse.Controls.Add(this.label_numberC);
            this.panel_trueOrFalse.Controls.Add(this.label_numberA);
            this.panel_trueOrFalse.Controls.Add(this.label2);
            this.panel_trueOrFalse.Controls.Add(this.label3);
            this.panel_trueOrFalse.Controls.Add(this.label_numberB);
            this.panel_trueOrFalse.Location = new System.Drawing.Point(81, 89);
            this.panel_trueOrFalse.Name = "panel_trueOrFalse";
            this.panel_trueOrFalse.Size = new System.Drawing.Size(279, 110);
            this.panel_trueOrFalse.TabIndex = 8;
            this.panel_trueOrFalse.Visible = false;
            // 
            // radioButton_false
            // 
            this.radioButton_false.AutoSize = true;
            this.radioButton_false.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_false.Location = new System.Drawing.Point(180, 68);
            this.radioButton_false.Name = "radioButton_false";
            this.radioButton_false.Size = new System.Drawing.Size(79, 25);
            this.radioButton_false.TabIndex = 15;
            this.radioButton_false.TabStop = true;
            this.radioButton_false.Text = "Λάθος";
            this.radioButton_false.UseVisualStyleBackColor = true;
            // 
            // radioButton_true
            // 
            this.radioButton_true.AutoSize = true;
            this.radioButton_true.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_true.Location = new System.Drawing.Point(21, 68);
            this.radioButton_true.Name = "radioButton_true";
            this.radioButton_true.Size = new System.Drawing.Size(76, 25);
            this.radioButton_true.TabIndex = 14;
            this.radioButton_true.TabStop = true;
            this.radioButton_true.Text = "Σωστό";
            this.radioButton_true.UseVisualStyleBackColor = true;
            // 
            // label_numberC
            // 
            this.label_numberC.AutoSize = true;
            this.label_numberC.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_numberC.Location = new System.Drawing.Point(228, 23);
            this.label_numberC.Name = "label_numberC";
            this.label_numberC.Size = new System.Drawing.Size(20, 22);
            this.label_numberC.TabIndex = 11;
            this.label_numberC.Text = "_";
            // 
            // label_numberA
            // 
            this.label_numberA.AutoSize = true;
            this.label_numberA.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_numberA.Location = new System.Drawing.Point(26, 23);
            this.label_numberA.Name = "label_numberA";
            this.label_numberA.Size = new System.Drawing.Size(20, 22);
            this.label_numberA.TabIndex = 7;
            this.label_numberA.Text = "_";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(164, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 22);
            this.label2.TabIndex = 10;
            this.label2.Text = "=";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(72, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "*";
            // 
            // label_numberB
            // 
            this.label_numberB.AutoSize = true;
            this.label_numberB.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_numberB.Location = new System.Drawing.Point(115, 23);
            this.label_numberB.Name = "label_numberB";
            this.label_numberB.Size = new System.Drawing.Size(20, 22);
            this.label_numberB.TabIndex = 9;
            this.label_numberB.Text = "_";
            // 
            // panel_multipleChoice
            // 
            this.panel_multipleChoice.Controls.Add(this.radioButton_choice3);
            this.panel_multipleChoice.Controls.Add(this.radioButton_choice2);
            this.panel_multipleChoice.Controls.Add(this.radioButton_choice1);
            this.panel_multipleChoice.Controls.Add(this.label_numberIII);
            this.panel_multipleChoice.Controls.Add(this.label_numberI);
            this.panel_multipleChoice.Controls.Add(this.label5);
            this.panel_multipleChoice.Controls.Add(this.label6);
            this.panel_multipleChoice.Controls.Add(this.label_numberII);
            this.panel_multipleChoice.Location = new System.Drawing.Point(81, 89);
            this.panel_multipleChoice.Name = "panel_multipleChoice";
            this.panel_multipleChoice.Size = new System.Drawing.Size(279, 96);
            this.panel_multipleChoice.TabIndex = 9;
            this.panel_multipleChoice.Visible = false;
            // 
            // radioButton_choice3
            // 
            this.radioButton_choice3.AutoSize = true;
            this.radioButton_choice3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_choice3.Location = new System.Drawing.Point(232, 68);
            this.radioButton_choice3.Name = "radioButton_choice3";
            this.radioButton_choice3.Size = new System.Drawing.Size(36, 25);
            this.radioButton_choice3.TabIndex = 16;
            this.radioButton_choice3.TabStop = true;
            this.radioButton_choice3.Text = "_";
            this.radioButton_choice3.UseVisualStyleBackColor = true;
            this.radioButton_choice3.CheckedChanged += new System.EventHandler(this.radiobutton_choice_Checked);
            // 
            // radioButton_choice2
            // 
            this.radioButton_choice2.AutoSize = true;
            this.radioButton_choice2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_choice2.Location = new System.Drawing.Point(126, 68);
            this.radioButton_choice2.Name = "radioButton_choice2";
            this.radioButton_choice2.Size = new System.Drawing.Size(36, 25);
            this.radioButton_choice2.TabIndex = 15;
            this.radioButton_choice2.TabStop = true;
            this.radioButton_choice2.Text = "_";
            this.radioButton_choice2.UseVisualStyleBackColor = true;
            this.radioButton_choice2.CheckedChanged += new System.EventHandler(this.radiobutton_choice_Checked);
            // 
            // radioButton_choice1
            // 
            this.radioButton_choice1.AutoSize = true;
            this.radioButton_choice1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_choice1.Location = new System.Drawing.Point(15, 68);
            this.radioButton_choice1.Name = "radioButton_choice1";
            this.radioButton_choice1.Size = new System.Drawing.Size(36, 25);
            this.radioButton_choice1.TabIndex = 14;
            this.radioButton_choice1.TabStop = true;
            this.radioButton_choice1.Text = "_";
            this.radioButton_choice1.UseVisualStyleBackColor = true;
            this.radioButton_choice1.CheckedChanged += new System.EventHandler(this.radiobutton_choice_Checked);
            // 
            // label_numberIII
            // 
            this.label_numberIII.AutoSize = true;
            this.label_numberIII.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_numberIII.Location = new System.Drawing.Point(228, 23);
            this.label_numberIII.Name = "label_numberIII";
            this.label_numberIII.Size = new System.Drawing.Size(20, 22);
            this.label_numberIII.TabIndex = 11;
            this.label_numberIII.Text = "_";
            // 
            // label_numberI
            // 
            this.label_numberI.AutoSize = true;
            this.label_numberI.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_numberI.Location = new System.Drawing.Point(26, 23);
            this.label_numberI.Name = "label_numberI";
            this.label_numberI.Size = new System.Drawing.Size(20, 22);
            this.label_numberI.TabIndex = 7;
            this.label_numberI.Text = "_";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(164, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 22);
            this.label5.TabIndex = 10;
            this.label5.Text = "=";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(72, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 22);
            this.label6.TabIndex = 8;
            this.label6.Text = "*";
            // 
            // label_numberII
            // 
            this.label_numberII.AutoSize = true;
            this.label_numberII.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_numberII.Location = new System.Drawing.Point(115, 23);
            this.label_numberII.Name = "label_numberII";
            this.label_numberII.Size = new System.Drawing.Size(20, 22);
            this.label_numberII.TabIndex = 9;
            this.label_numberII.Text = "_";
            // 
            // panel_fillTheBlank
            // 
            this.panel_fillTheBlank.Controls.Add(this.textBox_result);
            this.panel_fillTheBlank.Controls.Add(this.label_number1);
            this.panel_fillTheBlank.Controls.Add(this.label_equal);
            this.panel_fillTheBlank.Controls.Add(this.label_multi);
            this.panel_fillTheBlank.Controls.Add(this.label_number2);
            this.panel_fillTheBlank.Location = new System.Drawing.Point(81, 103);
            this.panel_fillTheBlank.Name = "panel_fillTheBlank";
            this.panel_fillTheBlank.Size = new System.Drawing.Size(279, 66);
            this.panel_fillTheBlank.TabIndex = 7;
            this.panel_fillTheBlank.Visible = false;
            // 
            // textBox_result
            // 
            this.textBox_result.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_result.Location = new System.Drawing.Point(219, 20);
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.Size = new System.Drawing.Size(40, 31);
            this.textBox_result.TabIndex = 6;
            // 
            // label_number1
            // 
            this.label_number1.AutoSize = true;
            this.label_number1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_number1.Location = new System.Drawing.Point(32, 23);
            this.label_number1.Name = "label_number1";
            this.label_number1.Size = new System.Drawing.Size(20, 22);
            this.label_number1.TabIndex = 2;
            this.label_number1.Text = "_";
            // 
            // label_equal
            // 
            this.label_equal.AutoSize = true;
            this.label_equal.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_equal.Location = new System.Drawing.Point(170, 23);
            this.label_equal.Name = "label_equal";
            this.label_equal.Size = new System.Drawing.Size(22, 22);
            this.label_equal.TabIndex = 5;
            this.label_equal.Text = "=";
            // 
            // label_multi
            // 
            this.label_multi.AutoSize = true;
            this.label_multi.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_multi.Location = new System.Drawing.Point(78, 22);
            this.label_multi.Name = "label_multi";
            this.label_multi.Size = new System.Drawing.Size(19, 22);
            this.label_multi.TabIndex = 3;
            this.label_multi.Text = "*";
            // 
            // label_number2
            // 
            this.label_number2.AutoSize = true;
            this.label_number2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_number2.Location = new System.Drawing.Point(121, 23);
            this.label_number2.Name = "label_number2";
            this.label_number2.Size = new System.Drawing.Size(20, 22);
            this.label_number2.TabIndex = 4;
            this.label_number2.Text = "_";
            // 
            // button_start
            // 
            this.button_start.BackColor = System.Drawing.Color.YellowGreen;
            this.button_start.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_start.Location = new System.Drawing.Point(162, 119);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(116, 50);
            this.button_start.TabIndex = 9;
            this.button_start.Text = "Έναρξη";
            this.button_start.UseVisualStyleBackColor = false;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // button_next_end
            // 
            this.button_next_end.BackColor = System.Drawing.Color.DarkTurquoise;
            this.button_next_end.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_next_end.Location = new System.Drawing.Point(333, 259);
            this.button_next_end.Name = "button_next_end";
            this.button_next_end.Size = new System.Drawing.Size(103, 47);
            this.button_next_end.TabIndex = 1;
            this.button_next_end.Text = "Επόμενο";
            this.button_next_end.UseVisualStyleBackColor = false;
            this.button_next_end.Visible = false;
            this.button_next_end.Click += new System.EventHandler(this.button_next_end_Click);
            // 
            // button_help
            // 
            this.button_help.Location = new System.Drawing.Point(165, 304);
            this.button_help.Name = "button_help";
            this.button_help.Size = new System.Drawing.Size(46, 36);
            this.button_help.TabIndex = 8;
            this.button_help.Text = "Help";
            this.button_help.UseVisualStyleBackColor = true;
            // 
            // pictureBox_helper
            // 
            this.pictureBox_helper.Location = new System.Drawing.Point(23, 185);
            this.pictureBox_helper.Name = "pictureBox_helper";
            this.pictureBox_helper.Size = new System.Drawing.Size(125, 155);
            this.pictureBox_helper.TabIndex = 2;
            this.pictureBox_helper.TabStop = false;
            // 
            // pictureBox_message
            // 
            this.pictureBox_message.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_message.BackgroundImage = global::Εducational_Software.Properties.Resources.messageCloud;
            this.pictureBox_message.Location = new System.Drawing.Point(23, 34);
            this.pictureBox_message.Name = "pictureBox_message";
            this.pictureBox_message.Size = new System.Drawing.Size(186, 125);
            this.pictureBox_message.TabIndex = 11;
            this.pictureBox_message.TabStop = false;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 453);
            this.Controls.Add(this.panel_testForm);
            this.Controls.Add(this.label_Test);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mathster";
            this.Load += new System.EventHandler(this.TestForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel_testForm.ResumeLayout(false);
            this.panel_test.ResumeLayout(false);
            this.panel_trueOrFalse.ResumeLayout(false);
            this.panel_trueOrFalse.PerformLayout();
            this.panel_multipleChoice.ResumeLayout(false);
            this.panel_multipleChoice.PerformLayout();
            this.panel_fillTheBlank.ResumeLayout(false);
            this.panel_fillTheBlank.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_helper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_message)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.Label label_Test;
        private System.Windows.Forms.Panel panel_testForm;
        private System.Windows.Forms.Button button_next_end;
        private System.Windows.Forms.PictureBox pictureBox_helper;
        private System.Windows.Forms.Button button_help;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Panel panel_test;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Label label_equal;
        private System.Windows.Forms.Label label_number2;
        private System.Windows.Forms.Label label_multi;
        private System.Windows.Forms.Label label_number1;
        private System.Windows.Forms.Panel panel_trueOrFalse;
        private System.Windows.Forms.Panel panel_fillTheBlank;
        private System.Windows.Forms.TextBox textBox_result;
        private System.Windows.Forms.Label label_numberA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_numberB;
        private System.Windows.Forms.Label label_numberC;
        private System.Windows.Forms.RadioButton radioButton_false;
        private System.Windows.Forms.RadioButton radioButton_true;
        private System.Windows.Forms.Panel panel_multipleChoice;
        private System.Windows.Forms.RadioButton radioButton_choice2;
        private System.Windows.Forms.RadioButton radioButton_choice1;
        private System.Windows.Forms.Label label_numberIII;
        private System.Windows.Forms.Label label_numberI;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_numberII;
        private System.Windows.Forms.RadioButton radioButton_choice3;
        private System.Windows.Forms.PictureBox pictureBox_message;
    }
}