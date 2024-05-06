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
            
                GameObject gameObject = new GameObject(img,type, Left, Top, controller);
                FormReference.Controls.Add(gameObject.Pb);
                GameObjects.Add(gameObject);
            if (type == ObjectType.Hero)
            {
                HeroCount++;
            }
            if (type == ObjectType.Enemy)
            {
                EnemyCount++;
                FormReference.Controls.Add(gameObject.GetHealthBar());
            }

        }
        public void AddGameObject(Image img, ObjectType type, int Left, int Top, IMovement controller, int Health)
        {
            
            GameObject gameObject = new GameObject(img, type, Left, Top, controller, Health);
            FormReference.Controls.Add(gameObject.Pb);
            GameObjects.Add(gameObject);
            if (type == ObjectType.Hero)
            {
                HeroCount++;
            }
            if (type == ObjectType.Enemy)
            {
                EnemyCount++;
                FormReference.Controls.Add(gameObject.GetHealthBar());
            }

        }
       
        public void Update()
        {
            foreach (GameObject gameObject in GameObjects.ToList())
             {
                gameObject.Update();
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
            foreach (GameObject gameObject in GameObjects)
            {
                if (gameObject.GetObjectType() == ObjectType.Hero)
                {
                    left = gameObject.Pb.Left + (gameObject.Pb.Width/2)-10;
                    top = (gameObject.Pb.Top);
                    break;
                }
            }

            
            AddGameObject(BulletImage,ObjectType.HeroFire, left, top, new FireMovement(20, new Point(FormReference.Width, FormReference.Height), FireDirection.Up));
        }

        public void FireEnemy(Image img)
        {
            List<GameObject> Enemies = new List<GameObject>();
            int left = 0, top = 0;
            for (int i = 0; i < GameObjects.Count; i++)
            {
                GameObject gameObject = GameObjects[i];
                if (gameObject.GetObjectType() == ObjectType.Enemy)
                {

                    left = gameObject.Pb.Left -3;
                    top = (gameObject.Pb.Top) + (gameObject.Pb.Height / 2);
                    AddGameObject(img, ObjectType.EnemyFire, left, top, new FireMovement(30, new Point(FormReference.Width, FormReference.Height), FireDirection.Down));
                }
            }

        }

        public bool IsHeroAlive()
        {
            for (int i = 0; i < GameObjects.Count; i++)
            {
                GameObject gameObject = GameObjects[i];
                if (gameObject.GetObjectType() == ObjectType.Hero)
                {

                    return true;
                }
            }
            return false;
        }

        public GameObject GetHeroObject()
        {
            for (int i = 0; i < GameObjects.Count; i++)
            {
                GameObject gameObject = GameObjects[i];
                if (gameObject.GetObjectType() == ObjectType.Hero)
                {

                    return gameObject;
                }
            }
            return null;
        }


        public bool AreEnemyAlive()
        {
            return GetLiveEnemiesCount() > 0;
        }



        public void RemoveGameObject()
        {
            for (int i = 0; i < GameObjects.Count; i++)
            {
                GameObject gameObject = GameObjects[i];
                if (gameObject.GetHealth() == 0)
                {

                    GameObjects.Remove(gameObject);
                    if(gameObject.GetObjectType() == ObjectType.Enemy)
                    {
                        FormReference.Controls.Remove(gameObject.GetHealthBar());
                    }
                    FormReference.Controls.Remove(gameObject.Pb);

                }
            }
        }

        public List<GameObject> GetGameObjects()
        {
            return GameObjects;
        }

        public int GetLiveEnemiesCount()
        {
            List<GameObject> Enemies = new List<GameObject>();

            foreach (GameObject gameObject in GameObjects)
            {
                if (gameObject.GetObjectType() == ObjectType.Enemy)
                {
                    Enemies.Add(gameObject);
                }
            }
            return Enemies.Count;
        }
        public int GetLivePlayersCount()
        {
            List<GameObject> Players = new List<GameObject>();

            foreach (GameObject gameObject in GameObjects)
            {
                if (gameObject.GetObjectType() == ObjectType.Hero)
                {
                    Players.Add(gameObject);
                }
            }
            return Players.Count;
        }
    }
}
