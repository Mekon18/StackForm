namespace StackForm.Forms
{
    partial class FormTicTacToe
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
            this.labelPlayersName = new System.Windows.Forms.Label();
            this.buttonBackToHabfttt = new System.Windows.Forms.Button();
            this.buttonSelectOther = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.pGameField = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // labelPlayersName
            // 
            this.labelPlayersName.AutoSize = true;
            this.labelPlayersName.Location = new System.Drawing.Point(13, 13);
            this.labelPlayersName.Name = "labelPlayersName";
            this.labelPlayersName.Size = new System.Drawing.Size(35, 13);
            this.labelPlayersName.TabIndex = 0;
            this.labelPlayersName.Text = "label1";
            // 
            // buttonBackToHabfttt
            // 
            this.buttonBackToHabfttt.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonBackToHabfttt.Location = new System.Drawing.Point(266, 206);
            this.buttonBackToHabfttt.Name = "buttonBackToHabfttt";
            this.buttonBackToHabfttt.Size = new System.Drawing.Size(75, 23);
            this.buttonBackToHabfttt.TabIndex = 1;
            this.buttonBackToHabfttt.Text = "Назад";
            this.buttonBackToHabfttt.UseVisualStyleBackColor = false;
            this.buttonBackToHabfttt.Click += new System.EventHandler(this.buttonBackToHabfttt_Click);
            // 
            // buttonSelectOther
            // 
            this.buttonSelectOther.Location = new System.Drawing.Point(16, 29);
            this.buttonSelectOther.Name = "buttonSelectOther";
            this.buttonSelectOther.Size = new System.Drawing.Size(97, 23);
            this.buttonSelectOther.TabIndex = 2;
            this.buttonSelectOther.Text = "Выбрать других";
            this.buttonSelectOther.UseVisualStyleBackColor = true;
            this.buttonSelectOther.Click += new System.EventHandler(this.buttonSelectOther_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(12, 154);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(25, 25);
            this.button7.TabIndex = 3;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonTTT_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 125);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(25, 25);
            this.button4.TabIndex = 4;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonTTT_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 25);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonTTT_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(43, 96);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 25);
            this.button2.TabIndex = 8;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonTTT_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(43, 125);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(25, 25);
            this.button5.TabIndex = 7;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonTTT_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(43, 154);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(25, 25);
            this.button8.TabIndex = 6;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonTTT_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(74, 96);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(25, 25);
            this.button3.TabIndex = 11;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonTTT_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(74, 125);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(25, 25);
            this.button6.TabIndex = 10;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonTTT_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(74, 154);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(25, 25);
            this.button9.TabIndex = 9;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonTTT_Click);
            // 
            // pGameField
            // 
            this.pGameField.Location = new System.Drawing.Point(105, 96);
            this.pGameField.Name = "pGameField";
            this.pGameField.Size = new System.Drawing.Size(95, 83);
            this.pGameField.TabIndex = 12;
            // 
            // FormTicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 241);
            this.Controls.Add(this.pGameField);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.buttonSelectOther);
            this.Controls.Add(this.buttonBackToHabfttt);
            this.Controls.Add(this.labelPlayersName);
            this.Name = "FormTicTacToe";
            this.Text = "FormTicTacToe";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormTicTacToe_Closing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPlayersName;
        private System.Windows.Forms.Button buttonBackToHabfttt;
        private System.Windows.Forms.Button buttonSelectOther;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Panel pGameField;
    }
}