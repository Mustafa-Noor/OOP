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
        }

        public void SetHealth(int Health)
        {
            this.Health = Health;
        }

        public int GetHealth()
        {
            return this.Health;
        }
        public void Update()
        {
            this.Pb.Location = MovementController.Move(this.Pb.Location);
        }

        public ObjectType GetObjectType()
        { return this.ObjectType; }
    }
}
