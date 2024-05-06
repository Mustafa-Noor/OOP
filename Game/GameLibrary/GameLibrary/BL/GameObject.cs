using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameLibrary
{
    public class GameObject
    {
        IMovement MovementController;
        internal PictureBox Pb;
        private ObjectType ObjectType;
        private int Health;
        private ProgressBar HealthBar;
        public GameObject(Image img, ObjectType Type, int left, int top, IMovement controller)
        {
            Pb = new PictureBox();
            this.ObjectType = Type;
            Pb.SizeMode = PictureBoxSizeMode.StretchImage;
            Pb.BackColor = Color.Transparent;
            Pb.Image = img;
            Pb.Width = img.Width;
            Pb.Height = img.Height;
           Health = 100;
        Pb.Left = left;
            Pb.Top = top;
            this.MovementController = controller;
            HealthBar = new ProgressBar();
            HealthBar.Minimum = 0;
            HealthBar.Maximum = 100;
            HealthBar.Value = Health;
            HealthBar.Width = img.Width;
            HealthBar.Height = 10; // Adjust height as needed
            HealthBar.BackColor = Color.Red; // Set the background color
            HealthBar.ForeColor = Color.Green; // Set the progress color
            HealthBar.Style = ProgressBarStyle.Continuous; // Set the style
            // Align the HealthBar below the PictureBox
            HealthBar.Left = Pb.Left;
            HealthBar.Top = Pb.Bottom + 5;
            
        }
        public GameObject(Image img, ObjectType Type, int left, int top, IMovement controller, int Health) 
        {
            this.Health = Health;
            Pb = new PictureBox();
            this.ObjectType = Type;
            Pb.SizeMode = PictureBoxSizeMode.StretchImage;
            Pb.BackColor = Color.Transparent;
            Pb.Image = img;
            Pb.Width = img.Width;
            Pb.Height = img.Height;

            Pb.Left = left;
            Pb.Top = top;
            this.MovementController = controller;

            HealthBar = new ProgressBar();
            StyleHealthBar(HealthBar, img);
            
        }

        public void StyleHealthBar(ProgressBar HealthBar, Image img)
        {
            HealthBar.Minimum = 0;
            HealthBar.Maximum = 1000;
            HealthBar.Value = Health;
            HealthBar.Width = img.Width;
            HealthBar.Height = 10; 
            HealthBar.BackColor = Color.Red; 
            HealthBar.ForeColor = Color.Green; 
            HealthBar.Style = ProgressBarStyle.Continuous; 
            HealthBar.Left = Pb.Left;
            HealthBar.Top = Pb.Bottom + 5;
        }

        public void SetHealth(int Health)
        {
            if (Health >= 0)
            {
               this.Health = Health;
            }
            else if (Health < 0)
            {
                this.Health = 0;
            }

        }

        public int GetHealth()
        {
            return this.Health;
        }
        public void Update()
        {
            this.Pb.Location = MovementController.Move(this.Pb.Location);
            HealthBar.Left = Pb.Left;
            HealthBar.Top = Pb.Bottom + 5;
            HealthBar.Value = this.Health;
        }

        public ObjectType GetObjectType()
        { return this.ObjectType; }

        public ProgressBar GetHealthBar()
        { return this.HealthBar; }
    }
}
