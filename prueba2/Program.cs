using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        //Se define la ruta del archivo a analizar
        string Archivo = "datos.txt";

        //Inicialización de las variables.
        decimal totalVentas = 0;
        HashSet<string> productosUnicos = new HashSet<string>(); //Inicialización de los nombres de productos únicos

        try
        {
        
            string[] lineas = File.ReadAllLines(Archivo); //Lee todas las líneas del archivo y las almacena en un array de strings 

            // Procesar cada línea
            foreach (string linea in lineas) //Recorre todas las lineas del array
            {
                //Divide cada línea en partes usando "|" como separador y almacena las partes en el array 
                string[] partes = linea.Split('|');

                // Obtener datos de cada parte
                string nombreProducto = partes[0]; //Almacena el nombre del producto
                int cantidad = int.Parse(partes[1]); //Almacena la cantidad
                decimal precioUnitario = decimal.Parse(partes[2]); //Almacena el precio unitaro
                decimal precioTotal = decimal.Parse(partes[3]); //Almacena el total 

                
                totalVentas += precioTotal; // Suma el precio total a totalVentas

                productosUnicos.Add(nombreProducto); //Añade el nombreProducto al HashSet productosUnicos, evitando automáticamente duplicados
            }

            // Imprimir el total de ventas
            Console.WriteLine($"Total: {totalVentas}");

            // Imprimir productos únicos
            Console.WriteLine("Productos únicos:"); //Imprime el encabezado 
            foreach (string producto in productosUnicos) //iterar sobre cada producto en productosUnicos e imprime el nombre del producto.
            {
                Console.WriteLine(producto);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Se produjo un error: {ex.Message}");
        }
    }
}
