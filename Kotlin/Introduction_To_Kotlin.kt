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
    fun f6() : Int{
        var suma = 0
        for(i in 10 until 100){
            suma += i
        }
        return suma
    }
	fun f7(a : Int) : Int{
        var x = a
        var suma = 0
        while (x >= 1){
            suma += x % 10
            x = x / 10
        }
        return suma
    }    
	fun f8(n : Int) : Array<Int>{
        var T = arrayOf(1)
        for (i in 2 until n){
            if (n % i == 0){
                T = T + i
            }
            
        }
        return T
        
    }
    fun f9(n: Int): MutableList<Int> {
        val T = mutableListOf(0, 1)
        for (i in 2 until n) {
            val suma = T[i - 2] + T[i - 1]
            T.add(suma)
    	}
    	return T
	}	
}

