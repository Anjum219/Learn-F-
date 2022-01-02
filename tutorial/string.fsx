let escapedStr = @"people <> \n "" team"
printfn $"{escapedStr}"

let properEscapedStr = """people <> \n "" team"""
printfn $"{properEscapedStr}"

// length
let str1 = "abcde"
printfn $"length: {String.length str1}"

// map
printfn $"map: {String.map (fun x -> if x = 'a' then 'e' else x) str1}"

// replicate
printfn $"replicate: {String.replicate 5 str1}"

// collect
let str2 = "Happy new year!"
let collectString str = String.collect (fun c -> sprintf $"{c} ") str
printfn $"{collectString str2}"

// concat
let strings = [ "Tutorials Point"; "Coding Ground"; "Absolute Classes" ]
let ourProducts = String.concat "\n" strings
printfn "%s" ourProducts

// iterate
let str3 = "Fly high"
printfn "Iterate: %c" str3.[0] // NOTICE HOW A DOT IS USED BEFORE THE [

// substring
printfn "Substring: %s" str3.[4..(String.length str3)]
