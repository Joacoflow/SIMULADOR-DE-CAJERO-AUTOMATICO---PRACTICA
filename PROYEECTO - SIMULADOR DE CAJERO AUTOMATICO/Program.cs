using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYEECTO___SIMULADOR_DE_CAJERO_AUTOMATICO
{
    internal class Program
    {    //Deza Diaz Joaquin.
        /*Para este proyecto realizaremos un sistema de cajero automatico donde
        te doy 3 cuentas con el dni y la clave->   1) DNI: 1757 , contra:2012
        2)  DNI: 3456 , contra:2020       3) DNI: 2789 , contra: 2004   
        Luego tendremos     las 2 clases usadas denominadas : usuarios y Eleccion.
        */
        static void Main(string[] args)
        {
          
            usuarios users = new usuarios();
            Eleccion elec = new Eleccion();
            //Inicializamos valores:
            int dni, clave, conf, conf2;

            do
            {
               
                try
                {
                    elec.primeraparte();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    //Pedimos el numero de Dni y lo escribmos (lo tenemos arriba)
                    Console.WriteLine("Ingrese el numero de DNI: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    dni = int.Parse(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.Blue;
                    //Digitamos la clave del usuario
                    Console.WriteLine("Ingrese su clave: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    clave = int.Parse(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    //confirmacion = conf
                    conf =  users.valDoc(dni);
                    conf2 = users.valPass(clave);

                    if (conf != -1 && conf2 != -1 && conf == conf2)
                    {
                        Console.Clear();
                        Console.WriteLine("Se confirmo su registro exitosamente\n");
                        elec.eleciusuarios(conf);
                    }
                    else
                    {
                        Console.WriteLine("No se logro registrar, Usuario Incorrecto");
                        Console.WriteLine("Inicie nuevamente el programa.");
                       

                    }
                }
                catch (FormatException )
                {
                    Console.WriteLine(" Has ingresado datos no validos");
                    conf = -1;
                } 
                } while (conf !=-1);

            }
        }
    }

