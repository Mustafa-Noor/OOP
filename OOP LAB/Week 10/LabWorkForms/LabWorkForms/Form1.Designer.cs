namespace LabWorkForms
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DegreeBtn = new System.Windows.Forms.Button();
            this.delBtn = new System.Windows.Forms.Button();
            this.Updatebtn = new System.Windows.Forms.Button();
            this.addbtn = new System.Windows.Forms.Button();
            this.StudentPage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.rollBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.fscBox = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.matricBox = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.EcatBox = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(103, 135);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(562, 278);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // DegreeBtn
            // 
            this.DegreeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DegreeBtn.Location = new System.Drawing.Point(682, 415);
            this.DegreeBtn.Name = "DegreeBtn";
            this.DegreeBtn.Size = new System.Drawing.Size(97, 23);
            this.DegreeBtn.TabIndex = 3;
            this.DegreeBtn.Text = "Degree";
            this.DegreeBtn.UseVisualStyleBackColor = true;
            this.DegreeBtn.Click += new System.EventHandler(this.DegreeBtn_Click);
            // 
            // delBtn
            // 
            this.delBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.delBtn.Location = new System.Drawing.Point(691, 256);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(75, 23);
            this.delBtn.TabIndex = 4;
            this.delBtn.Text = "Delete";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // Updatebtn
            // 
            this.Updatebtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Updatebtn.Location = new System.Drawing.Point(691, 214);
            this.Updatebtn.Name = "Updatebtn";
            this.Updatebtn.Size = new System.Drawing.Size(75, 23);
            this.Updatebtn.TabIndex = 5;
            this.Updatebtn.Text = "Update";
            this.Updatebtn.UseVisualStyleBackColor = true;
            this.Updatebtn.Click += new System.EventHandler(this.Updatebtn_Click);
            // 
            // addbtn
            // 
            this.addbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addbtn.Location = new System.Drawing.Point(691, 165);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(75, 23);
            this.addbtn.TabIndex = 6;
            this.addbtn.Text = "Add";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // StudentPage
            // 
            this.StudentPage.AutoSize = true;
            this.StudentPage.Font = new System.Drawing.Font("Palatino Linotype", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentPage.Location = new System.Drawing.Point(263, 0);
            this.StudentPage.Name = "StudentPage";
            this.StudentPage.Size = new System.Drawing.Size(217, 46);
            this.StudentPage.TabIndex = 7;
            this.StudentPage.Text = "Student Page";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Name";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(103, 68);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(156, 22);
            this.nameBox.TabIndex = 9;
            // 
            // rollBox
            // 
            this.rollBox.Location = new System.Drawing.Point(103, 101);
            this.rollBox.Name = "rollBox";
            this.rollBox.Size = new System.Drawing.Size(156, 22);
            this.rollBox.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Roll";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(381, 74);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(156, 22);
            this.textBox3.TabIndex = 13;
            // 
            // fscBox
            // 
            this.fscBox.AutoSize = true;
            this.fscBox.Location = new System.Drawing.Point(318, 74);
            this.fscBox.Name = "fscBox";
            this.fscBox.Size = new System.Drawing.Size(29, 16);
            this.fscBox.TabIndex = 12;
            this.fscBox.Text = "Fsc";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(381, 107);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(156, 22);
            this.textBox4.TabIndex = 15;
            // 
            // matricBox
            // 
            this.matricBox.AutoSize = true;
            this.matricBox.Location = new System.Drawing.Point(318, 107);
            this.matricBox.Name = "matricBox";
            this.matricBox.Size = new System.Drawing.Size(43, 16);
            this.matricBox.TabIndex = 14;
            this.matricBox.Text = "Matric";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(637, 91);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(156, 22);
            this.textBox5.TabIndex = 17;
            // 
            // EcatBox
            // 
            this.EcatBox.AutoSize = true;
            this.EcatBox.Location = new System.Drawing.Point(583, 94);
            this.EcatBox.Name = "EcatBox";
            this.EcatBox.Size = new System.Drawing.Size(34, 16);
            this.EcatBox.TabIndex = 16;
            this.EcatBox.Text = "Ecat";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.EcatBox);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.matricBox);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.fscBox);
            this.Controls.Add(this.rollBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StudentPage);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.Updatebtn);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.DegreeBtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button DegreeBtn;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Button Updatebtn;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Label StudentPage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox rollBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label fscBox;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label matricBox;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label EcatBox;
    }
}

