
using System;
using System.Collections.Generic;

public class Solution
{
    public IList<IList<int>> GroupThePeople(int[] groupSizes)
    {
        Dictionary<int, IList<int>> groupSizeToIndexes = new Dictionary<int, IList<int>>();
        IList<IList<int>> groupsPerSize = new List<IList<int>>();

        for (int i = 0; i < groupSizes.Length; ++i)
        {
            groupSizeToIndexes.TryAdd(groupSizes[i], new List<int>());
            groupSizeToIndexes[groupSizes[i]].Add(i);

            if (groupSizeToIndexes[groupSizes[i]].Count == groupSizes[i])
            {
                groupsPerSize.Add(groupSizeToIndexes[groupSizes[i]]);
                groupSizeToIndexes.Remove(groupSizes[i]);
            }
        }

        return groupsPerSize;
    }
}
