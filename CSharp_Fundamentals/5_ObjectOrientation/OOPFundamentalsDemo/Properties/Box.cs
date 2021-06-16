using System;

namespace Properties
{
    public class Box
    {
        // Member variables
        private int length;
        private int height;
        private int width;
        private int volume;
        private int frontBackFace;
        private readonly string color = "black";

        // Properties
        public int Volume => volume;
        public int Area => frontBackFace;
        public string Color => color;

        public int Length 
        {
            get{ return length; }
            set
            {
                if (value >= 0)
                {
                    length = value;
                    CalculateVolume();
                    CalculateArea();
                }
                else
                {
                    Console.WriteLine("Error: Length should be positive.");
                }
            }
        }

        public int Height
        {
            get { return height; }
            set 
            {
                if(value >= 0)
                {
                    height = value;
                    CalculateVolume();
                    CalculateArea();
                }
                else
                {
                    Console.WriteLine("Error: Height should be positive.");
                }
            }
        }

        public int Width
        {
            get { return width; }
            set
            {
                if (value >= 0)
                {
                    width = value;
                    CalculateVolume();
                    CalculateArea();
                }
                else
                {
                    Console.WriteLine("Error: Width should be positive.");
                }
            }
        }
        // constructor
        public Box() { }
        public Box(int length, int height, int width)
        {
            this.length = length;
            this.height = height;
            this.width = width;
            volume = length * height * width;
            frontBackFace = length * height;
        }
        // Member methods
        public void DisplayInfo()
        {
            Console.WriteLine($"\nLength is {length} and height is {height} and width is {width} \n" +
                              $"which gives a volume about {volume}");
            Console.WriteLine($"The area of the front and back face is {frontBackFace}");
        }

        private void CalculateVolume()
        {
            volume = length * width * height;
        }
        private void CalculateArea()
        {
            frontBackFace = length * height;
        }
    }
}
