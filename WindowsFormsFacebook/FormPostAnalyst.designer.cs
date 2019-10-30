namespace WindowsFormsFacebook
{
    partial class FormPostAnalyst
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPostAnalyst));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxSortBy = new System.Windows.Forms.GroupBox();
            this.radioButtonByNumOfLikes = new System.Windows.Forms.RadioButton();
            this.radioButtonByCreatTime = new System.Windows.Forms.RadioButton();
            this.chartAnalysisPostBySubjects = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonAnalysisPost = new System.Windows.Forms.Button();
            this.buttonFetchPosts = new System.Windows.Forms.Button();
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.textBoxWords = new System.Windows.Forms.TextBox();
            this.buttonPostWithWord = new System.Windows.Forms.Button();
            this.dataGridViewPostWithWord = new System.Windows.Forms.DataGridView();
            this.buttonExitApp = new System.Windows.Forms.Button();
            this.labelMinLenght = new System.Windows.Forms.Label();
            this.textBoxLenghtMinPost = new System.Windows.Forms.TextBox();
            this.groupBoxSortBy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartAnalysisPostBySubjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPostWithWord)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(9, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Enter words to sort by: ";
            // 
            // groupBoxSortBy
            // 
            this.groupBoxSortBy.BackColor = System.Drawing.Color.CornflowerBlue;
            this.groupBoxSortBy.Controls.Add(this.radioButtonByNumOfLikes);
            this.groupBoxSortBy.Controls.Add(this.radioButtonByCreatTime);
            this.groupBoxSortBy.Location = new System.Drawing.Point(954, 514);
            this.groupBoxSortBy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxSortBy.Name = "groupBoxSortBy";
            this.groupBoxSortBy.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxSortBy.Size = new System.Drawing.Size(303, 62);
            this.groupBoxSortBy.TabIndex = 15;
            this.groupBoxSortBy.TabStop = false;
            this.groupBoxSortBy.Text = "Sort By";
            // 
            // radioButtonByNumOfLikes
            // 
            this.radioButtonByNumOfLikes.AutoSize = true;
            this.radioButtonByNumOfLikes.Location = new System.Drawing.Point(132, 21);
            this.radioButtonByNumOfLikes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonByNumOfLikes.Name = "radioButtonByNumOfLikes";
            this.radioButtonByNumOfLikes.Size = new System.Drawing.Size(106, 21);
            this.radioButtonByNumOfLikes.TabIndex = 1;
            this.radioButtonByNumOfLikes.TabStop = true;
            this.radioButtonByNumOfLikes.Text = "NumOfLikes";
            this.radioButtonByNumOfLikes.UseVisualStyleBackColor = true;
            // 
            // radioButtonByCreatTime
            // 
            this.radioButtonByCreatTime.AutoSize = true;
            this.radioButtonByCreatTime.Location = new System.Drawing.Point(9, 21);
            this.radioButtonByCreatTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonByCreatTime.Name = "radioButtonByCreatTime";
            this.radioButtonByCreatTime.Size = new System.Drawing.Size(98, 21);
            this.radioButtonByCreatTime.TabIndex = 0;
            this.radioButtonByCreatTime.TabStop = true;
            this.radioButtonByCreatTime.Text = "Creat Time";
            this.radioButtonByCreatTime.UseVisualStyleBackColor = true;
            // 
            // chartAnalysisPostBySubjects
            // 
            this.chartAnalysisPostBySubjects.BackColor = System.Drawing.Color.CornflowerBlue;
            this.chartAnalysisPostBySubjects.BorderlineColor = System.Drawing.Color.CornflowerBlue;
            chartArea1.Name = "ChartArea1";
            this.chartAnalysisPostBySubjects.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartAnalysisPostBySubjects.Legends.Add(legend1);
            this.chartAnalysisPostBySubjects.Location = new System.Drawing.Point(478, 162);
            this.chartAnalysisPostBySubjects.Margin = new System.Windows.Forms.Padding(4);
            this.chartAnalysisPostBySubjects.Name = "chartAnalysisPostBySubjects";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "statistics";
            this.chartAnalysisPostBySubjects.Series.Add(series1);
            this.chartAnalysisPostBySubjects.Size = new System.Drawing.Size(469, 410);
            this.chartAnalysisPostBySubjects.TabIndex = 16;
            this.chartAnalysisPostBySubjects.Text = "Analysis Post By Subjects";
            // 
            // buttonAnalysisPost
            // 
            this.buttonAnalysisPost.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonAnalysisPost.Location = new System.Drawing.Point(478, 99);
            this.buttonAnalysisPost.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAnalysisPost.Name = "buttonAnalysisPost";
            this.buttonAnalysisPost.Size = new System.Drawing.Size(469, 55);
            this.buttonAnalysisPost.TabIndex = 17;
            this.buttonAnalysisPost.Text = "Analysis Post By Subjects";
            this.buttonAnalysisPost.UseVisualStyleBackColor = false;
            this.buttonAnalysisPost.Click += new System.EventHandler(this.buttonAnalysisPost_Click);
            // 
            // buttonFetchPosts
            // 
            this.buttonFetchPosts.Location = new System.Drawing.Point(954, 99);
            this.buttonFetchPosts.Name = "buttonFetchPosts";
            this.buttonFetchPosts.Size = new System.Drawing.Size(303, 55);
            this.buttonFetchPosts.TabIndex = 13;
            this.buttonFetchPosts.Text = "Fetch Text Post (click to see full post)";
            this.buttonFetchPosts.UseCompatibleTextRendering = true;
            this.buttonFetchPosts.UseVisualStyleBackColor = true;
            this.buttonFetchPosts.Click += new System.EventHandler(this.buttonFetchPosts_Click);
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.DisplayMember = "Caption";
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.ItemHeight = 16;
            this.listBoxPosts.Location = new System.Drawing.Point(954, 162);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(303, 340);
            this.listBoxPosts.TabIndex = 18;
            this.listBoxPosts.ValueMember = "Caption";
            this.listBoxPosts.SelectedIndexChanged += new System.EventHandler(this.listBoxPosts_SelectedIndexChanged);
            // 
            // textBoxWords
            // 
            this.textBoxWords.Location = new System.Drawing.Point(13, 54);
            this.textBoxWords.Name = "textBoxWords";
            this.textBoxWords.Size = new System.Drawing.Size(457, 22);
            this.textBoxWords.TabIndex = 19;
            // 
            // buttonPostWithWord
            // 
            this.buttonPostWithWord.Location = new System.Drawing.Point(13, 99);
            this.buttonPostWithWord.Name = "buttonPostWithWord";
            this.buttonPostWithWord.Size = new System.Drawing.Size(457, 55);
            this.buttonPostWithWord.TabIndex = 20;
            this.buttonPostWithWord.Text = "Found Posts With Words";
            this.buttonPostWithWord.UseVisualStyleBackColor = true;
            this.buttonPostWithWord.Click += new System.EventHandler(this.buttonPostWithWord_Click);
            // 
            // dataGridViewPostWithWord
            // 
            this.dataGridViewPostWithWord.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPostWithWord.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewPostWithWord.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.dataGridViewPostWithWord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Aharoni", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPostWithWord.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPostWithWord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewPostWithWord.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewPostWithWord.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridViewPostWithWord.Location = new System.Drawing.Point(13, 162);
            this.dataGridViewPostWithWord.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewPostWithWord.Name = "dataGridViewPostWithWord";
            this.dataGridViewPostWithWord.ReadOnly = true;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewPostWithWord.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewPostWithWord.Size = new System.Drawing.Size(457, 410);
            this.dataGridViewPostWithWord.TabIndex = 22;
            // 
            // buttonExitApp
            // 
            this.buttonExitApp.BackColor = System.Drawing.Color.Red;
            this.buttonExitApp.Location = new System.Drawing.Point(1007, 9);
            this.buttonExitApp.Name = "buttonExitApp";
            this.buttonExitApp.Size = new System.Drawing.Size(250, 40);
            this.buttonExitApp.TabIndex = 24;
            this.buttonExitApp.Text = "Exit App";
            this.buttonExitApp.UseVisualStyleBackColor = false;
            this.buttonExitApp.Click += new System.EventHandler(this.buttonExitApp_Click);
            // 
            // labelMinLenght
            // 
            this.labelMinLenght.AutoSize = true;
            this.labelMinLenght.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelMinLenght.Location = new System.Drawing.Point(958, 64);
            this.labelMinLenght.Name = "labelMinLenght";
            this.labelMinLenght.Size = new System.Drawing.Size(167, 20);
            this.labelMinLenght.TabIndex = 25;
            this.labelMinLenght.Text = "Min Lenght To Show:";
            // 
            // textBoxLenghtMinPost
            // 
            this.textBoxLenghtMinPost.Location = new System.Drawing.Point(1131, 63);
            this.textBoxLenghtMinPost.Name = "textBoxLenghtMinPost";
            this.textBoxLenghtMinPost.Size = new System.Drawing.Size(100, 22);
            this.textBoxLenghtMinPost.TabIndex = 26;
            this.textBoxLenghtMinPost.Text = "10";
            // 
            // FormPostAnalyst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BackgroundImage = global::WindowsFormsFacebook.Properties.Resources.facebook_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1279, 618);
            this.Controls.Add(this.textBoxLenghtMinPost);
            this.Controls.Add(this.labelMinLenght);
            this.Controls.Add(this.buttonExitApp);
            this.Controls.Add(this.dataGridViewPostWithWord);
            this.Controls.Add(this.buttonPostWithWord);
            this.Controls.Add(this.textBoxWords);
            this.Controls.Add(this.listBoxPosts);
            this.Controls.Add(this.buttonFetchPosts);
            this.Controls.Add(this.buttonAnalysisPost);
            this.Controls.Add(this.chartAnalysisPostBySubjects);
            this.Controls.Add(this.groupBoxSortBy);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormPostAnalyst";
            this.Text = "MyFicherForm";
            this.groupBoxSortBy.ResumeLayout(false);
            this.groupBoxSortBy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartAnalysisPostBySubjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPostWithWord)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxSortBy;
        private System.Windows.Forms.RadioButton radioButtonByNumOfLikes;
        private System.Windows.Forms.RadioButton radioButtonByCreatTime;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAnalysisPostBySubjects;
        private System.Windows.Forms.Button buttonAnalysisPost;
        private System.Windows.Forms.Button buttonFetchPosts;
        private System.Windows.Forms.ListBox listBoxPosts;
        private System.Windows.Forms.TextBox textBoxWords;
        private System.Windows.Forms.Button buttonPostWithWord;
        private System.Windows.Forms.DataGridView dataGridViewPostWithWord;
        private System.Windows.Forms.Button buttonExitApp;
        private System.Windows.Forms.Label labelMinLenght;
        private System.Windows.Forms.TextBox textBoxLenghtMinPost;
    }
}