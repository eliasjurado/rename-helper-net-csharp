namespace RenameHelper
{
    public class Program
    {
        public static void Main(string[] args)

        {
            DirectoryRenamer.RenameDirectoryTree(
            @"E:\My Drive",
            name => name.Replace("_", "-"));
        }
    }
}