using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.DeminDA.Sprint6.Review.V4.Lib;  

namespace Tyuiu.DeminDA.Sprint6.Review.V4
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        public int row = 0;
        public int col = 0;
        public int r1 = 0, r2 = 0;
        public int[,] MyArray;

        private void panelTask_DDA_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            textBoxNumsUp_DAA.Enabled = false;
            textBoxlabelNumsDown_DAA.Enabled = false;
            textBoxtextBoxRowAmount_DDA.Enabled = false;
            buttonDone_DDA.Enabled = false;
        }

        private void buttonCreateArray_DDA_Click(object sender, EventArgs e)
        {
            try
            {
                DataService ds = new DataService();
                int row = Convert.ToInt32(textBoxRowsInPut_DDA.Text), col = Convert.ToInt32(textBoxColunumnsInPut_DDA.Text);
                int r1 = Convert.ToInt32(textBoxFirstNumRandomInput_DDA.Text), r2 = Convert.ToInt32(textBoxecondNumRandomInPut_DDA.Text);
                int[,] array = new int[row, col];

                MyArray = ds.GetMatrix(row, col, r1, r2);

                dataGridViewArray_DDA.RowCount = row;
                dataGridViewArray_DDA.ColumnCount = col;

                for (int i = 0; i < col; i++)
                {
                    dataGridViewArray_DDA.Columns[i].Width = 50;
                }

                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        dataGridViewArray_DDA.Rows[i].Cells[j].Value = Convert.ToString(MyArray[i, j]);
                    }
                }
                textBoxNumsUp_DAA.Enabled = true;
                textBoxlabelNumsDown_DAA.Enabled = true;
                textBoxtextBoxRowAmount_DDA.Enabled = true;
                buttonDone_DDA.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_DDA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Автор:Дёмин Денис Александрович\nГруппа ИИПб -23-2\nСприн т6 Ревью Вариант 4", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonDone_DDA_Click(object sender, EventArgs e)
        {
            try
            {
                DataService ds = new DataService();
                int First = Convert.ToInt32(textBoxNumsUp_DAA.Text);
                int Second = Convert.ToInt32(textBoxlabelNumsDown_DAA.Text);
                int MyC = Convert.ToInt32(textBoxtextBoxRowAmount_DDA.Text);

                int MyAnswer = ds.Result(MyArray, MyC, First, Second);

                textBoxResult_DDA.Text = Convert.ToString(MyAnswer);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
