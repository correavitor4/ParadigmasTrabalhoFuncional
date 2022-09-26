// For more information see https://aka.ms/fsharp-console-apps

//currying é uma técnica de transformação de uma função que recebe múltiplos parâmetros (mais especificamente, uma n-tupla como parâmetro) de forma que ela pode ser chamada como uma cadeia de funções que recebem somente um parâmetro cada.
let lessComplexCurry = fun z -> fun y -> fun x -> x+y+z

let a = lessComplexCurry 4
let b = a 5
let c = b 10


printfn $"\nResults:\n A: {a}\n B: {b} \n C: {c}"
