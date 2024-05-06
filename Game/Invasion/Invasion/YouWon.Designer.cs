namespace Invasion
{
    partial class YouWon
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
            this.End = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // End
            // 
            this.End.BackColor = System.Drawing.Color.Thistle;
            this.End.Font = new System.Drawing.Font("Palatino Linotype", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.End.Location = new System.Drawing.Point(380, 248);
            this.End.Name = "End";
            this.End.Size = new System.Drawing.Size(435, 101);
            this.End.TabIndex = 3;
            this.End.Text = "Exit";
            this.End.UseVisualStyleBackColor = false;
            this.End.Click += new System.EventHandler(this.End_Click);
            // 
            // YouWon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Invasion.Properties.Resources.win;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1263, 744);
            this.Controls.Add(this.End);
            this.Name = "YouWon";
            this.Text = "YouWon";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button End;
    }
}