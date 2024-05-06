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

            
             game.AddGameObject(Properties.Resources.heroship,ObjectType.Hero, 100, 400, new KeyboardMovement(10, new Point(this.Width, this.Height), Properties.Resources.spr_bullet_strip03, this), 100);
             game.AddGameObject(Properties.Resources.enemy1,ObjectType.Enemy, 100, 100, new HorizontalMovement(10, new Point(this.Width, this.Height), HorizontalDirection.Left), 100);
            game.AddGameObject(Properties.Resources.enemy2, ObjectType.Enemy, 500, 0, new HorizontalMovement(10, new Point(this.Width, this.Height), HorizontalDirection.Left), 100);
            //  game.AddGameObject(Properties.Resources.USSR_Pe3, 100, 10, new ZigZagMovement(5, new Point(this.Width, this.Height)));
            CollisionDetection col1 = new CollisionDetection(ObjectType.HeroFire, ObjectType.Enemy, CollisionAction.ReduceEnemyHealth);
            CollisionDetection col2 = new CollisionDetection(ObjectType.EnemyFire, ObjectType.Hero, CollisionAction.ReduceHeroHealth);
            CollisionDetection col3 = new CollisionDetection(ObjectType.EnemyFire, ObjectType.Hero, CollisionAction.ReduceHeroHealth);

            game.AddCollisionDetections(col1);
            game.AddCollisionDetections(col2);
            game.AddCollisionDetections(col3);
            
            
            
        }

        private void GameLoop_Tick(object sender, EventArgs e)
        {
            game.RemoveGameObject();
            game.Update();
            
            if(!game.IsHeroAlive() || !game.AreEnemyAlive())
            {
                GameLoop.Enabled = false;
                this.Close();
                Form form = new RestartForm(); // endgame form
                form.ShowDialog();
            }
            else
            {
                label1.Text = game.GetHeroObject().GetHealth().ToString();
                SetLabel();
            }
            



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SetLabel() // set the label carrying the amont
        {
            HeroCount.Text = "HeroCount: " + game.GetLivePlayersCount();
            EnemyCount.Text = "EnemyCount: " + game.GetLiveEnemiesCount();
            
        }

        private void EnemyFireLoop_Tick(object sender, EventArgs e)
        {
            game.FireEnemy(Properties.Resources.spr_bullet_strip03);
        }
    }
}
