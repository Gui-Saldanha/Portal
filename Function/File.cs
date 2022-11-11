namespace Function
{
    public static class File
    {
        public static string ReturnPath(string bySplit, string file)
        {
            return AppDomain.CurrentDomain.BaseDirectory.Split(bySplit)[0] + "Configuration\\" + file;
        }
    }
}
