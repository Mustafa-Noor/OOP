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
            this.EnemyFireLoop = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.healthLabel = new System.Windows.Forms.Label();
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
            this.HeroCount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
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
            this.EnemyCount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EnemyCount.Location = new System.Drawing.Point(0, 16);
            this.EnemyCount.Name = "EnemyCount";
            this.EnemyCount.Size = new System.Drawing.Size(80, 16);
            this.EnemyCount.TabIndex = 1;
            this.EnemyCount.Text = "Hero Count :";
            // 
            // EnemyFireLoop
            // 
            this.EnemyFireLoop.Enabled = true;
            this.EnemyFireLoop.Interval = 900;
            this.EnemyFireLoop.Tick += new System.EventHandler(this.EnemyFireLoop_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label1.Location = new System.Drawing.Point(1172, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 29);
            this.label1.TabIndex = 2;
            // 
            // healthLabel
            // 
            this.healthLabel.AutoSize = true;
            this.healthLabel.BackColor = System.Drawing.Color.Transparent;
            this.healthLabel.Font = new System.Drawing.Font("Palatino Linotype", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.healthLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.healthLabel.Location = new System.Drawing.Point(1033, 3);
            this.healthLabel.Name = "healthLabel";
            this.healthLabel.Size = new System.Drawing.Size(93, 29);
            this.healthLabel.TabIndex = 4;
            this.healthLabel.Text = "Health: ";
            // 
            // Invasion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Invasion.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1263, 744);
            this.Controls.Add(this.healthLabel);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Timer EnemyFireLoop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label healthLabel;
    }
}

