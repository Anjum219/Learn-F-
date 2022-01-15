open System

let rec ex (x: float) (prevSum: float) (currPow: float) (currFact: float) (currTerm: int) (limit: int): float =
    if currTerm > limit then
        prevSum
    else
        ex x (prevSum + (currPow/currFact)) (currPow*x) (currFact*(float currTerm)) (currTerm + 1) limit

let N = Console.ReadLine() |> int

let ReadAndPrint _ = 
    let x = Console.ReadLine() |> float
    let ans = ex x 1.0 x 1.0 2 10
    printfn "%.4f" ans

seq { 1 .. N }
    |> Seq.iter (fun _ -> ReadAndPrint())
