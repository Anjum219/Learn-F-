open System

let ReadUntilEOF: seq<string> =
    fun _ -> Console.ReadLine()
    |> Seq.initInfinite
    |> Seq.takeWhile (fun x -> x <> null)

let rec makeListWithSameElement (lst: list<int>) (element: int) (n: int): list<int> =
    if n = 0 then
        lst
    else
        makeListWithSameElement ([element]@lst) element (n-1)

let rec replicateList (lst: list<int>) (n: int) (i: int) (newList: list<int>): list<int> =
    if i = lst.Length then
        newList
    else
        let tmp = ([], lst.[i], n) |||> makeListWithSameElement
        replicateList lst n (i+1) (newList@tmp)

let S = Console.ReadLine() |> int
let lst = 
    ReadUntilEOF
    |> Seq.map(fun x -> int x)
    |> Seq.toList
    
replicateList lst S 0 []
|> List.iter (fun x -> printfn "%d" x)
