namespace FormMain
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.txBxInput = new System.Windows.Forms.TextBox();
            this.cmBxOper = new System.Windows.Forms.ComboBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.chBxFile = new System.Windows.Forms.CheckBox();
            this.buttonPath = new System.Windows.Forms.Button();
            this.labelInput = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelSubstr = new System.Windows.Forms.Label();
            this.txBxSubStr = new System.Windows.Forms.TextBox();
            this.chBxChoiceAll = new System.Windows.Forms.CheckBox();
            this.labelStartIndex = new System.Windows.Forms.Label();
            this.txBxIndexSub = new System.Windows.Forms.TextBox();
            this.cmBxType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(14, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Строки";
            // 
            // txBxInput
            // 
            this.txBxInput.Location = new System.Drawing.Point(14, 89);
            this.txBxInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txBxInput.Name = "txBxInput";
            this.txBxInput.Size = new System.Drawing.Size(570, 27);
            this.txBxInput.TabIndex = 1;
            this.txBxInput.TextChanged += new System.EventHandler(this.txBxInput_TextChanged);
            // 
            // cmBxOper
            // 
            this.cmBxOper.FormattingEnabled = true;
            this.cmBxOper.Items.AddRange(new object[] {
            "1. Найти вхождения",
            "2. Вставить подстроку",
            "3. Удалить подстроку",
            "4. Заменить подстроку",
            "5. Определить тип",
            "6. Перевод в другой тип"});
            this.cmBxOper.Location = new System.Drawing.Point(146, 163);
            this.cmBxOper.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmBxOper.Name = "cmBxOper";
            this.cmBxOper.Size = new System.Drawing.Size(170, 28);
            this.cmBxOper.TabIndex = 2;
            this.cmBxOper.SelectedIndexChanged += new System.EventHandler(this.cmBxOper_SelectedIndexChanged);
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonStart.Location = new System.Drawing.Point(14, 313);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(137, 53);
            this.buttonStart.TabIndex = 3;
            this.buttonStart.Text = "Запустить";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Visible = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // chBxFile
            // 
            this.chBxFile.AutoSize = true;
            this.chBxFile.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chBxFile.Location = new System.Drawing.Point(14, 128);
            this.chBxFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chBxFile.Name = "chBxFile";
            this.chBxFile.Size = new System.Drawing.Size(244, 26);
            this.chBxFile.TabIndex = 4;
            this.chBxFile.Text = "Считать строку из файла";
            this.chBxFile.UseVisualStyleBackColor = true;
            this.chBxFile.CheckedChanged += new System.EventHandler(this.chBxFile_CheckedChanged);
            // 
            // buttonPath
            // 
            this.buttonPath.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonPath.Location = new System.Drawing.Point(446, 128);
            this.buttonPath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonPath.Name = "buttonPath";
            this.buttonPath.Size = new System.Drawing.Size(137, 47);
            this.buttonPath.TabIndex = 5;
            this.buttonPath.Text = "Выбрать";
            this.buttonPath.UseVisualStyleBackColor = true;
            this.buttonPath.Visible = false;
            this.buttonPath.Click += new System.EventHandler(this.buttonPath_Click);
            // 
            // labelInput
            // 
            this.labelInput.AutoSize = true;
            this.labelInput.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelInput.Location = new System.Drawing.Point(14, 55);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(82, 31);
            this.labelInput.TabIndex = 6;
            this.labelInput.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(14, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 31);
            this.label2.TabIndex = 7;
            this.label2.Text = "Действие:";
            // 
            // labelSubstr
            // 
            this.labelSubstr.AutoSize = true;
            this.labelSubstr.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSubstr.Location = new System.Drawing.Point(14, 201);
            this.labelSubstr.Name = "labelSubstr";
            this.labelSubstr.Size = new System.Drawing.Size(143, 31);
            this.labelSubstr.TabIndex = 8;
            this.labelSubstr.Text = "Подстрока:";
            this.labelSubstr.Visible = false;
            // 
            // txBxSubStr
            // 
            this.txBxSubStr.Location = new System.Drawing.Point(163, 205);
            this.txBxSubStr.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txBxSubStr.Name = "txBxSubStr";
            this.txBxSubStr.Size = new System.Drawing.Size(317, 27);
            this.txBxSubStr.TabIndex = 9;
            this.txBxSubStr.Visible = false;
            // 
            // chBxChoiceAll
            // 
            this.chBxChoiceAll.AutoSize = true;
            this.chBxChoiceAll.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chBxChoiceAll.Location = new System.Drawing.Point(14, 275);
            this.chBxChoiceAll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chBxChoiceAll.Name = "chBxChoiceAll";
            this.chBxChoiceAll.Size = new System.Drawing.Size(327, 26);
            this.chBxChoiceAll.TabIndex = 10;
            this.chBxChoiceAll.Text = "Совершить со всеми подстроками.";
            this.chBxChoiceAll.UseVisualStyleBackColor = true;
            this.chBxChoiceAll.Visible = false;
            // 
            // labelStartIndex
            // 
            this.labelStartIndex.AutoSize = true;
            this.labelStartIndex.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelStartIndex.Location = new System.Drawing.Point(14, 236);
            this.labelStartIndex.Name = "labelStartIndex";
            this.labelStartIndex.Size = new System.Drawing.Size(232, 31);
            this.labelStartIndex.TabIndex = 11;
            this.labelStartIndex.Text = "Начальный индекс:";
            this.labelStartIndex.Visible = false;
            // 
            // txBxIndexSub
            // 
            this.txBxIndexSub.Location = new System.Drawing.Point(245, 236);
            this.txBxIndexSub.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txBxIndexSub.Name = "txBxIndexSub";
            this.txBxIndexSub.Size = new System.Drawing.Size(51, 27);
            this.txBxIndexSub.TabIndex = 12;
            this.txBxIndexSub.Visible = false;
            // 
            // cmBxType
            // 
            this.cmBxType.FormattingEnabled = true;
            this.cmBxType.Items.AddRange(new object[] {
            "1. Идентификатор",
            "2. Целое число",
            "3. Вещественное число",
            "4. Логическое  значение "});
            this.cmBxType.Location = new System.Drawing.Point(302, 235);
            this.cmBxType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmBxType.Name = "cmBxType";
            this.cmBxType.Size = new System.Drawing.Size(138, 28);
            this.cmBxType.TabIndex = 14;
            this.cmBxType.Visible = false;
            this.cmBxType.SelectedIndexChanged += new System.EventHandler(this.cmBxType_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 387);
            this.Controls.Add(this.cmBxType);
            this.Controls.Add(this.txBxIndexSub);
            this.Controls.Add(this.labelStartIndex);
            this.Controls.Add(this.chBxChoiceAll);
            this.Controls.Add(this.txBxSubStr);
            this.Controls.Add(this.labelSubstr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelInput);
            this.Controls.Add(this.buttonPath);
            this.Controls.Add(this.chBxFile);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.cmBxOper);
            this.Controls.Add(this.txBxInput);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ErrorProvider errorProvider1;
        private Label labelInput;
        private Button buttonPath;
        private CheckBox chBxFile;
        private Button buttonStart;
        private ComboBox cmBxOper;
        private TextBox txBxInput;
        private Label label1;
        private OpenFileDialog openFileDialog1;
        private Label label2;
        private CheckBox chBxChoiceAll;
        private TextBox txBxSubStr;
        private Label labelSubstr;
        private TextBox txBxIndexSub;
        private Label labelStartIndex;
        private ComboBox cmBxType;
    }
}