using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia
{
    internal class User
    {
        private string Username;
        private List<User> Followers;
        private List<User> Following;
        private List<Post> Posts;
        private List<Like> Likes;


        public User(string name)
        { 
            Username = name;
            Followers = new List<User>();
            Following = new List<User>();
            Posts = new List<Post>();
            Likes = new List<Like>();
        }
        public string GetUsername()
        {
            return Username;
        }

        public void SetUsername(string value)
        {
            Username = value;
        }

        public List<User> GetFollowers()
        {
            return Followers;
        }

        public void SetFollowers(List<User> value)
        {
            Followers = value;
        }

        public List<User> GetFollowing()
        {
            return Following;
        }

        public void SetFollowing(List<User> value)
        {
            Following = value;
        }

        public void AddFollower(User user)
        {
            Followers.Add(user);
        }

        public void AddFollowing(User user)
        {
            Following.Add(user);
        }

        public List<Post> GetPosts()
        {
            return Posts;
        }

        public void SetPosts(List<Post> value)
        {
            Posts = value;
        }

        public List<Like> GetLikes()
        {
            return Likes;
        }

        public void SetLikes(List<Like> value)
        {
            Likes = value;
        }

        public Post CreatePost(Post post)
        {
            
            Posts.Add(post);
            return post;
        }
    }



}

