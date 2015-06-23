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
            this.buttonBackToHabfttt.Location = new System.Drawing.Point(243, 181);
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
            // FormTicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 216);
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
    }
}