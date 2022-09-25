open Plotly.NET
open System

let sum x = fun y -> x + y
let mult x = fun y -> x * y
let div x = fun y -> x / y
let sub x = fun y -> x - y
let exp x = fun y -> pown x y

let xValues = [-10..10] 

//Create expressions for operators
// 3x³ - 4x² + x/2
let expr1 x = (sum (sub (mult 3 (exp x 3))  (mult 4 (exp x 2)))  (div x 2))
// 2x² + 8x
let expr2 x = (sum (mult 2 (exp x 2))  (mult x 8))

let fexpr1 = List.map expr1 xValues
let fexpr2 = List.map expr2 xValues

[
    Chart.Line(xValues,fexpr1, Name="Expression 1 = 3x³ - 4x² + x/2")
    Chart.Line(xValues,fexpr2, Name="Expression 2 = 2x² + 8x")
]
|> Chart.combine
|> Chart.withTitle "Functor creates a expressions"
|> Chart.show

