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

//Agora um exemplo com as três funções (f,g,h) sendo executadas com o mesmo domínio:

let xValues = [1..10]
let fxValues = [for i in xValues -> exec f i]
let gxValues = [for i in xValues -> exec g i]
let hxValues = [for i in xValues -> exec h i]

printf "\n\n"


//Printando os valores
printf("X values: ")
printfn "%A" xValues


printf("f(x) values: ")
printfn "%A" fxValues


printf("g(x) values: ")
printfn "%A" gxValues


printf("h(x) values: ")
printfn "%A" hxValues