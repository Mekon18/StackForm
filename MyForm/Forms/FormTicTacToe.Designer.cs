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
            this.pGameField = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            this.buttonBackToHabfttt.Location = new System.Drawing.Point(119, 29);
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
            // pGameField
            // 
            this.pGameField.Location = new System.Drawing.Point(12, 58);
            this.pGameField.Name = "pGameField";
            this.pGameField.Size = new System.Drawing.Size(227, 212);
            this.pGameField.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "ходит:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(167, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "0:0";
            // 
            // FormTicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 282);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pGameField);
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
        private System.Windows.Forms.Panel pGameField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}