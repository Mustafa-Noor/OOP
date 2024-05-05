namespace Invasion
{
    partial class Invasion
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
            this.GameLoop = new System.Windows.Forms.Timer(this.components);
            this.HeroCount = new System.Windows.Forms.Label();
            this.EnemyCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GameLoop
            // 
            this.GameLoop.Enabled = true;
            this.GameLoop.Interval = 30;
            this.GameLoop.Tick += new System.EventHandler(this.GameLoop_Tick);
            // 
            // HeroCount
            // 
            this.HeroCount.AutoSize = true;
            this.HeroCount.BackColor = System.Drawing.Color.Transparent;
            this.HeroCount.Location = new System.Drawing.Point(0, 0);
            this.HeroCount.Name = "HeroCount";
            this.HeroCount.Size = new System.Drawing.Size(80, 16);
            this.HeroCount.TabIndex = 0;
            this.HeroCount.Text = "Hero Count :";
            this.HeroCount.Click += new System.EventHandler(this.label1_Click);
            // 
            // EnemyCount
            // 
            this.EnemyCount.AutoSize = true;
            this.EnemyCount.BackColor = System.Drawing.Color.Transparent;
            this.EnemyCount.Location = new System.Drawing.Point(0, 16);
            this.EnemyCount.Name = "EnemyCount";
            this.EnemyCount.Size = new System.Drawing.Size(80, 16);
            this.EnemyCount.TabIndex = 1;
            this.EnemyCount.Text = "Hero Count :";
            // 
            // Invasion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Invasion.Properties.Resources.sand_desert_landscape_87633_312;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1263, 744);
            this.Controls.Add(this.EnemyCount);
            this.Controls.Add(this.HeroCount);
            this.DoubleBuffered = true;
            this.Name = "Invasion";
            this.Text = "Invasion";
            this.Load += new System.EventHandler(this.Invasion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer GameLoop;
        private System.Windows.Forms.Label HeroCount;
        private System.Windows.Forms.Label EnemyCount;
    }
}

