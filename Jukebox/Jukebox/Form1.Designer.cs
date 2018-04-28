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
            this.PlayBtn = new System.Windows.Forms.Button();
            this.SongSelector = new System.Windows.Forms.ComboBox();
            this.RepeatBox = new System.Windows.Forms.CheckBox();
            this.StopBtn = new System.Windows.Forms.Button();
            this.NowPlaying = new System.Windows.Forms.Label();
            this.CurrentSongNameLbl = new System.Windows.Forms.Label();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.ShuffleBox = new System.Windows.Forms.CheckBox();
            this.nextBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // PlayBtn
            // 
            this.PlayBtn.Location = new System.Drawing.Point(239, 74);
            this.PlayBtn.Name = "PlayBtn";
            this.PlayBtn.Size = new System.Drawing.Size(75, 23);
            this.PlayBtn.TabIndex = 0;
            this.PlayBtn.Text = "Play";
            this.PlayBtn.UseVisualStyleBackColor = true;
            this.PlayBtn.Click += new System.EventHandler(this.PlayBtn_Click);
            // 
            // SongSelector
            // 
            this.SongSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SongSelector.FormattingEnabled = true;
            this.SongSelector.Location = new System.Drawing.Point(498, 12);
            this.SongSelector.Name = "SongSelector";
            this.SongSelector.Size = new System.Drawing.Size(403, 21);
            this.SongSelector.TabIndex = 1;
            // 
            // RepeatBox
            // 
            this.RepeatBox.AutoSize = true;
            this.RepeatBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Inch, ((byte)(0)));
            this.RepeatBox.Location = new System.Drawing.Point(45, 165);
            this.RepeatBox.Name = "RepeatBox";
            this.RepeatBox.Size = new System.Drawing.Size(110, 33);
            this.RepeatBox.TabIndex = 2;
            this.RepeatBox.Text = "Repeat";
            this.RepeatBox.UseVisualStyleBackColor = true;
            // 
            // StopBtn
            // 
            this.StopBtn.Location = new System.Drawing.Point(372, 74);
            this.StopBtn.Name = "StopBtn";
            this.StopBtn.Size = new System.Drawing.Size(75, 23);
            this.StopBtn.TabIndex = 3;
            this.StopBtn.Text = "Stop";
            this.StopBtn.UseVisualStyleBackColor = true;
            this.StopBtn.Click += new System.EventHandler(this.StopBtn_Click);
            // 
            // NowPlaying
            // 
            this.NowPlaying.AutoSize = true;
            this.NowPlaying.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Inch, ((byte)(0)));
            this.NowPlaying.Location = new System.Drawing.Point(40, 121);
            this.NowPlaying.Name = "NowPlaying";
            this.NowPlaying.Size = new System.Drawing.Size(160, 29);
            this.NowPlaying.TabIndex = 4;
            this.NowPlaying.Text = "Now Playing :";
            // 
            // CurrentSongNameLbl
            // 
            this.CurrentSongNameLbl.AutoSize = true;
            this.CurrentSongNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Inch, ((byte)(0)));
            this.CurrentSongNameLbl.Location = new System.Drawing.Point(223, 121);
            this.CurrentSongNameLbl.Name = "CurrentSongNameLbl";
            this.CurrentSongNameLbl.Size = new System.Drawing.Size(0, 29);
            this.CurrentSongNameLbl.TabIndex = 5;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 0);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(75, 23);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ShuffleBox
            // 
            this.ShuffleBox.AutoSize = true;
            this.ShuffleBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Inch, ((byte)(0)));
            this.ShuffleBox.Location = new System.Drawing.Point(183, 165);
            this.ShuffleBox.Name = "ShuffleBox";
            this.ShuffleBox.Size = new System.Drawing.Size(106, 33);
            this.ShuffleBox.TabIndex = 7;
            this.ShuffleBox.Text = "Shuffle";
            this.ShuffleBox.UseVisualStyleBackColor = true;
            this.ShuffleBox.CheckedChanged += new System.EventHandler(this.ShuffleBox_CheckedChanged);
            // 
            // nextBtn
            // 
            this.nextBtn.Location = new System.Drawing.Point(498, 74);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(75, 23);
            this.nextBtn.TabIndex = 8;
            this.nextBtn.Text = "button1";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 449);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.ShuffleBox);
            this.Controls.Add(this.CurrentSongNameLbl);
            this.Controls.Add(this.NowPlaying);
            this.Controls.Add(this.StopBtn);
            this.Controls.Add(this.RepeatBox);
            this.Controls.Add(this.SongSelector);
            this.Controls.Add(this.PlayBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PlayBtn;
        private System.Windows.Forms.ComboBox SongSelector;
        private System.Windows.Forms.CheckBox RepeatBox;
        private System.Windows.Forms.Button StopBtn;
        private System.Windows.Forms.Label NowPlaying;
        private System.Windows.Forms.Label CurrentSongNameLbl;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.CheckBox ShuffleBox;
        private System.Windows.Forms.Button nextBtn;
    }
}

