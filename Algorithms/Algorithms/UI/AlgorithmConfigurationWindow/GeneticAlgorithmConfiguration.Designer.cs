namespace UI
{
    partial class GeneticAlgorithmConfiguration
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.populationSizeLabel = new System.Windows.Forms.Label();
            this.generationsLabel = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.mutationRateLabel = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.applyBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(137, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // populationSizeLabel
            // 
            this.populationSizeLabel.AutoSize = true;
            this.populationSizeLabel.Location = new System.Drawing.Point(44, 46);
            this.populationSizeLabel.Name = "populationSizeLabel";
            this.populationSizeLabel.Size = new System.Drawing.Size(78, 13);
            this.populationSizeLabel.TabIndex = 1;
            this.populationSizeLabel.Text = "Population size";
            // 
            // generationsLabel
            // 
            this.generationsLabel.AutoSize = true;
            this.generationsLabel.Location = new System.Drawing.Point(44, 84);
            this.generationsLabel.Name = "generationsLabel";
            this.generationsLabel.Size = new System.Drawing.Size(64, 13);
            this.generationsLabel.TabIndex = 3;
            this.generationsLabel.Text = "Generations";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(137, 81);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            // 
            // mutationRateLabel
            // 
            this.mutationRateLabel.AutoSize = true;
            this.mutationRateLabel.Location = new System.Drawing.Point(44, 122);
            this.mutationRateLabel.Name = "mutationRateLabel";
            this.mutationRateLabel.Size = new System.Drawing.Size(69, 13);
            this.mutationRateLabel.TabIndex = 5;
            this.mutationRateLabel.Text = "Mutation rate";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(137, 119);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 4;
            // 
            // applyBtn
            // 
            this.applyBtn.Location = new System.Drawing.Point(49, 171);
            this.applyBtn.Name = "applyBtn";
            this.applyBtn.Size = new System.Drawing.Size(75, 23);
            this.applyBtn.TabIndex = 6;
            this.applyBtn.Text = "Apply";
            this.applyBtn.UseVisualStyleBackColor = true;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(160, 171);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 7;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // GeneticAlgorithmConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 241);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.applyBtn);
            this.Controls.Add(this.mutationRateLabel);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.generationsLabel);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.populationSizeLabel);
            this.Controls.Add(this.textBox1);
            this.Name = "GeneticAlgorithmConfiguration";
            this.Text = "GeneticAlgorithmConfiguration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label populationSizeLabel;
        private System.Windows.Forms.Label generationsLabel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label mutationRateLabel;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button applyBtn;
        private System.Windows.Forms.Button cancelBtn;
    }
}