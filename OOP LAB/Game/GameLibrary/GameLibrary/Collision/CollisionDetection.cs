using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    public class CollisionDetection
    {
        private ObjectType Type1;
        private ObjectType Type2;
        private CollisionAction Action;

        public CollisionDetection(ObjectType type1, ObjectType type2, CollisionAction action)
        {
            this.Type1 = type1;
            this.Type2 = type2;
            this.Action = action;
        }


        public void CheckCollision(List<GameObject> GameObjects)
        {
            foreach (GameObject obj1 in GameObjects) 
            {
                if (obj1.GetObjectType() == this.Type1)
                {
                    foreach (GameObject obj2 in GameObjects)
                    {
                        if (obj2.GetObjectType() == this.Type2)
                        {
                            if (obj1.Pb.Bounds.IntersectsWith(obj2.Pb.Bounds))
                            {
                                if (Action == CollisionAction.ReduceEnemyHealth)
                                {
                                    obj2.SetHealth(obj1.GetHealth()-100);
                                    break;
                                }
                                if(Action == CollisionAction.ReduceHeroHealth)
                                {
                                    obj2.SetHealth(obj1.GetHealth()-25);
                                    break;
                                }
                                
                                
                            }
                        }
                    }
                }
            }
        }
    }
}
