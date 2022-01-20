open System

let modulo = (((10.0 ** 8.0) |> int) + 7)

let rec fibonacci (a: int) (b: int) (i: int) (n: int): int =
    if i = n then
        a
    else
        fibonacci (b % modulo) ((a+b) % modulo) (i+1) n

let T = Console.ReadLine() |> int

let ReadAndPrint _ = 
    let n = Console.ReadLine() |> int
    let ans = fibonacci 0 1 0 n
    printfn "%d" ans

seq { 1 .. T }
    |> Seq.iter (fun _ -> ReadAndPrint())
