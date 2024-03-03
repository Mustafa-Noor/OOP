using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia
{
    internal class Like
    {
       private User User;
       private Post Post;

        public Like(User user, Post post)
        {
            User = user;
            Post = post;
        }

        public User GetUser()
        {
            return User;
        }

        public void SetUser(User value)
        {
            User = value;
        }

        public Post GetPost()
        {
            return Post;
        }

        public void SetPost(Post value)
        {
            Post = value;
        }
    }
}
