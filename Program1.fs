open System

// Задание 1
let lengthsLine () =
    [ for _ in 1 .. 5 do
        printf "Введите строку: "
        let line = Console.ReadLine()
        yield line.Length ]

[<EntryPoint>]
let main args =
    let lengths = lengthsLine ()
    printfn "Длины строк: %A" lengths
    0