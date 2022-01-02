open System

let rec isColor seq i r g y b =
    if i >= String.length seq && r = g && y = b then
        "True"
    elif i >= String.length seq then
        "False"
    elif abs (r-g) <= 1 && abs (y-b) <= 1 then
        match seq.[i] with
            | 'R' -> isColor seq (i+1) (r+1) g y b
            | 'G' -> isColor seq (i+1) r (g+1) y b
            | 'Y' -> isColor seq (i+1) r g (y+1) b
            | 'B' -> isColor seq (i+1) r g y (b+1)
            | _ -> "False"
    else
        "False"

let T = Console.ReadLine() |> int

for i = 1 to T do
    let seq = Console.ReadLine()
    let ans = isColor seq 0 0 0 0 0
    printfn "%s" ans
