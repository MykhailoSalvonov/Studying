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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.algorithmSelector = new System.Windows.Forms.ComboBox();
            this.selectAlgorithmLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.description = new System.Windows.Forms.Label();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.chartBtn = new System.Windows.Forms.Button();
            this.configureMap = new System.Windows.Forms.Button();
            this.configureAlgorithm = new System.Windows.Forms.Button();
            this.ukrMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.engMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // algorithmSelector
            // 
            this.algorithmSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.algorithmSelector.FormattingEnabled = true;
            this.algorithmSelector.Items.AddRange(new object[] {
            "Simulated Annealing",
            "Ant Algorithm",
            "Genetic Algorithm"});
            this.algorithmSelector.Location = new System.Drawing.Point(195, 31);
            this.algorithmSelector.Name = "algorithmSelector";
            this.algorithmSelector.Size = new System.Drawing.Size(220, 28);
            this.algorithmSelector.TabIndex = 0;
            this.algorithmSelector.SelectedIndexChanged += new System.EventHandler(this.algorithmSelector_SelectedIndexChanged);
            // 
            // selectAlgorithmLabel
            // 
            this.selectAlgorithmLabel.AutoSize = true;
            this.selectAlgorithmLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.selectAlgorithmLabel.Location = new System.Drawing.Point(32, 39);
            this.selectAlgorithmLabel.Name = "selectAlgorithmLabel";
            this.selectAlgorithmLabel.Size = new System.Drawing.Size(127, 20);
            this.selectAlgorithmLabel.TabIndex = 1;
            this.selectAlgorithmLabel.Text = Resources.select_algorithm;
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
            this.description.Text = Resources.description_text;
            // 
            // calculateBtn
            // 
            this.calculateBtn.Enabled = false;
            this.calculateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.calculateBtn.Location = new System.Drawing.Point(20, 243);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(191, 59);
            this.calculateBtn.TabIndex = 4;
            this.calculateBtn.Text = Resources.calculate_text_btn;
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculate_button_Click);
            // 
            // chartBtn
            // 
            this.chartBtn.Enabled = false;
            this.chartBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chartBtn.Location = new System.Drawing.Point(272, 243);
            this.chartBtn.Name = "chartBtn";
            this.chartBtn.Size = new System.Drawing.Size(191, 59);
            this.chartBtn.TabIndex = 5;
            this.chartBtn.Text = Resources.show_chart_btn;
            this.chartBtn.UseVisualStyleBackColor = true;
            this.chartBtn.Click += new System.EventHandler(this.show_chart_button_Click);
            // 
            // configureMap
            // 
            this.configureMap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.configureMap.Location = new System.Drawing.Point(20, 329);
            this.configureMap.Name = "configureMap";
            this.configureMap.Size = new System.Drawing.Size(191, 62);
            this.configureMap.TabIndex = 6;
            this.configureMap.Text = Resources.configure_map_btn;
            this.configureMap.UseVisualStyleBackColor = true;
            this.configureMap.Click += new System.EventHandler(this.configureMap_Click);
            // 
            // configureAlgorithm
            // 
            this.configureAlgorithm.Enabled = false;
            this.configureAlgorithm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.configureAlgorithm.Location = new System.Drawing.Point(272, 329);
            this.configureAlgorithm.Name = "configureAlgorithm";
            this.configureAlgorithm.Size = new System.Drawing.Size(191, 62);
            this.configureAlgorithm.TabIndex = 7;
            this.configureAlgorithm.Text = Resources.configure_algorithm_btn;
            this.configureAlgorithm.UseVisualStyleBackColor = true;
            this.configureAlgorithm.Click += new System.EventHandler(this.configureAlgorithm_Click);
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
            this.Name = "MainView";
            this.Text = Resources.title;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem ukrMenuItem;
        private System.Windows.Forms.ToolStripMenuItem engMenuItem;
    }
}

