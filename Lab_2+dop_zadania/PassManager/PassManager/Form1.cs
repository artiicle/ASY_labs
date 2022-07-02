using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Printing;
using System.Drawing;

namespace PassManager
{
    public partial class Form1 : Form
    {
        private readonly string backupPath = "C:\\Users\\budan\\Desktop\\PassManager\\BackUps";

        private readonly string dbPath = "D:\\lp.db";
        Database db;
        LCrypt lc = new LCrypt();
        

        public Form1()
        {
            lc = new LCrypt();
            PasswordAccess passAcc = new PasswordAccess(this);
            // Пароль на вход, временный
            passAcc.Password = "0000";

            if (passAcc.ShowDialog() == DialogResult.OK)
            {
                if (passAcc.IsPasswordTrue)
                {
                    InitializeComponent();
                }
                else { MessageBox.Show("Произошла ошибка!", "Ошибка!"); }
            }
            passAcc.Dispose();
            initRecGridView();
            db = new Database();
            if (isDbExists())
            {
                db.open();
                updateTable();
            }
            else
            {
                db.init();
            }
            delete_button.Enabled = false;
        }


        private bool isDbExists()
        {
            return File.Exists(dbPath);
        }

        public void updateTable()
        {
            List<Record> recs = db.getRecords();
            // gv_data.DataSource = null;
            gv_data.Rows.Clear();
            gv_data.Refresh();
            foreach (Record rec in recs)
            {
                gv_data.Rows.Add(rec.Id, rec.url, rec.login, rec.password);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void drawTable(DataTable DT)
        {
            gv_data.DataSource = DT;
        }

        // new record
        // Encryption here
        private void btnNewRecord(object sender, EventArgs e)
        {
            string tbPass = tb_pass.Text;
            string tbLogin = tb_login.Text;
            string encPass = Encoding.Unicode.GetString(lc.enc(Encoding.Unicode.GetBytes(tb_pass.Text), lc.PASSWORD));
            string encLogin = Encoding.Unicode.GetString(lc.enc(Encoding.Unicode.GetBytes(tb_login.Text), lc.PASSWORD));
            db.newRecord(tb_url.Text, encLogin, encPass);
            updateTable();
        }

        // Decryption here
        private void gvData_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (!db.IsOpened)
                return;

            // For any other operation except, StateChanged, do nothing
            if (e.StateChanged != DataGridViewElementStates.Selected) return;
            // DataGridViewRow curRow = gv_data.CurrentRow;
            string id = e.Row.Cells[0].Value.ToString();
            //string id = gv_data.CurrentRow.Cells[0].Value.ToString(); Не верно, можно удалить
            // string id = gv_data.SelectedRows[0].Cells[0].Value.ToString();
            int rowindex = gv_data.CurrentCell.RowIndex;
            int columnindex = gv_data.CurrentCell.ColumnIndex;
            Record selectedRecord = db.getRecord(id);
            selectedRecord.login = Encoding.Unicode.GetString(lc.dec(Encoding.Unicode.GetBytes(selectedRecord.login), lc.PASSWORD));
            selectedRecord.password = Encoding.Unicode.GetString(lc.dec(Encoding.Unicode.GetBytes(selectedRecord.password), lc.PASSWORD));
            drawSelectedRecord(selectedRecord);


            delete_button.Enabled = true;
            SelectedId = id;
        }

        private void drawSelectedRecord(Record selectedRecord)
        {
            // gv_record.DataSource = null;
            gv_record.Rows.Clear();
            gv_record.Refresh();
            gv_record.Rows.Add(selectedRecord.Id, selectedRecord.url, selectedRecord.login, selectedRecord.password);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string clear = "adasduiahsnduqibwdpuiwd821u3812738129371823721936120721h972";
            string enc = Encoding.Unicode.GetString(lc.enc(Encoding.Unicode.GetBytes(clear), lc.PASSWORD));
            string dec = Encoding.Unicode.GetString(lc.dec(Encoding.Unicode.GetBytes(enc), lc.PASSWORD));
            MessageBox.Show($"clear - ${clear}; enc - {enc}; dec - {dec}");
        }

        private void gvData_hideChars(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((e.ColumnIndex == 2 || e.ColumnIndex == 3) && e.Value != null)
            {
                e.Value = new String('*', e.Value.ToString().Length);
            }
        }

        private void initRecGridView()
        {
            gv_data.Columns.Add("id", "id");
            gv_data.Columns.Add("url", "url");
            gv_data.Columns.Add("login", "login");
            gv_data.Columns.Add("password", "password");

            gv_record.Columns.Add("id", "id");
            gv_record.Columns.Add("url", "url");
            gv_record.Columns.Add("login", "login");
            gv_record.Columns.Add("password", "password");
        }

        string SelectedId;

        private void delete_button_Click(object sender, EventArgs e)
        {
            gv_data.ClearSelection();
            db.deleteRecord(SelectedId);
            db.reIndexTable();  
            updateTable();
            delete_button.Enabled = false;
        }

        private void backup_button_Click(object sender, EventArgs e)
        {
            string time = $"{DateTime.Now.Day}-{DateTime.Now.Month}-{DateTime.Now.Year}H{DateTime.Now.Hour}-{DateTime.Now.Minute}-{DateTime.Now.Second}.db";
            string destPath = $"{backupPath}\\{time}";
            File.Copy(dbPath, destPath, false);
            MessageBox.Show($"Файл сохранен под именем {time}", "Backup успешно сохранен!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /*private void SaveDatabase(string Path, int rec)
        {
            if (!File.Exists(Path))
                File.Copy(dbPath, Path);
            else
            {
                rec++;
                Path = Path.Substring(0, Path.IndexOf('(') + 1);
                Path = $"{Path}({rec}).db";
                SaveDatabase(Path, rec);
            }
        }*/

        private void print_button_Click(object sender, EventArgs e)
        {
            printDialog1 = new PrintDialog();
            docToPrint = new PrintDocument();
            printDialog1.AllowSomePages = true;

            printDialog1.Document = docToPrint;
            docToPrint.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);

            DialogResult res = printDialog1.ShowDialog();
            if (res == DialogResult.OK)
            {
                docToPrint.PrinterSettings = printDialog1.PrinterSettings;

                docToPrint.Print();
            }
                
            docToPrint.Dispose();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            string text = CombineStrings();

            Font printFont = new Font("Arial", 12, System.Drawing.FontStyle.Regular);

            e.Graphics.DrawString(text, printFont, new SolidBrush(Color.Black), 10, 10);
        }

        private string CombineStrings()
        {
            string exportST = null;
            List<Record> records = db.getAllTable();
            foreach (Record record in records)
            {
                record.password = Encoding.Unicode.GetString(lc.dec(Encoding.Unicode.GetBytes(record.password), lc.PASSWORD));
                record.login = Encoding.Unicode.GetString(lc.dec(Encoding.Unicode.GetBytes(record.login), lc.PASSWORD));
                exportST += $"URL: {record.url}   Password: {record.password}   Login: {record.login}{Environment.NewLine}";
            }

            return exportST;
        }

        private void restoreBackup_button_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("автоматически будет создан backup текущей версии!", "Предупреждение!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {

                db.close();
                gv_record.ClearSelection();
                gv_data.ClearSelection();
                gv_data.Rows.Clear();
                gv_record.Rows.Clear();
                db = null;
                
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "DataBase Files (.db) |*.db";
                openFileDialog.Title = "Выберите нужный Backup!";
                string source;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                    source = openFileDialog.FileName;
                else
                    return;

                string FileName = $"{backupPath}\\{DateTime.Now.Day}-{DateTime.Now.Month}-{DateTime.Now.Year}H{DateTime.Now.Hour}-{DateTime.Now.Minute}-{DateTime.Now.Second}.db";


                File.Copy(dbPath, FileName);
                File.Delete(dbPath);
                File.Copy(source, dbPath);
                //File.Replace(source, dbPath, FileName);

                db = new Database();
                db.open();
                updateTable();
            }
            else
                return;
        }

    }
}
