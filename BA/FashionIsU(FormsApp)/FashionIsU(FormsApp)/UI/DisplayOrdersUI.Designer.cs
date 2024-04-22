namespace FashionIsU_FormsApp_.UI
{
    partial class DisplayOrdersUI
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
            this.BuyItemLabel = new System.Windows.Forms.Label();
            this.OrdersGrid = new System.Windows.Forms.DataGridView();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.BuyItemLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 90);
            this.panel1.TabIndex = 9;
            // 
            // BuyItemLabel
            // 
            this.BuyItemLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BuyItemLabel.AutoSize = true;
            this.BuyItemLabel.BackColor = System.Drawing.Color.Transparent;
            this.BuyItemLabel.Cursor = System.Windows.Forms.Cursors.No;
            this.BuyItemLabel.Font = new System.Drawing.Font("Palatino Linotype", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuyItemLabel.ForeColor = System.Drawing.Color.White;
            this.BuyItemLabel.Location = new System.Drawing.Point(212, 27);
            this.BuyItemLabel.Name = "BuyItemLabel";
            this.BuyItemLabel.Size = new System.Drawing.Size(474, 45);
            this.BuyItemLabel.TabIndex = 2;
            this.BuyItemLabel.Text = "Display Previous Orders Page";
            this.BuyItemLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OrdersGrid
            // 
            this.OrdersGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OrdersGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OrdersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrdersGrid.Location = new System.Drawing.Point(43, 105);
            this.OrdersGrid.Name = "OrdersGrid";
            this.OrdersGrid.ReadOnly = true;
            this.OrdersGrid.RowHeadersWidth = 51;
            this.OrdersGrid.RowTemplate.Height = 24;
            this.OrdersGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OrdersGrid.Size = new System.Drawing.Size(801, 423);
            this.OrdersGrid.TabIndex = 84;
            // 
            // AmountLabel
            // 
            this.AmountLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.BackColor = System.Drawing.Color.Black;
            this.AmountLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.AmountLabel.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountLabel.ForeColor = System.Drawing.Color.White;
            this.AmountLabel.Location = new System.Drawing.Point(37, 560);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(621, 32);
            this.AmountLabel.TabIndex = 85;
            this.AmountLabel.Text = "Your Total Amount Spent Including All The Orders is : Rs ";
            // 
            // DisplayOrdersUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.AmountLabel);
            this.Controls.Add(this.OrdersGrid);
            this.Controls.Add(this.panel1);
            this.Name = "DisplayOrdersUI";
            this.Text = "DisplayOrdersUI";
            this.Load += new System.EventHandler(this.DisplayOrdersUI_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label BuyItemLabel;
        private System.Windows.Forms.DataGridView OrdersGrid;
        private System.Windows.Forms.Label AmountLabel;
    }
}