namespace StackForm.Forms
{
    partial class FormClicker
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
            this.buttonBackToHab_clicker = new System.Windows.Forms.Button();
            this.panelForClicks = new System.Windows.Forms.Panel();
            this.labelScore = new System.Windows.Forms.Label();
            this.labelScoreNumber = new System.Windows.Forms.Label();
            this.listBoxPlayers = new System.Windows.Forms.ListBox();
            this.buttonAddPlayer = new System.Windows.Forms.Button();
            this.buttonDeletePlayer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.buttonBegin = new System.Windows.Forms.Button();
            this.listBoxHighScore = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonBackToHab_clicker
            // 
            this.buttonBackToHab_clicker.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonBackToHab_clicker.Location = new System.Drawing.Point(438, 309);
            this.buttonBackToHab_clicker.Name = "buttonBackToHab_clicker";
            this.buttonBackToHab_clicker.Size = new System.Drawing.Size(75, 23);
            this.buttonBackToHab_clicker.TabIndex = 0;
            this.buttonBackToHab_clicker.Text = "Назад";
            this.buttonBackToHab_clicker.UseVisualStyleBackColor = false;
            this.buttonBackToHab_clicker.Click += new System.EventHandler(this.buttonBackToHab);
            // 
            // panelForClicks
            // 
            this.panelForClicks.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panelForClicks.Location = new System.Drawing.Point(158, 98);
            this.panelForClicks.Name = "panelForClicks";
            this.panelForClicks.Size = new System.Drawing.Size(200, 100);
            this.panelForClicks.TabIndex = 1;
            this.panelForClicks.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelForClick_MouseDown);
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Location = new System.Drawing.Point(364, 98);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(35, 13);
            this.labelScore.TabIndex = 2;
            this.labelScore.Text = "Score";
            // 
            // labelScoreNumber
            // 
            this.labelScoreNumber.AutoSize = true;
            this.labelScoreNumber.Location = new System.Drawing.Point(364, 111);
            this.labelScoreNumber.Name = "labelScoreNumber";
            this.labelScoreNumber.Size = new System.Drawing.Size(13, 13);
            this.labelScoreNumber.TabIndex = 3;
            this.labelScoreNumber.Text = "0";
            // 
            // listBoxPlayers
            // 
            this.listBoxPlayers.FormattingEnabled = true;
            this.listBoxPlayers.Location = new System.Drawing.Point(12, 98);
            this.listBoxPlayers.Name = "listBoxPlayers";
            this.listBoxPlayers.Size = new System.Drawing.Size(81, 95);
            this.listBoxPlayers.TabIndex = 4;
            this.listBoxPlayers.SelectedIndexChanged += new System.EventHandler(this.lbp_IndexChenged);
            // 
            // buttonAddPlayer
            // 
            this.buttonAddPlayer.Location = new System.Drawing.Point(12, 54);
            this.buttonAddPlayer.Name = "buttonAddPlayer";
            this.buttonAddPlayer.Size = new System.Drawing.Size(81, 23);
            this.buttonAddPlayer.TabIndex = 5;
            this.buttonAddPlayer.Text = "Добавить";
            this.buttonAddPlayer.UseVisualStyleBackColor = true;
            this.buttonAddPlayer.Click += new System.EventHandler(this.buttonAddPlayer_Click);
            // 
            // buttonDeletePlayer
            // 
            this.buttonDeletePlayer.Location = new System.Drawing.Point(13, 200);
            this.buttonDeletePlayer.Name = "buttonDeletePlayer";
            this.buttonDeletePlayer.Size = new System.Drawing.Size(80, 23);
            this.buttonDeletePlayer.TabIndex = 6;
            this.buttonDeletePlayer.Text = "Удалить";
            this.buttonDeletePlayer.UseVisualStyleBackColor = true;
            this.buttonDeletePlayer.Click += new System.EventHandler(this.buttonDeletePlayer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Игроки:";
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Location = new System.Drawing.Point(364, 80);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(34, 13);
            this.lblTimer.TabIndex = 8;
            this.lblTimer.Text = "00:20";
            // 
            // buttonBegin
            // 
            this.buttonBegin.BackColor = System.Drawing.Color.Teal;
            this.buttonBegin.Location = new System.Drawing.Point(158, 69);
            this.buttonBegin.Name = "buttonBegin";
            this.buttonBegin.Size = new System.Drawing.Size(75, 23);
            this.buttonBegin.TabIndex = 9;
            this.buttonBegin.Text = "Начать";
            this.buttonBegin.UseVisualStyleBackColor = false;
            this.buttonBegin.Click += new System.EventHandler(this.buttonBegin_Click);
            // 
            // listBoxHighScore
            // 
            this.listBoxHighScore.FormattingEnabled = true;
            this.listBoxHighScore.Location = new System.Drawing.Point(405, 98);
            this.listBoxHighScore.Name = "listBoxHighScore";
            this.listBoxHighScore.Size = new System.Drawing.Size(108, 134);
            this.listBoxHighScore.TabIndex = 10;
            // 
            // FormClicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 344);
            this.Controls.Add(this.listBoxHighScore);
            this.Controls.Add(this.buttonBegin);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDeletePlayer);
            this.Controls.Add(this.buttonAddPlayer);
            this.Controls.Add(this.listBoxPlayers);
            this.Controls.Add(this.labelScoreNumber);
            this.Controls.Add(this.panelForClicks);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.buttonBackToHab_clicker);
            this.Name = "FormClicker";
            this.Text = "FormClicker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormClicker_Closing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBackToHab_clicker;
        private System.Windows.Forms.Panel panelForClicks;
        private System.Windows.Forms.Label labelScoreNumber;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.ListBox listBoxPlayers;
        private System.Windows.Forms.Button buttonAddPlayer;
        private System.Windows.Forms.Button buttonDeletePlayer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Button buttonBegin;
        private System.Windows.Forms.ListBox listBoxHighScore;
    }
}