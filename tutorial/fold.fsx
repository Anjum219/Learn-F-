// fold
type Charge =
    | In of int
    | Out of int

let inputs = [In 1; Out 2; In 3]

(0, inputs)
||> Seq.fold (fun acc charge ->
    match charge with
    | In i -> acc + i
    | Out o -> acc - o
) 
|> printfn "%A"

// fold2
type CoinToss = Head | Tails

let data1 = [Tails; Head; Tails]
let data2 = [Tails; Head; Head]

(0, data1, data2)
|||> Seq.fold2 (fun acc a b ->
    match (a, b) with
    | Head, Head -> acc + 1
    | Tails, Tails -> acc + 1
    | _ -> acc - 1
)
|> printfn "%A"

// foldBack
type Count = { 
    Positive: int
    Negative: int
    Text: string }

let sequence = [1; 0; -1; -2; 3]
let initialState = {Positive = 0; Negative = 0; Text = ""}

(sequence, initialState)
||> Seq.foldBack (fun a acc  ->
    let text = acc.Text + " " + string a
    if a >= 0 then
        { acc with
            Positive = acc.Positive + 1
            Text = text }
    else
        { acc with
            Negative = acc.Negative + 1
            Text = text }
)
|> printfn "%A"

// foldBack2
let inputs1 = [-1; -2; -3]
let inputs2 = [3; 2; 1; 0]
let initState = {Positive = 0; Negative = 0; Text = ""}

(inputs1, inputs2, initState) |||> Seq.foldBack2 (fun a b acc  ->
    let text = acc.Text + "(" + string a + "," + string b + ") " // notice, a and b are at the min(lastIndexOf inputs, inputs2)
    if a + b >= 0 then
        { acc with
            Positive = acc.Positive + 1
            Text = text }
    else
        { acc with
            Negative = acc.Negative + 1
            Text = text }
)
|> printfn "%A"
