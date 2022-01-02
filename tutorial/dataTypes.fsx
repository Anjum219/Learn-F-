let myInt = 21
let myFloat = 21.19
let myChar = 'x'
let myString = "A string"
let myBool = true

printfn "Integer: %i" myInt
printfn "Float: %f" myFloat
printfn "Character: %c" myChar
printfn "String: %s" myString
printfn "Boolean: %b" myBool

let x:int = 10
printfn $"x: {x}"

let mutable y = 20
let mutable z = x + y
printfn $"y: {y}"
printfn $"z: {z}"
y <- 40
printfn $"y: {y}"
z <- x + y
printfn $"z: {z}"
