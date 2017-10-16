namespace WindowsFormsApplication2
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
            this.inputText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.firstOrderOutput = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.secondOrderOutput = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.thirdOrderOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "LowpassFiter Lab";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inputText
            // 
            this.inputText.Location = new System.Drawing.Point(18, 127);
            this.inputText.Name = "inputText";
            this.inputText.Size = new System.Drawing.Size(100, 36);
            this.inputText.TabIndex = 1;
            this.inputText.Text = "10";
            this.inputText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter the input value:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Result:";
            // 
            // calculateBtn
            // 
            this.calculateBtn.Location = new System.Drawing.Point(150, 122);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(67, 41);
            this.calculateBtn.TabIndex = 4;
            this.calculateBtn.Text = "Go";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // firstOrderOutput
            // 
            this.firstOrderOutput.AutoSize = true;
            this.firstOrderOutput.Location = new System.Drawing.Point(172, 258);
            this.firstOrderOutput.Name = "firstOrderOutput";
            this.firstOrderOutput.Size = new System.Drawing.Size(21, 24);
            this.firstOrderOutput.TabIndex = 5;
            this.firstOrderOutput.Text = "0";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("PMingLiU", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(456, 382);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "by Jeremy, 9/26/2017";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "1 Order:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 24);
            this.label6.TabIndex = 8;
            this.label6.Text = "2 Order:";
            // 
            // secondOrderOutput
            // 
            this.secondOrderOutput.AutoSize = true;
            this.secondOrderOutput.Location = new System.Drawing.Point(172, 295);
            this.secondOrderOutput.Name = "secondOrderOutput";
            this.secondOrderOutput.Size = new System.Drawing.Size(21, 24);
            this.secondOrderOutput.TabIndex = 9;
            this.secondOrderOutput.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 333);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 24);
            this.label7.TabIndex = 10;
            this.label7.Text = "3 Order:";
            // 
            // thirdOrderOutput
            // 
            this.thirdOrderOutput.AutoSize = true;
            this.thirdOrderOutput.Location = new System.Drawing.Point(172, 333);
            this.thirdOrderOutput.Name = "thirdOrderOutput";
            this.thirdOrderOutput.Size = new System.Drawing.Size(21, 24);
            this.thirdOrderOutput.TabIndex = 11;
            this.thirdOrderOutput.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 412);
            this.Controls.Add(this.thirdOrderOutput);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.secondOrderOutput);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.firstOrderOutput);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputText);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.Label firstOrderOutput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label secondOrderOutput;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label thirdOrderOutput;
    }
}

