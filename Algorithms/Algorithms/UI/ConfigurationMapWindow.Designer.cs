using System.Windows.Forms;

namespace UI
{
    partial class ConfigurationMapWindow
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
            this.mapGrid = new System.Windows.Forms.DataGridView();
            this.addCityBtn = new System.Windows.Forms.Button();
            this.cityValue = new System.Windows.Forms.TextBox();
            this.applyBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mapGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // mapGrid
            // 
            this.mapGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.mapGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.mapGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mapGrid.Location = new System.Drawing.Point(30, 88);
            this.mapGrid.Name = "mapGrid";
            this.mapGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.mapGrid.Size = new System.Drawing.Size(1039, 493);
            this.mapGrid.TabIndex = 0;
            // 
            // addCityBtn
            // 
            this.addCityBtn.Location = new System.Drawing.Point(30, 37);
            this.addCityBtn.Name = "addCityBtn";
            this.addCityBtn.Size = new System.Drawing.Size(75, 23);
            this.addCityBtn.TabIndex = 2;
            this.addCityBtn.Text = "Add city";
            this.addCityBtn.UseVisualStyleBackColor = true;
            this.addCityBtn.Click += new System.EventHandler(this.addCityBtn_Click);
            // 
            // cityValue
            // 
            this.cityValue.Location = new System.Drawing.Point(132, 39);
            this.cityValue.Name = "cityValue";
            this.cityValue.Size = new System.Drawing.Size(138, 20);
            this.cityValue.TabIndex = 3;
            // 
            // applyBtn
            // 
            this.applyBtn.Location = new System.Drawing.Point(857, 599);
            this.applyBtn.Name = "applyBtn";
            this.applyBtn.Size = new System.Drawing.Size(75, 23);
            this.applyBtn.TabIndex = 4;
            this.applyBtn.Text = "Apply";
            this.applyBtn.UseVisualStyleBackColor = true;
            this.applyBtn.Click += new System.EventHandler(this.applyBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(983, 598);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 5;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(30, 597);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 6;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // ConfigurationMapWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 634);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.applyBtn);
            this.Controls.Add(this.cityValue);
            this.Controls.Add(this.addCityBtn);
            this.Controls.Add(this.mapGrid);
            this.Name = "ConfigurationMapWindow";
            this.Text = "ConfigurationMapWindow";
            ((System.ComponentModel.ISupportInitialize)(this.mapGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView mapGrid;
        private System.Windows.Forms.Button addCityBtn;
        private System.Windows.Forms.TextBox cityValue;
        private Button applyBtn;
        private Button cancelBtn;
        private Button clearBtn;
    }
}