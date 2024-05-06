namespace SimpleGame
{
    partial class GameForm
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
            this.SuspendLayout();
            // 
            // GameLoop
            // 
            this.GameLoop.Enabled = true;
            this.GameLoop.Interval = 30;
            this.GameLoop.Tick += new System.EventHandler(this.GameLoop_Tick);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SimpleGame.Properties.Resources.back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1255, 739);
            this.DoubleBuffered = true;
            this.Name = "GameForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer GameLoop;
    }
}

