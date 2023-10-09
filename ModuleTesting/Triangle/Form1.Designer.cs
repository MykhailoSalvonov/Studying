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
            sizeA = new TextBox();
            sizeB = new TextBox();
            sizeC = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            createBtn = new Button();
            resultLabel = new Label();
            SuspendLayout();
            // 
            // sizeA
            // 
            sizeA.Location = new Point(214, 79);
            sizeA.Name = "sizeA";
            sizeA.Size = new Size(120, 23);
            sizeA.TabIndex = 0;
            sizeA.KeyPress += sizeA_KeyPress;
            // 
            // sizeB
            // 
            sizeB.Location = new Point(214, 134);
            sizeB.Name = "sizeB";
            sizeB.Size = new Size(120, 23);
            sizeB.TabIndex = 1;
            sizeB.KeyPress += sizeB_KeyPress;
            // 
            // sizeC
            // 
            sizeC.Location = new Point(214, 195);
            sizeC.Name = "sizeC";
            sizeC.Size = new Size(120, 23);
            sizeC.TabIndex = 2;
            sizeC.KeyPress += sizeC_KeyPress;
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
            // createBtn
            // 
            createBtn.Location = new Point(177, 255);
            createBtn.Name = "createBtn";
            createBtn.Size = new Size(129, 29);
            createBtn.TabIndex = 7;
            createBtn.Text = "Створити";
            createBtn.UseVisualStyleBackColor = true;
            createBtn.Click += button1_Click;
            // 
            // resultLabel
            // 
            resultLabel.Anchor = AnchorStyles.Left;
            resultLabel.AutoSize = true;
            resultLabel.Location = new Point(110, 316);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(13, 15);
            resultLabel.TabIndex = 8;
            resultLabel.Text = "  ";
            resultLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(484, 361);
            Controls.Add(resultLabel);
            Controls.Add(createBtn);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(sizeC);
            Controls.Add(sizeB);
            Controls.Add(sizeA);
            MaximumSize = new Size(500, 400);
            MinimumSize = new Size(500, 400);
            Name = "Form1";
            Padding = new Padding(20, 0, 0, 0);
            Text = "TriangleBuilder";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox sizeA;
        private TextBox sizeB;
        private TextBox sizeC;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button createBtn;
        private Label resultLabel;
    }
}