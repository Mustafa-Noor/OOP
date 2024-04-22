namespace FashionIsU_FormsApp_.UI
{
    partial class BuyItemUI
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
            this.BuyItemLabel = new System.Windows.Forms.Label();
            this.ClothesGrid = new System.Windows.Forms.DataGridView();
            this.IdBox = new System.Windows.Forms.TextBox();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.QuantityBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Addbtn = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClothesGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.BuyItemLabel);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 81);
            this.panel1.TabIndex = 6;
            // 
            // BuyItemLabel
            // 
            this.BuyItemLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BuyItemLabel.AutoSize = true;
            this.BuyItemLabel.BackColor = System.Drawing.Color.Transparent;
            this.BuyItemLabel.Cursor = System.Windows.Forms.Cursors.No;
            this.BuyItemLabel.Font = new System.Drawing.Font("Palatino Linotype", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuyItemLabel.ForeColor = System.Drawing.Color.White;
            this.BuyItemLabel.Location = new System.Drawing.Point(307, 14);
            this.BuyItemLabel.Name = "BuyItemLabel";
            this.BuyItemLabel.Size = new System.Drawing.Size(286, 45);
            this.BuyItemLabel.TabIndex = 2;
            this.BuyItemLabel.Text = "Buy Clothes Page";
            this.BuyItemLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ClothesGrid
            // 
            this.ClothesGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClothesGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ClothesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClothesGrid.Location = new System.Drawing.Point(57, 87);
            this.ClothesGrid.Name = "ClothesGrid";
            this.ClothesGrid.ReadOnly = true;
            this.ClothesGrid.RowHeadersWidth = 51;
            this.ClothesGrid.RowTemplate.Height = 24;
            this.ClothesGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ClothesGrid.Size = new System.Drawing.Size(801, 406);
            this.ClothesGrid.TabIndex = 83;
            // 
            // IdBox
            // 
            this.IdBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.IdBox.Location = new System.Drawing.Point(403, 521);
            this.IdBox.Name = "IdBox";
            this.IdBox.Size = new System.Drawing.Size(201, 22);
            this.IdBox.TabIndex = 85;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.Location = new System.Drawing.Point(235, 521);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(142, 23);
            this.UsernameLabel.TabIndex = 84;
            this.UsernameLabel.Text = "Enter ID Of Cloth";
            this.UsernameLabel.Click += new System.EventHandler(this.UsernameLabel_Click);
            // 
            // QuantityBox
            // 
            this.QuantityBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.QuantityBox.Location = new System.Drawing.Point(403, 564);
            this.QuantityBox.Name = "QuantityBox";
            this.QuantityBox.Size = new System.Drawing.Size(201, 22);
            this.QuantityBox.TabIndex = 87;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(197, 562);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 23);
            this.label1.TabIndex = 86;
            this.label1.Text = "Enter Quantity To Buy";
            // 
            // Addbtn
            // 
            this.Addbtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Addbtn.BackColor = System.Drawing.Color.Black;
            this.Addbtn.Font = new System.Drawing.Font("Palatino Linotype", 10F);
            this.Addbtn.ForeColor = System.Drawing.Color.White;
            this.Addbtn.Location = new System.Drawing.Point(327, 607);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(216, 42);
            this.Addbtn.TabIndex = 88;
            this.Addbtn.Text = "Add To Cart";
            this.Addbtn.UseVisualStyleBackColor = false;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // BuyItemUI
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.Addbtn);
            this.Controls.Add(this.QuantityBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IdBox);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.ClothesGrid);
            this.Controls.Add(this.panel1);
            this.Name = "BuyItemUI";
            this.Text = "BuyItemUI";
            this.Load += new System.EventHandler(this.BuyItemUI_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClothesGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label BuyItemLabel;
        private System.Windows.Forms.DataGridView ClothesGrid;
        private System.Windows.Forms.TextBox IdBox;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.TextBox QuantityBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}