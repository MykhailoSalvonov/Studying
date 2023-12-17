using UI.Properties;

namespace UI
{
    partial class MainView
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
            this.algorithmSelector = new System.Windows.Forms.ComboBox();
            this.selectAlgorithmLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.description = new System.Windows.Forms.Label();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.chartBtn = new System.Windows.Forms.Button();
            this.configureMap = new System.Windows.Forms.Button();
            this.configureAlgorithm = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ukrMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.engMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // algorithmSelector
            // 
            this.algorithmSelector.FormattingEnabled = true;
            this.algorithmSelector.Items.AddRange(new object[] {
            "Simulated Annealing",
            "Ant Algorithm",
            "Genetic Algorithm"});
            this.algorithmSelector.Location = new System.Drawing.Point(195, 38);
            this.algorithmSelector.Name = "algorithmSelector";
            this.algorithmSelector.Size = new System.Drawing.Size(220, 21);
            this.algorithmSelector.TabIndex = 0;
            // 
            // selectAlgorithmLabel
            // 
            this.selectAlgorithmLabel.AutoSize = true;
            this.selectAlgorithmLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.selectAlgorithmLabel.Location = new System.Drawing.Point(32, 39);
            this.selectAlgorithmLabel.Name = "selectAlgorithmLabel";
            this.selectAlgorithmLabel.Size = new System.Drawing.Size(127, 20);
            this.selectAlgorithmLabel.TabIndex = 1;
            this.selectAlgorithmLabel.Text = "Select algorithm:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.algorithmSelector);
            this.panel1.Controls.Add(this.selectAlgorithmLabel);
            this.panel1.Location = new System.Drawing.Point(20, 117);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(443, 100);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.description);
            this.panel2.Location = new System.Drawing.Point(20, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(443, 72);
            this.panel2.TabIndex = 3;
            // 
            // description
            // 
            this.description.AutoEllipsis = true;
            this.description.AutoSize = true;
            this.description.Location = new System.Drawing.Point(14, 13);
            this.description.MaximumSize = new System.Drawing.Size(430, 60);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(420, 39);
            this.description.TabIndex = 0;
            this.description.Text = Properties.Resources.eng_description_text;
            this.description.Click += new System.EventHandler(this.description_Click);
            // 
            // calculateBtn
            // 
            this.calculateBtn.Enabled = false;
            this.calculateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.calculateBtn.Location = new System.Drawing.Point(20, 243);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(191, 59);
            this.calculateBtn.TabIndex = 4;
            this.calculateBtn.Text = "Calculate";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // chartBtn
            // 
            this.chartBtn.Enabled = false;
            this.chartBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chartBtn.Location = new System.Drawing.Point(272, 243);
            this.chartBtn.Name = "chartBtn";
            this.chartBtn.Size = new System.Drawing.Size(191, 59);
            this.chartBtn.TabIndex = 5;
            this.chartBtn.Text = "Show chart";
            this.chartBtn.UseVisualStyleBackColor = true;
            this.chartBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // configureMap
            // 
            this.configureMap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.configureMap.Location = new System.Drawing.Point(20, 329);
            this.configureMap.Name = "configureMap";
            this.configureMap.Size = new System.Drawing.Size(191, 62);
            this.configureMap.TabIndex = 6;
            this.configureMap.Text = "Configure map";
            this.configureMap.UseVisualStyleBackColor = true;
            // 
            // configureAlgorithm
            // 
            this.configureAlgorithm.Enabled = false;
            this.configureAlgorithm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.configureAlgorithm.Location = new System.Drawing.Point(272, 329);
            this.configureAlgorithm.Name = "configureAlgorithm";
            this.configureAlgorithm.Size = new System.Drawing.Size(191, 62);
            this.configureAlgorithm.TabIndex = 7;
            this.configureAlgorithm.Text = "Configure algorithm";
            this.configureAlgorithm.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.languageToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(486, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ukrMenuItem,
            this.engMenuItem});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            this.languageToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.languageToolStripMenuItem.Text = "Language";
            // 
            // ukrMenuItem
            // 
            this.ukrMenuItem.Name = "ukrMenuItem";
            this.ukrMenuItem.Size = new System.Drawing.Size(134, 22);
            this.ukrMenuItem.Text = "Українська";
            this.ukrMenuItem.Click += new System.EventHandler(this.UkrMenuItem_Click);
            // 
            // engMenuItem
            // 
            this.engMenuItem.Name = "engMenuItem";
            this.engMenuItem.Size = new System.Drawing.Size(134, 22);
            this.engMenuItem.Text = "English";
            this.engMenuItem.Click += new System.EventHandler(this.EngMenuItem_Click);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 414);
            this.Controls.Add(this.configureAlgorithm);
            this.Controls.Add(this.configureMap);
            this.Controls.Add(this.chartBtn);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainView";
            this.Text = "Travelling salesman problem";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox algorithmSelector;
        private System.Windows.Forms.Label selectAlgorithmLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.Button chartBtn;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.Button configureMap;
        private System.Windows.Forms.Button configureAlgorithm;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ukrMenuItem;
        private System.Windows.Forms.ToolStripMenuItem engMenuItem;
    }
}

