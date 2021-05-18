
namespace Conversao
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Celsius1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Fahrenheit1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Fahrenheit2 = new System.Windows.Forms.TextBox();
            this.Celsius2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Celsius1
            // 
            this.Celsius1.Font = new System.Drawing.Font("Segoe UI", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Celsius1.Location = new System.Drawing.Point(12, 12);
            this.Celsius1.Name = "Celsius1";
            this.Celsius1.Size = new System.Drawing.Size(167, 55);
            this.Celsius1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(185, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 24);
            this.button1.TabIndex = 1;
            this.button1.Text = "converter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Celsius";
            // 
            // Fahrenheit1
            // 
            this.Fahrenheit1.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Fahrenheit1.Location = new System.Drawing.Point(258, 12);
            this.Fahrenheit1.Name = "Fahrenheit1";
            this.Fahrenheit1.ReadOnly = true;
            this.Fahrenheit1.Size = new System.Drawing.Size(167, 57);
            this.Fahrenheit1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(310, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fahrenheit";
            // 
            // Fahrenheit2
            // 
            this.Fahrenheit2.Font = new System.Drawing.Font("Segoe UI", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Fahrenheit2.Location = new System.Drawing.Point(12, 121);
            this.Fahrenheit2.Name = "Fahrenheit2";
            this.Fahrenheit2.Size = new System.Drawing.Size(167, 55);
            this.Fahrenheit2.TabIndex = 5;
            // 
            // Celsius2
            // 
            this.Celsius2.Font = new System.Drawing.Font("Segoe UI", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Celsius2.Location = new System.Drawing.Point(258, 121);
            this.Celsius2.Name = "Celsius2";
            this.Celsius2.ReadOnly = true;
            this.Celsius2.Size = new System.Drawing.Size(167, 55);
            this.Celsius2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(320, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Celsius";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Fahrenheit";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(185, 136);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 24);
            this.button2.TabIndex = 9;
            this.button2.Text = "converter";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 206);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Celsius2);
            this.Controls.Add(this.Fahrenheit2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Fahrenheit1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Celsius1);
            this.Name = "Form1";
            this.Text = "Conversão";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Celsius1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Fahrenheit1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Fahrenheit2;
        private System.Windows.Forms.TextBox Celsius2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
    }
}

