using Forms;

namespace FormMain
{
    public partial class Form1 : Form
    {
        private string filePath;
        private int choice;
        entryPoint enPoint;
        public Form1()
        {
            InitializeComponent();
            labelInput.Text = "Входная строка:";
            
        }

        private void txBxInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void chBxFile_CheckedChanged(object sender, EventArgs e)
        {
            if (chBxFile.Checked)
            {
                labelInput.Text = "Путь к файлу";
                buttonPath.Visible = true;
                txBxInput.Enabled = false;
            } else { labelInput.Text = "Входная строка:"; buttonPath.Visible = false; txBxInput.Enabled = true; }
        }

        private void cmBxOper_SelectedIndexChanged(object sender, EventArgs e)
        {
            choice = int.Parse(Convert.ToString(cmBxOper.Text[0]));
            if (choice < 4 && choice != 2)
            {
                allClear();
                labelSubstr.Text = "Подстрока:";
                labelSubstr.Visible = true;
                txBxSubStr.Visible = true;
                buttonStart.Visible = true;
                chBxChoiceAll.Visible = true;
                cmBxType.Visible = false;
                txBxIndexSub.Visible = false;
                labelStartIndex.Visible = false;
                buttonStart.Location = new Point(12, 306);
                chBxChoiceAll.Location = new Point(12, 280);
            }
            else if (choice == 2)
            {
                allClear();
                labelSubstr.Text = "Подстрока:";
                labelSubstr.Visible = true;
                txBxSubStr.Visible = true;
                buttonStart.Visible = true;
                cmBxType.Visible = false;
                chBxChoiceAll.Visible = false;
                labelStartIndex.Visible = true;
                txBxIndexSub.Visible = true;
                buttonStart.Location = new Point(12, 306);
                txBxIndexSub.Size = new Size(45, 23);
                txBxIndexSub.Location = new Point(250, 250);
                labelStartIndex.Text = "Начальный индекс:";
            }
            else if (choice == 4)
            {
                allClear();
                labelSubstr.Text = "Подстрока:";
                labelSubstr.Visible = true;
                txBxSubStr.Visible = true;
                buttonStart.Visible = true;
                chBxChoiceAll.Visible = true;
                txBxIndexSub.Visible = true;
                cmBxType.Visible = false;
                labelStartIndex.Visible = true;
                txBxIndexSub.Size = new Size(228, 23);
                txBxIndexSub.Location = new Point(184, 240);
                labelStartIndex.Text = "Заменить на:";
                buttonStart.Location = new Point(12, 335);
                chBxChoiceAll.Location = new Point(12, 306);
            }
            else if (choice == 5)
            {
                allClear();
                labelSubstr.Text = "Подстрока:";
                labelSubstr.Visible = false;
                txBxSubStr.Visible = false;
                buttonStart.Visible = true;
                chBxChoiceAll.Visible = false;
                txBxIndexSub.Visible = false;
                labelStartIndex.Visible = false;
                cmBxType.Visible = false;
                buttonStart.Location = new Point(12, 250);
            }
            else if (choice == 6)
            {
                allClear();
                labelSubstr.Visible = true;
                labelSubstr.Text = "Желаемый тип:";
                txBxSubStr.Visible = false;
                buttonStart.Visible = true;
                chBxChoiceAll.Visible = false;
                txBxIndexSub.Visible = false;
                labelStartIndex.Visible = false;
                cmBxType.Visible = true;
                buttonStart.Location = new Point(12, 280);
                cmBxType.Location = new Point(220, 200);


            }
        }

        private void buttonPath_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog1.FileName;
                txBxInput.Text = filePath;
            } 
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            try
            {
                if (choice <= 6)
                {
                    if (choice != 6)
                    {
                        cmBxType.Text = "3";
                    }
                    enPoint = new entryPoint(txBxInput.Text, chBxFile.Checked, choice, txBxSubStr.Text, txBxIndexSub.Text, chBxChoiceAll.Checked, int.Parse(Convert.ToString(cmBxType.Text[0])));

                    resultForm formRes = new resultForm(enPoint.mainFunc(), choice);
                    formRes.Show();
                }
            } catch (Exception ex)
            {
                errorProvider1.SetError(buttonStart, ex.Message);
            }
        }
        private void allClear()
        {
            txBxIndexSub.Clear();
            txBxSubStr.Clear();
        }

        private void cmBxType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
    }
}