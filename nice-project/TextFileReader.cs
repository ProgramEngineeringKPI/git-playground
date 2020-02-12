namespace NiceProject
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    internal class TextFileReader : IFileReader
    {
        private string path;
        
        public TextFileReader(string path)
        {
            this.path = path;
        }

        public IEnumerable<int> ReadAllNumbers()
        {
            var allText = File.ReadAllText(path);
            var strings = allText.Split(new [] {'\r', '\n', ' '}, StringSplitOptions.RemoveEmptyEntries);

            foreach (var s in strings)
            {
                if (Int32.TryParse(s, out int num))
                {
                    yield return num;
                }
            }
        }
    }
}