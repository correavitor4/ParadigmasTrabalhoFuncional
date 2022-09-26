// O que são Closures? Closures (clausura, em português) é um conceito geralmente associado com as linguagens de programação funcionais (JavaScript, F# etc.) que vinculam uma função ao seu ambiente de referência, permitindo o acesso a variáveis fora do escopo da função

printfn "Hello from F#"

let count (name:string) = 
    printfn $"\n\nFunction Count() with name '{name}' is created"
    let mutable x = 0
    let mutable deepLevel =0
    fun () -> 
        x <- x + 1
        printfn $"{name} is called {x} times"
        fun () ->  
            deepLevel <- deepLevel + 1
            printfn $"Deep level of {name} was called {deepLevel} times"
      
//when cx is called with ()() the deep level function is called
      
let c1 = count("c1")
c1()
c1()
c1()() 

let c2 = count ("c2")
c2()
c2()
c2()
c2()
c2()()
c2()
c2()()
c2()
c2()


let c3 = count ("c3")
c3()
c3()
c3()()
c3()()
c3()()
