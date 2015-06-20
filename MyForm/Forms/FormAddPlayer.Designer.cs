namespace StackForm.Forms
{
    partial class FormAddPlayer
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonAddPlayer2 = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // buttonAddPlayer2
            // 
            this.buttonAddPlayer2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonAddPlayer2.Location = new System.Drawing.Point(13, 39);
            this.buttonAddPlayer2.Name = "buttonAddPlayer2";
            this.buttonAddPlayer2.Size = new System.Drawing.Size(99, 23);
            this.buttonAddPlayer2.TabIndex = 1;
            this.buttonAddPlayer2.Text = "Добавить";
            this.buttonAddPlayer2.UseVisualStyleBackColor = false;
            this.buttonAddPlayer2.Click += new System.EventHandler(this.buttonAddPlayer_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonCancel.Location = new System.Drawing.Point(118, 39);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(95, 23);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // FormAddPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 70);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAddPlayer2);
            this.Controls.Add(this.textBox1);
            this.Name = "FormAddPlayer";
            this.Text = "FormAddPlayer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAddPlayer_Closing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonAddPlayer2;
        private System.Windows.Forms.Button buttonCancel;
    }
}