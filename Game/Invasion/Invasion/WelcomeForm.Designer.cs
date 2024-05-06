namespace Invasion
{
    partial class WelcomeForm
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
            this.start = new System.Windows.Forms.Button();
            this.End = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Ravie", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(142, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(953, 66);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome To Space Invasion";
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.Fuchsia;
            this.start.Font = new System.Drawing.Font("Palatino Linotype", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start.Location = new System.Drawing.Point(171, 255);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(435, 101);
            this.start.TabIndex = 1;
            this.start.Text = "Start Game";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // End
            // 
            this.End.BackColor = System.Drawing.Color.Thistle;
            this.End.Font = new System.Drawing.Font("Palatino Linotype", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.End.Location = new System.Drawing.Point(171, 402);
            this.End.Name = "End";
            this.End.Size = new System.Drawing.Size(435, 101);
            this.End.TabIndex = 2;
            this.End.Text = "Exit";
            this.End.UseVisualStyleBackColor = false;
            this.End.Click += new System.EventHandler(this.End_Click);
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Invasion.Properties.Resources.welcomeback;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1263, 744);
            this.Controls.Add(this.End);
            this.Controls.Add(this.start);
            this.Controls.Add(this.label1);
            this.Name = "WelcomeForm";
            this.Text = "WelcomeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button End;
    }
}