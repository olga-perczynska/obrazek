namespace branchowanie
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
            button1 = new Button();
            pictureBox1 = new PictureBox();
            bRotate = new Button();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            bInvert = new Button();
            bUpDo = new Button();
            bGreen = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(60, 428);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(111, 35);
            button1.TabIndex = 0;
            button1.Text = "Load";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(237, 49);
            pictureBox1.Margin = new Padding(2, 2, 2, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(357, 414);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // bRotate
            // 
            bRotate.Location = new Point(60, 55);
            bRotate.Margin = new Padding(2, 2, 2, 2);
            bRotate.Name = "bRotate";
            bRotate.Size = new Size(111, 35);
            bRotate.TabIndex = 2;
            bRotate.Text = "Rotate";
            bRotate.UseVisualStyleBackColor = true;
            bRotate.Click += bRotate_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(60, 107);
            radioButton1.Margin = new Padding(2, 2, 2, 2);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(57, 29);
            radioButton1.TabIndex = 3;
            radioButton1.TabStop = true;
            radioButton1.Text = "90";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(60, 138);
            radioButton2.Margin = new Padding(2, 2, 2, 2);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(67, 29);
            radioButton2.TabIndex = 4;
            radioButton2.TabStop = true;
            radioButton2.Text = "180";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(60, 170);
            radioButton3.Margin = new Padding(2, 2, 2, 2);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(67, 29);
            radioButton3.TabIndex = 5;
            radioButton3.TabStop = true;
            radioButton3.Text = "270";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // bInvert
            // 
            bInvert.Location = new Point(60, 229);
            bInvert.Margin = new Padding(2, 2, 2, 2);
            bInvert.Name = "bInvert";
            bInvert.Size = new Size(139, 35);
            bInvert.TabIndex = 6;
            bInvert.Text = "Invert colors";
            bInvert.UseVisualStyleBackColor = true;
            bInvert.Click += bInvert_Click;
            // 
            // bUpDo
            // 
            bUpDo.Location = new Point(60, 340);
            bUpDo.Margin = new Padding(2, 2, 2, 2);
            bUpDo.Name = "bUpDo";
            bUpDo.Size = new Size(139, 35);
            bUpDo.TabIndex = 7;
            bUpDo.Text = "Upside down";
            bUpDo.UseVisualStyleBackColor = true;
            bUpDo.Click += bUpDo_Click;
            // 
            // bGreen
            // 
            bGreen.Location = new Point(60, 282);
            bGreen.Margin = new Padding(2, 2, 2, 2);
            bGreen.Name = "bGreen";
            bGreen.Size = new Size(111, 35);
            bGreen.TabIndex = 2;
            bGreen.Text = "Only green";
            bGreen.UseVisualStyleBackColor = true;
            bGreen.Click += bGreen_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(641, 500);
            Controls.Add(bGreen);
            Controls.Add(bUpDo);
            Controls.Add(bInvert);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(bRotate);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private PictureBox pictureBox1;
        private Button bRotate;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private Button bInvert;
        private Button bUpDo;
        private Button bGreen;
    }
}
