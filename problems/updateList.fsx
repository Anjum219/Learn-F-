let f (arr: list<int>): list<int> = [for i = 0 to arr.Length-1 do yield (abs arr.[i])] // Complete this function

//----------------DON'T MODIFY---------------

let input = 
    stdin.ReadToEnd().Split '\n' 
    |> Array.map(fun x -> int(x)) 
    |> Array.toList
    
let print_out (data:int list) = List.iter (fun x -> printfn "%A" x) data

print_out (f(input))
