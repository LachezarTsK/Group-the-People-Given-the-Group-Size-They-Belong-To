
/**
 * @param {number[]} groupSizes
 * @return {number[][]}
 */
var groupThePeople = function (groupSizes) {

    //Map<number, number[]>
    const groupSizeToIndexes = new Map();
    //number[][]
    const groupsPerSize = new Array();

    for (let i = 0; i < groupSizes.length; ++i) {
        if (!groupSizeToIndexes.has(groupSizes[i])) {
            groupSizeToIndexes.set(groupSizes[i], new Array());
        }
        groupSizeToIndexes.get(groupSizes[i]).push(i);

        if (groupSizeToIndexes.get(groupSizes[i]).length === groupSizes[i]) {
            groupsPerSize.push(groupSizeToIndexes.get(groupSizes[i]));
            groupSizeToIndexes.delete(groupSizes[i]);
        }
    }

    return groupsPerSize;
};
