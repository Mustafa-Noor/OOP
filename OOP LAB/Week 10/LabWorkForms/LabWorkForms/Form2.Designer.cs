namespace LabWorkForms
{
    partial class Form2
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
            this.durationBox = new System.Windows.Forms.TextBox();
            this.fscBox = new System.Windows.Forms.Label();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.StudentPage = new System.Windows.Forms.Label();
            this.addbtn = new System.Windows.Forms.Button();
            this.Updatebtn = new System.Windows.Forms.Button();
            this.delBtn = new System.Windows.Forms.Button();
            this.PreferBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // durationBox
            // 
            this.durationBox.Location = new System.Drawing.Point(365, 80);
            this.durationBox.Name = "durationBox";
            this.durationBox.Size = new System.Drawing.Size(156, 22);
            this.durationBox.TabIndex = 29;
            // 
            // fscBox
            // 
            this.fscBox.AutoSize = true;
            this.fscBox.Location = new System.Drawing.Point(302, 80);
            this.fscBox.Name = "fscBox";
            this.fscBox.Size = new System.Drawing.Size(57, 16);
            this.fscBox.TabIndex = 28;
            this.fscBox.Text = "Duration";
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(87, 74);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(156, 22);
            this.titleBox.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Title";
            // 
            // StudentPage
            // 
            this.StudentPage.AutoSize = true;
            this.StudentPage.Font = new System.Drawing.Font("Palatino Linotype", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentPage.Location = new System.Drawing.Point(247, 6);
            this.StudentPage.Name = "StudentPage";
            this.StudentPage.Size = new System.Drawing.Size(207, 46);
            this.StudentPage.TabIndex = 23;
            this.StudentPage.Text = "Degree Page";
            // 
            // addbtn
            // 
            this.addbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addbtn.Location = new System.Drawing.Point(675, 171);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(75, 23);
            this.addbtn.TabIndex = 22;
            this.addbtn.Text = "Add";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // Updatebtn
            // 
            this.Updatebtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Updatebtn.Location = new System.Drawing.Point(675, 220);
            this.Updatebtn.Name = "Updatebtn";
            this.Updatebtn.Size = new System.Drawing.Size(75, 23);
            this.Updatebtn.TabIndex = 21;
            this.Updatebtn.Text = "Update";
            this.Updatebtn.UseVisualStyleBackColor = true;
            // 
            // delBtn
            // 
            this.delBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.delBtn.Location = new System.Drawing.Point(675, 262);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(75, 23);
            this.delBtn.TabIndex = 20;
            this.delBtn.Text = "Delete";
            this.delBtn.UseVisualStyleBackColor = true;
            // 
            // PreferBtn
            // 
            this.PreferBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PreferBtn.Location = new System.Drawing.Point(666, 421);
            this.PreferBtn.Name = "PreferBtn";
            this.PreferBtn.Size = new System.Drawing.Size(97, 23);
            this.PreferBtn.TabIndex = 19;
            this.PreferBtn.Text = "Preferences";
            this.PreferBtn.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(87, 141);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(562, 278);
            this.dataGridView1.TabIndex = 18;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.durationBox);
            this.Controls.Add(this.fscBox);
            this.Controls.Add(this.titleBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StudentPage);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.Updatebtn);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.PreferBtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox durationBox;
        private System.Windows.Forms.Label fscBox;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label StudentPage;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Button Updatebtn;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Button PreferBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}