using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameLibrary;

namespace Invasion
{
    public partial class Invasion : Form
    {
        Game game;
        public Invasion()
        {
            InitializeComponent();
        }

        private void Invasion_Load(object sender, EventArgs e)
        {
            game = Game.GetGameInstance(this);

            
             game.AddGameObject(Properties.Resources.USSR_Tu2,ObjectType.Hero, 100, 400, new KeyboardMovement(10, new Point(this.Width, this.Height), Properties.Resources.spr_bullet_strip03, this), 300);
             game.AddGameObject(Properties.Resources.USSR_Pe3,ObjectType.Enemy, 100, 100, new HorizontalMovement(10, new Point(this.Width, this.Height), HorizontalDirection.Left), 100);
            game.AddGameObject(Properties.Resources.USSR_Pe3, ObjectType.Enemy, 500, 0, new HorizontalMovement(10, new Point(this.Width, this.Height), HorizontalDirection.Left), 100);
            //  game.AddGameObject(Properties.Resources.USSR_Pe3, 100, 10, new ZigZagMovement(5, new Point(this.Width, this.Height)));
            SetLabel();
            CollisionDetection col1 = new CollisionDetection(ObjectType.HeroFire, ObjectType.Enemy, CollisionAction.ReduceEnemyHealth);
            CollisionDetection col2 = new CollisionDetection(ObjectType.EnemyFire, ObjectType.Hero, CollisionAction.ReduceHeroHealth);
            
            game.AddCollisionDetections(col1);
            game.AddCollisionDetections(col2);
            
            
            
        }

        private void GameLoop_Tick(object sender, EventArgs e)
        {
            game.Update();
            game.RemoveGameObject();
            
            
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SetLabel() // set the label carrying the amont
        {
            HeroCount.Text = "HeroCount: " + game.GetHeroCount();
            EnemyCount.Text = "EnemyCount: " + game.GetEnemyCount();
            
        }

        private void EnemyFireLoop_Tick(object sender, EventArgs e)
        {
            game.FireEnemy(Properties.Resources.spr_bullet_strip03);
        }
    }
}
