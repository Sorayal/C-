using System;

namespace InheritanceDemos
{
    class Post
    {
        private static int currentPostId;

        // properties, accessable only by derived classes
        protected int ID { get; set; }
        protected string Title { get; set; }
        protected string SendByUserName { get; set; }
        protected bool IsPublic { get; set; }

        // constructor
        public Post()
        {
            ID = 0;
            Title = "First Post";
            IsPublic = true;
            SendByUserName = "Sascha";
        }

        public Post(string title, bool isPublic, string sendByUserName)
        {
            this.ID = GetNextID();
            this.Title = title;
            this.IsPublic = isPublic;
            this.SendByUserName = sendByUserName;
        }

        // Methods
        protected int GetNextID()
        {
            return ++currentPostId;
        }

        public void Update(string title, bool isPublic)
        {
            this.Title = title;
            this.IsPublic = isPublic;
        }

        // Methods which are virtual, can be overwritten by derived methods
        public override string ToString()
        {
            return String.Format($"{this.ID} - {this.Title} - von {this.SendByUserName}");
        }
    }
}
