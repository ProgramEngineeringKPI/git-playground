namespace NiceProject
{
    using System.Collections.Generic;

    internal class EmptyFileReader : IFileReader
    {
        public IEnumerable<int> ReadAllNumbers()
        {
            return new int[0];
        }
    }
}