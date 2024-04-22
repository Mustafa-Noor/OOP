namespace FashionIsU_FormsApp_.UI
{
    partial class DisplayOrderOfCustomerUI
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DisplayCustomersLabel = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.Diplaybtn = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.OrdersGrid = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel1.Controls.Add(this.DisplayCustomersLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 76);
            this.panel1.TabIndex = 10;
            // 
            // DisplayCustomersLabel
            // 
            this.DisplayCustomersLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DisplayCustomersLabel.AutoSize = true;
            this.DisplayCustomersLabel.BackColor = System.Drawing.Color.Transparent;
            this.DisplayCustomersLabel.Cursor = System.Windows.Forms.Cursors.No;
            this.DisplayCustomersLabel.Font = new System.Drawing.Font("Palatino Linotype", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayCustomersLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DisplayCustomersLabel.Location = new System.Drawing.Point(169, 20);
            this.DisplayCustomersLabel.Name = "DisplayCustomersLabel";
            this.DisplayCustomersLabel.Size = new System.Drawing.Size(533, 45);
            this.DisplayCustomersLabel.TabIndex = 2;
            this.DisplayCustomersLabel.Text = "Display Orders Of Customer Page";
            this.DisplayCustomersLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // username
            // 
            this.username.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.username.Font = new System.Drawing.Font("Palatino Linotype", 9F);
            this.username.Location = new System.Drawing.Point(395, 82);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(247, 28);
            this.username.TabIndex = 48;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.UsernameLabel.Location = new System.Drawing.Point(109, 80);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(280, 27);
            this.UsernameLabel.TabIndex = 47;
            this.UsernameLabel.Text = "Enter Username Of Customer";
            // 
            // Diplaybtn
            // 
            this.Diplaybtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Diplaybtn.BackColor = System.Drawing.Color.MediumAquamarine;
            this.Diplaybtn.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.Diplaybtn.Location = new System.Drawing.Point(602, 116);
            this.Diplaybtn.Name = "Diplaybtn";
            this.Diplaybtn.Size = new System.Drawing.Size(221, 45);
            this.Diplaybtn.TabIndex = 107;
            this.Diplaybtn.Text = "Display Orders";
            this.Diplaybtn.UseVisualStyleBackColor = false;
            this.Diplaybtn.Click += new System.EventHandler(this.Diplaybtn_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // OrdersGrid
            // 
            this.OrdersGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OrdersGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OrdersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrdersGrid.Location = new System.Drawing.Point(39, 179);
            this.OrdersGrid.Name = "OrdersGrid";
            this.OrdersGrid.ReadOnly = true;
            this.OrdersGrid.RowHeadersWidth = 51;
            this.OrdersGrid.RowTemplate.Height = 24;
            this.OrdersGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OrdersGrid.Size = new System.Drawing.Size(801, 423);
            this.OrdersGrid.TabIndex = 108;
            // 
            // DisplayOrderOfCustomerUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.OrdersGrid);
            this.Controls.Add(this.Diplaybtn);
            this.Controls.Add(this.username);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.panel1);
            this.Name = "DisplayOrderOfCustomerUI";
            this.Text = "DisplayOrderUI";
            this.Load += new System.EventHandler(this.DisplayOrderOfCustomerUI_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label DisplayCustomersLabel;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Button Diplaybtn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridView OrdersGrid;
    }
}