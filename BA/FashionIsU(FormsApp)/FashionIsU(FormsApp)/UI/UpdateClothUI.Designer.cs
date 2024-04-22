namespace FashionIsU_FormsApp_.UI
{
    partial class UpdateClothUI
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
            this.GenderCombo = new System.Windows.Forms.ComboBox();
            this.Updatebtn = new System.Windows.Forms.Button();
            this.PriceBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.QuantityBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TypeBox = new System.Windows.Forms.TextBox();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.IdBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.colorBox = new System.Windows.Forms.ComboBox();
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
            this.panel1.Size = new System.Drawing.Size(884, 79);
            this.panel1.TabIndex = 8;
            // 
            // UpdateItemLabel
            // 
            this.UpdateItemLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UpdateItemLabel.AutoSize = true;
            this.UpdateItemLabel.BackColor = System.Drawing.Color.Transparent;
            this.UpdateItemLabel.Cursor = System.Windows.Forms.Cursors.No;
            this.UpdateItemLabel.Font = new System.Drawing.Font("Palatino Linotype", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateItemLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.UpdateItemLabel.Location = new System.Drawing.Point(266, 17);
            this.UpdateItemLabel.Name = "UpdateItemLabel";
            this.UpdateItemLabel.Size = new System.Drawing.Size(343, 45);
            this.UpdateItemLabel.TabIndex = 2;
            this.UpdateItemLabel.Text = "Update An Item Page";
            this.UpdateItemLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ClothesGrid
            // 
            this.ClothesGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClothesGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ClothesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClothesGrid.Location = new System.Drawing.Point(44, 98);
            this.ClothesGrid.Name = "ClothesGrid";
            this.ClothesGrid.ReadOnly = true;
            this.ClothesGrid.RowHeadersWidth = 51;
            this.ClothesGrid.RowTemplate.Height = 24;
            this.ClothesGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ClothesGrid.Size = new System.Drawing.Size(801, 311);
            this.ClothesGrid.TabIndex = 85;
            // 
            // GenderCombo
            // 
            this.GenderCombo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.GenderCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GenderCombo.Font = new System.Drawing.Font("Palatino Linotype", 8.25F);
            this.GenderCombo.FormattingEnabled = true;
            this.GenderCombo.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.GenderCombo.Location = new System.Drawing.Point(168, 520);
            this.GenderCombo.Name = "GenderCombo";
            this.GenderCombo.Size = new System.Drawing.Size(205, 27);
            this.GenderCombo.TabIndex = 107;
            // 
            // Updatebtn
            // 
            this.Updatebtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Updatebtn.BackColor = System.Drawing.Color.MediumAquamarine;
            this.Updatebtn.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.Updatebtn.Location = new System.Drawing.Point(543, 564);
            this.Updatebtn.Name = "Updatebtn";
            this.Updatebtn.Size = new System.Drawing.Size(221, 45);
            this.Updatebtn.TabIndex = 106;
            this.Updatebtn.Text = "Update Item";
            this.Updatebtn.UseVisualStyleBackColor = false;
            this.Updatebtn.Click += new System.EventHandler(this.Updatebtn_Click);
            // 
            // PriceBox
            // 
            this.PriceBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PriceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceBox.Location = new System.Drawing.Point(597, 473);
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.Size = new System.Drawing.Size(205, 24);
            this.PriceBox.TabIndex = 105;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 11F);
            this.label4.Location = new System.Drawing.Point(462, 473);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 26);
            this.label4.TabIndex = 104;
            this.label4.Text = "Enter Price Rs";
            // 
            // QuantityBox
            // 
            this.QuantityBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.QuantityBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityBox.Location = new System.Drawing.Point(597, 518);
            this.QuantityBox.Name = "QuantityBox";
            this.QuantityBox.Size = new System.Drawing.Size(205, 24);
            this.QuantityBox.TabIndex = 103;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 11F);
            this.label3.Location = new System.Drawing.Point(456, 518);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 26);
            this.label3.TabIndex = 102;
            this.label3.Text = "Enter Quantity";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 11F);
            this.label2.Location = new System.Drawing.Point(46, 563);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 26);
            this.label2.TabIndex = 100;
            this.label2.Text = "Enter Color";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 11F);
            this.label1.Location = new System.Drawing.Point(39, 516);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 26);
            this.label1.TabIndex = 99;
            this.label1.Text = "Enter Gender";
            // 
            // TypeBox
            // 
            this.TypeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TypeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeBox.Location = new System.Drawing.Point(168, 473);
            this.TypeBox.Name = "TypeBox";
            this.TypeBox.Size = new System.Drawing.Size(205, 24);
            this.TypeBox.TabIndex = 98;
            // 
            // TypeLabel
            // 
            this.TypeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Font = new System.Drawing.Font("Palatino Linotype", 11F);
            this.TypeLabel.Location = new System.Drawing.Point(56, 471);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(106, 26);
            this.TypeLabel.TabIndex = 97;
            this.TypeLabel.Text = "Enter Type";
            // 
            // IdBox
            // 
            this.IdBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.IdBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdBox.Location = new System.Drawing.Point(461, 429);
            this.IdBox.Name = "IdBox";
            this.IdBox.Size = new System.Drawing.Size(205, 24);
            this.IdBox.TabIndex = 109;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 11F);
            this.label5.Location = new System.Drawing.Point(152, 427);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(252, 26);
            this.label5.TabIndex = 108;
            this.label5.Text = "Enter ID Of Cloth To Update";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // colorBox
            // 
            this.colorBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.colorBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.colorBox.Font = new System.Drawing.Font("Palatino Linotype", 8.25F);
            this.colorBox.FormattingEnabled = true;
            this.colorBox.Items.AddRange(new object[] {
            "Red",
            "Blue",
            "Green",
            "Yellow",
            "Orange",
            "Purple",
            "Pink",
            "Brown",
            "Black",
            "White",
            "Gray",
            "Cyan",
            "Magenta",
            "Turquoise",
            "Indigo",
            "Maroon",
            "Teal",
            "Lavender",
            "Gold",
            "Silve"});
            this.colorBox.Location = new System.Drawing.Point(168, 564);
            this.colorBox.Name = "colorBox";
            this.colorBox.Size = new System.Drawing.Size(205, 27);
            this.colorBox.TabIndex = 110;
            // 
            // UpdateClothUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.colorBox);
            this.Controls.Add(this.IdBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.GenderCombo);
            this.Controls.Add(this.Updatebtn);
            this.Controls.Add(this.PriceBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.QuantityBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TypeBox);
            this.Controls.Add(this.TypeLabel);
            this.Controls.Add(this.ClothesGrid);
            this.Controls.Add(this.panel1);
            this.Name = "UpdateClothUI";
            this.Text = "UpdateClothUI";
            this.Load += new System.EventHandler(this.UpdateClothUI_Load);
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
        private System.Windows.Forms.ComboBox GenderCombo;
        private System.Windows.Forms.Button Updatebtn;
        private System.Windows.Forms.TextBox PriceBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox QuantityBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TypeBox;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.TextBox IdBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox colorBox;
    }
}