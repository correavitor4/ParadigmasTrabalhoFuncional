open Plotly.NET
open System

//Uma função de alta ordem é uma função que recebe uma função como parâmetro ou que retorna uma outra função

//f(x) = x² + 2
let f = fun x -> (pown x 2) + 2
//g(x) = f(x+1)
let g = fun x -> f (x+1)
//h(x) = -f(x)
let h = fun x -> -f x


//Essa é a função de alta ordem que recebe uma função como parâmetro
let exec = fun functionToExecute x -> functionToExecute x

let a = exec f 2
let b = exec g 2
let c = exec h 2

printfn $"\nWhere x==2\n f(x) = {a}\n g(x) = {b}\n h(x) = {c}"


//Agora um exemplo com um gráfico a ser plotado
//É passado uma lista de valores inteiros no intervo 0<=x<=10
//Em seguida, a função exec é executado 3 vezes, cada um passando uma função diferente e a lista de valores de x, respectivamente
//O resultado é plotado no gráfico

let xValues = [1..10]
let fxValues = [for i in xValues -> exec f i]
let gxValues = [for i in xValues -> exec g i]
let hxValues = [for i in xValues -> exec h i]

[
  Chart.Line(xValues, fxValues, Name="f(x) = x² + 2")
  Chart.Line(xValues, gxValues, Name="g(x) = f(x+1)")
  Chart.Line(xValues, hxValues, Name="h(x) = -f(x)")
]
|> Chart.combine
|> Chart.withTitle "High Order Functions - three executions of function Exec that receive a function as parameter"
|> Chart.show