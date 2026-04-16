func sort(t: [Int]) -> [Int] {
    var arr = t

    for i in 1..<arr.count {
        let key = arr[i]
        var j = i - 1

        while j >= 0 && arr[j] > key {
            arr[j + 1] = arr[j]
            j -= 1
        }

        arr[j + 1] = key
    }

    return arr
}


let list = readLine()!
    .split(separator: " ")
    .map { Int($0)! }


print(sort(t: list))

func sumOfNumbers(t: Int) -> Int {
    let str = String(t)
    var sum = 0

    for ch in str {
        sum += Int(String(ch))!
    }

    return sum
}

let t = Int(readLine()!)!

print(sumOfNumbers(t: t))



func isPrime(a: Int) -> Bool {
    let num = abs(a)

    if num < 2 {
        return false
    }

    for i in 2...max(2, num/2) {
        if num % i == 0 {
            return false
        }
    }

    return true
}

let a = Int(readLine()!)!
print(isPrime(a: a))


func tabArray(t: [Int]) -> Int {
    let maxVal = t.max()!
    let minVal = t.min()!

    return maxVal - minVal
}

let tab = readLine()!
    .split(separator: " ")
    .map { Int($0)! }

print(tabArray(t: tab))


func Euklides(a : Int, b : Int) -> Int {
    var a = abs(a)
    var b = abs(b)
    while b != 0 {
        let temp = b;
        b = a % b
        a = temp
    }
    return a
}

let a = Int(readLine()!)!
let b = Int(readLine()!)!

print(Euklides(a: a, b: b))




func Horner(t:[Int], x: Int) -> Int {
    var wynik = 0;
    for coef in t.reversed(){
        wynik = wynik * x + coef
    }
    return wynik
}

print("Podaj długość wielomianu")

let n = Int(readLine()!)!
var list : [Int] = []

for _ in 0..<n{
    print("podaj współczynnik")
    
    let x = Int(readLine()!)!
    list.append(x)
}

print("podaj x")

let x = Int(readLine()!)!

print(Horner(t: list, x: x))
