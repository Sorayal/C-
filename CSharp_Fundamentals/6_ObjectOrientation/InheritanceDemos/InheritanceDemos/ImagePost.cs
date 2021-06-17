using System;

namespace InheritanceDemos
{
    class ImagePost : Post
    {
        // is derived from Post with all constructers and adds property ImageURL
        protected string ImageURL { get; set; }

        public ImagePost() { }
        public ImagePost(string title, string sendByUserName, string imageURL, bool isPublic)
        {
            this.ID = GetNextID();
            this.Title = title;
            this.SendByUserName = sendByUserName;
            this.IsPublic = isPublic;
            this.ImageURL = imageURL;
        }

        public override string ToString()
        {
            return String.Format($"{this.ID} - {this.Title} - {this.ImageURL} - von {this.SendByUserName} ");
        }
    }
}
