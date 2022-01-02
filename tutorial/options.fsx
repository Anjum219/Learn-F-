let divide x y =
    match y with
    | 0 -> None
    | _ -> Some(x/y)

printfn "divide: %A" (divide 5 0)
printfn "divide: %A" (divide 20 5)
printfn "divide: %A" (divide 20 5).Value
