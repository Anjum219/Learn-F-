let rec fibonacci (a: int) (b: int) (i: int) (n: int): int =
    if i = n then
        b
    else
        fibonacci b (a+b) (i+1) n

printfn "%d" (fibonacci 0 1 1 19) // 4181
