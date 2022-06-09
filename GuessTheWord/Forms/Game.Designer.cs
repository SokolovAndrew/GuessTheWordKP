using System;

namespace GuessTheWord.Forms
{
    partial class Game
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
            this.LabelCurrent = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LabelErrors = new System.Windows.Forms.Label();
            this.LabelTimeSpent = new System.Windows.Forms.Label();
            this.LabelTried = new System.Windows.Forms.Label();
            this.TimerTimeSpent = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.ButtonTry = new System.Windows.Forms.Button();
            this.InputTry = new System.Windows.Forms.TextBox();
            this.LabelWon = new System.Windows.Forms.Label();
            this.LabelInputFeedback = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelCurrent
            // 
            this.LabelCurrent.BackColor = System.Drawing.Color.Transparent;
            this.LabelCurrent.Dock = System.Windows.Forms.DockStyle.Top;
            this.LabelCurrent.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold);
            this.LabelCurrent.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.LabelCurrent.Image = global::GuessTheWord.Properties.Resources.back1;
            this.LabelCurrent.Location = new System.Drawing.Point(0, 25);
            this.LabelCurrent.Name = "LabelCurrent";
            this.LabelCurrent.Size = new System.Drawing.Size(800, 150);
            this.LabelCurrent.TabIndex = 1;
            this.LabelCurrent.Text = "M___U";
            this.LabelCurrent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LabelErrors);
            this.panel1.Controls.Add(this.LabelTimeSpent);
            this.panel1.Controls.Add(this.LabelTried);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 175);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 30);
            this.panel1.TabIndex = 2;
            // 
            // LabelErrors
            // 
            this.LabelErrors.BackColor = System.Drawing.Color.Transparent;
            this.LabelErrors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelErrors.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelErrors.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(193)))), ((int)(((byte)(173)))));
            this.LabelErrors.Image = global::GuessTheWord.Properties.Resources.back4;
            this.LabelErrors.Location = new System.Drawing.Point(135, 0);
            this.LabelErrors.Name = "LabelErrors";
            this.LabelErrors.Size = new System.Drawing.Size(527, 30);
            this.LabelErrors.TabIndex = 4;
            this.LabelErrors.Text = "Ошибок: 0 / 3";
            this.LabelErrors.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelTimeSpent
            // 
            this.LabelTimeSpent.BackColor = System.Drawing.Color.Transparent;
            this.LabelTimeSpent.Dock = System.Windows.Forms.DockStyle.Right;
            this.LabelTimeSpent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelTimeSpent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(193)))), ((int)(((byte)(173)))));
            this.LabelTimeSpent.Image = global::GuessTheWord.Properties.Resources.back3;
            this.LabelTimeSpent.Location = new System.Drawing.Point(662, 0);
            this.LabelTimeSpent.Name = "LabelTimeSpent";
            this.LabelTimeSpent.Size = new System.Drawing.Size(138, 30);
            this.LabelTimeSpent.TabIndex = 3;
            this.LabelTimeSpent.Text = "Время: 00:00";
            this.LabelTimeSpent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelTried
            // 
            this.LabelTried.BackColor = System.Drawing.Color.Transparent;
            this.LabelTried.Dock = System.Windows.Forms.DockStyle.Left;
            this.LabelTried.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelTried.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(193)))), ((int)(((byte)(173)))));
            this.LabelTried.Image = global::GuessTheWord.Properties.Resources.back2;
            this.LabelTried.Location = new System.Drawing.Point(0, 0);
            this.LabelTried.Name = "LabelTried";
            this.LabelTried.Size = new System.Drawing.Size(135, 30);
            this.LabelTried.TabIndex = 0;
            this.LabelTried.Text = "Попыток: 15";
            this.LabelTried.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimerTimeSpent
            // 
            this.TimerTimeSpent.Enabled = true;
            this.TimerTimeSpent.Interval = 1000;
            this.TimerTimeSpent.Tick += new System.EventHandler(this.TimerTimeSpent_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::GuessTheWord.Properties.Resources.back7;
            this.panel2.Controls.Add(this.ButtonTry);
            this.panel2.Controls.Add(this.InputTry);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 426);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 33);
            this.panel2.TabIndex = 3;
            // 
            // ButtonTry
            // 
            this.ButtonTry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(193)))), ((int)(((byte)(173)))));
            this.ButtonTry.Dock = System.Windows.Forms.DockStyle.Right;
            this.ButtonTry.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.ButtonTry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonTry.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonTry.ForeColor = System.Drawing.Color.SlateGray;
            this.ButtonTry.Location = new System.Drawing.Point(689, 0);
            this.ButtonTry.Name = "ButtonTry";
            this.ButtonTry.Size = new System.Drawing.Size(111, 33);
            this.ButtonTry.TabIndex = 1;
            this.ButtonTry.Text = "Спробувати";
            this.ButtonTry.UseVisualStyleBackColor = false;
            this.ButtonTry.Click += new System.EventHandler(this.ButtonTry_Click);
            // 
            // InputTry
            // 
            this.InputTry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(64)))), ((int)(((byte)(85)))));
            this.InputTry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputTry.Dock = System.Windows.Forms.DockStyle.Left;
            this.InputTry.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputTry.ForeColor = System.Drawing.Color.White;
            this.InputTry.Location = new System.Drawing.Point(0, 0);
            this.InputTry.MaxLength = 1;
            this.InputTry.Multiline = true;
            this.InputTry.Name = "InputTry";
            this.InputTry.Size = new System.Drawing.Size(683, 33);
            this.InputTry.TabIndex = 0;
            this.InputTry.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputTry_KeyPress);
            // 
            // LabelWon
            // 
            this.LabelWon.BackColor = System.Drawing.Color.Transparent;
            this.LabelWon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelWon.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelWon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(200)))), ((int)(((byte)(109)))));
            this.LabelWon.Image = global::GuessTheWord.Properties.Resources.back6;
            this.LabelWon.Location = new System.Drawing.Point(0, 205);
            this.LabelWon.Name = "LabelWon";
            this.LabelWon.Size = new System.Drawing.Size(800, 221);
            this.LabelWon.TabIndex = 4;
            this.LabelWon.Text = "Вы угадали слово, так держать!\r\n";
            this.LabelWon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelInputFeedback
            // 
            this.LabelInputFeedback.AutoSize = true;
            this.LabelInputFeedback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.LabelInputFeedback.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LabelInputFeedback.ForeColor = System.Drawing.Color.DarkRed;
            this.LabelInputFeedback.Location = new System.Drawing.Point(0, 403);
            this.LabelInputFeedback.Name = "LabelInputFeedback";
            this.LabelInputFeedback.Padding = new System.Windows.Forms.Padding(5);
            this.LabelInputFeedback.Size = new System.Drawing.Size(10, 23);
            this.LabelInputFeedback.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::GuessTheWord.Properties.Resources.reload;
            this.button1.Location = new System.Drawing.Point(730, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 54);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 459);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LabelInputFeedback);
            this.Controls.Add(this.LabelWon);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LabelCurrent);
            this.Name = "Game";
            this.Controls.SetChildIndex(this.LabelCurrent, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.LabelWon, 0);
            this.Controls.SetChildIndex(this.LabelInputFeedback, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelCurrent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LabelErrors;
        private System.Windows.Forms.Label LabelTimeSpent;
        private System.Windows.Forms.Label LabelTried;
        private System.Windows.Forms.Timer TimerTimeSpent;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ButtonTry;
        private System.Windows.Forms.TextBox InputTry;
        private System.Windows.Forms.Label LabelWon;
        private System.Windows.Forms.Label LabelInputFeedback;
        private System.Windows.Forms.Button button1;
    }
}
