object GfG 
{  
    def convertir(n:Int) : String ={
      (n).toBinaryString
    }
    
    def main(args:Array[String]) 
    { 
        val entero=7
        val result = convertir(entero)
        println(entero+" a Binario="+result) 
        
    } 
} 