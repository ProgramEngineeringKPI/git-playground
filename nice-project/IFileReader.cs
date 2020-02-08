namespace NiceProject
{
    using System.Collections.Generic;

    internal interface IFileReader
    {
        IEnumerable<int> ReadAllNumbers();
    }
}