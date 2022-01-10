namespace lab2_if
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
            this.txtStartSum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtStartSum
            // 
            this.txtStartSum.Location = new System.Drawing.Point(417, 62);
            this.txtStartSum.Name = "txtStartSum";
            this.txtStartSum.Size = new System.Drawing.Size(244, 39);
            this.txtStartSum.TabIndex = 0;
            this.txtStartSum.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Введите стоимость (в копейках):";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(622, 76);
            this.button1.TabIndex = 4;
            this.button1.Text = "Конвертировать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 276);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStartSum);
            this.Name = "Form1";
            this.Text = "Конвертер валюты";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtStartSum;
        private Label label1;
        private Button button1;
    }
}