namespace Calculator
{
    partial class MainForm
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
            this.previousInputLabel = new System.Windows.Forms.Label();
            this.currentInputTextBox = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.cleanButton = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.resultButton = new System.Windows.Forms.Button();
            this.divideButton = new System.Windows.Forms.Button();
            this.multiplyButton = new System.Windows.Forms.Button();
            this.minusButton = new System.Windows.Forms.Button();
            this.plusButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // previousInputLabel
            // 
            this.previousInputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.previousInputLabel.Location = new System.Drawing.Point(12, 9);
            this.previousInputLabel.Name = "previousInputLabel";
            this.previousInputLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.previousInputLabel.Size = new System.Drawing.Size(428, 23);
            this.previousInputLabel.TabIndex = 0;
            this.previousInputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // currentInputTextBox
            // 
            this.currentInputTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.currentInputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentInputTextBox.Location = new System.Drawing.Point(12, 39);
            this.currentInputTextBox.Name = "currentInputTextBox";
            this.currentInputTextBox.ReadOnly = true;
            this.currentInputTextBox.Size = new System.Drawing.Size(428, 26);
            this.currentInputTextBox.TabIndex = 0;
            this.currentInputTextBox.TabStop = false;
            this.currentInputTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.currentInputTextBox.TextChanged += new System.EventHandler(this.CurrentInputTextBox_TextChanged);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(12, 71);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(103, 49);
            this.button7.TabIndex = 14;
            this.button7.TabStop = false;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.DigitButton_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button8.Location = new System.Drawing.Point(121, 71);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(103, 49);
            this.button8.TabIndex = 15;
            this.button8.TabStop = false;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.DigitButton_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button9.Location = new System.Drawing.Point(230, 71);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(103, 49);
            this.button9.TabIndex = 16;
            this.button9.TabStop = false;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.DigitButton_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(12, 126);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(103, 49);
            this.button4.TabIndex = 11;
            this.button4.TabStop = false;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.DigitButton_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(121, 126);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(103, 49);
            this.button5.TabIndex = 12;
            this.button5.TabStop = false;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.DigitButton_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(230, 126);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(103, 49);
            this.button6.TabIndex = 13;
            this.button6.TabStop = false;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.DigitButton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(12, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 49);
            this.button1.TabIndex = 8;
            this.button1.TabStop = false;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.DigitButton_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(121, 181);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 49);
            this.button2.TabIndex = 9;
            this.button2.TabStop = false;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.DigitButton_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(230, 181);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 49);
            this.button3.TabIndex = 10;
            this.button3.TabStop = false;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.DigitButton_Click);
            // 
            // cleanButton
            // 
            this.cleanButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cleanButton.Location = new System.Drawing.Point(12, 235);
            this.cleanButton.Name = "cleanButton";
            this.cleanButton.Size = new System.Drawing.Size(103, 49);
            this.cleanButton.TabIndex = 6;
            this.cleanButton.TabStop = false;
            this.cleanButton.Text = "CE";
            this.cleanButton.UseVisualStyleBackColor = true;
            this.cleanButton.Click += new System.EventHandler(this.CleanButton_Click);
            // 
            // button0
            // 
            this.button0.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button0.Location = new System.Drawing.Point(121, 235);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(103, 49);
            this.button0.TabIndex = 7;
            this.button0.TabStop = false;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.DigitButton_Click);
            // 
            // resultButton
            // 
            this.resultButton.Enabled = false;
            this.resultButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultButton.Location = new System.Drawing.Point(230, 235);
            this.resultButton.Name = "resultButton";
            this.resultButton.Size = new System.Drawing.Size(103, 49);
            this.resultButton.TabIndex = 5;
            this.resultButton.TabStop = false;
            this.resultButton.Text = "=";
            this.resultButton.UseVisualStyleBackColor = true;
            this.resultButton.Click += new System.EventHandler(this.ResultButton_Click);
            // 
            // divideButton
            // 
            this.divideButton.Enabled = false;
            this.divideButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.divideButton.Location = new System.Drawing.Point(339, 71);
            this.divideButton.Name = "divideButton";
            this.divideButton.Size = new System.Drawing.Size(103, 49);
            this.divideButton.TabIndex = 1;
            this.divideButton.TabStop = false;
            this.divideButton.Text = "/";
            this.divideButton.UseVisualStyleBackColor = true;
            this.divideButton.Click += new System.EventHandler(this.OperationButton_Click);
            // 
            // multiplyButton
            // 
            this.multiplyButton.Enabled = false;
            this.multiplyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.multiplyButton.Location = new System.Drawing.Point(339, 126);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Size = new System.Drawing.Size(103, 49);
            this.multiplyButton.TabIndex = 2;
            this.multiplyButton.TabStop = false;
            this.multiplyButton.Text = "*";
            this.multiplyButton.UseVisualStyleBackColor = true;
            this.multiplyButton.Click += new System.EventHandler(this.OperationButton_Click);
            // 
            // minusButton
            // 
            this.minusButton.Enabled = false;
            this.minusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minusButton.Location = new System.Drawing.Point(337, 181);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(103, 49);
            this.minusButton.TabIndex = 3;
            this.minusButton.TabStop = false;
            this.minusButton.Text = "-";
            this.minusButton.UseVisualStyleBackColor = true;
            this.minusButton.Click += new System.EventHandler(this.OperationButton_Click);
            // 
            // plusButton
            // 
            this.plusButton.Enabled = false;
            this.plusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.plusButton.Location = new System.Drawing.Point(337, 235);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(103, 49);
            this.plusButton.TabIndex = 4;
            this.plusButton.TabStop = false;
            this.plusButton.Text = "+";
            this.plusButton.UseVisualStyleBackColor = true;
            this.plusButton.Click += new System.EventHandler(this.OperationButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 296);
            this.Controls.Add(this.plusButton);
            this.Controls.Add(this.minusButton);
            this.Controls.Add(this.multiplyButton);
            this.Controls.Add(this.divideButton);
            this.Controls.Add(this.resultButton);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.cleanButton);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.currentInputTextBox);
            this.Controls.Add(this.previousInputLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainForm_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label previousInputLabel;
        private System.Windows.Forms.TextBox currentInputTextBox;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button cleanButton;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button resultButton;
        private System.Windows.Forms.Button divideButton;
        private System.Windows.Forms.Button multiplyButton;
        private System.Windows.Forms.Button minusButton;
        private System.Windows.Forms.Button plusButton;
    }
}

