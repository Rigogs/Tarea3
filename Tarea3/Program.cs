using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea3
{
    class Program
    {
        static int opcion = 0;
        static int i = 0;
        static int size = 5;
        [Flags]
        enum edad
        {
            Menores = 0,
            Jovenes = 19,
            Adultos= 30,
        };
        struct Info
        {
            public int codigo;
            public string nombre;
            public string sexo;
            public double edad;
        };

        static Info[] info;

        static void Ingre()
        {
            int r = 0;
            while (r != 1)
            {
                Console.Clear();
                if (i < info.Length)
                {
                    Console.WriteLine("=================================");
                    Console.WriteLine("-* Listado estudiantil *-*");
                    Console.WriteLine("=================================");
                    Console.WriteLine("Universidad UH");
                    Console.WriteLine("----------------------------------");
                    Console.WriteLine("Ingreso de informacion.             ");
                    Console.Write("Digite el codigo:                  ");
                    info[i].codigo = int.Parse(Console.ReadLine());
                    Console.Write("Digite el nombre del estudiante:    ");
                    info[i].nombre = Console.ReadLine();
                    Console.Write("Digite el sexo del estudiante:     ");
                    info[i].sexo = Console.ReadLine();
                    Console.WriteLine("Ingrese la edad del estudiante:");
                    Console.Write(edad.Menores + ":" + (int)edad.Menores + "\n" +
                                  edad.Jovenes + ":" + (int)edad.Jovenes + "\n" +
                                  edad.Adultos + ":" + (int)edad.Adultos + "\n");
                    Console.Write("La edad es: ");
                    info[i].edad = double.Parse(Console.ReadLine());
                    Console.WriteLine("Edad " + info[i].edad);
                    Console.WriteLine("Desea agregar otro estudiante 0-Sí 1-No");
                    r = int.Parse(Console.ReadLine());
                    i++;
                }
                else
                {
                    Console.WriteLine("Registro de estudiantes lleno.");
                    r = 1;
                    Console.ReadKey();
                }
            }

        }

        static void Listado()
        {
            int reg = 0;
            Console.Clear();
            Console.WriteLine("-* Listado estudiantil  *-*");
            Console.WriteLine("Listado de estudiantes.             ");
            for (i = 0; i < info.Length; i++)
            {
                reg = i + 1;
                Console.WriteLine("Registro: " + reg);
                Console.WriteLine("ID:       " + info[i].codigo);
                Console.WriteLine("Nombre:   " + info[i].nombre);
                Console.WriteLine("Sexo:     " + info[i].sexo);
                Console.WriteLine("Edad:   " + info[i].edad);
            }
            Console.ReadKey();
        }

        static void Busqueda()
        { 
        int ID = 0;
        int reg = 0;
        int r = 0;
        bool found = false;
            while (r != 1)
            {
                Console.Clear();
                Console.WriteLine("-* Listado estudiantil  *-*");
                Console.WriteLine("Búsquedad de Estudiantes.           ");
                Console.WriteLine("Digite el ID del estudiante a buscar");
                ID = int.Parse(Console.ReadLine());
                for (i = 0; i < info.Length; i++)
                {

                    if (ID == info[i].codigo)
                    {
                        reg = i + 1;
                        Console.WriteLine("Registro: " + reg);
                        Console.WriteLine("ID:       " + info[i].codigo);
                        Console.WriteLine("Nombre:   " + info[i].nombre);
                        Console.WriteLine("Sexo:     " + info[i].sexo);
                        Console.WriteLine("Edad:   " + info[i].edad);
                        found = true;
                    }
                }

                    if (!found)
                    {
                        Console.WriteLine("NO ");
                        found = false;
                    }   
                Console.WriteLine("Desea buscar otro libro 0-Sí 1-No");
                r = int.Parse(Console.ReadLine());
                Console.ReadKey();
            }
            
        }

        static void Modi()
        {
            int r = 0;
            int ID = 0;
            Console.Clear();
            Console.WriteLine("-* Listado estudiantil  *-*");
            Console.WriteLine("Modificacion de Estudiantes.           ");
            Console.WriteLine("Digite el ID del estudiante a buscar");
            ID = int.Parse(Console.ReadLine());     
           {
                for (i = 0; i < info.Length; i++)
                {
                    if (ID == info[i].codigo)
                    {
                        Console.WriteLine("Ingreso de informacion.             ");
                        Console.WriteLine("Codigo del estudiante:      " + info[i].codigo);
                        Console.Write("Digite el nuevo codigo:  ");
                        info[i].codigo = int.Parse(Console.ReadLine());
                        Console.WriteLine("Nombre del estudiante:    " + info[i].nombre);
                        Console.Write("Nuevo nombre:  ");
                        info[i].nombre = Console.ReadLine();
                        Console.WriteLine("Sexo del estudiante:     " + info[i].sexo);
                        Console.Write("Digite el sexo:    ");
                        info[i].sexo = Console.ReadLine();
                        Console.WriteLine("Edad del estudiante:" + info[i].edad);
                        Console.WriteLine("Digite la edad del nuevo estudiante");
                        Console.Write(edad.Menores + ":" + (int)edad.Menores + "\n" +
                                      edad.Jovenes + ":" + (int)edad.Jovenes + "\n" +
                                      edad.Adultos + ":" + (int)edad.Adultos + "\n");
                        Console.Write("La edad es: ");
                        info[i].edad = double.Parse(Console.ReadLine());
                        Console.WriteLine("Edad " + info[i].edad);
                        Console.WriteLine("Desea modificar otro estudiante 0-Sí 1-No");
                        r = int.Parse(Console.ReadLine());
                        i++;
                    }
                }              
                Console.ReadKey();
            }
        }

        static void Borra()
        {
            int r = 0;
            int ID = 0;
            Console.Clear();
            Console.WriteLine("Digite el ID del estudiante a buscar");
            ID = int.Parse(Console.ReadLine());
            {
                for (i = 0; i < info.Length; i++)
                {
                    if (ID == info[i].codigo)
                    {
                        Console.WriteLine("Ingreso de informacion.             ");
                        Console.WriteLine("Codigo del estudiante:      " + info[i].codigo);
                        Console.WriteLine("Deseas borrar este codido: 0-Sí 1-No");
                        r = int.Parse(Console.ReadLine());
                        info[i].codigo = 0;
                    }
                    Console.WriteLine("Codigo borrado");
                    Console.ReadKey();
                }
            }
        }
                        static void Main(string[] args)
        {
            info = new Info[size];
            do
            {
                Console.Clear();
                Console.WriteLine("-* Listado estudiantil  *-*");
                Console.WriteLine("1. Ingreso de estudiantes.");
                Console.WriteLine("2. Modificación de estudiantes.");
                Console.WriteLine("3. Borrado de estudiantes.");
                Console.WriteLine("4. Búsqueda de estudiantes.");
                Console.WriteLine("5. Listado de estudiantes.");
                Console.WriteLine("6. Informe clasificación de estudiantess.");
                Console.WriteLine("7. Salir.");
                Console.WriteLine("Selecciones una opción");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        {
                            Ingre();
                            break;
                        }
                    case 2:
                        {

                            Modi();
                            break;
                        }
                    case 3:
                        {
                            Borra();
                            break;
                        }
                    case 4:
                        {
                            Busqueda();
                            break;
                        }
                    case 5:
                        {
                            Listado();
                            break;
                        }
                    case 6:
                        {
                            //Venta similar a tarea1
                            break;
                        }
                    case 7:
                        //Salir
                        break;
                    default:
                        {
                            Console.WriteLine("Seleccione inválida..");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                }
            } while (opcion != 7);
        }
    }
}
