open System

// Ввод числа
let readComplex () =
    printf "Введи действительную часть: "
    let real = float(Console.ReadLine())
    printf "Введи мнимую часть: "
    let imag = float(Console.ReadLine())
    (real, imag)

// Вывод числа
let printComplex (real, imag) =
    if imag < 0.0 then
        printfn "%f - %fi" real (abs imag)
    else
        printfn "%f + %fi" real imag

// Сложение
let add (a, b) (c, d) = 
    (a + c, b + d)

// Вычитание
let subtract (a, b) (c, d) = 
    (a - c, b - d)

// Умножение
let multiply (a, b) (c, d) = 
    (a * c - b * d, a * d + b * c)

// Деление
let divide (a, b) (c, d) =
    let denominator = c * c + d * d
    if denominator = 0.0 then
        printfn "Ошибка: деление на 0!"
        (0.0, 0.0)
    else
        let (x, y) = multiply (a, b) (c, -d)
        (x / denominator, y / denominator)

// Возведение в степень
let rec pow z n =
    if n < 0 then
        printfn ">>> ПРЕДУПРЕЖДЕНИЕ: Степень должна быть неотрицательной! (ты ввел %d)" n
        printfn ">>> Будет возведено в степень 0 (верну 1 + 0i)"
        (1.0, 0.0)
    else
        if n = 0 then 
            (1.0, 0.0)
        else
            if n = 1 then 
                z
            else 
                multiply z (pow z (n - 1))

[<EntryPoint>]
let main args =
    printfn "Вводим первое число"
    let num1 = readComplex()
    printfn "Первое число = "
    printComplex num1
    
    printfn "Вводим второе число"
    let num2 = readComplex()
    printfn "Второе число = "
    printComplex num2
    
    printfn "Результаты"
    
    printfn "Сложение: "
    printComplex (add num1 num2)
    
    printfn "Вычитание: "
    printComplex (subtract num1 num2)
    
    printfn "Умножение: "
    printComplex (multiply num1 num2)
    
    printfn "Деление: "
    printComplex (divide num1 num2)
    
    printfn "Возводим первое число в степень: "
    printfn "Введи степень (целое неотрицательное число): "
    let n = int(Console.ReadLine())
    
    printfn "Результат: "
    printComplex (pow num1 n)
    
    0
