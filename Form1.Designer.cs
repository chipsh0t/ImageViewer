namespace ImageViewerProject
{
    partial class Form1
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
            this.buttonRemoveDirectory = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonAddDirectory = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxImages = new System.Windows.Forms.ListBox();
            this.listBoxDirectories = new System.Windows.Forms.ListBox();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.pictureBoxNext = new System.Windows.Forms.PictureBox();
            this.pictureBoxCurrent = new System.Windows.Forms.PictureBox();
            this.pictureBoxPrevious = new System.Windows.Forms.PictureBox();
            this.checkBoxLoop = new System.Windows.Forms.CheckBox();
            this.textBoxInterval = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCurrent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPrevious)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRemoveDirectory
            // 
            this.buttonRemoveDirectory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonRemoveDirectory.Location = new System.Drawing.Point(299, 257);
            this.buttonRemoveDirectory.Name = "buttonRemoveDirectory";
            this.buttonRemoveDirectory.Size = new System.Drawing.Size(136, 48);
            this.buttonRemoveDirectory.TabIndex = 55;
            this.buttonRemoveDirectory.Text = "Remove Directory";
            this.buttonRemoveDirectory.UseVisualStyleBackColor = true;
            this.buttonRemoveDirectory.Click += new System.EventHandler(this.buttonRemoveDirectory_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonRefresh.Location = new System.Drawing.Point(149, 257);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(144, 48);
            this.buttonRefresh.TabIndex = 54;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonAddDirectory
            // 
            this.buttonAddDirectory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAddDirectory.Location = new System.Drawing.Point(7, 257);
            this.buttonAddDirectory.Name = "buttonAddDirectory";
            this.buttonAddDirectory.Size = new System.Drawing.Size(136, 48);
            this.buttonAddDirectory.TabIndex = 53;
            this.buttonAddDirectory.Text = "Add Directory";
            this.buttonAddDirectory.UseVisualStyleBackColor = true;
            this.buttonAddDirectory.Click += new System.EventHandler(this.buttonAddDirectory_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 52;
            this.label2.Text = "Pictures";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 51;
            this.label1.Text = "Directories";
            // 
            // listBoxImages
            // 
            this.listBoxImages.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listBoxImages.FormattingEnabled = true;
            this.listBoxImages.ItemHeight = 16;
            this.listBoxImages.Location = new System.Drawing.Point(12, 352);
            this.listBoxImages.Name = "listBoxImages";
            this.listBoxImages.Size = new System.Drawing.Size(423, 196);
            this.listBoxImages.TabIndex = 50;
            this.listBoxImages.SelectedIndexChanged += new System.EventHandler(this.listBoxImages_SelectedIndexChanged);
            // 
            // listBoxDirectories
            // 
            this.listBoxDirectories.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listBoxDirectories.FormattingEnabled = true;
            this.listBoxDirectories.ItemHeight = 16;
            this.listBoxDirectories.Location = new System.Drawing.Point(7, 24);
            this.listBoxDirectories.Name = "listBoxDirectories";
            this.listBoxDirectories.Size = new System.Drawing.Size(428, 196);
            this.listBoxDirectories.TabIndex = 49;
            // 
            // buttonPlay
            // 
            this.buttonPlay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonPlay.Location = new System.Drawing.Point(675, 699);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(117, 42);
            this.buttonPlay.TabIndex = 47;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonNext.Location = new System.Drawing.Point(241, 581);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(117, 36);
            this.buttonNext.TabIndex = 46;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonPrevious.Location = new System.Drawing.Point(76, 581);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(117, 36);
            this.buttonPrevious.TabIndex = 45;
            this.buttonPrevious.Text = "Previous";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // pictureBoxNext
            // 
            this.pictureBoxNext.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxNext.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pictureBoxNext.Location = new System.Drawing.Point(1076, 506);
            this.pictureBoxNext.Name = "pictureBoxNext";
            this.pictureBoxNext.Size = new System.Drawing.Size(200, 100);
            this.pictureBoxNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxNext.TabIndex = 44;
            this.pictureBoxNext.TabStop = false;
            // 
            // pictureBoxCurrent
            // 
            this.pictureBoxCurrent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxCurrent.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pictureBoxCurrent.Location = new System.Drawing.Point(476, 24);
            this.pictureBoxCurrent.Name = "pictureBoxCurrent";
            this.pictureBoxCurrent.Size = new System.Drawing.Size(800, 400);
            this.pictureBoxCurrent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCurrent.TabIndex = 43;
            this.pictureBoxCurrent.TabStop = false;
            // 
            // pictureBoxPrevious
            // 
            this.pictureBoxPrevious.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxPrevious.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pictureBoxPrevious.Location = new System.Drawing.Point(476, 506);
            this.pictureBoxPrevious.Name = "pictureBoxPrevious";
            this.pictureBoxPrevious.Size = new System.Drawing.Size(200, 100);
            this.pictureBoxPrevious.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPrevious.TabIndex = 42;
            this.pictureBoxPrevious.TabStop = false;
            // 
            // checkBoxLoop
            // 
            this.checkBoxLoop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxLoop.AutoSize = true;
            this.checkBoxLoop.Location = new System.Drawing.Point(957, 699);
            this.checkBoxLoop.Name = "checkBoxLoop";
            this.checkBoxLoop.Size = new System.Drawing.Size(60, 20);
            this.checkBoxLoop.TabIndex = 56;
            this.checkBoxLoop.Text = "Loop";
            this.checkBoxLoop.UseVisualStyleBackColor = true;
            this.checkBoxLoop.CheckedChanged += new System.EventHandler(this.checkBoxLoop_CheckedChanged);
            // 
            // textBoxInterval
            // 
            this.textBoxInterval.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxInterval.Location = new System.Drawing.Point(957, 719);
            this.textBoxInterval.Name = "textBoxInterval";
            this.textBoxInterval.Size = new System.Drawing.Size(117, 22);
            this.textBoxInterval.TabIndex = 57;
            this.textBoxInterval.TextChanged += new System.EventHandler(this.textBoxInterval_TextChanged);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1585, 776);
            this.Controls.Add(this.textBoxInterval);
            this.Controls.Add(this.checkBoxLoop);
            this.Controls.Add(this.buttonRemoveDirectory);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonAddDirectory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxImages);
            this.Controls.Add(this.listBoxDirectories);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrevious);
            this.Controls.Add(this.pictureBoxNext);
            this.Controls.Add(this.pictureBoxCurrent);
            this.Controls.Add(this.pictureBoxPrevious);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCurrent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPrevious)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRemoveDirectory;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonAddDirectory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxImages;
        private System.Windows.Forms.ListBox listBoxDirectories;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.PictureBox pictureBoxNext;
        private System.Windows.Forms.PictureBox pictureBoxCurrent;
        private System.Windows.Forms.PictureBox pictureBoxPrevious;
        private System.Windows.Forms.CheckBox checkBoxLoop;
        private System.Windows.Forms.TextBox textBoxInterval;
        private System.Windows.Forms.Timer timer;
    }
}

