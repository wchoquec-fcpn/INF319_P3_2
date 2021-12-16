open System
    
let convertir num =
    let mutable num=num
    let mutable digito=0
    let mutable exp=0
    let mutable  binario=0
    while (num<>0) do
        digito <- num % 2
        binario <- binario + digito*(pown 10 exp)
        exp<- exp+1
        num<-num/2
    binario

[<EntryPoint>]
let main argv = 
    let numero=7
    let  Binario=convertir numero 
    printfn " %i en Binario = %i" numero Binario

    Console.ReadKey() |>ignore
    0 // return an integer exit code
