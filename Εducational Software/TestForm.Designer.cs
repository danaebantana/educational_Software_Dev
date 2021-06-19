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
            this.πίσωToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.βοήθειαToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label_Test = new System.Windows.Forms.Label();
            this.panel_test = new System.Windows.Forms.Panel();
            this.button_help = new System.Windows.Forms.Button();
            this.label_message = new System.Windows.Forms.Label();
            this.pictureBox_message = new System.Windows.Forms.PictureBox();
            this.pictureBox_animal = new System.Windows.Forms.PictureBox();
            this.button_check = new System.Windows.Forms.Button();
            this.button_next_end = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel_test.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_message)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_animal)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.πίσωToolStripMenuItem,
            this.βοήθειαToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(692, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // πίσωToolStripMenuItem
            // 
            this.πίσωToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.πίσωToolStripMenuItem.Name = "πίσωToolStripMenuItem";
            this.πίσωToolStripMenuItem.Size = new System.Drawing.Size(60, 25);
            this.πίσωToolStripMenuItem.Text = "Πίσω";
            // 
            // βοήθειαToolStripMenuItem
            // 
            this.βοήθειαToolStripMenuItem.Name = "βοήθειαToolStripMenuItem";
            this.βοήθειαToolStripMenuItem.Size = new System.Drawing.Size(82, 25);
            this.βοήθειαToolStripMenuItem.Text = "Βοήθεια";
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
            // panel_test
            // 
            this.panel_test.Controls.Add(this.button_help);
            this.panel_test.Controls.Add(this.label_message);
            this.panel_test.Controls.Add(this.pictureBox_message);
            this.panel_test.Controls.Add(this.pictureBox_animal);
            this.panel_test.Controls.Add(this.button_check);
            this.panel_test.Controls.Add(this.button_next_end);
            this.panel_test.Location = new System.Drawing.Point(12, 81);
            this.panel_test.Name = "panel_test";
            this.panel_test.Size = new System.Drawing.Size(668, 360);
            this.panel_test.TabIndex = 2;
            // 
            // button_help
            // 
            this.button_help.Location = new System.Drawing.Point(165, 294);
            this.button_help.Name = "button_help";
            this.button_help.Size = new System.Drawing.Size(46, 36);
            this.button_help.TabIndex = 8;
            this.button_help.Text = "Help";
            this.button_help.UseVisualStyleBackColor = true;
            // 
            // label_message
            // 
            this.label_message.AutoSize = true;
            this.label_message.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_message.Location = new System.Drawing.Point(44, 71);
            this.label_message.Name = "label_message";
            this.label_message.Size = new System.Drawing.Size(145, 23);
            this.label_message.TabIndex = 4;
            this.label_message.Text = "Καλή επιτυχία!";
            // 
            // pictureBox_message
            // 
            this.pictureBox_message.BackgroundImage = global::Εducational_Software.Properties.Resources.messageCloud;
            this.pictureBox_message.Location = new System.Drawing.Point(23, 34);
            this.pictureBox_message.Name = "pictureBox_message";
            this.pictureBox_message.Size = new System.Drawing.Size(188, 125);
            this.pictureBox_message.TabIndex = 3;
            this.pictureBox_message.TabStop = false;
            // 
            // pictureBox_animal
            // 
            this.pictureBox_animal.Location = new System.Drawing.Point(23, 174);
            this.pictureBox_animal.Name = "pictureBox_animal";
            this.pictureBox_animal.Size = new System.Drawing.Size(125, 156);
            this.pictureBox_animal.TabIndex = 2;
            this.pictureBox_animal.TabStop = false;
            // 
            // button_check
            // 
            this.button_check.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_check.Location = new System.Drawing.Point(220, 294);
            this.button_check.Name = "button_check";
            this.button_check.Size = new System.Drawing.Size(88, 36);
            this.button_check.TabIndex = 0;
            this.button_check.Text = "Έλεγχος";
            this.button_check.UseVisualStyleBackColor = true;
            // 
            // button_next_end
            // 
            this.button_next_end.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_next_end.Location = new System.Drawing.Point(550, 294);
            this.button_next_end.Name = "button_next_end";
            this.button_next_end.Size = new System.Drawing.Size(88, 36);
            this.button_next_end.TabIndex = 1;
            this.button_next_end.Text = "Επόμενο";
            this.button_next_end.UseVisualStyleBackColor = true;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 453);
            this.Controls.Add(this.panel_test);
            this.Controls.Add(this.label_Test);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mathster";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel_test.ResumeLayout(false);
            this.panel_test.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_message)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_animal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem πίσωToolStripMenuItem;
        private System.Windows.Forms.Label label_Test;
        private System.Windows.Forms.Panel panel_test;
        private System.Windows.Forms.Button button_check;
        private System.Windows.Forms.Button button_next_end;
        private System.Windows.Forms.PictureBox pictureBox_message;
        private System.Windows.Forms.PictureBox pictureBox_animal;
        private System.Windows.Forms.Label label_message;
        private System.Windows.Forms.Button button_help;
        private System.Windows.Forms.ToolStripMenuItem βοήθειαToolStripMenuItem;
    }
}