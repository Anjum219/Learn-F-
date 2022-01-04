open System

let replicateItem item n = 
    [for i in 1 .. n do yield item]

let rec replicateList (lst: list<int>) (newLst: list<int>) (index: int) (n: int) =
    if index = lst.Length then
        newLst
    else
        replicateList lst (List.append newLst (replicateItem lst.[index] n)) (index+1) n


let S = Console.ReadLine() |> int
let lst = [
    let mutable X = Console.ReadLine()
    while not (X = null) do
        yield X |> int
        X <- Console.ReadLine()
]

let repLst = replicateList lst [] 0 S
for item in repLst do
    printfn "%d" item
