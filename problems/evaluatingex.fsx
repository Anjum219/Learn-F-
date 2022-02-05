open System

type Acc = {
    pow: float;
    fact: float;
    sum: float;
}

let ex (x: float) (term: int): float = 
    let seq = seq { 2.0 .. float term }
    let acc = {
        pow = x;
        fact = 1.0;
        sum = 1.0;
    }
    (acc, seq)
    ||> Seq.fold ( fun acc curr ->
        { acc with
            pow = acc.pow * x;
            fact = acc.fact * curr;
            sum = acc.sum + acc.pow/acc.fact;
        }
    )
    |> ( fun x -> x.sum )


let N = Console.ReadLine() |> int

let ReadAndPrint _ = 
    let x = Console.ReadLine() |> float
    // let ans = ex x 1.0 x 1.0 2 10
    let ans = ex x 10
    printfn "%.4f" ans

seq { 1 .. N }
    |> Seq.iter (fun _ -> ReadAndPrint())
