using System;
using System.Drawing;
using System.Windows.Forms;

namespace PassManager
{
    public partial class PasswordAccess : Form
    {
        public PasswordAccess()
        {
            InitializeComponent();
        }

        public string Password { private get; set; }
        public bool IsPasswordTrue { get; set; } = false;
        private Form1 f1;

        public PasswordAccess(Form1 f1)
        {
            this.f1 = f1;
            InitializeComponent();
            //f1 = Application.OpenForms.OfType<Form1>().FirstOrDefault();
        }

        private void Except_button_Click(object sender, EventArgs e)
        {
            if (CheckInputPassword(Pass_textBox.Text))
            {
                PasswordLabel_notif.ForeColor = Color.Green;
                PasswordLabel_notif.Text = "Доступ разрешен";
                DialogResult = DialogResult.OK;
            }
            else
            {
                PasswordLabel_notif.ForeColor = Color.Red;
                PasswordLabel_notif.Text = "Пароль не верный!";
            }
        }

        private bool CheckInputPassword(string INputPassword)
        {
            if (INputPassword.Equals(Password))
                IsPasswordTrue = true;
            else
                IsPasswordTrue = false;

            return IsPasswordTrue;
        }

        private void PasswordAccess_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!IsPasswordTrue)
                Application.Exit();
        }
    }
}
