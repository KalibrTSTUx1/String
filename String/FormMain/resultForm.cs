using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class resultForm : Form
    {
        private string filePath;
        private string result;
        private int oper;
        public resultForm(string result, int oper)
        {
            InitializeComponent();
            buttonSave.Visible = false;
            labelSaveResult.Visible = false;
            this.result = result;
            this.oper = oper;
            if (oper <= 4)
            {
                labelOperResult.Text = "Результат операции над стрококой:";
                buttonSave.Visible = true;
            } else if (oper == 5) { labelOperResult.Text = "Строка имеет тип:"; }
            else { labelOperResult.Text = "Результат преобразовании строки:"; }
            txBxRes.Text = result;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (openFilePath.ShowDialog() == DialogResult.OK)
            {
                filePath = openFilePath.FileName;
                fileHandler fh = new fileHandler(filePath);
                fh.fileRecorder(filePath, result);
                labelSaveResult.Visible = true;
                labelSaveResult.Text = "Результат сохранен";
                labelSaveResult.ForeColor = Color.Green;
            }
        }
    }
}
