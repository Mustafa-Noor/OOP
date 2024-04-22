namespace FashionIsU_FormsApp_.UI
{
    partial class GiveReviewUI
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
            this.ReviewPageLabel = new System.Windows.Forms.Label();
            this.ClothesGrid = new System.Windows.Forms.DataGridView();
            this.ReviewBtn = new System.Windows.Forms.Button();
            this.RatingBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.IdBox = new System.Windows.Forms.TextBox();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.CommentBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClothesGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.ReviewPageLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 90);
            this.panel1.TabIndex = 7;
            // 
            // ReviewPageLabel
            // 
            this.ReviewPageLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ReviewPageLabel.AutoSize = true;
            this.ReviewPageLabel.BackColor = System.Drawing.Color.Transparent;
            this.ReviewPageLabel.Cursor = System.Windows.Forms.Cursors.No;
            this.ReviewPageLabel.Font = new System.Drawing.Font("Palatino Linotype", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReviewPageLabel.ForeColor = System.Drawing.Color.White;
            this.ReviewPageLabel.Location = new System.Drawing.Point(282, 27);
            this.ReviewPageLabel.Name = "ReviewPageLabel";
            this.ReviewPageLabel.Size = new System.Drawing.Size(292, 45);
            this.ReviewPageLabel.TabIndex = 2;
            this.ReviewPageLabel.Text = "Give Review Page";
            this.ReviewPageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ClothesGrid
            // 
            this.ClothesGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClothesGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ClothesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClothesGrid.Location = new System.Drawing.Point(40, 96);
            this.ClothesGrid.Name = "ClothesGrid";
            this.ClothesGrid.ReadOnly = true;
            this.ClothesGrid.RowHeadersWidth = 51;
            this.ClothesGrid.RowTemplate.Height = 24;
            this.ClothesGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ClothesGrid.Size = new System.Drawing.Size(801, 401);
            this.ClothesGrid.TabIndex = 84;
            // 
            // ReviewBtn
            // 
            this.ReviewBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ReviewBtn.BackColor = System.Drawing.Color.Black;
            this.ReviewBtn.Font = new System.Drawing.Font("Palatino Linotype", 10F);
            this.ReviewBtn.ForeColor = System.Drawing.Color.White;
            this.ReviewBtn.Location = new System.Drawing.Point(633, 590);
            this.ReviewBtn.Name = "ReviewBtn";
            this.ReviewBtn.Size = new System.Drawing.Size(195, 46);
            this.ReviewBtn.TabIndex = 93;
            this.ReviewBtn.Text = "Give Review";
            this.ReviewBtn.UseVisualStyleBackColor = false;
            this.ReviewBtn.Click += new System.EventHandler(this.ReviewBtn_Click);
            // 
            // RatingBox
            // 
            this.RatingBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RatingBox.Location = new System.Drawing.Point(214, 604);
            this.RatingBox.Name = "RatingBox";
            this.RatingBox.Size = new System.Drawing.Size(201, 22);
            this.RatingBox.TabIndex = 92;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 602);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 23);
            this.label1.TabIndex = 91;
            this.label1.Text = "Enter Rating (1 to 5)";
            // 
            // IdBox
            // 
            this.IdBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.IdBox.Location = new System.Drawing.Point(214, 514);
            this.IdBox.Name = "IdBox";
            this.IdBox.Size = new System.Drawing.Size(201, 22);
            this.IdBox.TabIndex = 90;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.Location = new System.Drawing.Point(46, 514);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(142, 23);
            this.UsernameLabel.TabIndex = 89;
            this.UsernameLabel.Text = "Enter ID Of Cloth";
            // 
            // CommentBox
            // 
            this.CommentBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CommentBox.Location = new System.Drawing.Point(390, 554);
            this.CommentBox.Name = "CommentBox";
            this.CommentBox.Size = new System.Drawing.Size(468, 22);
            this.CommentBox.TabIndex = 95;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(210, 554);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 23);
            this.label3.TabIndex = 94;
            this.label3.Text = "Enter Your Comment";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // GiveReviewUI
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.CommentBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ReviewBtn);
            this.Controls.Add(this.RatingBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IdBox);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.ClothesGrid);
            this.Controls.Add(this.panel1);
            this.Name = "GiveReviewUI";
            this.Text = "GiveReviewUI";
            this.Load += new System.EventHandler(this.GiveReviewUI_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClothesGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ReviewPageLabel;
        private System.Windows.Forms.DataGridView ClothesGrid;
        private System.Windows.Forms.Button ReviewBtn;
        private System.Windows.Forms.TextBox RatingBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IdBox;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.TextBox CommentBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}