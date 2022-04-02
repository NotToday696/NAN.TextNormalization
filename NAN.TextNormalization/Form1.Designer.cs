namespace NAN.TextNormalization
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
            this.SourceTextBox = new System.Windows.Forms.RichTextBox();
            this.TransfomationTextBox = new System.Windows.Forms.RichTextBox();
            this.SourceText = new System.Windows.Forms.Label();
            this.TransformationText = new System.Windows.Forms.Label();
            this.OpenButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // SourceTextBox
            // 
            this.SourceTextBox.Location = new System.Drawing.Point(18, 47);
            this.SourceTextBox.Name = "SourceTextBox";
            this.SourceTextBox.ReadOnly = true;
            this.SourceTextBox.Size = new System.Drawing.Size(410, 120);
            this.SourceTextBox.TabIndex = 0;
            this.SourceTextBox.Text = "";
            // 
            // TransfomationTextBox
            // 
            this.TransfomationTextBox.Location = new System.Drawing.Point(18, 219);
            this.TransfomationTextBox.Name = "TransfomationTextBox";
            this.TransfomationTextBox.ReadOnly = true;
            this.TransfomationTextBox.Size = new System.Drawing.Size(410, 120);
            this.TransfomationTextBox.TabIndex = 1;
            this.TransfomationTextBox.Text = "";
            // 
            // SourceText
            // 
            this.SourceText.AutoSize = true;
            this.SourceText.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SourceText.ForeColor = System.Drawing.Color.Green;
            this.SourceText.Location = new System.Drawing.Point(12, 9);
            this.SourceText.Name = "SourceText";
            this.SourceText.Size = new System.Drawing.Size(230, 35);
            this.SourceText.TabIndex = 2;
            this.SourceText.Text = "Исходный текст:";
            // 
            // TransformationText
            // 
            this.TransformationText.AutoSize = true;
            this.TransformationText.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TransformationText.ForeColor = System.Drawing.Color.Red;
            this.TransformationText.Location = new System.Drawing.Point(12, 181);
            this.TransformationText.Name = "TransformationText";
            this.TransformationText.Size = new System.Drawing.Size(319, 35);
            this.TransformationText.TabIndex = 3;
            this.TransformationText.Text = "Преобазованный текст:";
            // 
            // OpenButton
            // 
            this.OpenButton.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.OpenButton.Location = new System.Drawing.Point(18, 367);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(180, 71);
            this.OpenButton.TabIndex = 4;
            this.OpenButton.Text = "Открыть файл";
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.SaveButton.Location = new System.Drawing.Point(248, 367);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(180, 71);
            this.SaveButton.TabIndex = 5;
            this.SaveButton.Text = "Сохранить файл";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 450);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.OpenButton);
            this.Controls.Add(this.TransformationText);
            this.Controls.Add(this.SourceText);
            this.Controls.Add(this.TransfomationTextBox);
            this.Controls.Add(this.SourceTextBox);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Text Normalization by NAN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox SourceTextBox;
        private System.Windows.Forms.RichTextBox TransfomationTextBox;
        private System.Windows.Forms.Label SourceText;
        private System.Windows.Forms.Label TransformationText;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

