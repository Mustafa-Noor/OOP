using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SocialMedia;

namespace SocialMedia
{
    internal class UserUI
    {
        public static void DisplayUserInfo(User user)
        {
            Console.WriteLine($"Username: {user.GetUsername()}");
            Console.WriteLine("Followers:");
            foreach (var follower in user.GetFollowers())
            {
                Console.WriteLine($" - {follower.GetUsername()}");
            }
            Console.WriteLine("Following:");
            foreach (var following in user.GetFollowing())
            {
                Console.WriteLine($" - {following.GetUsername()}");
            }
            Console.WriteLine("Posts:");
            foreach (var post in user.GetPosts())
            {
                Console.WriteLine($" - {post}");
            }
            Console.WriteLine("Likes:");
            foreach (var like in user.GetLikes())
            {
                Console.WriteLine($" - Liked '{like.GetPost()}' by {like.GetUser().GetUsername()}");
            }
        }

    }
}
