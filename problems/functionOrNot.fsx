open System

type Acc = {
    mp: Map<int, int>;
    res: bool;
}

let isFunction (x: seq<int>) (y: seq<int>): string = 
    ({ mp = (Map []); res = true; }, x, y)
    |||> Seq.fold2 (fun acc x y ->
        if acc.res = false then
            acc
        else if acc.mp |> Map.containsKey x && acc.mp.[x] <> y then
            { acc with
                res = false;
            }
        else
            { acc with
                mp = acc.mp |> Map.add x y;
            }
    )
    |> (fun x -> 
        if x.res = true then
            "YES"
        else
            "NO"
    )

let T = Console.ReadLine() |> int
seq { 1 .. T }
    |> Seq.iter (fun _ -> 
        let N = Console.ReadLine()
        let x = Console.ReadLine().Split [|' '|] |> Array.toSeq |> Seq.map (fun x -> x |> int)
        let y = Console.ReadLine().Split [|' '|] |> Array.toSeq |> Seq.map (fun x -> x |> int)
        printfn "%s" (isFunction x y)
    )
