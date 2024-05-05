using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using EZInput;

namespace SimpleGame
{
    public partial class GameForm : Form
    {
        PictureBox player;
        List<PictureBox> playerBullets; 
        PictureBox enemy;
        Random random;
        string enemyDirection = "left";
        int enemySpeed = 7;
        public GameForm()
        {
            InitializeComponent();
        }

        private void GameLoop_Tick(object sender, EventArgs e)
        {
            
            MovePlayer();
            MoveEnemy();
            CreateBullet();
        }

        private void CreateBullet()
        {
            if(Keyboard.IsKeyPressed(Key.Space))
            {
                PictureBox bullet = new PictureBox();
                Image img = SimpleGame.Properties.Resources.spr_bullet_strip03;
                bullet.Image = img;
                bullet.Width = img.Width;
                bullet.Height = img.Height;
                bullet.BackColor = Color.Transparent;
                bullet.Top = player.Top-40;
                bullet.Left = (player.Width/2)+365;
                this.Controls.Add(bullet);

            } 
        }
        private void MoveEnemy()
        {
            if(enemyDirection == "left")
            {
                enemy.Left -=enemySpeed;
            }
            if(enemy.Left <= 0)
            {
                enemyDirection = "right";
            }
            if(enemy.Left >= this.Width-enemy.Width)
            {
                enemyDirection = "left";
            }
            if(enemyDirection == "right")
            {
                enemy.Left +=enemySpeed;
            }
        }
        

        private void MovePlayer()
        {
            if (Keyboard.IsKeyPressed(Key.RightArrow))
            {
                player.Left += 10;
            }
            if (Keyboard.IsKeyPressed(Key.LeftArrow))
            {
                player.Left -= 10;
            }
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            random = new Random();
            playerBullets = new List<PictureBox>();
            CreatePlayer();
            CreateEnemy();
        }

        private void CreatePlayer()
        {
            player = new PictureBox();
            Image img = SimpleGame.Properties.Resources.USSR_Tu2;
            player.Image = img;
            player.Width = img.Width;
            player.Height = img.Height;
            player.BackColor = Color.Transparent;
            player.Top = (this.Height / 2) + 100;
            player.Left = (this.Width / 2) - 100;
            this.Controls.Add(player);
        }

        private void CreateEnemy()
        {
            enemy = new PictureBox();
            Image img = SimpleGame.Properties.Resources.USSR_Pe3;
            enemy.Image = img;
            enemy.Width = img.Width;
            enemy.Height = img.Height;
            enemy.BackColor = Color.Transparent;
            enemy.Top = 0;
            enemy.Left = random.Next(0,this.Width-enemy.Width);
            enemy.Left = (this.Width / 2) - 100;
            this.Controls.Add(enemy);
        }
    }
}
