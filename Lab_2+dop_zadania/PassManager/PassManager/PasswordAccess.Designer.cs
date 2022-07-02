namespace PassManager
{
    partial class PasswordAccess
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
            this.Pass_textBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel_notif = new System.Windows.Forms.Label();
            this.Except_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Pass_textBox
            // 
            this.Pass_textBox.Location = new System.Drawing.Point(35, 292);
            this.Pass_textBox.Name = "Pass_textBox";
            this.Pass_textBox.Size = new System.Drawing.Size(292, 20);
            this.Pass_textBox.TabIndex = 0;
            // 
            // PasswordLabel_notif
            // 
            this.PasswordLabel_notif.AutoSize = true;
            this.PasswordLabel_notif.Location = new System.Drawing.Point(35, 273);
            this.PasswordLabel_notif.Name = "PasswordLabel_notif";
            this.PasswordLabel_notif.Size = new System.Drawing.Size(88, 13);
            this.PasswordLabel_notif.TabIndex = 1;
            this.PasswordLabel_notif.Text = "Введите пароль";
            // 
            // Except_button
            // 
            this.Except_button.Location = new System.Drawing.Point(35, 330);
            this.Except_button.Name = "Except_button";
            this.Except_button.Size = new System.Drawing.Size(292, 60);
            this.Except_button.TabIndex = 2;
            this.Except_button.Text = "Принять";
            this.Except_button.UseVisualStyleBackColor = true;
            this.Except_button.Click += new System.EventHandler(this.Except_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Менеджер паролей";
            // 
            // PasswordAccess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 439);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Except_button);
            this.Controls.Add(this.PasswordLabel_notif);
            this.Controls.Add(this.Pass_textBox);
            this.Name = "PasswordAccess";
            this.Text = "PasswordAccess";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PasswordAccess_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Pass_textBox;
        private System.Windows.Forms.Label PasswordLabel_notif;
        private System.Windows.Forms.Button Except_button;
        private System.Windows.Forms.Label label1;
    }
}