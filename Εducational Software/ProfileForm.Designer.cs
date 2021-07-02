namespace Εducational_Software
{
    partial class ProfileForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label_nameOfUser = new System.Windows.Forms.Label();
            this.label_surnameOfUser = new System.Windows.Forms.Label();
            this.label_emailOfUser = new System.Windows.Forms.Label();
            this.groupBox_personalDetails = new System.Windows.Forms.GroupBox();
            this.label_email = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.label_surname = new System.Windows.Forms.Label();
            this.label_profile = new System.Windows.Forms.Label();
            this.groupBox_statisticalDetails = new System.Windows.Forms.GroupBox();
            this.chart_unitProblems = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_theoryRevisions = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_revisionRates = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_unitRates = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label_unit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_help = new System.Windows.Forms.Button();
            this.panel_details = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.groupBox_personalDetails.SuspendLayout();
            this.groupBox_statisticalDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_unitProblems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_theoryRevisions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_revisionRates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_unitRates)).BeginInit();
            this.panel_details.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
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
            this.backToolStripMenuItem.Image = global::Εducational_Software.Properties.Resources.backArrow;
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(76, 25);
            this.backToolStripMenuItem.Text = "Πίσω";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(82, 25);
            this.helpToolStripMenuItem.Text = "Βοήθεια";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // label_nameOfUser
            // 
            this.label_nameOfUser.AutoSize = true;
            this.label_nameOfUser.Location = new System.Drawing.Point(41, 32);
            this.label_nameOfUser.Name = "label_nameOfUser";
            this.label_nameOfUser.Size = new System.Drawing.Size(69, 21);
            this.label_nameOfUser.TabIndex = 2;
            this.label_nameOfUser.Text = "Όνομα:";
            // 
            // label_surnameOfUser
            // 
            this.label_surnameOfUser.AutoSize = true;
            this.label_surnameOfUser.Location = new System.Drawing.Point(40, 68);
            this.label_surnameOfUser.Name = "label_surnameOfUser";
            this.label_surnameOfUser.Size = new System.Drawing.Size(70, 21);
            this.label_surnameOfUser.TabIndex = 3;
            this.label_surnameOfUser.Text = "Επίθετο:";
            // 
            // label_emailOfUser
            // 
            this.label_emailOfUser.AutoSize = true;
            this.label_emailOfUser.Location = new System.Drawing.Point(54, 105);
            this.label_emailOfUser.Name = "label_emailOfUser";
            this.label_emailOfUser.Size = new System.Drawing.Size(55, 21);
            this.label_emailOfUser.TabIndex = 4;
            this.label_emailOfUser.Text = "Email:";
            // 
            // groupBox_personalDetails
            // 
            this.groupBox_personalDetails.Controls.Add(this.label_email);
            this.groupBox_personalDetails.Controls.Add(this.label_name);
            this.groupBox_personalDetails.Controls.Add(this.label_nameOfUser);
            this.groupBox_personalDetails.Controls.Add(this.label_surname);
            this.groupBox_personalDetails.Controls.Add(this.label_emailOfUser);
            this.groupBox_personalDetails.Controls.Add(this.label_surnameOfUser);
            this.groupBox_personalDetails.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_personalDetails.Location = new System.Drawing.Point(13, 12);
            this.groupBox_personalDetails.Name = "groupBox_personalDetails";
            this.groupBox_personalDetails.Size = new System.Drawing.Size(640, 136);
            this.groupBox_personalDetails.TabIndex = 6;
            this.groupBox_personalDetails.TabStop = false;
            this.groupBox_personalDetails.Text = "Προσωπικά Στοιχεία";
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Location = new System.Drawing.Point(156, 105);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(15, 21);
            this.label_email.TabIndex = 7;
            this.label_email.Text = "-";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(156, 32);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(15, 21);
            this.label_name.TabIndex = 5;
            this.label_name.Text = "-";
            // 
            // label_surname
            // 
            this.label_surname.AutoSize = true;
            this.label_surname.Location = new System.Drawing.Point(156, 68);
            this.label_surname.Name = "label_surname";
            this.label_surname.Size = new System.Drawing.Size(15, 21);
            this.label_surname.TabIndex = 6;
            this.label_surname.Text = "-";
            // 
            // label_profile
            // 
            this.label_profile.AutoSize = true;
            this.label_profile.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_profile.Location = new System.Drawing.Point(6, 37);
            this.label_profile.Name = "label_profile";
            this.label_profile.Size = new System.Drawing.Size(129, 39);
            this.label_profile.TabIndex = 7;
            this.label_profile.Text = "Προφίλ";
            // 
            // groupBox_statisticalDetails
            // 
            this.groupBox_statisticalDetails.Controls.Add(this.chart_unitProblems);
            this.groupBox_statisticalDetails.Controls.Add(this.chart_theoryRevisions);
            this.groupBox_statisticalDetails.Controls.Add(this.chart_revisionRates);
            this.groupBox_statisticalDetails.Controls.Add(this.chart_unitRates);
            this.groupBox_statisticalDetails.Controls.Add(this.label_unit);
            this.groupBox_statisticalDetails.Controls.Add(this.label1);
            this.groupBox_statisticalDetails.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_statisticalDetails.Location = new System.Drawing.Point(13, 165);
            this.groupBox_statisticalDetails.Name = "groupBox_statisticalDetails";
            this.groupBox_statisticalDetails.Size = new System.Drawing.Size(640, 1361);
            this.groupBox_statisticalDetails.TabIndex = 8;
            this.groupBox_statisticalDetails.TabStop = false;
            this.groupBox_statisticalDetails.Text = "Στατιστικά Στοιχεία:";
            // 
            // chart_unitProblems
            // 
            this.chart_unitProblems.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chart_unitProblems.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.chart_unitProblems.Legends.Add(legend1);
            this.chart_unitProblems.Location = new System.Drawing.Point(45, 995);
            this.chart_unitProblems.Name = "chart_unitProblems";
            this.chart_unitProblems.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            series1.Legend = "Legend1";
            series1.Name = "Ενότητες";
            this.chart_unitProblems.Series.Add(series1);
            this.chart_unitProblems.Size = new System.Drawing.Size(589, 335);
            this.chart_unitProblems.TabIndex = 5;
            this.chart_unitProblems.Text = "chart1";
            title1.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            title1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "Προβληματικές Ενότητες";
            this.chart_unitProblems.Titles.Add(title1);
            // 
            // chart_theoryRevisions
            // 
            this.chart_theoryRevisions.BackColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.chart_theoryRevisions.ChartAreas.Add(chartArea2);
            this.chart_theoryRevisions.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.chart_theoryRevisions.Location = new System.Drawing.Point(26, 372);
            this.chart_theoryRevisions.Name = "chart_theoryRevisions";
            series2.ChartArea = "ChartArea1";
            series2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.LabelBackColor = System.Drawing.Color.Transparent;
            series2.LabelBorderColor = System.Drawing.Color.Transparent;
            series2.Name = "Επαναλήψεις Θεωρίας";
            series2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            this.chart_theoryRevisions.Series.Add(series2);
            this.chart_theoryRevisions.Size = new System.Drawing.Size(596, 300);
            this.chart_theoryRevisions.TabIndex = 4;
            this.chart_theoryRevisions.Text = "chart1";
            title2.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            title2.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Left;
            title2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            title2.Name = "Title1";
            title2.Text = "Επαναλήψεις Θεωρίας";
            this.chart_theoryRevisions.Titles.Add(title2);
            // 
            // chart_revisionRates
            // 
            this.chart_revisionRates.BackColor = System.Drawing.Color.Transparent;
            chartArea3.BackColor = System.Drawing.Color.Transparent;
            chartArea3.Name = "ChartArea1";
            this.chart_revisionRates.ChartAreas.Add(chartArea3);
            legend2.BackColor = System.Drawing.Color.Transparent;
            legend2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend2.IsTextAutoFit = false;
            legend2.Name = "Legend1";
            this.chart_revisionRates.Legends.Add(legend2);
            this.chart_revisionRates.Location = new System.Drawing.Point(45, 687);
            this.chart_revisionRates.Name = "chart_revisionRates";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Color = System.Drawing.SystemColors.MenuHighlight;
            series3.CustomProperties = "PieLabelStyle=Disabled";
            series3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series3.Legend = "Legend1";
            series3.Name = "Revision";
            this.chart_revisionRates.Series.Add(series3);
            this.chart_revisionRates.Size = new System.Drawing.Size(550, 300);
            this.chart_revisionRates.TabIndex = 3;
            title3.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            title3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title3.Name = "Title1";
            title3.Text = "Επαναληπτικά Τεστ";
            this.chart_revisionRates.Titles.Add(title3);
            // 
            // chart_unitRates
            // 
            this.chart_unitRates.BackColor = System.Drawing.Color.Transparent;
            this.chart_unitRates.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea4.Name = "ChartArea1";
            this.chart_unitRates.ChartAreas.Add(chartArea4);
            legend3.BackColor = System.Drawing.Color.Transparent;
            legend3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend3.IsTextAutoFit = false;
            legend3.Name = "Legend1";
            this.chart_unitRates.Legends.Add(legend3);
            this.chart_unitRates.Location = new System.Drawing.Point(26, 66);
            this.chart_unitRates.Name = "chart_unitRates";
            this.chart_unitRates.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            this.chart_unitRates.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar100;
            series4.Color = System.Drawing.Color.LawnGreen;
            series4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series4.Legend = "Legend1";
            series4.Name = "Επιτυχία";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar100;
            series5.Color = System.Drawing.Color.Red;
            series5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series5.Legend = "Legend1";
            series5.Name = "Αποτυχία";
            this.chart_unitRates.Series.Add(series4);
            this.chart_unitRates.Series.Add(series5);
            this.chart_unitRates.Size = new System.Drawing.Size(596, 300);
            this.chart_unitRates.TabIndex = 2;
            this.chart_unitRates.Text = "Ποσοστά Επιτυχίας-Αποτυχίας κάθε Κεφαλαίου";
            title4.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            title4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title4.Name = "Title_chart_unitRates";
            title4.Text = "Τεστ Αυτοαξιολόγησης";
            this.chart_unitRates.Titles.Add(title4);
            // 
            // label_unit
            // 
            this.label_unit.AutoSize = true;
            this.label_unit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_unit.Location = new System.Drawing.Point(275, 35);
            this.label_unit.Name = "label_unit";
            this.label_unit.Size = new System.Drawing.Size(15, 21);
            this.label_unit.TabIndex = 1;
            this.label_unit.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ολοκληρωμένες Ενότητες:";
            // 
            // button_help
            // 
            this.button_help.BackColor = System.Drawing.Color.Transparent;
            this.button_help.BackgroundImage = global::Εducational_Software.Properties.Resources.help;
            this.button_help.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_help.Location = new System.Drawing.Point(640, 37);
            this.button_help.Name = "button_help";
            this.button_help.Size = new System.Drawing.Size(40, 40);
            this.button_help.TabIndex = 9;
            this.button_help.UseVisualStyleBackColor = false;
            this.button_help.Click += new System.EventHandler(this.button_help_Click);
            // 
            // panel_details
            // 
            this.panel_details.AutoScroll = true;
            this.panel_details.Controls.Add(this.groupBox_personalDetails);
            this.panel_details.Controls.Add(this.groupBox_statisticalDetails);
            this.panel_details.Location = new System.Drawing.Point(12, 79);
            this.panel_details.Name = "panel_details";
            this.panel_details.Size = new System.Drawing.Size(680, 375);
            this.panel_details.TabIndex = 10;
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(692, 453);
            this.Controls.Add(this.panel_details);
            this.Controls.Add(this.button_help);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label_profile);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "ProfileForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mathster";
            this.Load += new System.EventHandler(this.ProfileForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox_personalDetails.ResumeLayout(false);
            this.groupBox_personalDetails.PerformLayout();
            this.groupBox_statisticalDetails.ResumeLayout(false);
            this.groupBox_statisticalDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_unitProblems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_theoryRevisions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_revisionRates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_unitRates)).EndInit();
            this.panel_details.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.Label label_nameOfUser;
        private System.Windows.Forms.Label label_surnameOfUser;
        private System.Windows.Forms.Label label_emailOfUser;
        private System.Windows.Forms.GroupBox groupBox_personalDetails;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.Label label_surname;
        private System.Windows.Forms.Label label_profile;
        private System.Windows.Forms.GroupBox groupBox_statisticalDetails;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Button button_help;
        private System.Windows.Forms.Panel panel_details;
        private System.Windows.Forms.Label label_unit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_unitRates;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_revisionRates;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_theoryRevisions;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_unitProblems;
    }
}