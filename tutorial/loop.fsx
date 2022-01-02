let fruits = ["papaya"; "guava"; "strawberry"; "blueberry"]

for fruit in fruits do
    printfn $"fruit: {fruit}"

for i = 1 to 3 do
    printfn $"i: {i}"

for i = 0 downto -3 do
    printfn $"i: {i}"

let mutable x = 3
while x > 0 do
    printfn $"x: {x}"
    x <- x - 1
