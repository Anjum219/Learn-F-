open System

let filterPos (array: list<int>): list<int> =
    [for i = 0 to (array.Length-1) do 
        if i%2 = 1 then
            yield array.[i]
    ]

let array = [
    let mutable i = Console.ReadLine()
    while not (i = null) do
        yield i |> int
        i <- Console.ReadLine()
]

let filteredArray = filterPos array
List.map (fun x -> printfn "%d" x) filteredArray
