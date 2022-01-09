let f (arr: list<int>): int =
    arr
    |> List.filter (fun x -> abs x%2 = 1)
    |> List.sum

printfn "%d" (f [-1; 3])
