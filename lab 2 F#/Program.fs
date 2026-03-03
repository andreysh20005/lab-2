open System

let add_char char str :string=
    str+char

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
            let rec rec_input () =
                printfn "введите символ: "
                let input = Console.ReadLine()
                if input.Length = 1 then 
                    input
                else
                    printfn "1 символ!"
                    rec_input ()
            let char = rec_input ()
            printf "%A" (List.map (add_char char ) my_list)
    else
        printf "число не является целым"
    0