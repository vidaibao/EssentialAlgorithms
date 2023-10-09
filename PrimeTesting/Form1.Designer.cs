namespace PrimeTesting
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
            this.findPrimeButton = new System.Windows.Forms.Button();
            this.factorsTextBox = new System.Windows.Forms.TextBox();
            this.isPrimeTextBox = new System.Windows.Forms.TextBox();
            this.factorButton = new System.Windows.Forms.Button();
            this.isPrimeButton = new System.Windows.Forms.Button();
            this.randomButton = new System.Windows.Forms.Button();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // findPrimeButton
            // 
            this.findPrimeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.findPrimeButton.Location = new System.Drawing.Point(292, 9);
            this.findPrimeButton.Name = "findPrimeButton";
            this.findPrimeButton.Size = new System.Drawing.Size(75, 21);
            this.findPrimeButton.TabIndex = 16;
            this.findPrimeButton.Text = "Find Prime";
            this.findPrimeButton.UseVisualStyleBackColor = true;
            this.findPrimeButton.Click += new System.EventHandler(this.findPrimeButton_Click);
            // 
            // factorsTextBox
            // 
            this.factorsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.factorsTextBox.Location = new System.Drawing.Point(93, 79);
            this.factorsTextBox.Name = "factorsTextBox";
            this.factorsTextBox.ReadOnly = true;
            this.factorsTextBox.Size = new System.Drawing.Size(274, 19);
            this.factorsTextBox.TabIndex = 15;
            // 
            // isPrimeTextBox
            // 
            this.isPrimeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.isPrimeTextBox.Location = new System.Drawing.Point(93, 53);
            this.isPrimeTextBox.Name = "isPrimeTextBox";
            this.isPrimeTextBox.ReadOnly = true;
            this.isPrimeTextBox.Size = new System.Drawing.Size(274, 19);
            this.isPrimeTextBox.TabIndex = 14;
            // 
            // factorButton
            // 
            this.factorButton.Location = new System.Drawing.Point(12, 78);
            this.factorButton.Name = "factorButton";
            this.factorButton.Size = new System.Drawing.Size(75, 21);
            this.factorButton.TabIndex = 13;
            this.factorButton.Text = "Factor";
            this.factorButton.UseVisualStyleBackColor = true;
            this.factorButton.Click += new System.EventHandler(this.factorButton_Click);
            // 
            // isPrimeButton
            // 
            this.isPrimeButton.Location = new System.Drawing.Point(12, 51);
            this.isPrimeButton.Name = "isPrimeButton";
            this.isPrimeButton.Size = new System.Drawing.Size(75, 21);
            this.isPrimeButton.TabIndex = 12;
            this.isPrimeButton.Text = "Is Prime?";
            this.isPrimeButton.UseVisualStyleBackColor = true;
            this.isPrimeButton.Click += new System.EventHandler(this.isPrimeButton_Click);
            // 
            // randomButton
            // 
            this.randomButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.randomButton.Location = new System.Drawing.Point(211, 10);
            this.randomButton.Name = "randomButton";
            this.randomButton.Size = new System.Drawing.Size(75, 21);
            this.randomButton.TabIndex = 11;
            this.randomButton.Text = "Random";
            this.randomButton.UseVisualStyleBackColor = true;
            this.randomButton.Click += new System.EventHandler(this.randomButton_Click);
            // 
            // numberTextBox
            // 
            this.numberTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numberTextBox.Location = new System.Drawing.Point(65, 12);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(140, 19);
            this.numberTextBox.TabIndex = 10;
            this.numberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numberTextBox.TextChanged += new System.EventHandler(this.numberTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "Number:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 108);
            this.Controls.Add(this.findPrimeButton);
            this.Controls.Add(this.factorsTextBox);
            this.Controls.Add(this.isPrimeTextBox);
            this.Controls.Add(this.factorButton);
            this.Controls.Add(this.isPrimeButton);
            this.Controls.Add(this.randomButton);
            this.Controls.Add(this.numberTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrimeTesting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button findPrimeButton;
        private System.Windows.Forms.TextBox factorsTextBox;
        private System.Windows.Forms.TextBox isPrimeTextBox;
        private System.Windows.Forms.Button factorButton;
        private System.Windows.Forms.Button isPrimeButton;
        private System.Windows.Forms.Button randomButton;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.Label label1;
    }
}

