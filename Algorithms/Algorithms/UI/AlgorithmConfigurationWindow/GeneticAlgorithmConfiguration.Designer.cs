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
            this.populationSizeValue = new System.Windows.Forms.TextBox();
            this.populationSizeLabel = new System.Windows.Forms.Label();
            this.generationsLabel = new System.Windows.Forms.Label();
            this.generationsValue = new System.Windows.Forms.TextBox();
            this.mutationRateLabel = new System.Windows.Forms.Label();
            this.mutationRateValue = new System.Windows.Forms.TextBox();
            this.applyBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // populationSizeValue
            // 
            this.populationSizeValue.Location = new System.Drawing.Point(137, 43);
            this.populationSizeValue.Name = "populationSizeValue";
            this.populationSizeValue.Size = new System.Drawing.Size(100, 20);
            this.populationSizeValue.TabIndex = 0;
            this.populationSizeValue.Text = "100";
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
            // generationsValue
            // 
            this.generationsValue.Location = new System.Drawing.Point(137, 81);
            this.generationsValue.Name = "generationsValue";
            this.generationsValue.Size = new System.Drawing.Size(100, 20);
            this.generationsValue.TabIndex = 2;
            this.generationsValue.Text = "100";
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
            // mutationRateValue
            // 
            this.mutationRateValue.Location = new System.Drawing.Point(137, 119);
            this.mutationRateValue.Name = "mutationRateValue";
            this.mutationRateValue.Size = new System.Drawing.Size(100, 20);
            this.mutationRateValue.TabIndex = 4;
            this.mutationRateValue.Text = "0.01";
            // 
            // applyBtn
            // 
            this.applyBtn.Location = new System.Drawing.Point(49, 171);
            this.applyBtn.Name = "applyBtn";
            this.applyBtn.Size = new System.Drawing.Size(75, 23);
            this.applyBtn.TabIndex = 6;
            this.applyBtn.Text = "Apply";
            this.applyBtn.UseVisualStyleBackColor = true;
            this.applyBtn.Click += new System.EventHandler(this.applyBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(160, 171);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 7;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // GeneticAlgorithmConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 241);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.applyBtn);
            this.Controls.Add(this.mutationRateLabel);
            this.Controls.Add(this.mutationRateValue);
            this.Controls.Add(this.generationsLabel);
            this.Controls.Add(this.generationsValue);
            this.Controls.Add(this.populationSizeLabel);
            this.Controls.Add(this.populationSizeValue);
            this.Name = "GeneticAlgorithmConfiguration";
            this.Text = "GeneticAlgorithmConfiguration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox populationSizeValue;
        private System.Windows.Forms.Label populationSizeLabel;
        private System.Windows.Forms.Label generationsLabel;
        private System.Windows.Forms.TextBox generationsValue;
        private System.Windows.Forms.Label mutationRateLabel;
        private System.Windows.Forms.TextBox mutationRateValue;
        private System.Windows.Forms.Button applyBtn;
        private System.Windows.Forms.Button cancelBtn;
    }
}