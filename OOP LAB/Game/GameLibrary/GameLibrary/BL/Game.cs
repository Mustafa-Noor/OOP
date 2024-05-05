using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace GameLibrary
{
    public class Game
    {
        private Form FormReference;
        private List<GameObject> GameObjects;
        private static Game GameInstance;
        private int HeroCount=0;
        private int EnemyCount=0;
        private List<CollisionDetection> CollisionDetections;
        private Game(Form form)
        {
            this.FormReference = form;
            GameObjects = new List<GameObject>();
            CollisionDetections = new List<CollisionDetection>();
        }
        public static Game GetGameInstance(Form form)
        {
            if (GameInstance == null)
            {
                GameInstance = new Game(form);
            }
            return GameInstance;
        }
        public void AddGameObject(Image img,ObjectType type, int Left, int Top, IMovement controller)
        {
            if(type == ObjectType.Hero)
            {
                HeroCount++;
            }
            if(type == ObjectType.Enemy)
            {
                EnemyCount++;
            }
                GameObject gameObject = new GameObject(img,type, Left, Top, controller);
                FormReference.Controls.Add(gameObject.Pb);
                GameObjects.Add(gameObject);
            
        }
        public void AddGameObject(Image img, ObjectType type, int Left, int Top, IMovement controller, int Health)
        {
            if (type == ObjectType.Hero)
            {
                HeroCount++;
            }
            if (type == ObjectType.Enemy)
            {
                EnemyCount++;
            }
            GameObject gameObject = new GameObject(img, type, Left, Top, controller, Health);
            FormReference.Controls.Add(gameObject.Pb);
            GameObjects.Add(gameObject);

        }
       
        public void Update()
        {
            foreach (GameObject gameobject in GameObjects.ToList())
            {
                gameobject.Update();
                foreach (CollisionDetection collision in CollisionDetections)
                {
                    collision.CheckCollision(GameObjects);
                }
            }

            


        }

        public void AddCollisionDetections(CollisionDetection col)
        {
            CollisionDetections.Add(col);
        }

        public int GetHeroCount()
        {
            return HeroCount;
        }

        public int GetEnemyCount()
        {
            return EnemyCount;
        }

        public void Fire(Image BulletImage)
        {
            int left = 0, top = 0;
            foreach (GameObject gameobject in GameObjects)
            {
                if (gameobject.GetObjectType() == ObjectType.Hero)
                {
                    left = gameobject.Pb.Left + (gameobject.Pb.Width/2)-10;
                    top = (gameobject.Pb.Top);
                    break;
                }
            }

            
            AddGameObject(BulletImage,ObjectType.HeroFire, left, top, new FireMovement(20, new Point(FormReference.Width, FormReference.Height), FireDirection.Up));
        }

        public void RemoveGameObject()
        {
            for (int i = 0; i < GameObjects.Count; i++)
            {
                GameObject gameobject = GameObjects[i];
                if (gameobject.GetHealth() <= 0)
                {

                    GameObjects.Remove(gameobject);
                    FormReference.Controls.Remove(gameobject.Pb);

                }
            }
        }
    }
}
