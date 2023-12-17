namespace UI.AlgorithmConfigurationWindow
{
    partial class SimulatedAnnealingConfiguration
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
            this.cancelBtn = new System.Windows.Forms.Button();
            this.applyBtn = new System.Windows.Forms.Button();
            this.coolingRateLabel = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.temperatureLabel = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(152, 118);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 13;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // applyBtn
            // 
            this.applyBtn.Location = new System.Drawing.Point(41, 118);
            this.applyBtn.Name = "applyBtn";
            this.applyBtn.Size = new System.Drawing.Size(75, 23);
            this.applyBtn.TabIndex = 12;
            this.applyBtn.Text = "Apply";
            this.applyBtn.UseVisualStyleBackColor = true;
            // 
            // coolingRateLabel
            // 
            this.coolingRateLabel.AutoSize = true;
            this.coolingRateLabel.Location = new System.Drawing.Point(36, 69);
            this.coolingRateLabel.Name = "coolingRateLabel";
            this.coolingRateLabel.Size = new System.Drawing.Size(63, 13);
            this.coolingRateLabel.TabIndex = 11;
            this.coolingRateLabel.Text = "Cooling rate";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(129, 66);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 10;
            this.textBox3.Text = "0.001";
            // 
            // temperatureLabel
            // 
            this.temperatureLabel.AutoSize = true;
            this.temperatureLabel.Location = new System.Drawing.Point(36, 31);
            this.temperatureLabel.Name = "temperatureLabel";
            this.temperatureLabel.Size = new System.Drawing.Size(67, 13);
            this.temperatureLabel.TabIndex = 9;
            this.temperatureLabel.Text = "Temperature";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(129, 28);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 8;
            this.textBox2.Text = "50";
            // 
            // SimulatedAnnealingConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 179);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.applyBtn);
            this.Controls.Add(this.coolingRateLabel);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.temperatureLabel);
            this.Controls.Add(this.textBox2);
            this.Name = "SimulatedAnnealingConfiguration";
            this.Text = "SimulatedAnnealingConfiguration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button applyBtn;
        private System.Windows.Forms.Label coolingRateLabel;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label temperatureLabel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}