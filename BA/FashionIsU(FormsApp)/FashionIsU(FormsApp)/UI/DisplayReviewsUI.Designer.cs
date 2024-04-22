namespace FashionIsU_FormsApp_.UI
{
    partial class DisplayReviewsUI
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
            this.displayRevLabel = new System.Windows.Forms.Label();
            this.Diplaybtn = new System.Windows.Forms.Button();
            this.IdBox = new System.Windows.Forms.TextBox();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.ReviewsGrid = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReviewsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel1.Controls.Add(this.displayRevLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 69);
            this.panel1.TabIndex = 9;
            // 
            // displayRevLabel
            // 
            this.displayRevLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.displayRevLabel.AutoSize = true;
            this.displayRevLabel.BackColor = System.Drawing.Color.Transparent;
            this.displayRevLabel.Cursor = System.Windows.Forms.Cursors.No;
            this.displayRevLabel.Font = new System.Drawing.Font("Palatino Linotype", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayRevLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.displayRevLabel.Location = new System.Drawing.Point(203, 16);
            this.displayRevLabel.Name = "displayRevLabel";
            this.displayRevLabel.Size = new System.Drawing.Size(486, 45);
            this.displayRevLabel.TabIndex = 2;
            this.displayRevLabel.Text = "Display Reviews An Item Page";
            this.displayRevLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Diplaybtn
            // 
            this.Diplaybtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Diplaybtn.BackColor = System.Drawing.Color.MediumAquamarine;
            this.Diplaybtn.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.Diplaybtn.Location = new System.Drawing.Point(587, 109);
            this.Diplaybtn.Name = "Diplaybtn";
            this.Diplaybtn.Size = new System.Drawing.Size(221, 45);
            this.Diplaybtn.TabIndex = 110;
            this.Diplaybtn.Text = "Display Reviews";
            this.Diplaybtn.UseVisualStyleBackColor = false;
            this.Diplaybtn.Click += new System.EventHandler(this.Diplaybtn_Click);
            // 
            // IdBox
            // 
            this.IdBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.IdBox.Font = new System.Drawing.Font("Palatino Linotype", 9F);
            this.IdBox.Location = new System.Drawing.Point(380, 75);
            this.IdBox.Name = "IdBox";
            this.IdBox.Size = new System.Drawing.Size(247, 28);
            this.IdBox.TabIndex = 109;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.UsernameLabel.Location = new System.Drawing.Point(94, 73);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(281, 27);
            this.UsernameLabel.TabIndex = 108;
            this.UsernameLabel.Text = "Enter ClothesID Of The Cloth";
            // 
            // ReviewsGrid
            // 
            this.ReviewsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReviewsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ReviewsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReviewsGrid.Location = new System.Drawing.Point(43, 179);
            this.ReviewsGrid.Name = "ReviewsGrid";
            this.ReviewsGrid.ReadOnly = true;
            this.ReviewsGrid.RowHeadersWidth = 51;
            this.ReviewsGrid.RowTemplate.Height = 24;
            this.ReviewsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ReviewsGrid.Size = new System.Drawing.Size(801, 423);
            this.ReviewsGrid.TabIndex = 111;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // DisplayReviewsUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.ReviewsGrid);
            this.Controls.Add(this.Diplaybtn);
            this.Controls.Add(this.IdBox);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.panel1);
            this.Name = "DisplayReviewsUI";
            this.Text = "DisplayReviewsUI";
            this.Load += new System.EventHandler(this.DisplayReviewsUI_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReviewsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label displayRevLabel;
        private System.Windows.Forms.Button Diplaybtn;
        private System.Windows.Forms.TextBox IdBox;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.DataGridView ReviewsGrid;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}