namespace CalculatorPractice
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
            this.TxtBox1 = new System.Windows.Forms.TextBox();
            this.TxtBox2 = new System.Windows.Forms.TextBox();
            this.AnsText = new System.Windows.Forms.TextBox();
            this.Num1 = new System.Windows.Forms.Label();
            this.Num2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Addition = new System.Windows.Forms.Button();
            this.Sub = new System.Windows.Forms.Button();
            this.Mul = new System.Windows.Forms.Button();
            this.Divide = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtBox1
            // 
            this.TxtBox1.Location = new System.Drawing.Point(130, 135);
            this.TxtBox1.Multiline = true;
            this.TxtBox1.Name = "TxtBox1";
            this.TxtBox1.Size = new System.Drawing.Size(100, 22);
            this.TxtBox1.TabIndex = 0;
            this.TxtBox1.TextChanged += new System.EventHandler(this.TxtBox1_TextChanged);
            // 
            // TxtBox2
            // 
            this.TxtBox2.Location = new System.Drawing.Point(286, 135);
            this.TxtBox2.Multiline = true;
            this.TxtBox2.Name = "TxtBox2";
            this.TxtBox2.Size = new System.Drawing.Size(100, 22);
            this.TxtBox2.TabIndex = 1;
            // 
            // AnsText
            // 
            this.AnsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnsText.Location = new System.Drawing.Point(438, 135);
            this.AnsText.Multiline = true;
            this.AnsText.Name = "AnsText";
            this.AnsText.Size = new System.Drawing.Size(100, 22);
            this.AnsText.TabIndex = 2;
            // 
            // Num1
            // 
            this.Num1.AutoSize = true;
            this.Num1.Location = new System.Drawing.Point(156, 97);
            this.Num1.Name = "Num1";
            this.Num1.Size = new System.Drawing.Size(42, 16);
            this.Num1.TabIndex = 3;
            this.Num1.Text = "Num1";
            // 
            // Num2
            // 
            this.Num2.AutoSize = true;
            this.Num2.Location = new System.Drawing.Point(312, 97);
            this.Num2.Name = "Num2";
            this.Num2.Size = new System.Drawing.Size(42, 16);
            this.Num2.TabIndex = 4;
            this.Num2.Text = "Num2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(466, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ans";
            // 
            // Addition
            // 
            this.Addition.Location = new System.Drawing.Point(139, 209);
            this.Addition.Name = "Addition";
            this.Addition.Size = new System.Drawing.Size(91, 44);
            this.Addition.TabIndex = 6;
            this.Addition.Text = "Add";
            this.Addition.UseVisualStyleBackColor = true;
            this.Addition.Click += new System.EventHandler(this.Addition_Click);
            // 
            // Sub
            // 
            this.Sub.Location = new System.Drawing.Point(295, 209);
            this.Sub.Name = "Sub";
            this.Sub.Size = new System.Drawing.Size(91, 44);
            this.Sub.TabIndex = 7;
            this.Sub.Text = "Subtract";
            this.Sub.UseVisualStyleBackColor = true;
            this.Sub.Click += new System.EventHandler(this.Sub_Click);
            // 
            // Mul
            // 
            this.Mul.Location = new System.Drawing.Point(139, 278);
            this.Mul.Name = "Mul";
            this.Mul.Size = new System.Drawing.Size(91, 42);
            this.Mul.TabIndex = 8;
            this.Mul.Text = "Multiply";
            this.Mul.UseVisualStyleBackColor = true;
            this.Mul.Click += new System.EventHandler(this.Mul_Click);
            // 
            // Divide
            // 
            this.Divide.Location = new System.Drawing.Point(295, 278);
            this.Divide.Name = "Divide";
            this.Divide.Size = new System.Drawing.Size(91, 42);
            this.Divide.TabIndex = 9;
            this.Divide.Text = "Div";
            this.Divide.UseVisualStyleBackColor = true;
            this.Divide.Click += new System.EventHandler(this.Divide_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(438, 209);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(100, 44);
            this.ClearBtn.TabIndex = 10;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(438, 278);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(100, 44);
            this.Close.TabIndex = 11;
            this.Close.Text = "Exit";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.Divide);
            this.Controls.Add(this.Mul);
            this.Controls.Add(this.Sub);
            this.Controls.Add(this.Addition);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Num2);
            this.Controls.Add(this.Num1);
            this.Controls.Add(this.AnsText);
            this.Controls.Add(this.TxtBox2);
            this.Controls.Add(this.TxtBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtBox1;
        private System.Windows.Forms.TextBox TxtBox2;
        private System.Windows.Forms.TextBox AnsText;
        private System.Windows.Forms.Label Num1;
        private System.Windows.Forms.Label Num2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Addition;
        private System.Windows.Forms.Button Sub;
        private System.Windows.Forms.Button Mul;
        private System.Windows.Forms.Button Divide;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button Close;
    }
}

