open System

let ReadUntilEOF: seq<string> =
    fun _ -> Console.ReadLine()
    |> Seq.initInfinite
    |> Seq.takeWhile (fun x -> x <> null)

let rec replicateList (lst: list<int>) (n: int): list<int>=
    lst
    |> List.map (fun x -> List.init n (fun _ -> x))
    |> List.concat

let S = Console.ReadLine() |> int
let lst = 
    ReadUntilEOF
    |> Seq.map(fun x -> int x)
    |> Seq.toList
    
replicateList lst S
|> List.iter (fun x -> printfn "%d" x)
