namespace WindowsFormsFacebook
{
    partial class FormSelectPhotos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSelectPhotos));
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.buttonGetPhotos = new System.Windows.Forms.Button();
            this.pictureBoxPhotosSelected = new System.Windows.Forms.PictureBox();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.labelTimeCreatedPhoto = new System.Windows.Forms.Label();
            this.labelNumOfLikes = new System.Windows.Forms.Label();
            this.groupBoxSortBy = new System.Windows.Forms.GroupBox();
            this.radioButtonByNumOfLikes = new System.Windows.Forms.RadioButton();
            this.radioButtonByTimeCreated = new System.Windows.Forms.RadioButton();
            this.buttonDowloadImags = new System.Windows.Forms.Button();
            this.labelDateFrom = new System.Windows.Forms.Label();
            this.labelUntilDate = new System.Windows.Forms.Label();
            this.labelConstLikes = new System.Windows.Forms.Label();
            this.groupBoxFormatNamePhotoDown = new System.Windows.Forms.GroupBox();
            this.radioButtonNameByID = new System.Windows.Forms.RadioButton();
            this.radioButtonNameByDateCreate = new System.Windows.Forms.RadioButton();
            this.buttonExitApp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhotosSelected)).BeginInit();
            this.groupBoxSortBy.SuspendLayout();
            this.groupBoxFormatNamePhotoDown.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerStart.Location = new System.Drawing.Point(50, 105);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(160, 22);
            this.dateTimePickerStart.TabIndex = 0;
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerEnd.Location = new System.Drawing.Point(50, 163);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(160, 22);
            this.dateTimePickerEnd.TabIndex = 1;
            // 
            // buttonGetPhotos
            // 
            this.buttonGetPhotos.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonGetPhotos.Location = new System.Drawing.Point(44, 392);
            this.buttonGetPhotos.Name = "buttonGetPhotos";
            this.buttonGetPhotos.Size = new System.Drawing.Size(160, 75);
            this.buttonGetPhotos.TabIndex = 2;
            this.buttonGetPhotos.Text = "Get Photos";
            this.buttonGetPhotos.UseVisualStyleBackColor = false;
            this.buttonGetPhotos.Click += new System.EventHandler(this.buttonGetPhotos_Click);
            // 
            // pictureBoxPhotosSelected
            // 
            this.pictureBoxPhotosSelected.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBoxPhotosSelected.Location = new System.Drawing.Point(252, 85);
            this.pictureBoxPhotosSelected.Name = "pictureBoxPhotosSelected";
            this.pictureBoxPhotosSelected.Size = new System.Drawing.Size(503, 393);
            this.pictureBoxPhotosSelected.TabIndex = 3;
            this.pictureBoxPhotosSelected.TabStop = false;
            // 
            // buttonNext
            // 
            this.buttonNext.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonNext.Location = new System.Drawing.Point(519, 484);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(236, 71);
            this.buttonNext.TabIndex = 6;
            this.buttonNext.Text = "Next >>";
            this.buttonNext.UseVisualStyleBackColor = false;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonPrev
            // 
            this.buttonPrev.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonPrev.Location = new System.Drawing.Point(252, 484);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(227, 71);
            this.buttonPrev.TabIndex = 7;
            this.buttonPrev.Text = "<< Prev";
            this.buttonPrev.UseVisualStyleBackColor = false;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // labelTimeCreatedPhoto
            // 
            this.labelTimeCreatedPhoto.AutoSize = true;
            this.labelTimeCreatedPhoto.Location = new System.Drawing.Point(249, 65);
            this.labelTimeCreatedPhoto.Name = "labelTimeCreatedPhoto";
            this.labelTimeCreatedPhoto.Size = new System.Drawing.Size(93, 17);
            this.labelTimeCreatedPhoto.TabIndex = 8;
            this.labelTimeCreatedPhoto.Text = "Time Created";
            // 
            // labelNumOfLikes
            // 
            this.labelNumOfLikes.AutoSize = true;
            this.labelNumOfLikes.Location = new System.Drawing.Point(701, 65);
            this.labelNumOfLikes.Name = "labelNumOfLikes";
            this.labelNumOfLikes.Size = new System.Drawing.Size(41, 17);
            this.labelNumOfLikes.TabIndex = 9;
            this.labelNumOfLikes.Text = "Likes";
            // 
            // groupBoxSortBy
            // 
            this.groupBoxSortBy.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxSortBy.Controls.Add(this.radioButtonByNumOfLikes);
            this.groupBoxSortBy.Controls.Add(this.radioButtonByTimeCreated);
            this.groupBoxSortBy.Location = new System.Drawing.Point(44, 221);
            this.groupBoxSortBy.Name = "groupBoxSortBy";
            this.groupBoxSortBy.Size = new System.Drawing.Size(160, 101);
            this.groupBoxSortBy.TabIndex = 10;
            this.groupBoxSortBy.TabStop = false;
            this.groupBoxSortBy.Text = "Sort By";
            // 
            // radioButtonByNumOfLikes
            // 
            this.radioButtonByNumOfLikes.AutoSize = true;
            this.radioButtonByNumOfLikes.Location = new System.Drawing.Point(6, 59);
            this.radioButtonByNumOfLikes.Name = "radioButtonByNumOfLikes";
            this.radioButtonByNumOfLikes.Size = new System.Drawing.Size(95, 21);
            this.radioButtonByNumOfLikes.TabIndex = 1;
            this.radioButtonByNumOfLikes.TabStop = true;
            this.radioButtonByNumOfLikes.Text = "Num Likes";
            this.radioButtonByNumOfLikes.UseVisualStyleBackColor = true;
            // 
            // radioButtonByTimeCreated
            // 
            this.radioButtonByTimeCreated.AutoSize = true;
            this.radioButtonByTimeCreated.Location = new System.Drawing.Point(6, 32);
            this.radioButtonByTimeCreated.Name = "radioButtonByTimeCreated";
            this.radioButtonByTimeCreated.Size = new System.Drawing.Size(118, 21);
            this.radioButtonByTimeCreated.TabIndex = 0;
            this.radioButtonByTimeCreated.TabStop = true;
            this.radioButtonByTimeCreated.Text = "Time Created ";
            this.radioButtonByTimeCreated.UseVisualStyleBackColor = true;
            // 
            // buttonDowloadImags
            // 
            this.buttonDowloadImags.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonDowloadImags.Location = new System.Drawing.Point(252, 623);
            this.buttonDowloadImags.Name = "buttonDowloadImags";
            this.buttonDowloadImags.Size = new System.Drawing.Size(503, 59);
            this.buttonDowloadImags.TabIndex = 11;
            this.buttonDowloadImags.Text = "Dowload Imags";
            this.buttonDowloadImags.UseVisualStyleBackColor = false;
            this.buttonDowloadImags.Click += new System.EventHandler(this.buttonDowloadImags_Click);
            // 
            // labelDateFrom
            // 
            this.labelDateFrom.AutoSize = true;
            this.labelDateFrom.Location = new System.Drawing.Point(47, 85);
            this.labelDateFrom.Name = "labelDateFrom";
            this.labelDateFrom.Size = new System.Drawing.Size(74, 17);
            this.labelDateFrom.TabIndex = 12;
            this.labelDateFrom.Text = "From Date";
            // 
            // labelUntilDate
            // 
            this.labelUntilDate.AutoSize = true;
            this.labelUntilDate.Location = new System.Drawing.Point(47, 143);
            this.labelUntilDate.Name = "labelUntilDate";
            this.labelUntilDate.Size = new System.Drawing.Size(70, 17);
            this.labelUntilDate.TabIndex = 13;
            this.labelUntilDate.Text = "Until Date";
            // 
            // labelConstLikes
            // 
            this.labelConstLikes.AutoSize = true;
            this.labelConstLikes.Location = new System.Drawing.Point(654, 65);
            this.labelConstLikes.Name = "labelConstLikes";
            this.labelConstLikes.Size = new System.Drawing.Size(45, 17);
            this.labelConstLikes.TabIndex = 14;
            this.labelConstLikes.Text = "Likes:";
            // 
            // groupBoxFormatNamePhotoDown
            // 
            this.groupBoxFormatNamePhotoDown.Controls.Add(this.radioButtonNameByID);
            this.groupBoxFormatNamePhotoDown.Controls.Add(this.radioButtonNameByDateCreate);
            this.groupBoxFormatNamePhotoDown.Location = new System.Drawing.Point(252, 569);
            this.groupBoxFormatNamePhotoDown.Name = "groupBoxFormatNamePhotoDown";
            this.groupBoxFormatNamePhotoDown.Size = new System.Drawing.Size(503, 47);
            this.groupBoxFormatNamePhotoDown.TabIndex = 15;
            this.groupBoxFormatNamePhotoDown.TabStop = false;
            this.groupBoxFormatNamePhotoDown.Text = "Name Photos By";
            // 
            // radioButtonNameByID
            // 
            this.radioButtonNameByID.AutoSize = true;
            this.radioButtonNameByID.Location = new System.Drawing.Point(395, 20);
            this.radioButtonNameByID.Name = "radioButtonNameByID";
            this.radioButtonNameByID.Size = new System.Drawing.Size(42, 21);
            this.radioButtonNameByID.TabIndex = 1;
            this.radioButtonNameByID.TabStop = true;
            this.radioButtonNameByID.Text = "ID";
            this.radioButtonNameByID.UseVisualStyleBackColor = true;
            // 
            // radioButtonNameByDateCreate
            // 
            this.radioButtonNameByDateCreate.AutoSize = true;
            this.radioButtonNameByDateCreate.Location = new System.Drawing.Point(207, 20);
            this.radioButtonNameByDateCreate.Name = "radioButtonNameByDateCreate";
            this.radioButtonNameByDateCreate.Size = new System.Drawing.Size(105, 21);
            this.radioButtonNameByDateCreate.TabIndex = 0;
            this.radioButtonNameByDateCreate.TabStop = true;
            this.radioButtonNameByDateCreate.Text = "Date Create";
            this.radioButtonNameByDateCreate.UseVisualStyleBackColor = true;
            // 
            // buttonExitApp
            // 
            this.buttonExitApp.BackColor = System.Drawing.Color.Red;
            this.buttonExitApp.Location = new System.Drawing.Point(505, 12);
            this.buttonExitApp.Name = "buttonExitApp";
            this.buttonExitApp.Size = new System.Drawing.Size(250, 40);
            this.buttonExitApp.TabIndex = 16;
            this.buttonExitApp.Text = "Exit App";
            this.buttonExitApp.UseVisualStyleBackColor = false;
            this.buttonExitApp.Click += new System.EventHandler(this.buttonExitApp_Click);
            // 
            // FormSelectPhotos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(787, 699);
            this.Controls.Add(this.buttonExitApp);
            this.Controls.Add(this.groupBoxFormatNamePhotoDown);
            this.Controls.Add(this.labelConstLikes);
            this.Controls.Add(this.labelUntilDate);
            this.Controls.Add(this.labelDateFrom);
            this.Controls.Add(this.buttonDowloadImags);
            this.Controls.Add(this.groupBoxSortBy);
            this.Controls.Add(this.labelNumOfLikes);
            this.Controls.Add(this.labelTimeCreatedPhoto);
            this.Controls.Add(this.buttonPrev);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.pictureBoxPhotosSelected);
            this.Controls.Add(this.buttonGetPhotos);
            this.Controls.Add(this.dateTimePickerEnd);
            this.Controls.Add(this.dateTimePickerStart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSelectPhotos";
            this.Text = "Facebook";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhotosSelected)).EndInit();
            this.groupBoxSortBy.ResumeLayout(false);
            this.groupBoxSortBy.PerformLayout();
            this.groupBoxFormatNamePhotoDown.ResumeLayout(false);
            this.groupBoxFormatNamePhotoDown.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.Button buttonGetPhotos;
        private System.Windows.Forms.PictureBox pictureBoxPhotosSelected;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Label labelTimeCreatedPhoto;
        private System.Windows.Forms.Label labelNumOfLikes;
        private System.Windows.Forms.GroupBox groupBoxSortBy;
        private System.Windows.Forms.RadioButton radioButtonByNumOfLikes;
        private System.Windows.Forms.RadioButton radioButtonByTimeCreated;
        private System.Windows.Forms.Button buttonDowloadImags;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.Label labelDateFrom;
        private System.Windows.Forms.Label labelUntilDate;
        private System.Windows.Forms.Label labelConstLikes;
        private System.Windows.Forms.GroupBox groupBoxFormatNamePhotoDown;
        private System.Windows.Forms.RadioButton radioButtonNameByDateCreate;
        private System.Windows.Forms.RadioButton radioButtonNameByID;
        private System.Windows.Forms.Button buttonExitApp;
    }
}