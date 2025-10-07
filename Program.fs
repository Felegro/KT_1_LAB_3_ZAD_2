// Lecture1 - создание списка
let binaryStrings = ["1"; "10"; "11"; "100"; "101"; "110"; "111"; "1000"; "1001"]

// Функция для преобразования двоичной строки в десятичное число
let binaryToDecimal binaryStr =
    let rec convert chars acc =
        match chars with
        | [] -> acc
        | head::tail ->
            let digit = if head = '1' then 1 else 0
            convert tail (acc * 2 + digit)
    convert (List.ofSeq binaryStr) 0

// Lecture1 - использование List.fold для вычисления суммы
let sumOfBinaryNumbers = 
    List.fold (fun acc binaryStr -> acc + binaryToDecimal binaryStr) 0 binaryStrings

// Lecture1 - вывод результатов
printfn "Список двоичных чисел: %A" binaryStrings
printfn "Сумма в десятичной системе: %d" sumOfBinaryNumbers