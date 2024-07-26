using System;

class Program
{
    static void Main()
    {
        for (int i = 1; i <= 100; i++) //Empieza desde 1 siempre y cuando i sea menor o igual a 100, Incrementando i en 1 despues de cada iteración
        {
            if (i % 3 == 0 && i % 5 == 0) //Evalua si número es divisible por 3 y por 5  
            {
                Console.WriteLine("FizzBuzz"); //Si la condición anterior es verdadera, imprime "FizzBuzz"
            }
            else if (i % 3 == 0) //Evalua si número es divisible por 3
            {
                Console.WriteLine("Fizz"); //Si la condición anterior es verdadera, imprime "Fizz"
            }
            else if (i % 5 == 0) //Evalua si número es divisible por 5
            {
                Console.WriteLine("Buzz"); //Si la condición anterior es verdadera, imprime "Buzz"
            }
            else
            {
                Console.WriteLine(i); //Si ninguna de las condiciones anteriores se cumple, imprime el valor de i.
            }
        } //El bucle for continúa hasta que i alcanza 100.
    }
}
