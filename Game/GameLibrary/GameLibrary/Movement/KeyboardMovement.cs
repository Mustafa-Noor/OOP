using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using EZInput;

namespace GameLibrary
{
    public class KeyboardMovement:IMovement
    {
        private int Speed;
        private System.Drawing.Point Boundary;
        private int OffSet = 70;
        private Image BulletPicture;
        Form form;
        public KeyboardMovement(int speed, System.Drawing.Point boundary, Image BulletPicture, Form form)
        {
            Speed = speed;
            Boundary = boundary;
            this.BulletPicture = BulletPicture;
            this.form = form;
        }

        public System.Drawing.Point Move(System.Drawing.Point location)
        {
            if ((location.Y + OffSet) <= Boundary.Y -100 && Keyboard.IsKeyPressed(Key.DownArrow))
            {
                location.Y += Speed;
            }

            else if (location.Y - OffSet >= 0 + 100 && Keyboard.IsKeyPressed(Key.UpArrow))
            {
                location.Y -= Speed;
            }
            else if (location.X - OffSet >= 0 && Keyboard.IsKeyPressed(Key.LeftArrow))
            {
                location.X -= Speed;
            }
            if ((location.X + OffSet) <= Boundary.X-100 && Keyboard.IsKeyPressed(Key.RightArrow))
            {
                location.X += Speed;
            }
            if(Keyboard.IsKeyPressed(Key.Space))
            {
                Game.GetGameInstance(form).Fire(BulletPicture);
            }
            return location;
        }
    }
}
