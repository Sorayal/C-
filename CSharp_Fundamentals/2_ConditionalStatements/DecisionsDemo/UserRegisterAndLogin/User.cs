namespace UserRegisterAndLogin
{
    public class User
    {
        private static int globalUserIndex;
        public int ActualUserIndex { get; } = globalUserIndex;
        public string UserName { get; set; }
        public string PassWord { get; set; }



        public static int GlobalUserIndex
        {
            get { return globalUserIndex; }
            set {globalUserIndex = value; }
        }

    }
}
