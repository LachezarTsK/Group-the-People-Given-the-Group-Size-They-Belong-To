
import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

public class Solution {

    public List<List<Integer>> groupThePeople(int[] groupSizes) {

        Map<Integer, List<Integer>> groupSizeToIndexes = new HashMap<>();
        List<List<Integer>> groupsPerSize = new ArrayList<>();

        for (int i = 0; i < groupSizes.length; ++i) {

            groupSizeToIndexes.computeIfAbsent(groupSizes[i], listIndexes -> new ArrayList<>()).add(i);

            if (groupSizeToIndexes.get(groupSizes[i]).size() == groupSizes[i]) {
                groupsPerSize.add(groupSizeToIndexes.get(groupSizes[i]));
                groupSizeToIndexes.remove(groupSizes[i]);
            }
        }

        return groupsPerSize;
    }
}
