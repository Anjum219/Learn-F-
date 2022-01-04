open System

let f n = //Complete this function
    [for i = 1 to n do yield 0]

let main() =
    let input = Console.ReadLine()
    let n = int input
    printfn "%A" (f n)

main()