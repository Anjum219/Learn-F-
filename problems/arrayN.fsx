open System

let f n = //Complete this function
    seq { 1 .. n }
    |> Seq.toList

let main() =
    let input = Console.ReadLine()
    let n = int input
    printfn "%A" (f n)

main()