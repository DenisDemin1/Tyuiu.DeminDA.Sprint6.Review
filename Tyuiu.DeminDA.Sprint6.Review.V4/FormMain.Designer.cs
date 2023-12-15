
namespace Tyuiu.DeminDA.Sprint6.Review.V4
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelFill_DDA = new System.Windows.Forms.Panel();
            this.panelRight_DDA = new System.Windows.Forms.Panel();
            this.groupBoxResult_DDA = new System.Windows.Forms.GroupBox();
            this.textBoxResult_DDA = new System.Windows.Forms.TextBox();
            this.labelResult_DDA = new System.Windows.Forms.Label();
            this.groupBoxArray_DDA = new System.Windows.Forms.GroupBox();
            this.dataGridViewArray_DDA = new System.Windows.Forms.DataGridView();
            this.panelLeft_DDA = new System.Windows.Forms.Panel();
            this.groupBoxVars_DDA = new System.Windows.Forms.GroupBox();
            this.textBoxtextBoxRowAmount_DDA = new System.Windows.Forms.TextBox();
            this.labeltextBoxRowAmount_DDA = new System.Windows.Forms.Label();
            this.textBoxlabelNumsDown_DAA = new System.Windows.Forms.TextBox();
            this.textBoxNumsUp_DAA = new System.Windows.Forms.TextBox();
            this.labelNumsDown_DAA = new System.Windows.Forms.Label();
            this.labelNumsUp_DAA = new System.Windows.Forms.Label();
            this.labelNumsInMatrix_DDA = new System.Windows.Forms.Label();
            this.textBoxecondNumRandomInPut_DDA = new System.Windows.Forms.TextBox();
            this.textBoxFirstNumRandomInput_DDA = new System.Windows.Forms.TextBox();
            this.labelSecondNumRandom_DDA = new System.Windows.Forms.Label();
            this.labelFirstNumRandom_DDA = new System.Windows.Forms.Label();
            this.labelGenerationSize_DDA = new System.Windows.Forms.Label();
            this.textBoxColunumnsInPut_DDA = new System.Windows.Forms.TextBox();
            this.textBoxRowsInPut_DDA = new System.Windows.Forms.TextBox();
            this.labelColumns_DDA = new System.Windows.Forms.Label();
            this.labelRows_DDA = new System.Windows.Forms.Label();
            this.labelSize_DDA = new System.Windows.Forms.Label();
            this.panelTask_DDA = new System.Windows.Forms.Panel();
            this.buttonHelp_DDA = new System.Windows.Forms.Button();
            this.buttonCreateArray_DDA = new System.Windows.Forms.Button();
            this.buttonDone_DDA = new System.Windows.Forms.Button();
            this.groupBoxTask_DDA = new System.Windows.Forms.GroupBox();
            this.labelTask_DDA = new System.Windows.Forms.Label();
            this.panelFill_DDA.SuspendLayout();
            this.panelRight_DDA.SuspendLayout();
            this.groupBoxResult_DDA.SuspendLayout();
            this.groupBoxArray_DDA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArray_DDA)).BeginInit();
            this.panelLeft_DDA.SuspendLayout();
            this.groupBoxVars_DDA.SuspendLayout();
            this.panelTask_DDA.SuspendLayout();
            this.groupBoxTask_DDA.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFill_DDA
            // 
            this.panelFill_DDA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelFill_DDA.Controls.Add(this.panelRight_DDA);
            this.panelFill_DDA.Controls.Add(this.panelLeft_DDA);
            this.panelFill_DDA.Controls.Add(this.panelTask_DDA);
            this.panelFill_DDA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFill_DDA.Location = new System.Drawing.Point(0, 0);
            this.panelFill_DDA.Name = "panelFill_DDA";
            this.panelFill_DDA.Size = new System.Drawing.Size(1098, 694);
            this.panelFill_DDA.TabIndex = 0;
            this.panelFill_DDA.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTask_DDA_Paint);
            // 
            // panelRight_DDA
            // 
            this.panelRight_DDA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelRight_DDA.Controls.Add(this.groupBoxResult_DDA);
            this.panelRight_DDA.Controls.Add(this.groupBoxArray_DDA);
            this.panelRight_DDA.Location = new System.Drawing.Point(552, 159);
            this.panelRight_DDA.Name = "panelRight_DDA";
            this.panelRight_DDA.Size = new System.Drawing.Size(542, 533);
            this.panelRight_DDA.TabIndex = 2;
            // 
            // groupBoxResult_DDA
            // 
            this.groupBoxResult_DDA.Controls.Add(this.textBoxResult_DDA);
            this.groupBoxResult_DDA.Controls.Add(this.labelResult_DDA);
            this.groupBoxResult_DDA.Location = new System.Drawing.Point(19, 410);
            this.groupBoxResult_DDA.Name = "groupBoxResult_DDA";
            this.groupBoxResult_DDA.Size = new System.Drawing.Size(513, 120);
            this.groupBoxResult_DDA.TabIndex = 1;
            this.groupBoxResult_DDA.TabStop = false;
            this.groupBoxResult_DDA.Text = "Результат выполнения программы";
            // 
            // textBoxResult_DDA
            // 
            this.textBoxResult_DDA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxResult_DDA.Location = new System.Drawing.Point(9, 43);
            this.textBoxResult_DDA.Multiline = true;
            this.textBoxResult_DDA.Name = "textBoxResult_DDA";
            this.textBoxResult_DDA.Size = new System.Drawing.Size(498, 75);
            this.textBoxResult_DDA.TabIndex = 1;
            // 
            // labelResult_DDA
            // 
            this.labelResult_DDA.AutoSize = true;
            this.labelResult_DDA.Location = new System.Drawing.Point(6, 23);
            this.labelResult_DDA.Name = "labelResult_DDA";
            this.labelResult_DDA.Size = new System.Drawing.Size(316, 17);
            this.labelResult_DDA.TabIndex = 0;
            this.labelResult_DDA.Text = "Сумма чётных элементов в заданном столбце:";
            // 
            // groupBoxArray_DDA
            // 
            this.groupBoxArray_DDA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxArray_DDA.Controls.Add(this.dataGridViewArray_DDA);
            this.groupBoxArray_DDA.Location = new System.Drawing.Point(3, 14);
            this.groupBoxArray_DDA.Name = "groupBoxArray_DDA";
            this.groupBoxArray_DDA.Size = new System.Drawing.Size(529, 390);
            this.groupBoxArray_DDA.TabIndex = 0;
            this.groupBoxArray_DDA.TabStop = false;
            this.groupBoxArray_DDA.Text = "Сгенирированный массив";
            // 
            // dataGridViewArray_DDA
            // 
            this.dataGridViewArray_DDA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewArray_DDA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewArray_DDA.Location = new System.Drawing.Point(16, 21);
            this.dataGridViewArray_DDA.Name = "dataGridViewArray_DDA";
            this.dataGridViewArray_DDA.RowHeadersVisible = false;
            this.dataGridViewArray_DDA.RowHeadersWidth = 51;
            this.dataGridViewArray_DDA.RowTemplate.Height = 24;
            this.dataGridViewArray_DDA.Size = new System.Drawing.Size(507, 363);
            this.dataGridViewArray_DDA.TabIndex = 0;
            // 
            // panelLeft_DDA
            // 
            this.panelLeft_DDA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelLeft_DDA.Controls.Add(this.groupBoxVars_DDA);
            this.panelLeft_DDA.Location = new System.Drawing.Point(3, 159);
            this.panelLeft_DDA.Name = "panelLeft_DDA";
            this.panelLeft_DDA.Size = new System.Drawing.Size(562, 533);
            this.panelLeft_DDA.TabIndex = 1;
            // 
            // groupBoxVars_DDA
            // 
            this.groupBoxVars_DDA.Controls.Add(this.textBoxtextBoxRowAmount_DDA);
            this.groupBoxVars_DDA.Controls.Add(this.labeltextBoxRowAmount_DDA);
            this.groupBoxVars_DDA.Controls.Add(this.textBoxlabelNumsDown_DAA);
            this.groupBoxVars_DDA.Controls.Add(this.textBoxNumsUp_DAA);
            this.groupBoxVars_DDA.Controls.Add(this.labelNumsDown_DAA);
            this.groupBoxVars_DDA.Controls.Add(this.labelNumsUp_DAA);
            this.groupBoxVars_DDA.Controls.Add(this.labelNumsInMatrix_DDA);
            this.groupBoxVars_DDA.Controls.Add(this.textBoxecondNumRandomInPut_DDA);
            this.groupBoxVars_DDA.Controls.Add(this.textBoxFirstNumRandomInput_DDA);
            this.groupBoxVars_DDA.Controls.Add(this.labelSecondNumRandom_DDA);
            this.groupBoxVars_DDA.Controls.Add(this.labelFirstNumRandom_DDA);
            this.groupBoxVars_DDA.Controls.Add(this.labelGenerationSize_DDA);
            this.groupBoxVars_DDA.Controls.Add(this.textBoxColunumnsInPut_DDA);
            this.groupBoxVars_DDA.Controls.Add(this.textBoxRowsInPut_DDA);
            this.groupBoxVars_DDA.Controls.Add(this.labelColumns_DDA);
            this.groupBoxVars_DDA.Controls.Add(this.labelRows_DDA);
            this.groupBoxVars_DDA.Controls.Add(this.labelSize_DDA);
            this.groupBoxVars_DDA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxVars_DDA.Location = new System.Drawing.Point(9, 3);
            this.groupBoxVars_DDA.Name = "groupBoxVars_DDA";
            this.groupBoxVars_DDA.Size = new System.Drawing.Size(534, 530);
            this.groupBoxVars_DDA.TabIndex = 0;
            this.groupBoxVars_DDA.TabStop = false;
            this.groupBoxVars_DDA.Text = "Значения переменных для программы";
            // 
            // textBoxtextBoxRowAmount_DDA
            // 
            this.textBoxtextBoxRowAmount_DDA.Location = new System.Drawing.Point(422, 425);
            this.textBoxtextBoxRowAmount_DDA.Name = "textBoxtextBoxRowAmount_DDA";
            this.textBoxtextBoxRowAmount_DDA.Size = new System.Drawing.Size(106, 22);
            this.textBoxtextBoxRowAmount_DDA.TabIndex = 16;
            // 
            // labeltextBoxRowAmount_DDA
            // 
            this.labeltextBoxRowAmount_DDA.AutoSize = true;
            this.labeltextBoxRowAmount_DDA.Location = new System.Drawing.Point(419, 384);
            this.labeltextBoxRowAmount_DDA.Name = "labeltextBoxRowAmount_DDA";
            this.labeltextBoxRowAmount_DDA.Size = new System.Drawing.Size(109, 17);
            this.labeltextBoxRowAmount_DDA.TabIndex = 15;
            this.labeltextBoxRowAmount_DDA.Text = "Номер столбца";
            // 
            // textBoxlabelNumsDown_DAA
            // 
            this.textBoxlabelNumsDown_DAA.Location = new System.Drawing.Point(216, 425);
            this.textBoxlabelNumsDown_DAA.Name = "textBoxlabelNumsDown_DAA";
            this.textBoxlabelNumsDown_DAA.Size = new System.Drawing.Size(182, 22);
            this.textBoxlabelNumsDown_DAA.TabIndex = 14;
            // 
            // textBoxNumsUp_DAA
            // 
            this.textBoxNumsUp_DAA.Location = new System.Drawing.Point(16, 425);
            this.textBoxNumsUp_DAA.Name = "textBoxNumsUp_DAA";
            this.textBoxNumsUp_DAA.Size = new System.Drawing.Size(191, 22);
            this.textBoxNumsUp_DAA.TabIndex = 13;
            // 
            // labelNumsDown_DAA
            // 
            this.labelNumsDown_DAA.AutoSize = true;
            this.labelNumsDown_DAA.Location = new System.Drawing.Point(213, 384);
            this.labelNumsDown_DAA.Name = "labelNumsDown_DAA";
            this.labelNumsDown_DAA.Size = new System.Drawing.Size(185, 17);
            this.labelNumsDown_DAA.TabIndex = 12;
            this.labelNumsDown_DAA.Text = "L - номер конечного числа";
            // 
            // labelNumsUp_DAA
            // 
            this.labelNumsUp_DAA.AutoSize = true;
            this.labelNumsUp_DAA.Location = new System.Drawing.Point(13, 384);
            this.labelNumsUp_DAA.Name = "labelNumsUp_DAA";
            this.labelNumsUp_DAA.Size = new System.Drawing.Size(194, 17);
            this.labelNumsUp_DAA.TabIndex = 11;
            this.labelNumsUp_DAA.Text = "K - номер начального числа";
            // 
            // labelNumsInMatrix_DDA
            // 
            this.labelNumsInMatrix_DDA.AutoSize = true;
            this.labelNumsInMatrix_DDA.Location = new System.Drawing.Point(169, 345);
            this.labelNumsInMatrix_DDA.Name = "labelNumsInMatrix_DDA";
            this.labelNumsInMatrix_DDA.Size = new System.Drawing.Size(142, 17);
            this.labelNumsInMatrix_DDA.TabIndex = 10;
            this.labelNumsInMatrix_DDA.Text = "Значения в массиве";
            // 
            // textBoxecondNumRandomInPut_DDA
            // 
            this.textBoxecondNumRandomInPut_DDA.Location = new System.Drawing.Point(312, 272);
            this.textBoxecondNumRandomInPut_DDA.Name = "textBoxecondNumRandomInPut_DDA";
            this.textBoxecondNumRandomInPut_DDA.Size = new System.Drawing.Size(182, 22);
            this.textBoxecondNumRandomInPut_DDA.TabIndex = 9;
            // 
            // textBoxFirstNumRandomInput_DDA
            // 
            this.textBoxFirstNumRandomInput_DDA.Location = new System.Drawing.Point(16, 272);
            this.textBoxFirstNumRandomInput_DDA.Name = "textBoxFirstNumRandomInput_DDA";
            this.textBoxFirstNumRandomInput_DDA.Size = new System.Drawing.Size(126, 22);
            this.textBoxFirstNumRandomInput_DDA.TabIndex = 8;
            // 
            // labelSecondNumRandom_DDA
            // 
            this.labelSecondNumRandom_DDA.AutoSize = true;
            this.labelSecondNumRandom_DDA.Location = new System.Drawing.Point(309, 226);
            this.labelSecondNumRandom_DDA.Name = "labelSecondNumRandom_DDA";
            this.labelSecondNumRandom_DDA.Size = new System.Drawing.Size(141, 17);
            this.labelSecondNumRandom_DDA.TabIndex = 7;
            this.labelSecondNumRandom_DDA.Text = "n2 - правая граница";
            // 
            // labelFirstNumRandom_DDA
            // 
            this.labelFirstNumRandom_DDA.AutoSize = true;
            this.labelFirstNumRandom_DDA.Location = new System.Drawing.Point(13, 226);
            this.labelFirstNumRandom_DDA.Name = "labelFirstNumRandom_DDA";
            this.labelFirstNumRandom_DDA.Size = new System.Drawing.Size(133, 17);
            this.labelFirstNumRandom_DDA.TabIndex = 6;
            this.labelFirstNumRandom_DDA.Text = "n1 - левая граница";
            // 
            // labelGenerationSize_DDA
            // 
            this.labelGenerationSize_DDA.AutoSize = true;
            this.labelGenerationSize_DDA.Location = new System.Drawing.Point(111, 181);
            this.labelGenerationSize_DDA.Name = "labelGenerationSize_DDA";
            this.labelGenerationSize_DDA.Size = new System.Drawing.Size(256, 17);
            this.labelGenerationSize_DDA.TabIndex = 5;
            this.labelGenerationSize_DDA.Text = "Границы генерации случайных чисел\r\n";
            // 
            // textBoxColunumnsInPut_DDA
            // 
            this.textBoxColunumnsInPut_DDA.Location = new System.Drawing.Point(312, 123);
            this.textBoxColunumnsInPut_DDA.Name = "textBoxColunumnsInPut_DDA";
            this.textBoxColunumnsInPut_DDA.Size = new System.Drawing.Size(182, 22);
            this.textBoxColunumnsInPut_DDA.TabIndex = 4;
            // 
            // textBoxRowsInPut_DDA
            // 
            this.textBoxRowsInPut_DDA.Location = new System.Drawing.Point(16, 123);
            this.textBoxRowsInPut_DDA.Name = "textBoxRowsInPut_DDA";
            this.textBoxRowsInPut_DDA.Size = new System.Drawing.Size(126, 22);
            this.textBoxRowsInPut_DDA.TabIndex = 3;
            // 
            // labelColumns_DDA
            // 
            this.labelColumns_DDA.AutoSize = true;
            this.labelColumns_DDA.Location = new System.Drawing.Point(309, 93);
            this.labelColumns_DDA.Name = "labelColumns_DDA";
            this.labelColumns_DDA.Size = new System.Drawing.Size(158, 17);
            this.labelColumns_DDA.TabIndex = 2;
            this.labelColumns_DDA.Text = "M- столбцов в массиве";
            // 
            // labelRows_DDA
            // 
            this.labelRows_DDA.AutoSize = true;
            this.labelRows_DDA.Location = new System.Drawing.Point(13, 93);
            this.labelRows_DDA.Name = "labelRows_DDA";
            this.labelRows_DDA.Size = new System.Drawing.Size(129, 17);
            this.labelRows_DDA.TabIndex = 1;
            this.labelRows_DDA.Text = "N-строк в массиве";
            // 
            // labelSize_DDA
            // 
            this.labelSize_DDA.AutoSize = true;
            this.labelSize_DDA.Location = new System.Drawing.Point(155, 49);
            this.labelSize_DDA.Name = "labelSize_DDA";
            this.labelSize_DDA.Size = new System.Drawing.Size(156, 17);
            this.labelSize_DDA.TabIndex = 0;
            this.labelSize_DDA.Text = "Размерность массива:";
            // 
            // panelTask_DDA
            // 
            this.panelTask_DDA.Controls.Add(this.buttonHelp_DDA);
            this.panelTask_DDA.Controls.Add(this.buttonCreateArray_DDA);
            this.panelTask_DDA.Controls.Add(this.buttonDone_DDA);
            this.panelTask_DDA.Controls.Add(this.groupBoxTask_DDA);
            this.panelTask_DDA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTask_DDA.Location = new System.Drawing.Point(0, 0);
            this.panelTask_DDA.Name = "panelTask_DDA";
            this.panelTask_DDA.Size = new System.Drawing.Size(1094, 153);
            this.panelTask_DDA.TabIndex = 0;
            // 
            // buttonHelp_DDA
            // 
            this.buttonHelp_DDA.Image = global::Tyuiu.DeminDA.Sprint6.Review.V4.Properties.Resources.help;
            this.buttonHelp_DDA.Location = new System.Drawing.Point(941, 10);
            this.buttonHelp_DDA.Name = "buttonHelp_DDA";
            this.buttonHelp_DDA.Size = new System.Drawing.Size(137, 56);
            this.buttonHelp_DDA.TabIndex = 3;
            this.buttonHelp_DDA.UseVisualStyleBackColor = true;
            this.buttonHelp_DDA.Click += new System.EventHandler(this.buttonHelp_DDA_Click);
            // 
            // buttonCreateArray_DDA
            // 
            this.buttonCreateArray_DDA.Image = global::Tyuiu.DeminDA.Sprint6.Review.V4.Properties.Resources.arrow_refresh;
            this.buttonCreateArray_DDA.Location = new System.Drawing.Point(12, 10);
            this.buttonCreateArray_DDA.Name = "buttonCreateArray_DDA";
            this.buttonCreateArray_DDA.Size = new System.Drawing.Size(142, 56);
            this.buttonCreateArray_DDA.TabIndex = 2;
            this.buttonCreateArray_DDA.UseVisualStyleBackColor = true;
            this.buttonCreateArray_DDA.Click += new System.EventHandler(this.buttonCreateArray_DDA_Click);
            // 
            // buttonDone_DDA
            // 
            this.buttonDone_DDA.Image = global::Tyuiu.DeminDA.Sprint6.Review.V4.Properties.Resources.accept;
            this.buttonDone_DDA.Location = new System.Drawing.Point(170, 10);
            this.buttonDone_DDA.Name = "buttonDone_DDA";
            this.buttonDone_DDA.Size = new System.Drawing.Size(153, 56);
            this.buttonDone_DDA.TabIndex = 1;
            this.buttonDone_DDA.UseVisualStyleBackColor = true;
            this.buttonDone_DDA.Click += new System.EventHandler(this.buttonDone_DDA_Click);
            // 
            // groupBoxTask_DDA
            // 
            this.groupBoxTask_DDA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxTask_DDA.Controls.Add(this.labelTask_DDA);
            this.groupBoxTask_DDA.Location = new System.Drawing.Point(3, 72);
            this.groupBoxTask_DDA.Name = "groupBoxTask_DDA";
            this.groupBoxTask_DDA.Size = new System.Drawing.Size(1081, 78);
            this.groupBoxTask_DDA.TabIndex = 0;
            this.groupBoxTask_DDA.TabStop = false;
            this.groupBoxTask_DDA.Text = "Условие задания:";
            // 
            // labelTask_DDA
            // 
            this.labelTask_DDA.AutoSize = true;
            this.labelTask_DDA.Location = new System.Drawing.Point(6, 24);
            this.labelTask_DDA.Name = "labelTask_DDA";
            this.labelTask_DDA.Size = new System.Drawing.Size(960, 51);
            this.labelTask_DDA.TabIndex = 0;
            this.labelTask_DDA.Text = resources.GetString("labelTask_DDA.Text");
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 694);
            this.Controls.Add(this.panelFill_DDA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Ревью | Вариант 4 | Дёмин Д. А.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelFill_DDA.ResumeLayout(false);
            this.panelRight_DDA.ResumeLayout(false);
            this.groupBoxResult_DDA.ResumeLayout(false);
            this.groupBoxResult_DDA.PerformLayout();
            this.groupBoxArray_DDA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArray_DDA)).EndInit();
            this.panelLeft_DDA.ResumeLayout(false);
            this.groupBoxVars_DDA.ResumeLayout(false);
            this.groupBoxVars_DDA.PerformLayout();
            this.panelTask_DDA.ResumeLayout(false);
            this.groupBoxTask_DDA.ResumeLayout(false);
            this.groupBoxTask_DDA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFill_DDA;
        private System.Windows.Forms.Panel panelRight_DDA;
        private System.Windows.Forms.Panel panelLeft_DDA;
        private System.Windows.Forms.Panel panelTask_DDA;
        private System.Windows.Forms.GroupBox groupBoxVars_DDA;
        private System.Windows.Forms.GroupBox groupBoxTask_DDA;
        private System.Windows.Forms.Label labelTask_DDA;
        private System.Windows.Forms.TextBox textBoxColunumnsInPut_DDA;
        private System.Windows.Forms.TextBox textBoxRowsInPut_DDA;
        private System.Windows.Forms.Label labelColumns_DDA;
        private System.Windows.Forms.Label labelRows_DDA;
        private System.Windows.Forms.Label labelSize_DDA;
        private System.Windows.Forms.TextBox textBoxecondNumRandomInPut_DDA;
        private System.Windows.Forms.TextBox textBoxFirstNumRandomInput_DDA;
        private System.Windows.Forms.Label labelSecondNumRandom_DDA;
        private System.Windows.Forms.Label labelFirstNumRandom_DDA;
        private System.Windows.Forms.Label labelGenerationSize_DDA;
        private System.Windows.Forms.TextBox textBoxlabelNumsDown_DAA;
        private System.Windows.Forms.TextBox textBoxNumsUp_DAA;
        private System.Windows.Forms.Label labelNumsDown_DAA;
        private System.Windows.Forms.Label labelNumsUp_DAA;
        private System.Windows.Forms.Label labelNumsInMatrix_DDA;
        private System.Windows.Forms.GroupBox groupBoxArray_DDA;
        private System.Windows.Forms.DataGridView dataGridViewArray_DDA;
        private System.Windows.Forms.GroupBox groupBoxResult_DDA;
        private System.Windows.Forms.TextBox textBoxResult_DDA;
        private System.Windows.Forms.Label labelResult_DDA;
        private System.Windows.Forms.Button buttonDone_DDA;
        private System.Windows.Forms.Button buttonCreateArray_DDA;
        private System.Windows.Forms.TextBox textBoxtextBoxRowAmount_DDA;
        private System.Windows.Forms.Label labeltextBoxRowAmount_DDA;
        private System.Windows.Forms.Button buttonHelp_DDA;
    }
}

