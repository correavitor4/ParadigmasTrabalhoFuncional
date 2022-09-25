// For more information see https://aka.ms/fsharp-console-apps
printfn "Hello from F#"

//let sum x = fun y -> x + y
let mult x = fun y -> x * y
let div x = fun y -> x / y
//let sub x = fun y -> x - y
let exp x = fun y -> pown x y

let xValues = [0..10] 

//Create expressions for operators
// 3x³ - 4x² + x/2
let expr1 x = (mult 3 (exp x 3)) + (mult 4 (exp x 2)) + (div x 2)
// 2x² + 8x
let expr2 x = (mult 2 (exp x 2)) + (mult x 8)

let fexpr1 = List.map expr1 xValues
let fexpr2 = List.map expr2 xValues

printfn $"{fexpr1}"
printfn $"{fexpr2}"

