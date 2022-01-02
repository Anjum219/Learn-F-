type student =
    { name: string;
      register: bool }

let registerStudent s =
    {
        s with
            register = true
    }

// SEE HOW IT"S DIFFERENT FROM JS OBJECT. PROPERTIES ARE ASSIGNED WITH = , NOT WITH :
let haz = { name = "Haz"; register = false }

printfn "Student: %A" (registerStudent haz)
