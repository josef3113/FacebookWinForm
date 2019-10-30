namespace WindowsFormsFacebook
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.pictureBoxPropilePhoto = new System.Windows.Forms.PictureBox();
            this.buttonSelectedPhotosByDateCreat = new System.Windows.Forms.Button();
            this.buttonAnalystPost = new System.Windows.Forms.Button();
            this.linkFriends = new System.Windows.Forms.LinkLabel();
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.friendBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelPostStatus = new System.Windows.Forms.Label();
            this.buttonSetStatus = new System.Windows.Forms.Button();
            this.linkPosts = new System.Windows.Forms.LinkLabel();
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.listBoxPostComments = new System.Windows.Forms.ListBox();
            this.labelEvents = new System.Windows.Forms.LinkLabel();
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.eventBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBoxEvent = new System.Windows.Forms.PictureBox();
            this.textBoxHintProxyPost = new WindowsFormsFacebook.TextBoxHintProxy();
            this.pictureBoxFriendPhoto = new System.Windows.Forms.PictureBox();
            this.buttonExitApp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPropilePhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.friendBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEvent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriendPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxPropilePhoto
            // 
            this.pictureBoxPropilePhoto.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBoxPropilePhoto.Location = new System.Drawing.Point(13, 86);
            this.pictureBoxPropilePhoto.Name = "pictureBoxPropilePhoto";
            this.pictureBoxPropilePhoto.Size = new System.Drawing.Size(328, 310);
            this.pictureBoxPropilePhoto.TabIndex = 1;
            this.pictureBoxPropilePhoto.TabStop = false;
            // 
            // buttonSelectedPhotosByDateCreat
            // 
            this.buttonSelectedPhotosByDateCreat.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonSelectedPhotosByDateCreat.Location = new System.Drawing.Point(13, 577);
            this.buttonSelectedPhotosByDateCreat.Name = "buttonSelectedPhotosByDateCreat";
            this.buttonSelectedPhotosByDateCreat.Size = new System.Drawing.Size(328, 56);
            this.buttonSelectedPhotosByDateCreat.TabIndex = 3;
            this.buttonSelectedPhotosByDateCreat.Text = "Select Photos By Time";
            this.buttonSelectedPhotosByDateCreat.UseVisualStyleBackColor = false;
            this.buttonSelectedPhotosByDateCreat.Click += new System.EventHandler(this.buttonSelectedPhotosByDateCreat_Click);
            // 
            // buttonAnalystPost
            // 
            this.buttonAnalystPost.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonAnalystPost.Location = new System.Drawing.Point(13, 475);
            this.buttonAnalystPost.Name = "buttonAnalystPost";
            this.buttonAnalystPost.Size = new System.Drawing.Size(328, 56);
            this.buttonAnalystPost.TabIndex = 4;
            this.buttonAnalystPost.Text = "Analyst Posts";
            this.buttonAnalystPost.UseVisualStyleBackColor = false;
            this.buttonAnalystPost.Click += new System.EventHandler(this.buttonAnalystPost_Click);
            // 
            // linkFriends
            // 
            this.linkFriends.AutoSize = true;
            this.linkFriends.LinkArea = new System.Windows.Forms.LinkArea(0, 13);
            this.linkFriends.Location = new System.Drawing.Point(377, 86);
            this.linkFriends.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkFriends.Name = "linkFriends";
            this.linkFriends.Size = new System.Drawing.Size(317, 35);
            this.linkFriends.TabIndex = 48;
            this.linkFriends.TabStop = true;
            this.linkFriends.Text = "Fetch Friends (Only friends who also use this app..)\r\n(Click on a friend to view " +
    "it\'s picture)";
            this.linkFriends.UseCompatibleTextRendering = true;
            this.linkFriends.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkFriends_LinkClicked);
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.DataSource = this.friendBindingSource;
            this.listBoxFriends.DisplayMember = "Name";
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.ItemHeight = 16;
            this.listBoxFriends.Location = new System.Drawing.Point(377, 125);
            this.listBoxFriends.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(317, 180);
            this.listBoxFriends.TabIndex = 49;
            this.listBoxFriends.ValueMember = "About";
            this.listBoxFriends.SelectedIndexChanged += new System.EventHandler(this.listBoxFriends_SelectedIndexChanged);
            // 
            // friendBindingSource
            // 
            this.friendBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.User);
            // 
            // labelPostStatus
            // 
            this.labelPostStatus.AutoSize = true;
            this.labelPostStatus.Location = new System.Drawing.Point(741, 560);
            this.labelPostStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPostStatus.Name = "labelPostStatus";
            this.labelPostStatus.Size = new System.Drawing.Size(84, 17);
            this.labelPostStatus.TabIndex = 51;
            this.labelPostStatus.Text = "Post Status:";
            // 
            // buttonSetStatus
            // 
            this.buttonSetStatus.Location = new System.Drawing.Point(744, 609);
            this.buttonSetStatus.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSetStatus.Name = "buttonSetStatus";
            this.buttonSetStatus.Size = new System.Drawing.Size(317, 29);
            this.buttonSetStatus.TabIndex = 53;
            this.buttonSetStatus.Text = "Post";
            this.buttonSetStatus.UseVisualStyleBackColor = true;
            this.buttonSetStatus.Click += new System.EventHandler(this.buttonSetStatus_Click);
            // 
            // linkPosts
            // 
            this.linkPosts.AutoSize = true;
            this.linkPosts.LinkArea = new System.Windows.Forms.LinkArea(0, 13);
            this.linkPosts.Location = new System.Drawing.Point(744, 86);
            this.linkPosts.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkPosts.Name = "linkPosts";
            this.linkPosts.Size = new System.Drawing.Size(212, 35);
            this.linkPosts.TabIndex = 55;
            this.linkPosts.TabStop = true;
            this.linkPosts.Text = "Fetch postss \r\n(Click on a post to view comments)";
            this.linkPosts.UseCompatibleTextRendering = true;
            this.linkPosts.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkPosts_LinkClicked);
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.ItemHeight = 16;
            this.listBoxPosts.Location = new System.Drawing.Point(744, 125);
            this.listBoxPosts.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(317, 180);
            this.listBoxPosts.TabIndex = 56;
            this.listBoxPosts.SelectedIndexChanged += new System.EventHandler(this.listBoxPosts_SelectedIndexChanged);
            // 
            // listBoxPostComments
            // 
            this.listBoxPostComments.FormattingEnabled = true;
            this.listBoxPostComments.ItemHeight = 16;
            this.listBoxPostComments.Location = new System.Drawing.Point(744, 344);
            this.listBoxPostComments.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxPostComments.Name = "listBoxPostComments";
            this.listBoxPostComments.Size = new System.Drawing.Size(317, 212);
            this.listBoxPostComments.TabIndex = 57;
            // 
            // labelEvents
            // 
            this.labelEvents.AutoSize = true;
            this.labelEvents.LinkArea = new System.Windows.Forms.LinkArea(0, 13);
            this.labelEvents.Location = new System.Drawing.Point(1097, 83);
            this.labelEvents.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEvents.Name = "labelEvents";
            this.labelEvents.Size = new System.Drawing.Size(225, 35);
            this.labelEvents.TabIndex = 58;
            this.labelEvents.TabStop = true;
            this.labelEvents.Text = "Fetch Events \r\n(Click on an event to view it\'s picture)";
            this.labelEvents.UseCompatibleTextRendering = true;
            this.labelEvents.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.labelEvents_LinkClicked);
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.DataSource = this.eventBindingSource;
            this.listBoxEvents.DisplayMember = "Name";
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.ItemHeight = 16;
            this.listBoxEvents.Location = new System.Drawing.Point(1097, 125);
            this.listBoxEvents.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(317, 180);
            this.listBoxEvents.TabIndex = 59;
            this.listBoxEvents.ValueMember = "AttendingUsers";
            this.listBoxEvents.SelectedIndexChanged += new System.EventHandler(this.listBoxEvents_SelectedIndexChanged);
            // 
            // eventBindingSource
            // 
            this.eventBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Event);
            // 
            // pictureBoxEvent
            // 
            this.pictureBoxEvent.Location = new System.Drawing.Point(1097, 344);
            this.pictureBoxEvent.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxEvent.Name = "pictureBoxEvent";
            this.pictureBoxEvent.Size = new System.Drawing.Size(317, 289);
            this.pictureBoxEvent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxEvent.TabIndex = 60;
            this.pictureBoxEvent.TabStop = false;
            // 
            // textBoxHintProxyPost
            // 
            this.textBoxHintProxyPost.Location = new System.Drawing.Point(744, 580);
            this.textBoxHintProxyPost.Name = "textBoxHintProxyPost";
            this.textBoxHintProxyPost.Size = new System.Drawing.Size(317, 22);
            this.textBoxHintProxyPost.TabIndex = 63;
            this.textBoxHintProxyPost.Text = "what are you thinking about ?";
            // 
            // pictureBoxFriendPhoto
            // 
            this.pictureBoxFriendPhoto.Location = new System.Drawing.Point(377, 344);
            this.pictureBoxFriendPhoto.Name = "pictureBoxFriendPhoto";
            this.pictureBoxFriendPhoto.Size = new System.Drawing.Size(317, 289);
            this.pictureBoxFriendPhoto.TabIndex = 64;
            this.pictureBoxFriendPhoto.TabStop = false;
            // 
            // buttonExitApp
            // 
            this.buttonExitApp.BackColor = System.Drawing.Color.Red;
            this.buttonExitApp.Location = new System.Drawing.Point(1164, 12);
            this.buttonExitApp.Name = "buttonExitApp";
            this.buttonExitApp.Size = new System.Drawing.Size(250, 40);
            this.buttonExitApp.TabIndex = 66;
            this.buttonExitApp.Text = "Exit App";
            this.buttonExitApp.UseVisualStyleBackColor = false;
            this.buttonExitApp.Click += new System.EventHandler(this.buttonExitApp_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1437, 653);
            this.Controls.Add(this.buttonExitApp);
            this.Controls.Add(this.pictureBoxFriendPhoto);
            this.Controls.Add(this.textBoxHintProxyPost);
            this.Controls.Add(this.pictureBoxEvent);
            this.Controls.Add(this.listBoxEvents);
            this.Controls.Add(this.labelEvents);
            this.Controls.Add(this.listBoxPostComments);
            this.Controls.Add(this.listBoxPosts);
            this.Controls.Add(this.linkPosts);
            this.Controls.Add(this.buttonSetStatus);
            this.Controls.Add(this.labelPostStatus);
            this.Controls.Add(this.listBoxFriends);
            this.Controls.Add(this.linkFriends);
            this.Controls.Add(this.buttonAnalystPost);
            this.Controls.Add(this.buttonSelectedPhotosByDateCreat);
            this.Controls.Add(this.pictureBoxPropilePhoto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "Facebook";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPropilePhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.friendBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEvent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriendPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxPropilePhoto;
        private System.Windows.Forms.Button buttonSelectedPhotosByDateCreat;
        private System.Windows.Forms.Button buttonAnalystPost;
        private System.Windows.Forms.LinkLabel linkFriends;
        private System.Windows.Forms.ListBox listBoxFriends;
        private System.Windows.Forms.Label labelPostStatus;
        private System.Windows.Forms.Button buttonSetStatus;
        private System.Windows.Forms.LinkLabel linkPosts;
        private System.Windows.Forms.ListBox listBoxPosts;
        private System.Windows.Forms.ListBox listBoxPostComments;
        private System.Windows.Forms.LinkLabel labelEvents;
        private System.Windows.Forms.ListBox listBoxEvents;
        private System.Windows.Forms.PictureBox pictureBoxEvent;
        private System.Windows.Forms.BindingSource eventBindingSource;
        private System.Windows.Forms.BindingSource friendBindingSource;
        private TextBoxHintProxy textBoxHintProxyPost;
        private System.Windows.Forms.PictureBox pictureBoxFriendPhoto;
        private System.Windows.Forms.Button buttonExitApp;
    }
}