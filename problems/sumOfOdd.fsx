let f (arr: list<int>): int =
    [for i = 0 to (arr.Length-1) do if (abs arr.[i]%2) = 1 then yield arr.[i]] // see -1 mod 2 = -1 NOT 1
    |> List.sum

printfn "%d" (f [-1; 3])
