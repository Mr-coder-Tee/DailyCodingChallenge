def containsDuplicate(nums):
    numSet=set()
    # print(numSet)
    for i in nums:
        if i in numSet:
            return True
        else:
            numSet.add(i)
    return False


arr=[1,2,3,1]

print(containsDuplicate(arr))