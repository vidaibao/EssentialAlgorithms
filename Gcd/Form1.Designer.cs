namespace Gcd
{
    partial class Form1
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
            this.lcmTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gcdTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.findGcdButton = new System.Windows.Forms.Button();
            this.number2TextBox = new System.Windows.Forms.TextBox();
            this.number1TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lcmTextBox
            // 
            this.lcmTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lcmTextBox.Location = new System.Drawing.Point(70, 85);
            this.lcmTextBox.Name = "lcmTextBox";
            this.lcmTextBox.Size = new System.Drawing.Size(206, 19);
            this.lcmTextBox.TabIndex = 15;
            this.lcmTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 12);
            this.label3.TabIndex = 14;
            this.label3.Text = "LCM:";
            // 
            // gcdTextBox
            // 
            this.gcdTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcdTextBox.Location = new System.Drawing.Point(70, 61);
            this.gcdTextBox.Name = "gcdTextBox";
            this.gcdTextBox.Size = new System.Drawing.Size(206, 19);
            this.gcdTextBox.TabIndex = 13;
            this.gcdTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "GCD:";
            // 
            // findGcdButton
            // 
            this.findGcdButton.Location = new System.Drawing.Point(107, 34);
            this.findGcdButton.Name = "findGcdButton";
            this.findGcdButton.Size = new System.Drawing.Size(75, 21);
            this.findGcdButton.TabIndex = 11;
            this.findGcdButton.Text = "Find GCD";
            this.findGcdButton.UseVisualStyleBackColor = true;
            this.findGcdButton.Click += new System.EventHandler(this.findGcdButton_Click);
            // 
            // number2TextBox
            // 
            this.number2TextBox.Location = new System.Drawing.Point(176, 10);
            this.number2TextBox.Name = "number2TextBox";
            this.number2TextBox.Size = new System.Drawing.Size(100, 19);
            this.number2TextBox.TabIndex = 10;
            this.number2TextBox.Text = "45";
            this.number2TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // number1TextBox
            // 
            this.number1TextBox.Location = new System.Drawing.Point(70, 10);
            this.number1TextBox.Name = "number1TextBox";
            this.number1TextBox.Size = new System.Drawing.Size(100, 19);
            this.number1TextBox.TabIndex = 9;
            this.number1TextBox.Text = "60";
            this.number1TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "Numbers:";
            // 
            // Form1
            // 
            this.AcceptButton = this.findGcdButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 114);
            this.Controls.Add(this.lcmTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gcdTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.findGcdButton);
            this.Controls.Add(this.number2TextBox);
            this.Controls.Add(this.number1TextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gcd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lcmTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox gcdTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button findGcdButton;
        private System.Windows.Forms.TextBox number2TextBox;
        private System.Windows.Forms.TextBox number1TextBox;
        private System.Windows.Forms.Label label1;
    }
}

