open System

let rec filterPos (array: list<int>) (filteredArray: list<int>) (pos: int): list<int> =
    if pos >= array.Length then
        filteredArray
    else
        filterPos
            array
            (List.append filteredArray [array.[pos]])
            (pos+2)

let array = [
    let mutable i = Console.ReadLine()
    while not (i = null) do
        yield i |> int
        i <- Console.ReadLine()
]

let filteredArray = filterPos array [] 1
List.map (fun x -> printfn "%d" x) filteredArray
