open System

let ReadUntilEOF: seq<string> =
    fun _ -> Console.ReadLine()
    |> Seq.initInfinite
    |> Seq.takeWhile (fun x -> x <> null)

let rec cntElement (arr: list<int>) (cnt: int): int =
    if cnt >= arr.Length then
        cnt
    else
        cntElement arr (cnt+1)

let cnt = 
    (ReadUntilEOF
    |> Seq.map(fun x -> int x)
    |> Seq.toList, 0)
    ||> cntElement

printfn "%d" cnt
