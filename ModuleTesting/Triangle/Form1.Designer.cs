namespace TriangleBuilder
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
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            numericUpDown3 = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            resultLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            SuspendLayout();
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(214, 79);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 0;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(214, 134);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(120, 23);
            numericUpDown2.TabIndex = 1;
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(214, 195);
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(120, 23);
            numericUpDown3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(133, 35);
            label1.Name = "label1";
            label1.Size = new Size(201, 15);
            label1.TabIndex = 3;
            label1.Text = "Введіть довжини сторін трикутника";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(138, 83);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 4;
            label2.Text = "Сторона А:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(138, 203);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 5;
            label3.Text = "Сторона С:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(138, 142);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 6;
            label4.Text = "Сторона В:";
            // 
            // button1
            // 
            button1.Location = new Point(177, 255);
            button1.Name = "button1";
            button1.Size = new Size(129, 29);
            button1.TabIndex = 7;
            button1.Text = "Створити";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // resultLabel
            // 
            resultLabel.Anchor = AnchorStyles.Left;
            resultLabel.AutoSize = true;
            resultLabel.Location = new Point(110, 316);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(0, 15);
            resultLabel.TabIndex = 8;
            resultLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(484, 361);
            Controls.Add(resultLabel);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(numericUpDown3);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            MaximumSize = new Size(500, 400);
            MinimumSize = new Size(500, 400);
            Name = "Form1";
            Padding = new Padding(20, 0, 0, 0);
            Text = "TriangleBuilder";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Label resultLabel;
    }
}