namespace Lab3Start
{
    partial class Lab3Params
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
            this.label1 = new System.Windows.Forms.Label();
            this.beginNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.endNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.countNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.startButton = new System.Windows.Forms.Button();
            this.showNumbersCheckBox = new System.Windows.Forms.CheckBox();
            this.createLogFileCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.beginNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Диапазон";
            // 
            // beginNumericUpDown
            // 
            this.beginNumericUpDown.Location = new System.Drawing.Point(65, 20);
            this.beginNumericUpDown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.beginNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.beginNumericUpDown.Name = "beginNumericUpDown";
            this.beginNumericUpDown.Size = new System.Drawing.Size(64, 20);
            this.beginNumericUpDown.TabIndex = 1;
            this.beginNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "-";
            // 
            // endNumericUpDown
            // 
            this.endNumericUpDown.Location = new System.Drawing.Point(148, 21);
            this.endNumericUpDown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.endNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.endNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.endNumericUpDown.Name = "endNumericUpDown";
            this.endNumericUpDown.Size = new System.Drawing.Size(55, 20);
            this.endNumericUpDown.TabIndex = 3;
            this.endNumericUpDown.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 54);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Кол-во";
            // 
            // countNumericUpDown
            // 
            this.countNumericUpDown.Location = new System.Drawing.Point(65, 54);
            this.countNumericUpDown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.countNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.countNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.countNumericUpDown.Name = "countNumericUpDown";
            this.countNumericUpDown.Size = new System.Drawing.Size(64, 20);
            this.countNumericUpDown.TabIndex = 5;
            this.countNumericUpDown.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(74, 144);
            this.startButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(102, 28);
            this.startButton.TabIndex = 6;
            this.startButton.Text = "Старт";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // showNumbersCheckBox
            // 
            this.showNumbersCheckBox.AutoSize = true;
            this.showNumbersCheckBox.Location = new System.Drawing.Point(13, 87);
            this.showNumbersCheckBox.Name = "showNumbersCheckBox";
            this.showNumbersCheckBox.Size = new System.Drawing.Size(107, 17);
            this.showNumbersCheckBox.TabIndex = 7;
            this.showNumbersCheckBox.Text = "Показать числа";
            this.showNumbersCheckBox.UseVisualStyleBackColor = true;
            // 
            // createLogFileCheckBox
            // 
            this.createLogFileCheckBox.AutoSize = true;
            this.createLogFileCheckBox.Location = new System.Drawing.Point(13, 111);
            this.createLogFileCheckBox.Name = "createLogFileCheckBox";
            this.createLogFileCheckBox.Size = new System.Drawing.Size(117, 17);
            this.createLogFileCheckBox.TabIndex = 8;
            this.createLogFileCheckBox.Text = "Создать лог файл";
            this.createLogFileCheckBox.UseVisualStyleBackColor = true;
            // 
            // Lab3Params
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 195);
            this.Controls.Add(this.createLogFileCheckBox);
            this.Controls.Add(this.showNumbersCheckBox);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.countNumericUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.endNumericUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.beginNumericUpDown);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Lab3Params";
            this.Text = "Параметры";
            ((System.ComponentModel.ISupportInitialize)(this.beginNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown beginNumericUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown endNumericUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown countNumericUpDown;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.CheckBox showNumbersCheckBox;
        private System.Windows.Forms.CheckBox createLogFileCheckBox;
    }
}

