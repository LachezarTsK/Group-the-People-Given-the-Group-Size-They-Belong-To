
#include <vector>
#include <unordered_map>
using namespace std;

class Solution {
    
public:
    vector<vector<int>> groupThePeople(const vector<int>& groupSizes) const {
        
        unordered_map<int, vector<int>> groupSizeToIndexes;
        vector<vector<int>> groupsPerSize;

        for (int i = 0; i < groupSizes.size(); ++i) {

            groupSizeToIndexes[groupSizes[i]].push_back(i);

            if (groupSizeToIndexes[groupSizes[i]].size() == groupSizes[i]) {
                groupsPerSize.push_back(groupSizeToIndexes[groupSizes[i]]);
                groupSizeToIndexes.erase(groupSizes[i]);
            }
        }

        return groupsPerSize;
    }
};
