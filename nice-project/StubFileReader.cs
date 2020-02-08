namespace NiceProject
{
    using System;
    using System.Collections.Generic;

    internal class StubFileReader : IFileReader
    {
        public IEnumerable<int> ReadAllNumbers()
        {
            return new[] {1, 2, 3, 4, 5, 6};
        }
    }
}