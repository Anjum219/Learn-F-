// Reverse a list without using the reverse function

open System

let rev (lst: list<int>) (n: int): list<int> =
    [for i = n downto 0 do yield lst.[i]]

let lst = [
    let mutable X = Console.ReadLine()
    while not (X = null) do
        yield X |> int
        X <- Console.ReadLine()
]

let revList = rev lst (lst.Length-1)
for i = 0 to (lst.Length-1) do
    printfn "%d" revList.[i]
