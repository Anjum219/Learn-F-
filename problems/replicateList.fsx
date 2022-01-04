open System

let replicateList (lst: list<int>) (n: int): list<int> =
    [for i = 0 to (lst.Length-1) do
        for j = 1 to n do
            yield lst.[i]
    ]


let S = Console.ReadLine() |> int
let lst = [
    let mutable X = Console.ReadLine()
    while not (X = null) do
        yield X |> int
        X <- Console.ReadLine()
]

let repLst = replicateList lst S
for item in repLst do
    printfn "%d" item
