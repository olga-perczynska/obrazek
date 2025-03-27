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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(102, 702);
            button1.Name = "button1";
            button1.Size = new Size(188, 58);
            button1.TabIndex = 0;
            button1.Text = "Load";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(403, 81);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(607, 679);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // bRotate
            // 
            bRotate.Location = new Point(102, 90);
            bRotate.Name = "bRotate";
            bRotate.Size = new Size(188, 58);
            bRotate.TabIndex = 2;
            bRotate.Text = "Rotate";
            bRotate.UseVisualStyleBackColor = true;
            bRotate.Click += bRotate_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(102, 176);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(87, 45);
            radioButton1.TabIndex = 3;
            radioButton1.TabStop = true;
            radioButton1.Text = "90";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(102, 227);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(103, 45);
            radioButton2.TabIndex = 4;
            radioButton2.TabStop = true;
            radioButton2.Text = "180";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(102, 278);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(103, 45);
            radioButton3.TabIndex = 5;
            radioButton3.TabStop = true;
            radioButton3.Text = "270";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // bInvert
            // 
            bInvert.Location = new Point(102, 375);
            bInvert.Name = "bInvert";
            bInvert.Size = new Size(236, 58);
            bInvert.TabIndex = 6;
            bInvert.Text = "Invert colors";
            bInvert.UseVisualStyleBackColor = true;
            bInvert.Click += bInvert_Click;
            // 
            // bUpDo
            // 
            bUpDo.Location = new Point(102, 471);
            bUpDo.Name = "bUpDo";
            bUpDo.Size = new Size(236, 58);
            bUpDo.TabIndex = 7;
            bUpDo.Text = "Upside down";
            bUpDo.UseVisualStyleBackColor = true;
            bUpDo.Click += bUpDo_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1089, 820);
            Controls.Add(bUpDo);
            Controls.Add(bInvert);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(bRotate);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
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
    }
}
