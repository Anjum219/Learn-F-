// **** Elements in a sequence is computed when required, not at once ****

let seq1: seq<float> = seq { 1 .. 5 }
printfn "%A" seq1

let avg = seq1 |> Seq.average // only works for seq<float>, not for seq<int>
printfn "%f" avg

let avgBy = ((fun x -> x*2.0), seq1) ||> Seq.averageBy
printfn "%f" avgBy

printfn "%A" (((fun x -> Some(x*2.0)), seq1) ||> Seq.choose)

printfn "%A" (([1; 2], [3; 4]) ||> Seq.allPairs)
printfn "%A" ((([1; 2], [3; 4]) ||> Seq.allPairs, [5; 6]) ||> Seq.allPairs)

// * cache doesn't calculate the elements every time, rather store them.
// cache is useful when enumerating the same sequence frequenty
let seq2 = Seq.cache seq1
printfn "%A" seq2

printfn "%A" ([box 1; box 2; box 3] |> Seq.cast<int>)

printfn "%A" (seq1 |> Seq.chunkBySize 6)
printfn "%A" (seq1 |> Seq.chunkBySize 2)

type Foo = { 
    Bar: int seq;
    Baz: int
}
let input = seq { 
    {
        Bar = [1; 2];
        Baz = 9
    };
    {
        Bar = [3; 4];
        Baz = 9
    }
}
printfn "%A" input
printfn "%A" (input |> Seq.collect (fun foo -> foo.Bar))
