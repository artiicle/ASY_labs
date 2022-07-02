namespace PassManager
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.gv_data = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_url = new System.Windows.Forms.TextBox();
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tb_login = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gv_record = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.delete_button = new System.Windows.Forms.Button();
            this.backup_button = new System.Windows.Forms.Button();
            this.print_button = new System.Windows.Forms.Button();
            this.restoreBackup_button = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.docToPrint = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.gv_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_record)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gv_data
            // 
            this.gv_data.AllowUserToAddRows = false;
            this.gv_data.AllowUserToDeleteRows = false;
            this.gv_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_data.Location = new System.Drawing.Point(515, 12);
            this.gv_data.Name = "gv_data";
            this.gv_data.ReadOnly = true;
            this.gv_data.Size = new System.Drawing.Size(466, 381);
            this.gv_data.TabIndex = 0;
            this.gv_data.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.gvData_hideChars);
            this.gv_data.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.gvData_RowStateChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "URL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // tb_url
            // 
            this.tb_url.Location = new System.Drawing.Point(90, 27);
            this.tb_url.Name = "tb_url";
            this.tb_url.Size = new System.Drawing.Size(100, 20);
            this.tb_url.TabIndex = 3;
            // 
            // tb_pass
            // 
            this.tb_pass.Location = new System.Drawing.Point(90, 52);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.Size = new System.Drawing.Size(100, 20);
            this.tb_pass.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 104);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(184, 37);
            this.button2.TabIndex = 5;
            this.button2.Text = "ADD";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnNewRecord);
            // 
            // tb_login
            // 
            this.tb_login.Location = new System.Drawing.Point(90, 78);
            this.tb_login.Name = "tb_login";
            this.tb_login.Size = new System.Drawing.Size(100, 20);
            this.tb_login.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Login";
            // 
            // gv_record
            // 
            this.gv_record.AllowUserToAddRows = false;
            this.gv_record.AllowUserToDeleteRows = false;
            this.gv_record.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_record.Location = new System.Drawing.Point(515, 449);
            this.gv_record.Name = "gv_record";
            this.gv_record.ReadOnly = true;
            this.gv_record.Size = new System.Drawing.Size(466, 117);
            this.gv_record.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_url);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tb_pass);
            this.groupBox1.Controls.Add(this.tb_login);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(12, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(202, 147);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавить уч. запись";
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(18, 212);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(184, 37);
            this.delete_button.TabIndex = 11;
            this.delete_button.Text = "DELETE";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // backup_button
            // 
            this.backup_button.Location = new System.Drawing.Point(18, 529);
            this.backup_button.Name = "backup_button";
            this.backup_button.Size = new System.Drawing.Size(184, 37);
            this.backup_button.TabIndex = 12;
            this.backup_button.Text = "BACKUP";
            this.backup_button.UseVisualStyleBackColor = true;
            this.backup_button.Click += new System.EventHandler(this.backup_button_Click);
            // 
            // print_button
            // 
            this.print_button.Location = new System.Drawing.Point(18, 255);
            this.print_button.Name = "print_button";
            this.print_button.Size = new System.Drawing.Size(184, 37);
            this.print_button.TabIndex = 13;
            this.print_button.Text = "PRINT";
            this.print_button.UseVisualStyleBackColor = true;
            this.print_button.Click += new System.EventHandler(this.print_button_Click);
            // 
            // restoreBackup_button
            // 
            this.restoreBackup_button.Location = new System.Drawing.Point(285, 529);
            this.restoreBackup_button.Name = "restoreBackup_button";
            this.restoreBackup_button.Size = new System.Drawing.Size(184, 37);
            this.restoreBackup_button.TabIndex = 14;
            this.restoreBackup_button.Text = "RESTORE BACKUP";
            this.restoreBackup_button.UseVisualStyleBackColor = true;
            this.restoreBackup_button.Click += new System.EventHandler(this.restoreBackup_button_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.docToPrint;
            this.printDialog1.PrintToFile = true;
            this.printDialog1.UseEXDialog = true;
            // 
            // docToPrint
            // 
            this.docToPrint.DocumentName = "docToPrint";
            this.docToPrint.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 578);
            this.Controls.Add(this.restoreBackup_button);
            this.Controls.Add(this.print_button);
            this.Controls.Add(this.backup_button);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gv_record);
            this.Controls.Add(this.gv_data);
            this.Name = "Form1";
            this.Text = "LightPass";
            ((System.ComponentModel.ISupportInitialize)(this.gv_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_record)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gv_data;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_url;
        private System.Windows.Forms.TextBox tb_pass;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tb_login;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView gv_record;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button backup_button;
        private System.Windows.Forms.Button print_button;
        private System.Windows.Forms.Button restoreBackup_button;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument docToPrint;
    }
}

