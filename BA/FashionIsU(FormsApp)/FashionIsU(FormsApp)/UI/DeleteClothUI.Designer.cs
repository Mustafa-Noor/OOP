namespace FashionIsU_FormsApp_.UI
{
    partial class DeleteClothUI
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
            this.UpdateItemLabel = new System.Windows.Forms.Label();
            this.ClothesGrid = new System.Windows.Forms.DataGridView();
            this.IdBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClothesGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel1.Controls.Add(this.UpdateItemLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 88);
            this.panel1.TabIndex = 9;
            // 
            // UpdateItemLabel
            // 
            this.UpdateItemLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UpdateItemLabel.AutoSize = true;
            this.UpdateItemLabel.BackColor = System.Drawing.Color.Transparent;
            this.UpdateItemLabel.Cursor = System.Windows.Forms.Cursors.No;
            this.UpdateItemLabel.Font = new System.Drawing.Font("Palatino Linotype", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateItemLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.UpdateItemLabel.Location = new System.Drawing.Point(270, 26);
            this.UpdateItemLabel.Name = "UpdateItemLabel";
            this.UpdateItemLabel.Size = new System.Drawing.Size(326, 45);
            this.UpdateItemLabel.TabIndex = 2;
            this.UpdateItemLabel.Text = "Delete An Item Page";
            this.UpdateItemLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ClothesGrid
            // 
            this.ClothesGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClothesGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ClothesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClothesGrid.Location = new System.Drawing.Point(38, 94);
            this.ClothesGrid.Name = "ClothesGrid";
            this.ClothesGrid.ReadOnly = true;
            this.ClothesGrid.RowHeadersWidth = 51;
            this.ClothesGrid.RowTemplate.Height = 24;
            this.ClothesGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ClothesGrid.Size = new System.Drawing.Size(801, 388);
            this.ClothesGrid.TabIndex = 86;
            // 
            // IdBox
            // 
            this.IdBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.IdBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdBox.Location = new System.Drawing.Point(462, 512);
            this.IdBox.Name = "IdBox";
            this.IdBox.Size = new System.Drawing.Size(205, 24);
            this.IdBox.TabIndex = 111;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 11F);
            this.label5.Location = new System.Drawing.Point(188, 512);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(244, 26);
            this.label5.TabIndex = 110;
            this.label5.Text = "Enter ID Of Cloth To Delete";
            // 
            // Deletebtn
            // 
            this.Deletebtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Deletebtn.BackColor = System.Drawing.Color.MediumAquamarine;
            this.Deletebtn.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.Deletebtn.Location = new System.Drawing.Point(323, 563);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(221, 45);
            this.Deletebtn.TabIndex = 112;
            this.Deletebtn.Text = "Delete Item";
            this.Deletebtn.UseVisualStyleBackColor = false;
            this.Deletebtn.Click += new System.EventHandler(this.Deletebtn_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // DeleteClothUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.Deletebtn);
            this.Controls.Add(this.IdBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ClothesGrid);
            this.Controls.Add(this.panel1);
            this.Name = "DeleteClothUI";
            this.Text = "DeleteClothUI";
            this.Load += new System.EventHandler(this.DeleteClothUI_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClothesGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label UpdateItemLabel;
        private System.Windows.Forms.DataGridView ClothesGrid;
        private System.Windows.Forms.TextBox IdBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Deletebtn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}