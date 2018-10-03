using System;

namespace bucles
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int num;

            Console.WriteLine("Introduce un número:");
            num = Convert.ToInt32(Console.ReadLine());

            while (i < 11)
            {
                Console.WriteLine(num + " x " + i + "=" + (num * i));
                i++;
            }

            //Mostrar bucle del 1 al 100
            int a = 1;

            Console.WriteLine("Introduce un número:");
            num = Int32.Parse(Console.ReadLine());

            while (a < 101)
            {
                Console.WriteLine(a);
                a++;
            }

            //Ejercicio do while
            a = 2;
            do
            {
                Console.WriteLine(a);
                a++;
            } while (a <= 100);

            //Pedir números hasta que se introduzca uno negativo
            Console.WriteLine("Introduce un número:");
            num = Int32.Parse(Console.ReadLine());

            while (num >= 0)
            {
                Console.WriteLine("Introduce un número:");
                num = Int32.Parse(Console.ReadLine());

            }


            do
            {
                Console.WriteLine("Introduce un número:");
                num = Int32.Parse(Console.ReadLine());
            } while (num >= 0);

            int k = 0;
            while (k <= 10)
            {
                Console.WriteLine(k);
                k = k + 2;
            }

            //Ejercicio con el for
            for (int j = 0; j <= 10; j = j + 2)
            {
                Console.WriteLine(j);
            }

            //El usuario debe introducir 4 números y debes realizar la suma de los 4 con for
            int suma = 0;
            int num;

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Introduce un número");
                num = Int32.Parse(Console.ReadLine());
                suma = suma + num;
            }

            Console.WriteLine("Total: " + suma);

            //Escribe un programa que muestre en pantalla los números del 10 al 20 (incluidos los dos) con una línea vacía entre ellos.
            int a = 10;

            while (a <= 20)
            {
                Console.WriteLine(a + Environment.NewLine);
                a++;
            }

            //Escribe un programa que muestre en pantalla los números del 20 al 10 (incluidos los dos) con una línea vacía entre ellos.
            int b = 20;

            while (b >= 10)
            {
                Console.WriteLine(b + Environment.NewLine);
                b--;
            }

            //Escribe un programa que pida 10 valores. Al final mostrar la media de esos valores.
            int media = 0;
            int num;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Introduce un número");
                num = Int32.Parse(Console.ReadLine());
                media = media + num;
            }
            Console.WriteLine(media / 3.0);

            //Escribe un programa que pida valores hasta que el usuario introduzca un 0. Si introduce un valor negativo, mostrar un mensaje diciendo que se ignoran los valores negativos. Mostrar la suma de los valores introducidos.
            int suma = 0;
            int num;
            do
            {
                Console.WriteLine("Introduce un número:");
                num = Int32.Parse(Console.ReadLine());
                if (num >= 0)
                {
                    suma = suma + num;
                    Console.WriteLine("La suma acumulada es : " + suma);
                }
                else
                {
                    Console.WriteLine("Se ignoran los valores negativos");
                }
            }
            while (num != 0);


            Console.WriteLine("Total: " + suma);

            //Escribe un programa que muestre todos los valores pares o impares entre 1 y 100 dependiendo de si el usuario introduce P o I . Si introduce otra cosa, decir que ese valor no es correcto y pedirle otra vez.
            string respuesta ="";
            while (respuesta != "p" && respuesta != "I")
            {
                Console.WriteLine("Escribe p o I para saber si es un número par o impar");
                respuesta = Console.ReadLine();
            }
            if (respuesta == "p")
            {
                for (int i = 2; i < 101; i = i + 2)
                {
                    Console.WriteLine(i);
                }
            }else

            {
                for (int i = 1; i < 101; i = i + 2)
                {
                    Console.WriteLine(i);
                }
            }

            //Escribe un programa que pregunte al usuario su edad. Mostrar en pantalla “Feliz cumpleaños” repetido tantas veces como años tenga.
            int edad;

            Console.WriteLine("¿Cuál es tu edad?");
            edad = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < edad; i++)
            {
                Console.WriteLine("Feliz cumpleaños");
            }

            //Pedir al usuario un número. Mostrar en pantalla
            Console.WriteLine("Introduce el número de lineas");
            int lineas = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < lineas; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            //Escribe un programa que muestre los números de 1 a 12 en una columna. En la columna de al lado de los números impares mostrar el cuadrado de ese valor y en la de los pares mostrar el cubo.
            for (int numFila = 1; numFila <= 12; numFila = numFila + 1)
            {
                if (numFila %2 == 0)//si la fila es par
                {
                    Console.WriteLine(numFila + "\t" + Math.Pow(numFila, 2)); // mostrar el numero de fila, un tabulador(\t), mostrar el cuadrado
                }
                else //si la fila es impar
                {
                    Console.WriteLine(numFila + "\t" + Math.Pow(numFila, 3)); // mostrar el numero de fila, un tabulador(\t), mostrar el cubo
                }
            }

            //Otra opción para el mismo ejercicio
            Console.WriteLine("\tNúmero \t\t Operación");
            Console.WriteLine("++++++++++++++++++++\n");
            for (int i = 1; i <= 12; i++)
            {
                Console.Write("\t" + i + "\t");
                if(i % 2 == 0)
                {
                    Console.Write("\t al cubo = " + Math.Pow(i, 3));
                }
                else
                {
                    Console.Write("\t al cuadrado = " + Math.Pow(i, 2));
                }
                Console.WriteLine();
            }

            //Ejercicio string
            String nombre = "arrate";
            Console.WriteLine(nombre.ToUpper());

            //Escribe un programa que te calcule la largura de un string
            String largura = "x";
            Console.WriteLine(largura.Length);

            //Escribe un programa que nos cuente el número de vocales en un string +++++++++++++++++++++++++++++++
            String palabra;
            int vocales = 0;

            Console.WriteLine("Escribe una palabra:");
            palabra = Console.ReadLine();

            for (int i = 0; i < palabra.Length; i++)
            {
                if(palabra [i] == 'a' || palabra[i] == 'e' || palabra[i] == 'i' || palabra[i] == 'o' || palabra[i] == 'u')
                {
                    vocales++;
                }
            }
            Console.WriteLine("La palabra " + palabra + " tiene " + vocales + " vocales");


            //Mostrar en pantalla los números del 20 al 30(incluidos 20 y 30). Hacerlo tres veces, una con for, una con while y una con do while
            int a = 20;

            while (a <= 30)
            {
                Console.WriteLine(a);
                a++;
            }

            //
            for (int b = 20; b <= 30; b++)
            {
                Console.WriteLine(b);
            }

            //
            int c = 20;

            do
            {
                Console.WriteLine(c);
                c++;
            }
            while (c <= 30);

            //Mostrar en pantalla los números del 48 al 43 (incluidos 48 y 43). Hacerlo tres veces, una con for, una con while y una con do while
            int d = 48;

            while (d >= 43)
            {
                Console.WriteLine(d);
                d--;
            }

            //
            for (int e = 48; e >= 43; e--)
            {
                Console.WriteLine(e);
            }

            //
            int f = 48;
            do
            {
                Console.WriteLine(f);
                f--;

            }
            while (f>= 43) ;

            //Mostrar en pantalla diez números, siendo el primero 1 y los siguientes la suma del número anterior y 5.
            for (int number = 1; number != 0; number = number + 5)
            {

            }

            Console.ReadLine();
        }


    }
}
