namespace FashionIsU_FormsApp_.UI
{
    partial class ManageCartUI
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
            this.CartGrid = new System.Windows.Forms.DataGridView();
            this.Removebtn = new System.Windows.Forms.Button();
            this.QuantityBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.IdBox = new System.Windows.Forms.TextBox();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.ChangeQBtn = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CartGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.BuyItemLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 95);
            this.panel1.TabIndex = 7;
            // 
            // BuyItemLabel
            // 
            this.BuyItemLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BuyItemLabel.AutoSize = true;
            this.BuyItemLabel.BackColor = System.Drawing.Color.Transparent;
            this.BuyItemLabel.Cursor = System.Windows.Forms.Cursors.No;
            this.BuyItemLabel.Font = new System.Drawing.Font("Palatino Linotype", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuyItemLabel.ForeColor = System.Drawing.Color.White;
            this.BuyItemLabel.Location = new System.Drawing.Point(297, 21);
            this.BuyItemLabel.Name = "BuyItemLabel";
            this.BuyItemLabel.Size = new System.Drawing.Size(300, 45);
            this.BuyItemLabel.TabIndex = 2;
            this.BuyItemLabel.Text = "Manage Cart Page";
            this.BuyItemLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CartGrid
            // 
            this.CartGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CartGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CartGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CartGrid.Location = new System.Drawing.Point(51, 113);
            this.CartGrid.Name = "CartGrid";
            this.CartGrid.ReadOnly = true;
            this.CartGrid.RowHeadersWidth = 51;
            this.CartGrid.RowTemplate.Height = 24;
            this.CartGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CartGrid.Size = new System.Drawing.Size(801, 384);
            this.CartGrid.TabIndex = 84;
            // 
            // Removebtn
            // 
            this.Removebtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Removebtn.BackColor = System.Drawing.Color.Black;
            this.Removebtn.Font = new System.Drawing.Font("Palatino Linotype", 10F);
            this.Removebtn.ForeColor = System.Drawing.Color.White;
            this.Removebtn.Location = new System.Drawing.Point(584, 513);
            this.Removebtn.Name = "Removebtn";
            this.Removebtn.Size = new System.Drawing.Size(169, 42);
            this.Removebtn.TabIndex = 93;
            this.Removebtn.Text = "Remove Item";
            this.Removebtn.UseVisualStyleBackColor = false;
            this.Removebtn.Click += new System.EventHandler(this.Removebtn_Click);
            // 
            // QuantityBox
            // 
            this.QuantityBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.QuantityBox.Location = new System.Drawing.Point(343, 582);
            this.QuantityBox.Name = "QuantityBox";
            this.QuantityBox.Size = new System.Drawing.Size(201, 22);
            this.QuantityBox.TabIndex = 92;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 580);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 23);
            this.label1.TabIndex = 91;
            this.label1.Text = "Enter Quantity To Change To";
            // 
            // IdBox
            // 
            this.IdBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.IdBox.Location = new System.Drawing.Point(343, 521);
            this.IdBox.Name = "IdBox";
            this.IdBox.Size = new System.Drawing.Size(201, 22);
            this.IdBox.TabIndex = 90;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.Location = new System.Drawing.Point(175, 521);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(142, 23);
            this.UsernameLabel.TabIndex = 89;
            this.UsernameLabel.Text = "Enter ID Of Cloth";
            // 
            // ChangeQBtn
            // 
            this.ChangeQBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ChangeQBtn.BackColor = System.Drawing.Color.Black;
            this.ChangeQBtn.Font = new System.Drawing.Font("Palatino Linotype", 10F);
            this.ChangeQBtn.ForeColor = System.Drawing.Color.White;
            this.ChangeQBtn.Location = new System.Drawing.Point(584, 572);
            this.ChangeQBtn.Name = "ChangeQBtn";
            this.ChangeQBtn.Size = new System.Drawing.Size(169, 42);
            this.ChangeQBtn.TabIndex = 94;
            this.ChangeQBtn.Text = "Change Quantity";
            this.ChangeQBtn.UseVisualStyleBackColor = false;
            this.ChangeQBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ManageCartUI
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.ChangeQBtn);
            this.Controls.Add(this.Removebtn);
            this.Controls.Add(this.QuantityBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IdBox);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.CartGrid);
            this.Controls.Add(this.panel1);
            this.Name = "ManageCartUI";
            this.Text = "ManageCartUI";
            this.Load += new System.EventHandler(this.ManageCartUI_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CartGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label BuyItemLabel;
        private System.Windows.Forms.DataGridView CartGrid;
        private System.Windows.Forms.Button Removebtn;
        private System.Windows.Forms.TextBox QuantityBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IdBox;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Button ChangeQBtn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}