let mp = Map [(-1, -1)]
printfn "%A" (Map.add 0 0 (Map []))
printfn "%A" (mp |> Map.add 0 0)
printfn "%A" (mp |> Map.add 1 1)
printfn "%A" mp[-1]
printfn "%A" (mp |> Map.containsKey 1)
