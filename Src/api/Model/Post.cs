using System;

namespace Model
{
    public class Post
    {
        public Post()
        {
        }

        public Post(Guid id, string creator, string description, int userId)
        {
            Id = id;
            Creator = creator;
            Description = description;
            UserId = userId;
        }
        public Guid Id { get; set; }

        public string Creator { get; set; }

        public string Description { get; set; }

        public int UserId { get; set; }

        public bool IsValid
        {
            get { return !string.IsNullOrEmpty(Creator) && !string.IsNullOrEmpty(Description); }
        }
    }
}