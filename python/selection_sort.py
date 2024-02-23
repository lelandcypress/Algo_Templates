sortlist=[23,87,12,90,76,15]
 #answer = [5,23,76,90,27]
def selectionSort(lst):
    #first step in tracking the index
    for i in range(len(lst)):
        min_idx=i
        #sets range from offset 1i to end of list
        for j in range(i+1, len(lst)):
            if lst[min_idx] > lst[j]:
                 min_idx=j
        lst[i], lst[min_idx] = lst[min_idx], lst[i]
    print("Output: ")
    for i in range(len(lst)):
        print(lst[i], end=" ")


selectionSort(sortlist)