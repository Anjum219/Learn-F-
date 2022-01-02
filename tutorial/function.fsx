let foo x y
    = x * y

printfn $"3*4 = {foo 3 4}"

let bar (x: int) (y: int) : int
    = x + y

printfn $"3+4 = {bar 3 4}"

// recursive function

let rec fibonacci n
    =
        if n < 2
            then 1
        else
            fibonacci(n-1) + fibonacci(n-2)

printfn $"5th fibonacchi number: {fibonacci 5}"

// lambda expression

let sum x y = x + y
let subtract (x: int) (y: int) = x - y

let math (f: int -> int -> int) x y = f x y

printfn $"add 8 and 4: {math sum 8 4}"
printfn $"add 8 and 4: {math (fun x y -> x + y) 8 4}"
printfn $"add 8 and 4: {(fun x y -> x + y) 8 4}" // this is lambda expression

// function composition

let fun1 x = x * 10
let fun2 x = x + 10
let fun3 = fun1 >> fun2 // composition

printfn $"composition: {fun3 100}"

// pipelining

let pipe
    = 20
    |> fun1
    |> fun2

printfn $"pipe: {pipe}"
