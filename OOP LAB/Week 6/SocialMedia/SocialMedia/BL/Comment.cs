using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia.BL
{
    internal class Comment
    {
        private string Content;
        private User Author;
        private Post Post;

        public Comment(string content, User author, Post p)
        {
            this.Content = content;
            this.Author = author;
            this.Post = p;
        }

        public string GetContent()
        {
            return Content;
        }

        public void SetContent(string value)
        {
            Content = value;
        }

        public User GetAuthor()
        {
            return Author;
        }

        public void SetAuthor(User value)
        {
            Author = value;
        }

    }
}
