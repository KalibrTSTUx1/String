namespace Forms
{
    partial class resultForm
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
            this.labelOperResult = new System.Windows.Forms.Label();
            this.txBxRes = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.openFilePath = new System.Windows.Forms.OpenFileDialog();
            this.labelSaveResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelOperResult
            // 
            this.labelOperResult.AutoSize = true;
            this.labelOperResult.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelOperResult.Location = new System.Drawing.Point(12, 9);
            this.labelOperResult.Name = "labelOperResult";
            this.labelOperResult.Size = new System.Drawing.Size(88, 32);
            this.labelOperResult.TabIndex = 0;
            this.labelOperResult.Text = "label1";
            // 
            // txBxRes
            // 
            this.txBxRes.Location = new System.Drawing.Point(12, 44);
            this.txBxRes.Name = "txBxRes";
            this.txBxRes.ReadOnly = true;
            this.txBxRes.Size = new System.Drawing.Size(393, 23);
            this.txBxRes.TabIndex = 1;
            this.txBxRes.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(12, 73);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(202, 47);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Сохранить результат в файл";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // openFilePath
            // 
            this.openFilePath.FileName = "openFileDialog1";
            // 
            // labelSaveResult
            // 
            this.labelSaveResult.AutoSize = true;
            this.labelSaveResult.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSaveResult.Location = new System.Drawing.Point(12, 123);
            this.labelSaveResult.Name = "labelSaveResult";
            this.labelSaveResult.Size = new System.Drawing.Size(59, 22);
            this.labelSaveResult.TabIndex = 3;
            this.labelSaveResult.Text = "label2";
            // 
            // resultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 252);
            this.Controls.Add(this.labelSaveResult);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.txBxRes);
            this.Controls.Add(this.labelOperResult);
            this.Name = "resultForm";
            this.Text = "resultForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelOperResult;
        private TextBox txBxRes;
        private Button buttonSave;
        private OpenFileDialog openFilePath;
        private Label labelSaveResult;
    }
}