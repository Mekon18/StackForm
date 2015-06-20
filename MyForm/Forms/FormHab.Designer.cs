namespace StackForm.Forms
{
    partial class FormHab
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
            this.buttonOpenStackForm = new System.Windows.Forms.Button();
            this.buttonOpenClicker = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonOpenStackForm
            // 
            this.buttonOpenStackForm.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonOpenStackForm.Location = new System.Drawing.Point(12, 12);
            this.buttonOpenStackForm.Name = "buttonOpenStackForm";
            this.buttonOpenStackForm.Size = new System.Drawing.Size(89, 23);
            this.buttonOpenStackForm.TabIndex = 0;
            this.buttonOpenStackForm.Text = "открыть Stack";
            this.buttonOpenStackForm.UseVisualStyleBackColor = false;
            this.buttonOpenStackForm.Click += new System.EventHandler(this.buttonOpenStackForm_Click);
            // 
            // buttonOpenClicker
            // 
            this.buttonOpenClicker.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonOpenClicker.Location = new System.Drawing.Point(123, 12);
            this.buttonOpenClicker.Name = "buttonOpenClicker";
            this.buttonOpenClicker.Size = new System.Drawing.Size(101, 23);
            this.buttonOpenClicker.TabIndex = 1;
            this.buttonOpenClicker.Text = "открыть кликер";
            this.buttonOpenClicker.UseVisualStyleBackColor = false;
            this.buttonOpenClicker.Click += new System.EventHandler(this.buttonOpenClicker_Click);
            // 
            // FormHab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 51);
            this.Controls.Add(this.buttonOpenClicker);
            this.Controls.Add(this.buttonOpenStackForm);
            this.Name = "FormHab";
            this.Text = "FormHab";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormHab_Closing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOpenStackForm;
        private System.Windows.Forms.Button buttonOpenClicker;
    }
}