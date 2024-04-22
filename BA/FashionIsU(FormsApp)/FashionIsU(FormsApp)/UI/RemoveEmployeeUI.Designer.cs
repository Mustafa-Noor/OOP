namespace FashionIsU_FormsApp_.UI
{
    partial class RemoveEmployeeUI
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
            this.RemoveEmployeeLabel = new System.Windows.Forms.Label();
            this.EmployeeGrid = new System.Windows.Forms.DataGridView();
            this.username = new System.Windows.Forms.TextBox();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.RemoveEmployeeLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 96);
            this.panel1.TabIndex = 10;
            // 
            // RemoveEmployeeLabel
            // 
            this.RemoveEmployeeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RemoveEmployeeLabel.AutoSize = true;
            this.RemoveEmployeeLabel.BackColor = System.Drawing.Color.Transparent;
            this.RemoveEmployeeLabel.Cursor = System.Windows.Forms.Cursors.No;
            this.RemoveEmployeeLabel.Font = new System.Drawing.Font("Palatino Linotype", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveEmployeeLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.RemoveEmployeeLabel.Location = new System.Drawing.Point(231, 30);
            this.RemoveEmployeeLabel.Name = "RemoveEmployeeLabel";
            this.RemoveEmployeeLabel.Size = new System.Drawing.Size(428, 45);
            this.RemoveEmployeeLabel.TabIndex = 2;
            this.RemoveEmployeeLabel.Text = "Remove An Employee Page";
            this.RemoveEmployeeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EmployeeGrid
            // 
            this.EmployeeGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmployeeGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EmployeeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeeGrid.Location = new System.Drawing.Point(48, 102);
            this.EmployeeGrid.Name = "EmployeeGrid";
            this.EmployeeGrid.ReadOnly = true;
            this.EmployeeGrid.RowHeadersWidth = 51;
            this.EmployeeGrid.RowTemplate.Height = 24;
            this.EmployeeGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EmployeeGrid.Size = new System.Drawing.Size(801, 405);
            this.EmployeeGrid.TabIndex = 87;
            // 
            // username
            // 
            this.username.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(519, 533);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(205, 24);
            this.username.TabIndex = 119;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Palatino Linotype", 11F);
            this.UsernameLabel.Location = new System.Drawing.Point(133, 531);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(363, 26);
            this.UsernameLabel.TabIndex = 118;
            this.UsernameLabel.Text = "Enter Username Of Employee To Remove";
            // 
            // Deletebtn
            // 
            this.Deletebtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Deletebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Deletebtn.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.Deletebtn.Location = new System.Drawing.Point(615, 594);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(221, 45);
            this.Deletebtn.TabIndex = 125;
            this.Deletebtn.Text = "Remove Employee";
            this.Deletebtn.UseVisualStyleBackColor = false;
            this.Deletebtn.Click += new System.EventHandler(this.Deletebtn_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // RemoveEmployeeUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.Deletebtn);
            this.Controls.Add(this.username);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.EmployeeGrid);
            this.Controls.Add(this.panel1);
            this.Name = "RemoveEmployeeUI";
            this.Text = "RemoveEmployeeUI";
            this.Load += new System.EventHandler(this.RemoveEmployeeUI_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label RemoveEmployeeLabel;
        private System.Windows.Forms.DataGridView EmployeeGrid;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Button Deletebtn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}