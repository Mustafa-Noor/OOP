namespace FashionIsU_FormsApp_.UI
{
    partial class AddClothUI
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
            this.AddItemLabel = new System.Windows.Forms.Label();
            this.ClothesGrid = new System.Windows.Forms.DataGridView();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.TypeBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.QuantityBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PriceBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Addbtn = new System.Windows.Forms.Button();
            this.GenderCombo = new System.Windows.Forms.ComboBox();
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
            this.panel1.Controls.Add(this.AddItemLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 76);
            this.panel1.TabIndex = 7;
            // 
            // AddItemLabel
            // 
            this.AddItemLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddItemLabel.AutoSize = true;
            this.AddItemLabel.BackColor = System.Drawing.Color.Transparent;
            this.AddItemLabel.Cursor = System.Windows.Forms.Cursors.No;
            this.AddItemLabel.Font = new System.Drawing.Font("Palatino Linotype", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddItemLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AddItemLabel.Location = new System.Drawing.Point(280, 20);
            this.AddItemLabel.Name = "AddItemLabel";
            this.AddItemLabel.Size = new System.Drawing.Size(295, 45);
            this.AddItemLabel.TabIndex = 2;
            this.AddItemLabel.Text = "Add An Item Page";
            this.AddItemLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ClothesGrid
            // 
            this.ClothesGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClothesGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ClothesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClothesGrid.Location = new System.Drawing.Point(42, 82);
            this.ClothesGrid.Name = "ClothesGrid";
            this.ClothesGrid.ReadOnly = true;
            this.ClothesGrid.RowHeadersWidth = 51;
            this.ClothesGrid.RowTemplate.Height = 24;
            this.ClothesGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ClothesGrid.Size = new System.Drawing.Size(801, 311);
            this.ClothesGrid.TabIndex = 84;
            this.ClothesGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClothesGrid_CellContentClick);
            // 
            // TypeLabel
            // 
            this.TypeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Font = new System.Drawing.Font("Palatino Linotype", 11F);
            this.TypeLabel.Location = new System.Drawing.Point(47, 413);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(106, 26);
            this.TypeLabel.TabIndex = 85;
            this.TypeLabel.Text = "Enter Type";
            // 
            // TypeBox
            // 
            this.TypeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TypeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeBox.Location = new System.Drawing.Point(159, 415);
            this.TypeBox.Name = "TypeBox";
            this.TypeBox.Size = new System.Drawing.Size(205, 24);
            this.TypeBox.TabIndex = 86;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 11F);
            this.label1.Location = new System.Drawing.Point(30, 458);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 26);
            this.label1.TabIndex = 87;
            this.label1.Text = "Enter Gender";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 11F);
            this.label2.Location = new System.Drawing.Point(37, 505);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 26);
            this.label2.TabIndex = 89;
            this.label2.Text = "Enter Color";
            // 
            // QuantityBox
            // 
            this.QuantityBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.QuantityBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityBox.Location = new System.Drawing.Point(591, 460);
            this.QuantityBox.Name = "QuantityBox";
            this.QuantityBox.Size = new System.Drawing.Size(205, 24);
            this.QuantityBox.TabIndex = 92;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 11F);
            this.label3.Location = new System.Drawing.Point(450, 460);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 26);
            this.label3.TabIndex = 91;
            this.label3.Text = "Enter Quantity";
            // 
            // PriceBox
            // 
            this.PriceBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PriceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceBox.Location = new System.Drawing.Point(591, 415);
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.Size = new System.Drawing.Size(205, 24);
            this.PriceBox.TabIndex = 94;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 11F);
            this.label4.Location = new System.Drawing.Point(456, 415);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 26);
            this.label4.TabIndex = 93;
            this.label4.Text = "Enter Price Rs";
            // 
            // Addbtn
            // 
            this.Addbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Addbtn.BackColor = System.Drawing.Color.MediumAquamarine;
            this.Addbtn.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.Addbtn.Location = new System.Drawing.Point(622, 505);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(221, 45);
            this.Addbtn.TabIndex = 95;
            this.Addbtn.Text = "Add Item";
            this.Addbtn.UseVisualStyleBackColor = false;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
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
            this.GenderCombo.Location = new System.Drawing.Point(159, 462);
            this.GenderCombo.Name = "GenderCombo";
            this.GenderCombo.Size = new System.Drawing.Size(205, 27);
            this.GenderCombo.TabIndex = 96;
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
            this.colorBox.Location = new System.Drawing.Point(159, 506);
            this.colorBox.Name = "colorBox";
            this.colorBox.Size = new System.Drawing.Size(205, 27);
            this.colorBox.TabIndex = 97;
            // 
            // AddClothUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.colorBox);
            this.Controls.Add(this.GenderCombo);
            this.Controls.Add(this.Addbtn);
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
            this.Name = "AddClothUI";
            this.Text = "3";
            this.Load += new System.EventHandler(this.AddClothUI_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClothesGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label AddItemLabel;
        private System.Windows.Forms.DataGridView ClothesGrid;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.TextBox TypeBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox QuantityBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PriceBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.ComboBox GenderCombo;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox colorBox;
    }
}