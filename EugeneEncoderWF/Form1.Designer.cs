namespace EugeneEncoderWF
{
    partial class EugeneEncoder
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
            this.InputLabel = new System.Windows.Forms.Label();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.InputTextBox = new System.Windows.Forms.TextBox();
            this.OutputTextBox = new System.Windows.Forms.TextBox();
            this.EncodeButton = new System.Windows.Forms.Button();
            this.EncodingsList = new System.Windows.Forms.ComboBox();
            this.DecodeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InputLabel
            // 
            this.InputLabel.AutoSize = true;
            this.InputLabel.Location = new System.Drawing.Point(13, 13);
            this.InputLabel.Name = "InputLabel";
            this.InputLabel.Size = new System.Drawing.Size(34, 13);
            this.InputLabel.TabIndex = 0;
            this.InputLabel.Text = "Input:";
            // 
            // OutputLabel
            // 
            this.OutputLabel.AutoSize = true;
            this.OutputLabel.Location = new System.Drawing.Point(286, 13);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(42, 13);
            this.OutputLabel.TabIndex = 1;
            this.OutputLabel.Text = "Output:";
            // 
            // InputTextBox
            // 
            this.InputTextBox.Location = new System.Drawing.Point(16, 46);
            this.InputTextBox.Multiline = true;
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(207, 78);
            this.InputTextBox.TabIndex = 2;
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.Location = new System.Drawing.Point(289, 46);
            this.OutputTextBox.Multiline = true;
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.Size = new System.Drawing.Size(207, 78);
            this.OutputTextBox.TabIndex = 3;
            // 
            // EncodeButton
            // 
            this.EncodeButton.Location = new System.Drawing.Point(16, 188);
            this.EncodeButton.Name = "EncodeButton";
            this.EncodeButton.Size = new System.Drawing.Size(207, 23);
            this.EncodeButton.TabIndex = 4;
            this.EncodeButton.Text = "Encode";
            this.EncodeButton.UseVisualStyleBackColor = true;
            this.EncodeButton.Click += new System.EventHandler(this.EncodeButton_Click);
            // 
            // EncodingsList
            // 
            this.EncodingsList.FormattingEnabled = true;
            this.EncodingsList.Items.AddRange(new object[] {
            "Ceaser\'s Code"});
            this.EncodingsList.Location = new System.Drawing.Point(193, 140);
            this.EncodingsList.Name = "EncodingsList";
            this.EncodingsList.Size = new System.Drawing.Size(121, 21);
            this.EncodingsList.TabIndex = 5;
            this.EncodingsList.Text = "Choose Encoding";
            // 
            // DecodeButton
            // 
            this.DecodeButton.Location = new System.Drawing.Point(289, 188);
            this.DecodeButton.Name = "DecodeButton";
            this.DecodeButton.Size = new System.Drawing.Size(207, 23);
            this.DecodeButton.TabIndex = 6;
            this.DecodeButton.Text = "Decode";
            this.DecodeButton.UseVisualStyleBackColor = true;
            this.DecodeButton.Click += new System.EventHandler(this.DecodeButton_Click);
            // 
            // EugeneEncoder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(540, 244);
            this.Controls.Add(this.DecodeButton);
            this.Controls.Add(this.EncodingsList);
            this.Controls.Add(this.EncodeButton);
            this.Controls.Add(this.OutputTextBox);
            this.Controls.Add(this.InputTextBox);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.InputLabel);
            this.MaximizeBox = false;
            this.Name = "EugeneEncoder";
            this.Text = "EugeneEncoder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InputLabel;
        private System.Windows.Forms.Label OutputLabel;
        private System.Windows.Forms.TextBox InputTextBox;
        private System.Windows.Forms.TextBox OutputTextBox;
        private System.Windows.Forms.Button EncodeButton;
        private System.Windows.Forms.ComboBox EncodingsList;
        private System.Windows.Forms.Button DecodeButton;
    }
}

