open System

let X = Console.ReadLine() |> int
let array = [
    let mutable i = Console.ReadLine()
    while not (i = null) do
        yield i |> int
        i <- Console.ReadLine()
]

let res = List.filter (fun x -> x < X) array
List.map (fun x -> printfn "%d" x) res
