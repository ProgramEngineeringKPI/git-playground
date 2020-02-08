namespace NiceProject
{
    using System.Collections.Generic;
    using System.IO;

    public class SomeStrangeFileReader : IFileReader
    {
        private string path;
        
        public SomeStrangeFileReader(string path)
        {
            this.path = path;
        }

        public IEnumerable<int> ReadAllNumbers()
        {
            FileInfo fi = new FileInfo(path);
            yield return (int) fi.Length;
        }
    }
}