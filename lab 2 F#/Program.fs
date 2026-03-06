open System

let AddChar char str :string=
    str+char

let rec RecInput () =
    printfn "введите символ: "
    let input = Console.ReadLine()
    if input.Length = 1 then 
        input
    else
        printfn "1 символ!"
        RecInput ()


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

    let char = RecInput ()
    let new_list = (List.map (AddChar char ) MyList)
    printf "Итоговый результат: %A" new_list
    0
