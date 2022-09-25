// For more information see https://aka.ms/fsharp-console-apps

let lessComplexCurry = fun z -> fun y -> fun x -> x+y+z

let a = lessComplexCurry 4
let b = a 5
let c = b 10


printfn $"\nResults:\n A: {a}\n B: {b} \n C: {c}"