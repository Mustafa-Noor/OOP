namespace Invasion
{
    partial class RestartForm
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
            this.End = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DimGray;
            this.label1.Font = new System.Drawing.Font("Ravie", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(400, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(474, 66);
            this.label1.TabIndex = 1;
            this.label1.Text = "Game Is Over";
            // 
            // End
            // 
            this.End.BackColor = System.Drawing.Color.Thistle;
            this.End.Font = new System.Drawing.Font("Palatino Linotype", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.End.Location = new System.Drawing.Point(349, 401);
            this.End.Name = "End";
            this.End.Size = new System.Drawing.Size(564, 150);
            this.End.TabIndex = 3;
            this.End.Text = "Exit";
            this.End.UseVisualStyleBackColor = false;
            this.End.Click += new System.EventHandler(this.End_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DimGray;
            this.label2.Font = new System.Drawing.Font("Ravie", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(276, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(707, 66);
            this.label2.TabIndex = 4;
            this.label2.Text = "Thanks for PLaying";
            // 
            // RestartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Invasion.Properties.Resources.gameover;
            this.ClientSize = new System.Drawing.Size(1263, 744);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.End);
            this.Controls.Add(this.label1);
            this.Name = "RestartForm";
            this.Text = "RestartForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button End;
        private System.Windows.Forms.Label label2;
    }
}