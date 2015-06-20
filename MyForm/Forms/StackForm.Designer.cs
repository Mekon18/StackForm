namespace StackForm
{
    partial class StackForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonBackToHab_stack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 32);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(134, 95);
            this.textBox1.TabIndex = 2;
            this.textBox1.DoubleClick += new System.EventHandler(this.TextBox_DoubleClick);
            // 
            // buttonRemove
            // 
            this.buttonRemove.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonRemove.Location = new System.Drawing.Point(143, 3);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(134, 23);
            this.buttonRemove.TabIndex = 5;
            this.buttonRemove.Text = "Удалить";
            this.buttonRemove.UseVisualStyleBackColor = false;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonBackToHab_stack
            // 
            this.buttonBackToHab_stack.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonBackToHab_stack.Location = new System.Drawing.Point(143, 104);
            this.buttonBackToHab_stack.Name = "buttonBackToHab_stack";
            this.buttonBackToHab_stack.Size = new System.Drawing.Size(134, 23);
            this.buttonBackToHab_stack.TabIndex = 6;
            this.buttonBackToHab_stack.Text = "Назад";
            this.buttonBackToHab_stack.UseVisualStyleBackColor = false;
            this.buttonBackToHab_stack.Click += new System.EventHandler(this.buttonBackToHab_Click);
            // 
            // StackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 130);
            this.Controls.Add(this.buttonBackToHab_stack);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "StackForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StackForm_Closing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonBackToHab_stack;
    }
}

