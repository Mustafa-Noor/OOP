using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using SocialMedia.BL;

namespace SocialMedia
{
    internal class Post
    {
        private List<Comment> Comments;
        private List<Like> Likes;

        public Post()
        {
            Comments = new List<Comment>();
            Likes = new List<Like>();
        }

        public List<Comment> GetComments()
        {
            return Comments;
        }

        public void SetComments(List<Comment> value)
        {
            Comments = value;
        }

        public List<Like> GetLikes()
        {
            return Likes;
        }

        public void SetLikes(List<Like> value)
        {
            Likes = value;
        }

        public void LikePost(User user)
        {
            Like like = new Like(user, this);
            Likes.Add(like);
        }

        public void GiveComment(User user, string comment)
        {
            Comment c = new Comment(comment,user, this);
            Comments.Add(c);
        }

    }
}
