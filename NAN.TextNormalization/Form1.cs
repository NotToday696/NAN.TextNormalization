using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NAN.TextNormalization
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            openFileDialog1.Filter = "Unicode files(*.utf-8)|*.utf-8";
            saveFileDialog1.Filter = "Unicode files(*.utf-8)|*.utf-8";
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Converted convert = new Converted();
                SourceTextBox.Text = convert.Source(openFileDialog1.FileName);
                Transformation transformation = new Transformation();
                TransfomationTextBox.Text =transformation.Transform(convert.Convert(openFileDialog1.FileName));
            }
            else
            {
                MessageBox.Show("Вы не выбрали файл!", "Ошибка");
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, TransfomationTextBox.Text);
                MessageBox.Show("Файл сохранен!", "Уведомление");
            }
        }
    }
}
