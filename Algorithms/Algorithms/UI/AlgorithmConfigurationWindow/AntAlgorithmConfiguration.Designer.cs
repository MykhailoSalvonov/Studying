namespace UI
{
    partial class AntAlgorithmConfiguration
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
            this.applyBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.alphaValue = new System.Windows.Forms.TextBox();
            this.betaValue = new System.Windows.Forms.TextBox();
            this.evaporationRateValue = new System.Windows.Forms.TextBox();
            this.qValue = new System.Windows.Forms.TextBox();
            this.alphaLabel = new System.Windows.Forms.Label();
            this.betaLabel = new System.Windows.Forms.Label();
            this.evaporationRateLabel = new System.Windows.Forms.Label();
            this.qLabel = new System.Windows.Forms.Label();
            this.antsAmountLabel = new System.Windows.Forms.Label();
            this.antsAmountValue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.iterationsValue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // applyBtn
            // 
            this.applyBtn.Location = new System.Drawing.Point(55, 256);
            this.applyBtn.Name = "applyBtn";
            this.applyBtn.Size = new System.Drawing.Size(75, 23);
            this.applyBtn.TabIndex = 0;
            this.applyBtn.Text = "Apply";
            this.applyBtn.UseVisualStyleBackColor = true;
            this.applyBtn.Click += new System.EventHandler(this.applyBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(165, 256);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 1;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // alphaValue
            // 
            this.alphaValue.Location = new System.Drawing.Point(150, 29);
            this.alphaValue.Name = "alphaValue";
            this.alphaValue.Size = new System.Drawing.Size(100, 20);
            this.alphaValue.TabIndex = 2;
            this.alphaValue.Text = "1.5";
            // 
            // betaValue
            // 
            this.betaValue.Location = new System.Drawing.Point(150, 65);
            this.betaValue.Name = "betaValue";
            this.betaValue.Size = new System.Drawing.Size(100, 20);
            this.betaValue.TabIndex = 3;
            this.betaValue.Text = "3.5";
            // 
            // evaporationRateValue
            // 
            this.evaporationRateValue.Location = new System.Drawing.Point(150, 102);
            this.evaporationRateValue.Name = "evaporationRateValue";
            this.evaporationRateValue.Size = new System.Drawing.Size(100, 20);
            this.evaporationRateValue.TabIndex = 4;
            this.evaporationRateValue.Text = "0.3";
            // 
            // qValue
            // 
            this.qValue.Location = new System.Drawing.Point(150, 138);
            this.qValue.Name = "qValue";
            this.qValue.Size = new System.Drawing.Size(100, 20);
            this.qValue.TabIndex = 5;
            this.qValue.Text = "100";
            // 
            // alphaLabel
            // 
            this.alphaLabel.AutoSize = true;
            this.alphaLabel.Location = new System.Drawing.Point(46, 35);
            this.alphaLabel.Name = "alphaLabel";
            this.alphaLabel.Size = new System.Drawing.Size(34, 13);
            this.alphaLabel.TabIndex = 6;
            this.alphaLabel.Text = "Alpha";
            // 
            // betaLabel
            // 
            this.betaLabel.AutoSize = true;
            this.betaLabel.Location = new System.Drawing.Point(46, 72);
            this.betaLabel.Name = "betaLabel";
            this.betaLabel.Size = new System.Drawing.Size(29, 13);
            this.betaLabel.TabIndex = 7;
            this.betaLabel.Text = "Beta";
            // 
            // evaporationRateLabel
            // 
            this.evaporationRateLabel.AutoSize = true;
            this.evaporationRateLabel.Location = new System.Drawing.Point(46, 109);
            this.evaporationRateLabel.Name = "evaporationRateLabel";
            this.evaporationRateLabel.Size = new System.Drawing.Size(90, 13);
            this.evaporationRateLabel.TabIndex = 8;
            this.evaporationRateLabel.Text = "Evaporation Rate";
            // 
            // qLabel
            // 
            this.qLabel.AutoSize = true;
            this.qLabel.Location = new System.Drawing.Point(46, 145);
            this.qLabel.Name = "qLabel";
            this.qLabel.Size = new System.Drawing.Size(15, 13);
            this.qLabel.TabIndex = 9;
            this.qLabel.Text = "Q";
            // 
            // antsAmountLabel
            // 
            this.antsAmountLabel.AutoSize = true;
            this.antsAmountLabel.Location = new System.Drawing.Point(46, 180);
            this.antsAmountLabel.Name = "antsAmountLabel";
            this.antsAmountLabel.Size = new System.Drawing.Size(66, 13);
            this.antsAmountLabel.TabIndex = 11;
            this.antsAmountLabel.Text = "Ants amount";
            // 
            // antsAmountValue
            // 
            this.antsAmountValue.Location = new System.Drawing.Point(150, 173);
            this.antsAmountValue.Name = "antsAmountValue";
            this.antsAmountValue.Size = new System.Drawing.Size(100, 20);
            this.antsAmountValue.TabIndex = 10;
            this.antsAmountValue.Text = "20";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Iterations";
            // 
            // iterationsValue
            // 
            this.iterationsValue.Location = new System.Drawing.Point(150, 209);
            this.iterationsValue.Name = "iterationsValue";
            this.iterationsValue.Size = new System.Drawing.Size(100, 20);
            this.iterationsValue.TabIndex = 12;
            this.iterationsValue.Text = "50";
            // 
            // AntAlgorithmConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 308);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.iterationsValue);
            this.Controls.Add(this.antsAmountLabel);
            this.Controls.Add(this.antsAmountValue);
            this.Controls.Add(this.qLabel);
            this.Controls.Add(this.evaporationRateLabel);
            this.Controls.Add(this.betaLabel);
            this.Controls.Add(this.alphaLabel);
            this.Controls.Add(this.qValue);
            this.Controls.Add(this.evaporationRateValue);
            this.Controls.Add(this.betaValue);
            this.Controls.Add(this.alphaValue);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.applyBtn);
            this.Name = "AntAlgorithmConfiguration";
            this.Text = "AntAlgorithmConfiguration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button applyBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.TextBox alphaValue;
        private System.Windows.Forms.TextBox betaValue;
        private System.Windows.Forms.TextBox evaporationRateValue;
        private System.Windows.Forms.TextBox qValue;
        private System.Windows.Forms.Label alphaLabel;
        private System.Windows.Forms.Label betaLabel;
        private System.Windows.Forms.Label evaporationRateLabel;
        private System.Windows.Forms.Label qLabel;
        private System.Windows.Forms.Label antsAmountLabel;
        private System.Windows.Forms.TextBox antsAmountValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox iterationsValue;
    }
}