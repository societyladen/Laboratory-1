open System

// Задание 2
let rec sumOfDigits x =
    if x = 0 then
        0
    else
        let lastDigit = x % 10
        let isEven = lastDigit % 2 = 0
        let value = if isEven then lastDigit else 0
        value + sumOfDigits (x / 10)

[<EntryPoint>]
let main args =
    printf "Введите x для подсчета суммы четных цифр натурального числа числа: "
    let x = int (Console.ReadLine())
    if x <= 0 then
        printfn "Вы ввели не натуральное число"
        else
            printfn "Сумма четных цифр числа %d = %d" x (sumOfDigits x)
    0
