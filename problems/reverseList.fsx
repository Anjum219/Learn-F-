// Reverse a list without using the reverse function

open System

let ReadUntilEOF: seq<string> =
    fun _ -> Console.ReadLine()
    |> Seq.initInfinite
    |> Seq.takeWhile (fun x -> x <> null)

let rec rev (head: int) (tail: list<int>) (lst: list<int>): list<int> =
    if tail.Length = 0 then
        (([head], lst) ||> List.append)
    else
        rev tail.Head tail.Tail (([head], lst) ||> List.append)

let lst = 
    ReadUntilEOF
    |> Seq.map(fun x -> int x)
    |> Seq.toList

rev lst.Head lst.Tail []
|> List.iter (fun x -> printfn "%d" x)
