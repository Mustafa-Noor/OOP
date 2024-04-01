namespace SignInUp
{
    partial class Main
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
            this.label1 = new System.Windows.Forms.Label();
            this.SignIn = new System.Windows.Forms.CheckBox();
            this.SignUp = new System.Windows.Forms.CheckBox();
            this.Next = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei Light", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(262, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sign In & Sign Up ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // SignIn
            // 
            this.SignIn.AutoSize = true;
            this.SignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignIn.Location = new System.Drawing.Point(197, 149);
            this.SignIn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SignIn.Name = "SignIn";
            this.SignIn.Size = new System.Drawing.Size(96, 30);
            this.SignIn.TabIndex = 1;
            this.SignIn.Text = "SignIn";
            this.SignIn.UseVisualStyleBackColor = true;
            this.SignIn.CheckedChanged += new System.EventHandler(this.SignIn_CheckedChanged);
            // 
            // SignUp
            // 
            this.SignUp.AutoSize = true;
            this.SignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUp.Location = new System.Drawing.Point(467, 149);
            this.SignUp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SignUp.Name = "SignUp";
            this.SignUp.Size = new System.Drawing.Size(106, 30);
            this.SignUp.TabIndex = 2;
            this.SignUp.Text = "SignUp";
            this.SignUp.UseVisualStyleBackColor = true;
            // 
            // Next
            // 
            this.Next.Location = new System.Drawing.Point(317, 282);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(119, 43);
            this.Next.TabIndex = 14;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 562);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.SignUp);
            this.Controls.Add(this.SignIn);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Mistral", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox SignIn;
        private System.Windows.Forms.CheckBox SignUp;
        private System.Windows.Forms.Button Next;
    }
}

