open System

let min (a: string) (b: string) = 
    if a.Length < b.Length then
        a
    else
        b

[<EntryPoint>]
let main _ =
    printf "введите количество элементов списка:"
    
    let flag, n  = Int32.TryParse(Console.ReadLine())

    if flag then
        if n<=0 then 
            printf "число не является натуральным!"
        else
            let my_list = 
                [
                    for i in 1..n do
                        printfn "введите строку:"
                        yield Console.ReadLine()
                ]
            
            printf "минимальная длинна строки списка = %A" (List.fold min my_list.Head my_list.Tail).Length
    else
        printf "число не является целым"
    0