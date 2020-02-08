namespace NiceProject
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class ImportantStuff
    {
        public int DoWhatNeedsToBeDone(IFileReader fileReader)
        {
            var allNumbers = fileReader.ReadAllNumbers();
            var sum = CalculateSumOf(allNumbers);

            return sum;
        }

        private int CalculateSumOf(IEnumerable<int> allNumbers)
        {
            var list = allNumbers.ToList();
            var sum = 0;
            for (int i = 0; i < list.Count; i++)
            {
                sum += list[i];
            }

            return sum;
        }
    }
}