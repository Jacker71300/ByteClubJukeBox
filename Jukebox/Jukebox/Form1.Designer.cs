﻿using System;

namespace Jukebox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PlayBtn = new System.Windows.Forms.Button();
            this.SongSelector = new System.Windows.Forms.ComboBox();
            this.RepeatBox = new System.Windows.Forms.CheckBox();
            this.StopBtn = new System.Windows.Forms.Button();
            this.NowPlaying = new System.Windows.Forms.Label();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.ShuffleBox = new System.Windows.Forms.CheckBox();
            this.nextBtn = new System.Windows.Forms.Button();
            this.volumeBar = new System.Windows.Forms.TrackBar();
            this.lblVolume = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lblVolumePercent = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // PlayBtn
            // 
            this.PlayBtn.Location = new System.Drawing.Point(12, 39);
            this.PlayBtn.Name = "PlayBtn";
            this.PlayBtn.Size = new System.Drawing.Size(73, 73);
            this.PlayBtn.TabIndex = 0;
            this.PlayBtn.Text = "Play";
            this.PlayBtn.UseVisualStyleBackColor = true;
            this.PlayBtn.Click += new System.EventHandler(this.PlayBtn_Click);
            // 
            // SongSelector
            // 
            this.SongSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SongSelector.FormattingEnabled = true;
            this.SongSelector.Location = new System.Drawing.Point(12, 12);
            this.SongSelector.Name = "SongSelector";
            this.SongSelector.Size = new System.Drawing.Size(390, 21);
            this.SongSelector.TabIndex = 1;
            // 
            // RepeatBox
            // 
            this.RepeatBox.AutoSize = true;
            this.RepeatBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Inch, ((byte)(0)));
            this.RepeatBox.Location = new System.Drawing.Point(12, 150);
            this.RepeatBox.Name = "RepeatBox";
            this.RepeatBox.Size = new System.Drawing.Size(110, 33);
            this.RepeatBox.TabIndex = 2;
            this.RepeatBox.Text = "Repeat";
            this.RepeatBox.UseVisualStyleBackColor = true;
            // 
            // StopBtn
            // 
            this.StopBtn.Location = new System.Drawing.Point(170, 39);
            this.StopBtn.Name = "StopBtn";
            this.StopBtn.Size = new System.Drawing.Size(73, 73);
            this.StopBtn.TabIndex = 3;
            this.StopBtn.Text = "Stop";
            this.StopBtn.UseVisualStyleBackColor = true;
            this.StopBtn.Click += new System.EventHandler(this.StopBtn_Click);
            // 
            // NowPlaying
            // 
            this.NowPlaying.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NowPlaying.AutoSize = true;
            this.NowPlaying.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Inch, ((byte)(0)));
            this.NowPlaying.Location = new System.Drawing.Point(12, 194);
            this.NowPlaying.Name = "NowPlaying";
            this.NowPlaying.Size = new System.Drawing.Size(160, 29);
            this.NowPlaying.TabIndex = 4;
            this.NowPlaying.Text = "Now Playing :";
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 0);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(245, 240);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ShuffleBox
            // 
            this.ShuffleBox.AutoSize = true;
            this.ShuffleBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Inch, ((byte)(0)));
            this.ShuffleBox.Location = new System.Drawing.Point(137, 150);
            this.ShuffleBox.Name = "ShuffleBox";
            this.ShuffleBox.Size = new System.Drawing.Size(106, 33);
            this.ShuffleBox.TabIndex = 7;
            this.ShuffleBox.Text = "Shuffle";
            this.ShuffleBox.UseVisualStyleBackColor = true;
            this.ShuffleBox.CheckedChanged += new System.EventHandler(this.ShuffleBox_CheckedChanged);
            // 
            // nextBtn
            // 
            this.nextBtn.Location = new System.Drawing.Point(91, 39);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(73, 73);
            this.nextBtn.TabIndex = 8;
            this.nextBtn.Text = "Next";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // volumeBar
            // 
            this.volumeBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.volumeBar.Location = new System.Drawing.Point(249, 67);
            this.volumeBar.Maximum = 100;
            this.volumeBar.Name = "volumeBar";
            this.volumeBar.Size = new System.Drawing.Size(163, 45);
            this.volumeBar.TabIndex = 9;
            this.volumeBar.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // lblVolume
            // 
            this.lblVolume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVolume.AutoSize = true;
            this.lblVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolume.Location = new System.Drawing.Point(249, 39);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(84, 25);
            this.lblVolume.TabIndex = 10;
            this.lblVolume.Text = "Volume";
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.progressBar.Location = new System.Drawing.Point(12, 226);
            this.progressBar.Maximum = 0;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(390, 23);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 11;
            this.progressBar.Click += new System.EventHandler(this.progressBar_Click);
            // 
            // lblPosition
            // 
            this.lblPosition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.Location = new System.Drawing.Point(12, 252);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(40, 20);
            this.lblPosition.TabIndex = 14;
            this.lblPosition.Text = "0:00";
            // 
            // lblMax
            // 
            this.lblMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMax.AutoSize = true;
            this.lblMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMax.Location = new System.Drawing.Point(351, 252);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(51, 20);
            this.lblMax.TabIndex = 15;
            this.lblMax.Text = "label2";
            // 
            // lblVolumePercent
            // 
            this.lblVolumePercent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVolumePercent.AutoSize = true;
            this.lblVolumePercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolumePercent.Location = new System.Drawing.Point(339, 40);
            this.lblVolumePercent.Name = "lblVolumePercent";
            this.lblVolumePercent.Size = new System.Drawing.Size(60, 24);
            this.lblVolumePercent.TabIndex = 16;
            this.lblVolumePercent.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 281);
            this.Controls.Add(this.lblVolumePercent);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.lblVolume);
            this.Controls.Add(this.volumeBar);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.ShuffleBox);
            this.Controls.Add(this.NowPlaying);
            this.Controls.Add(this.StopBtn);
            this.Controls.Add(this.RepeatBox);
            this.Controls.Add(this.SongSelector);
            this.Controls.Add(this.PlayBtn);
            this.MinimumSize = new System.Drawing.Size(430, 320);
            this.Name = "Form1";
            this.Text = "Byte Club Juke Box";
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PlayBtn;
        private System.Windows.Forms.ComboBox SongSelector;
        private System.Windows.Forms.CheckBox RepeatBox;
        private System.Windows.Forms.Button StopBtn;
        private System.Windows.Forms.Label NowPlaying;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.CheckBox ShuffleBox;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.TrackBar volumeBar;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label lblVolumePercent;
    }
}

