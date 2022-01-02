let x = 10
let y = 50

if x <> 0
    then 
        printfn $"x: {x}";
        printfn "then"
elif not(System.Convert.ToBoolean(x))
    then 
        printfn $"x: {x}"
else 
    printfn $"x: {x}"
