using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SocialMedia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User("user1");
            User user2 = new User("user2");
            User user3 = new User("user3");

            Post post1 = new Post();
            Post post2 = new Post();

            post1.LikePost(user1);
            post1.LikePost(user2);

            post2.GiveComment(user3, "Nice post!");

            user1.AddFollower(user2);
            user2.AddFollowing(user3);

            Console.WriteLine("User 1:");
            UserUI.DisplayUserInfo(user1);
            Console.WriteLine();

            Console.WriteLine("User 2:");
            UserUI.DisplayUserInfo(user2);
            Console.WriteLine();

            Console.WriteLine("User 3:");
            UserUI.DisplayUserInfo(user3);
            Console.WriteLine();
            Console.Read();
        }
    }
}
