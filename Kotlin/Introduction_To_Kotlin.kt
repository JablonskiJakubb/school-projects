/**
 * You can edit, run, and share this code.
 * play.kotlinlang.org
 */
fun main() {
    fun f1(){
        println("Hello World!")
    }
    
    fun f2(a: Int, b: Int) : Int {
        var x = a
        var y = b
        while (x != y){
            if (x > y){
                x = x - y
            }else{
                y = y - x
            }
        }
        return x
    }
    fun f3(a: Int) : Boolean{
        var z = 0
        for (i in 1 until a){
            if (a % i == 0){
                z += i
            }
        }
        if (a == z){ return true}
        return false
    }
    fun f4(T: Array<Int>) : Array<Int>{
        for (j in 0 until T.size){
            var n = j
            for (i in j until T.size){
            	if(T[n] > T[i]){
                    n = i
                }
            }
            val temp = T[j]
            T[j] = T[n]
            T[n] = temp
        }
        return T
        }
    fun f5(x : Int, T : Array<Int>) : Int{
        val stop = T.size - 1
        var wynik = T[0]
        for (i in 1 .. stop){
            wynik = wynik * x + T[i]
        }
        return wynik
    }
    f1()
    println(f2(12,8))
    println(f3(6))
   	println(f4(arrayOf(12,10,5,25,2,57)).joinToString(", "))
    println(f5(3,arrayOf(4,2,5,-2)))
}

