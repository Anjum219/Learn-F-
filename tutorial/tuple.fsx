let avg tup =
    match tup with
    | (a, b, c) -> (a+b+c)/3

printfn "tuple avg: %d" (avg (2, 3, 4))
printfn "tuple first: %d" (fst (2, 3))
printfn "tuple second: %d" (snd (2, 3))
