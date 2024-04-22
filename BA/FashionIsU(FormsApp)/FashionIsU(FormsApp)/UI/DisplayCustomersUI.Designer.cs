namespace FashionIsU_FormsApp_.UI
{
    partial class DisplayCustomersUI
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.DisplayCustomersLabel = new System.Windows.Forms.Label();
            this.CustomersGrid = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel1.Controls.Add(this.DisplayCustomersLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 92);
            this.panel1.TabIndex = 9;
            // 
            // DisplayCustomersLabel
            // 
            this.DisplayCustomersLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DisplayCustomersLabel.AutoSize = true;
            this.DisplayCustomersLabel.BackColor = System.Drawing.Color.Transparent;
            this.DisplayCustomersLabel.Cursor = System.Windows.Forms.Cursors.No;
            this.DisplayCustomersLabel.Font = new System.Drawing.Font("Palatino Linotype", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayCustomersLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DisplayCustomersLabel.Location = new System.Drawing.Point(230, 28);
            this.DisplayCustomersLabel.Name = "DisplayCustomersLabel";
            this.DisplayCustomersLabel.Size = new System.Drawing.Size(389, 45);
            this.DisplayCustomersLabel.TabIndex = 2;
            this.DisplayCustomersLabel.Text = "Display Customers Page";
            this.DisplayCustomersLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CustomersGrid
            // 
            this.CustomersGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomersGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CustomersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomersGrid.Location = new System.Drawing.Point(48, 114);
            this.CustomersGrid.Name = "CustomersGrid";
            this.CustomersGrid.ReadOnly = true;
            this.CustomersGrid.RowHeadersWidth = 51;
            this.CustomersGrid.RowTemplate.Height = 24;
            this.CustomersGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CustomersGrid.Size = new System.Drawing.Size(801, 490);
            this.CustomersGrid.TabIndex = 86;
            // 
            // DisplayCustomersUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.CustomersGrid);
            this.Controls.Add(this.panel1);
            this.Name = "DisplayCustomersUI";
            this.Text = "DisplayCustomersUI";
            this.Load += new System.EventHandler(this.DisplayCustomersUI_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label DisplayCustomersLabel;
        private System.Windows.Forms.DataGridView CustomersGrid;
    }
}