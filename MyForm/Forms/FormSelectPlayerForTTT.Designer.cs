namespace StackForm.Forms
{
    partial class FormSelectPlayerForTTT
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
            this.buttonBackToHabTicTacToe = new System.Windows.Forms.Button();
            this.listBoxPlayersTicTacToe = new System.Windows.Forms.ListBox();
            this.buttonAddPlayerTicTacToe = new System.Windows.Forms.Button();
            this.buttonRemovePlayerttt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSelectPlayerttt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonBeginTTT = new System.Windows.Forms.Button();
            this.listBoxSelectedPlayers = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBackToHabTicTacToe
            // 
            this.buttonBackToHabTicTacToe.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonBackToHabTicTacToe.Location = new System.Drawing.Point(95, 156);
            this.buttonBackToHabTicTacToe.Name = "buttonBackToHabTicTacToe";
            this.buttonBackToHabTicTacToe.Size = new System.Drawing.Size(91, 23);
            this.buttonBackToHabTicTacToe.TabIndex = 1;
            this.buttonBackToHabTicTacToe.Text = "Назад";
            this.buttonBackToHabTicTacToe.UseVisualStyleBackColor = false;
            this.buttonBackToHabTicTacToe.Click += new System.EventHandler(this.buttonBackToHabTicTacToe_Click);
            // 
            // listBoxPlayersTicTacToe
            // 
            this.listBoxPlayersTicTacToe.FormattingEnabled = true;
            this.listBoxPlayersTicTacToe.Location = new System.Drawing.Point(12, 55);
            this.listBoxPlayersTicTacToe.Name = "listBoxPlayersTicTacToe";
            this.listBoxPlayersTicTacToe.Size = new System.Drawing.Size(77, 95);
            this.listBoxPlayersTicTacToe.TabIndex = 0;
            this.listBoxPlayersTicTacToe.DoubleClick += new System.EventHandler(this.buttonSelectPlayerttt_Click);
            // 
            // buttonAddPlayerTicTacToe
            // 
            this.buttonAddPlayerTicTacToe.Location = new System.Drawing.Point(13, 13);
            this.buttonAddPlayerTicTacToe.Name = "buttonAddPlayerTicTacToe";
            this.buttonAddPlayerTicTacToe.Size = new System.Drawing.Size(76, 23);
            this.buttonAddPlayerTicTacToe.TabIndex = 2;
            this.buttonAddPlayerTicTacToe.Text = "Добавить";
            this.buttonAddPlayerTicTacToe.UseVisualStyleBackColor = true;
            this.buttonAddPlayerTicTacToe.Click += new System.EventHandler(this.buttonAddPlayerttt_Click);
            // 
            // buttonRemovePlayerttt
            // 
            this.buttonRemovePlayerttt.Location = new System.Drawing.Point(13, 156);
            this.buttonRemovePlayerttt.Name = "buttonRemovePlayerttt";
            this.buttonRemovePlayerttt.Size = new System.Drawing.Size(76, 23);
            this.buttonRemovePlayerttt.TabIndex = 3;
            this.buttonRemovePlayerttt.Text = "Удалить";
            this.buttonRemovePlayerttt.UseVisualStyleBackColor = true;
            this.buttonRemovePlayerttt.Click += new System.EventHandler(this.buttonRemovePlayerttt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Игроки:";
            // 
            // buttonSelectPlayerttt
            // 
            this.buttonSelectPlayerttt.Location = new System.Drawing.Point(96, 13);
            this.buttonSelectPlayerttt.Name = "buttonSelectPlayerttt";
            this.buttonSelectPlayerttt.Size = new System.Drawing.Size(90, 23);
            this.buttonSelectPlayerttt.TabIndex = 5;
            this.buttonSelectPlayerttt.Text = "Выбрать";
            this.buttonSelectPlayerttt.UseVisualStyleBackColor = true;
            this.buttonSelectPlayerttt.Click += new System.EventHandler(this.buttonSelectPlayerttt_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Добавленные игроки:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(95, 100);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(39, 20);
            this.numericUpDown1.TabIndex = 8;
            this.numericUpDown1.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "размер поля:";
            // 
            // buttonBeginTTT
            // 
            this.buttonBeginTTT.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonBeginTTT.Location = new System.Drawing.Point(95, 127);
            this.buttonBeginTTT.Name = "buttonBeginTTT";
            this.buttonBeginTTT.Size = new System.Drawing.Size(75, 23);
            this.buttonBeginTTT.TabIndex = 10;
            this.buttonBeginTTT.Text = "Играть";
            this.buttonBeginTTT.UseVisualStyleBackColor = false;
            this.buttonBeginTTT.Click += new System.EventHandler(this.buttonBeginTTT_Click);
            // 
            // listBoxSelectedPlayers
            // 
            this.listBoxSelectedPlayers.FormattingEnabled = true;
            this.listBoxSelectedPlayers.Location = new System.Drawing.Point(96, 56);
            this.listBoxSelectedPlayers.Name = "listBoxSelectedPlayers";
            this.listBoxSelectedPlayers.Size = new System.Drawing.Size(108, 30);
            this.listBoxSelectedPlayers.TabIndex = 11;
            // 
            // FormSelectPlayerForTTT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(216, 186);
            this.Controls.Add(this.listBoxSelectedPlayers);
            this.Controls.Add(this.buttonBeginTTT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonSelectPlayerttt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRemovePlayerttt);
            this.Controls.Add(this.buttonAddPlayerTicTacToe);
            this.Controls.Add(this.buttonBackToHabTicTacToe);
            this.Controls.Add(this.listBoxPlayersTicTacToe);
            this.Name = "FormSelectPlayerForTTT";
            this.Text = "FormTicTacToe";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormTicTacToe_Closing);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBackToHabTicTacToe;
        private System.Windows.Forms.ListBox listBoxPlayersTicTacToe;
        private System.Windows.Forms.Button buttonAddPlayerTicTacToe;
        private System.Windows.Forms.Button buttonRemovePlayerttt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSelectPlayerttt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonBeginTTT;
        private System.Windows.Forms.ListBox listBoxSelectedPlayers;
    }
}