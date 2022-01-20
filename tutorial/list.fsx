let lst = [-4; 4; -1; 1; 0; 9]
printfn "List: %A" lst

// Head
printfn "List head: %A" lst.Head

// Tail
printfn "List tail: %A" lst.Tail // Notice how tail is NOT the last element, rather rest of the list except head

// Last element of list
printfn "Last element: %A" (List.rev lst).Head

// filter
printfn "Filtered list: %A" (List.filter (fun x -> x%2 = 0) lst)
printfn "Filtered list: %A" (lst |> List.filter (fun x -> x%2 = 0)) // does the same as above

// map 
printfn "Mapped list: %A" (lst |> List.map (fun x -> x*2))

// sort, sum, average
printfn "Sorted list: %A" (lst |> List.sort)
printfn "List sum: %A" (lst |> List.sum)
printfn "List average: %A" (lst |> List.map (fun x -> float x) |> List.average)

// *** fold
printfn "Folded list: %A" (lst |> List.fold (fun x y -> x + y) 0)
printfn "Folded list from back: %A" (0 |> List.foldBack (fun x y -> x + y) lst)

// iterate
let rec iterate (lst: list<int>): unit =
       match lst with
       | [ ] -> return
       | head :: tail ->
             printfn "%d" head
             iterate tail
