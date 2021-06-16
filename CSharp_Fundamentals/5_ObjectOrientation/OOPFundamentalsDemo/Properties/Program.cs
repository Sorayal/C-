
namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Box box = new();
            box.DisplayInfo();

            Box box2 = new(2, 2, 2);
            box2.DisplayInfo();

            box2.Height = 4;
            box2.Length = -2;
            box2.DisplayInfo();


        }
    }
}
