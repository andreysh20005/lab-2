open System

let MinimumLenth (a: string) (b: string) = 
    if a.Length < b.Length then
        a
    else
        b


let rec InputNum () = 
    printfn "введите количество элементов списка:"
    let flag, n = Int32.TryParse(Console.ReadLine())

    if flag then
        if n <= 0 then 
            printfn "число не является натуральным!"
            InputNum ()
        else n
    else
        printfn "не является целым числом!"
        InputNum ()
        


[<EntryPoint>]
let main _ =

    let n = InputNum () 
    let MyList = 
        [
            for i in 1..n do
                printfn "введите строку:"
                yield Console.ReadLine()
        ]  
    let MinStrLen = (List.fold MinimumLenth MyList.Head MyList.Tail).Length
    printf "минимальная длинна строки списка = %d" MinStrLen
    0
