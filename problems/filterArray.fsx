open System

let X = Console.ReadLine() |> int
let ReadUntilEOF: seq<string> =
    fun _ -> Console.ReadLine()
    |> Seq.initInfinite
    |> Seq.takeWhile (fun x -> x <> null)

ReadUntilEOF
|> Seq.map (fun x -> int x)
|> Seq.filter (fun x -> x < X)
|> Seq.iter (fun x -> printfn "%d" x)
