let rec cntElement (arr: list<int>) (cnt: int): int =
    if cnt >= arr.Length then
        cnt
    else
        cntElement arr (cnt+1)
