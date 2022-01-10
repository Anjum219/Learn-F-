open System

let ReadUntilEOF: seq<string> =
    fun _ -> Console.ReadLine()
    |> Seq.initInfinite
    |> Seq.takeWhile (fun x -> x <> null)

ReadUntilEOF
|> Seq.map (fun x -> int x)
|> Seq.iteri (fun i x -> if i%2 = 0 then printfn "%d" x )
