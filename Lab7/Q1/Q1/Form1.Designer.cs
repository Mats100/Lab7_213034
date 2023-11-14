namespace Q1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.num1 = new System.Windows.Forms.TextBox();
            this.num2 = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.substractButtton = new System.Windows.Forms.Button();
            this.multiplyButton = new System.Windows.Forms.Button();
            this.divideButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter 1st number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 109);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter 2nd number: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 189);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Result: ";
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(180, 34);
            this.num1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(148, 26);
            this.num1.TabIndex = 3;
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(180, 109);
            this.num2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(148, 26);
            this.num2.TabIndex = 4;
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(180, 186);
            this.result.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(148, 26);
            this.result.TabIndex = 5;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(13, 254);
            this.addButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(72, 51);
            this.addButton.TabIndex = 6;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // substractButtton
            // 
            this.substractButtton.Location = new System.Drawing.Point(113, 254);
            this.substractButtton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.substractButtton.Name = "substractButtton";
            this.substractButtton.Size = new System.Drawing.Size(96, 51);
            this.substractButtton.TabIndex = 7;
            this.substractButtton.Text = "Substract";
            this.substractButtton.UseVisualStyleBackColor = true;
            this.substractButtton.Click += new System.EventHandler(this.button2_Click);
            // 
            // multiplyButton
            // 
            this.multiplyButton.Location = new System.Drawing.Point(235, 255);
            this.multiplyButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Size = new System.Drawing.Size(93, 51);
            this.multiplyButton.TabIndex = 8;
            this.multiplyButton.Text = "Multiply";
            this.multiplyButton.UseVisualStyleBackColor = true;
            this.multiplyButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // divideButton
            // 
            this.divideButton.Location = new System.Drawing.Point(341, 254);
            this.divideButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.divideButton.Name = "divideButton";
            this.divideButton.Size = new System.Drawing.Size(72, 51);
            this.divideButton.TabIndex = 9;
            this.divideButton.Text = "Divide";
            this.divideButton.UseVisualStyleBackColor = true;
            this.divideButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 320);
            this.Controls.Add(this.divideButton);
            this.Controls.Add(this.multiplyButton);
            this.Controls.Add(this.substractButtton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.result);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox num1;
        private System.Windows.Forms.TextBox num2;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button substractButtton;
        private System.Windows.Forms.Button multiplyButton;
        private System.Windows.Forms.Button divideButton;
    }
}

