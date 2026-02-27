open System

// Задание 1
let lengthsLine count =
    [ for _ in 1 .. count do
        printf "Введите строку: "
        let line = Console.ReadLine()
        yield line.Length ]

[<EntryPoint>]
let main args =
    printf "Введите количество строк: "
    let count = Console.ReadLine() |> int
    let lengths = lengthsLine count
    printfn "Длины строк: %A" lengths
    0
