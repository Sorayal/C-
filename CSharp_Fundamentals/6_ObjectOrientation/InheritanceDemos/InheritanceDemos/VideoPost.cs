using System;
using System.Threading;

namespace InheritanceDemos
{
    class VideoPost : Post
    {
        // member field
        protected bool isPlaying = false;
        protected int currentDuration = 0;
        Timer timer;

        protected string VideoURL { get; set; }
        protected int Length { get; set; }

        public VideoPost() { }
        public VideoPost(string title, string sendByUserName, string videoURL, int length, bool isPublic)
        {
            this.Title = title;
            this.SendByUserName = sendByUserName;
            this.VideoURL = videoURL;
            this.Length = length;
            this.IsPublic = isPublic;
        }


        public override string ToString()
        {
            return String.Format($"{this.ID} - {this.Title} - {this.VideoURL} - {this.Length} s lang von {this.SendByUserName}");
        }


        public void Play()
        {
            if (!isPlaying)
            {
                isPlaying = true;
                Console.WriteLine("Spiele Video ab...");
                // Calls every second the Callback Method
                timer = new Timer(CustomTimerCallBack, null, 0, 1000);
            }
        }

        private void CustomTimerCallBack(Object obj)
        {
            if (currentDuration < Length)
            {
                currentDuration++;
                Console.WriteLine($"Video is at {currentDuration}s");
                GC.Collect();
            }
            else
            {
                Stop();
            }
        }

        public void Stop()
        {
            if (isPlaying)
            {
                isPlaying = false;
                Console.WriteLine($"Angehalten bei {currentDuration}s");
                currentDuration = 0;
                timer.Dispose();
            }
        }
    }
}
