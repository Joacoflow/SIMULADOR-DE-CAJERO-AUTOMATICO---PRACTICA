using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYEECTO___SIMULADOR_DE_CAJERO_AUTOMATICO
{
    internal class Eleccion
    {
        //Joaquin Deza Diaz - 
        int selecuser, max = 30500;
        int contadordSaldo = 0, contadordPuntos = 0;
        usuarios usu = new usuarios();
        
        public void primeraparte()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒" +
                          "\r\n▒▒▄▄▄▒▒▒█▒▒▒▒▄▒▒▒▒▒▒▒▒\r\n" +
                          "    ▒█▀█▀█▒█▀█▒▒█▀█▒▄███▄▒\r\n" +
                          "    ░█▀█▀█░█▀██░█▀█░█▄█▄█░\r\n" +
                          "    ░█▀█▀█░█▀████▀█░█▄█▄█░\r\n" +
                          "    ████████▀█████████████");
            Console.WriteLine("BIENVENIDO AL CAJERO DE");
            Console.WriteLine("DOUG DIMMADOME DUEÑO DEL ");
            Console.WriteLine("DIMMADOMO DE DIMMSDALE EN EL DIMMADOMO");
            Console.WriteLine("*******APP PARA IOS, ADNROID **********");
            Console.WriteLine("*********SOLO BCP**********");

        }
        public void eleciusuarios(int conf)
        {
            do
            {
                primeraparte();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Escoga la opcion que va a realizar");
                Console.WriteLine("1- Consulte su saldo");
                Console.WriteLine("2- Retirar");
                Console.WriteLine("3- Transferencias");
                Console.WriteLine("4- Revise sus puntos en la tarjeta BCP");
                Console.WriteLine("5- Canje de productos por puntos BCP");
                Console.WriteLine("6- ¿Que deudas pagar primero?");
                Console.WriteLine("7- Entra aqui y participa en el sorteo");
                Console.WriteLine("8- Salir");
                Console.ForegroundColor = ConsoleColor.White;
                selecuser = int.Parse(Console.ReadLine());
                switch (selecuser)
                {
                    case 1:
                        Console.Clear();
                        conSaldo(conf);
                        Console.WriteLine("Presione una tecla para continuar.");
                        Console.ReadKey();
                        Console.Clear();
                        eleciusuarios(conf);
                        break;
                    case 2:
                        Console.Clear();
                        retiro(conf);
                        break;
                    case 3:
                        Console.Clear();
                        trans(conf);
                        break;
                    case 4:
                        Console.Clear();
                        conPuntos(conf);
                        Console.WriteLine("Presione una tecla para continuar.. ");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 5:
                        Console.Clear();
                        canjeoPuntos(conf);
                        break;
                    case 6:
                        Console.Clear();
                        Prioridedeudas(conf);
                        Console.ReadKey();
                        Console.Clear();
                        eleciusuarios(conf);
                        break;
                    case 7:
                        Console.Clear();
                        entrarsorteo(conf);
                        Console.ReadKey();
                        Console.Clear();
                        eleciusuarios(conf);

                        break;
                    case 8:
                        Console.Clear();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("");
                        Console.WriteLine("Opcion NO VALIDA");
                        Console.WriteLine("Ingrese denuevo la opcion que desea elegir");
                        
                        break;

                }


            } while (selecuser != 8);
        }

        private void conSaldo(int conf)
        {
            primeraparte();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Opcion 1 ->  CONSULTA DE SALDO: ");
            Console.WriteLine($"SU SALDO ES DE : S/.{usu.saldo[conf]}");
        }
        private void retiro(int conf)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Opcion 2 -> RETIRO");
            Console.WriteLine("Registre el monto a retirar: ");
            Console.WriteLine("1. S/.100");
            Console.WriteLine("2. S/.500");
            Console.WriteLine("3. S/.1000");
            Console.WriteLine("4. S/.5000");
            Console.WriteLine("5. S/.10000");
            Console.ForegroundColor = ConsoleColor.White;
            int seleretiro = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            switch (seleretiro)
            {
                case 1:
                    if (100 <= usu.saldo[conf])
                    {
                        contadordPuntos += 100;
                        contadordSaldo += 100;
                        if (contadordSaldo <= max)
                        {
                            usu.saldo[conf] -= 100;
                            Console.WriteLine("Listo. Retire su dinero porfavor.");
                            Console.WriteLine($"Saldo Actual: S/.{usu.saldo[conf]}");
                        }
                        else
                        {
                            Console.WriteLine("Solo puede retirar S/.30 500");
                            contadordSaldo += 100;
                            contadordPuntos -= 100;
                        }

                    }
                    else
                        Console.WriteLine("Saldo insuficiente");
                    Console.WriteLine("Presione una tecla para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                    eleciusuarios(conf);
                    break;
                //Repetimos los mismo casos para lo demas considerando el precio elegido de 1-5
                case 2:

                    if (500 <= usu.saldo[conf])
                    {
                        contadordPuntos += 500;
                        contadordSaldo += 500;
                        if (contadordSaldo <= max)
                        {
                            usu.saldo[conf] -= 500;
                            Console.WriteLine("Listo. Retire su dinero porfavor.");
                            Console.WriteLine($"Saldo Actual: S/.{usu.saldo[conf]}");
                        }
                        else
                        {
                            Console.WriteLine("Solo puede retirar S/.30 500");
                            contadordSaldo += 500;
                            contadordPuntos -= 500;
                        }

                    }
                    else Console.WriteLine("Saldo insuficiente");
                    Console.WriteLine("Presione una tecla para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                    eleciusuarios(conf);
                    break;
                case 3:
                    if (1000 <= usu.saldo[conf])
                    {
                        contadordPuntos += 1000;
                        contadordSaldo += 1000;
                        if (contadordSaldo <= max)
                        {
                            usu.saldo[conf] -= 1000;
                            Console.WriteLine("Listo. Retire su dinero porfavor.");
                            Console.WriteLine($"Saldo Actual: S/.{usu.saldo[conf]}");
                        }
                        else
                        {
                            Console.WriteLine("Solo puede retirar S/.30 500");
                            contadordSaldo += 1000;
                            contadordPuntos -= 1000;
                        }

                    }
                    else Console.WriteLine("Saldo insuficiente");
                    Console.WriteLine("Presione una tecla para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                    eleciusuarios(conf);
                    break;
                case 4:
                    if (5000 <= usu.saldo[conf])
                    {
                        contadordPuntos += 5000;
                        contadordSaldo += 5000;
                        if (contadordSaldo <= max)
                        {
                            usu.saldo[conf] -= 5000;
                            Console.WriteLine("Listo. Retire su dinero porfavor.");
                            Console.WriteLine($"Saldo Actual: S/.{usu.saldo[conf]}");
                        }
                        else
                        {
                            Console.WriteLine("Solo puede retirar S/.30 500");
                            contadordSaldo += 5000;
                            contadordPuntos -= 5000;
                        }

                    }
                    else Console.WriteLine("Saldo insuficiente");
                    Console.WriteLine("Presione una tecla para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                    eleciusuarios(conf);
                    break;
                case 5:
                    if (10000 <= usu.saldo[conf])
                    {
                        contadordPuntos += 10000;
                        contadordSaldo += 10000;
                        if (contadordSaldo <= max)
                        {
                            usu.saldo[conf] -= 10000;
                            Console.WriteLine("Listo. Retire su dinero porfavor.");
                            Console.WriteLine($"Saldo Actual: S/.{usu.saldo[conf]}");
                        }
                        else
                        {
                            Console.WriteLine("Solo puede retirar S/.30 500");
                            contadordSaldo += 10000;
                            contadordPuntos -= 10000;
                        }

                    }
                    else Console.WriteLine("Saldo insuficiente");
                    Console.WriteLine("Presione una tecla para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                    eleciusuarios(conf);
                    break;


            }
        }

        private void trans(int conf)
        {
            primeraparte();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(" Usted escogio la opcion 3 ->> ---- TRASNFERENCIA ----");
            Console.WriteLine("Ingrese la tarjeta de la cuenta donde va transferir dinero: ");
            Console.ForegroundColor = ConsoleColor.White;
            int trans1 = int.Parse(Console.ReadLine()); 
            int cuentaexisval = usu.valDoc(trans1);
            Console.ForegroundColor = ConsoleColor.Cyan;
            while (cuentaexisval != -1)
            {
                Console.WriteLine("Cuenta registrada correctamente.");

            }
           
            Console.WriteLine("Ingrese el monto a transferir: ");
            Console.WriteLine("1- 500 ");
            Console.WriteLine("2- 1000 ");
            Console.WriteLine("3- 2000 ");
            Console.WriteLine("4- 5000 ");
            Console.ForegroundColor = ConsoleColor.White;
            int trans2 = int.Parse(Console.ReadLine());
            int verificacion = usu.valDoc(trans1);
            Console.ForegroundColor = ConsoleColor.Cyan;

            switch (trans2)
            {
                case 1:
                    if (500 <= usu.saldo[conf])
                    {
                        Console.WriteLine("TRANSFERENCIA HECHA CORRECTAMENTE. ");
                        usu.saldo[conf] -= 500;
                        Console.WriteLine("Monto transferido : S/.500 al numero de cuenta elegido.");
                        Console.WriteLine("PRESIONE UNA TECLA PARA CONTINUAR...");
                        Console.ReadKey();
                        conSaldo(conf);
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("Saldo insuficiente");
                    }
                    break;
                // Asi repetimos para los otros 3 casos solo cambiando el monto elegido por el usuario.
                case 2:
                    if (1000 <= usu.saldo[conf])
                    {
                        Console.WriteLine("TRANSFERENCIA HECHA CORRECTAMENTE. ");
                        usu.saldo[conf] -= 1000;
                        Console.WriteLine($"Monto transferido : 500 al numero de cuenta -> {usu.id[verificacion]}");
                        Console.ReadKey();
                        Console.Clear();
                        conSaldo(conf);
                        Console.WriteLine("Presione una tecla para continuar..");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else Console.WriteLine("Saldo insuficiente");
                    break;
                case 3:
                    if (2000 <= usu.saldo[conf])
                    {
                        Console.WriteLine("TRANSFERENCIA HECHA CORRECTAMENTE. ");
                        usu.saldo[conf] -= 2000;
                        Console.WriteLine($"Monto transferido : 500 al numero de cuenta -> {usu.id[verificacion]}");
                        Console.ReadKey();
                        Console.Clear();
                        conSaldo(conf);
                        Console.WriteLine("Presione una tecla para continuar..");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else Console.WriteLine("Saldo insuficiente");
                    break;
                case 4:
                    if (5000 <= usu.saldo[conf])
                    {
                        Console.WriteLine("TRANSFERENCIA HECHA CORRECTAMENTE. ");
                        usu.saldo[conf] -= 5000;
                        Console.WriteLine($"Monto transferido : 500 al numero de cuenta -> {usu.id[verificacion]}");
                        Console.ReadKey();
                        Console.Clear();
                        conSaldo(conf);
                        Console.WriteLine("Presione una tecla para continuar..");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else Console.WriteLine("Saldo insuficiente");
                    break;
            }
        }

        private void conPuntos(int conf)
        {
            primeraparte();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Opcion 4 ->  CONSULTA DE PUNTOS DE TU TARJETA BCP");
            Console.WriteLine($"Sus puntos son: {usu.points[conf]}");


        }
        private void canjeoPuntos(int conf)
        {
            primeraparte();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Opcioon 5 -> ESCOGIO CANJE DE PRODUCTOS POR PUNTOS ");
            Console.WriteLine("Seleccione cuantos puntos quiere canjear.");
            Console.WriteLine("1. 1000");
            Console.WriteLine("2. 2000");
            Console.WriteLine("3. 4000");
            Console.WriteLine("4. 5000");
            Console.WriteLine("5. 8000");
            Console.ForegroundColor = ConsoleColor.White;
            int escogpuntos = int.Parse(Console.ReadLine());
            switch (escogpuntos)
            {
                case 1:
                    if (1000 <= usu.points[conf])
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        usu.points[conf] -= 1000;
                        Console.Clear();
                        Console.WriteLine("----------EL TICKET ELEGIDO ES DE 1000-----------\n");
                        Console.WriteLine("El canje de punto se realizo correctamente.");
                        Console.WriteLine("Usted ha obtenido un peluche.");
                        Console.WriteLine("Ingrese ala web de nuestro patrocinador: DIN DIMADON.");
                        Console.WriteLine("Para canjear los premios.");
                        Console.WriteLine($"Puntos actuales: {usu.points[conf]}\n");
                        Console.WriteLine("Presione una tecla para continuar....");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("Lamentablemente usted no posee o no alcanza los puntos necesarios.");
                        Console.WriteLine("Presione cualquier tecla para continuar....");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    break;
                //Asi repetimos lo mismo para los otros casos de regalos.
                case 2:
                    if (2000 <= usu.points[conf])
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        usu.points[conf] -= 2000;
                        Console.Clear();
                        Console.WriteLine("----------EL TICKET ELEGIDO ES DE 2000-----------\n");
                        Console.WriteLine("El canje de punto se realizo correctamente.");
                        Console.WriteLine("Usted ha obtenido un Collar de perla.");
                        Console.WriteLine("Ingrese ala web de nuestro patrocinador: DIN DIMADON.");
                        Console.WriteLine("Para canjear los premios.");
                        Console.WriteLine($"Puntos actuales: {usu.points[conf]}\n");
                        Console.WriteLine("Presione una tecla para continuar....");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("Lamentablemente usted no posee o no alcanza los puntos necesarios.");
                        Console.WriteLine("Presione cualquier tecla para continuar....");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    break;
                case 3:
                    if (4000 <= usu.points[conf])
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        usu.points[conf] -= 4000;
                        Console.Clear();
                        Console.WriteLine("----------EL TICKET ELEGIDO ES DE 2000-----------\n");
                        Console.WriteLine("El canje de punto se realizo correctamente.");
                        Console.WriteLine("Usted ha obtenido una cartuchera.");
                        Console.WriteLine("Ingrese ala web de nuestro patrocinador: DIN DIMADON.");
                        Console.WriteLine("Para canjear los premios.");
                        Console.WriteLine($"Puntos actuales: {usu.points[conf]}\n");
                        Console.WriteLine("Presione una tecla para continuar....");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("Lamentablemente usted no posee o no alcanza los puntos necesarios.");
                        Console.WriteLine("Presione cualquier tecla para continuar....");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    break;
                case 4:
                    if (5000 <= usu.points[conf])
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        usu.points[conf] -= 5000;
                        Console.Clear();
                        Console.WriteLine("----------EL TICKET ELEGIDO ES DE 2000-----------\n");
                        Console.WriteLine("El canje de punto se realizo correctamente.");
                        Console.WriteLine("Usted ha obtenido un Gorro de los BULLS.");
                        Console.WriteLine("Ingrese ala web de nuestro patrocinador: DIN DIMADON.");
                        Console.WriteLine("Para canjear los premios.");
                        Console.WriteLine($"Puntos actuales: {usu.points[conf]}\n");
                        Console.WriteLine("Presione una tecla para continuar....");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("Lamentablemente usted no posee o no alcanza los puntos necesarios.");
                        Console.WriteLine("Presione cualquier tecla para continuar....");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    break;
                case 5:
                    if (8000 <= usu.points[conf])
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        usu.points[conf] -= 8000;
                        Console.Clear();
                        Console.WriteLine("----------EL TICKET ELEGIDO ES DE 2000-----------\n");
                        Console.WriteLine("El canje de punto se realizo correctamente.");
                        Console.WriteLine("Usted ha obtenido unos audfinos BLUETOOH.");
                        Console.WriteLine("Ingrese ala web de nuestro patrocinador: DIN DIMADON.");
                        Console.WriteLine("Para canjear los premios.");
                        Console.WriteLine($"Puntos actuales: {usu.points[conf]}\n");
                        Console.WriteLine("Presione una tecla para continuar....");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("Lamentablemente usted no posee o no alcanza los puntos necesarios.");
                        Console.WriteLine("Presione cualquier tecla para continuar....");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    break;
            }
        }
        //---------------------------------------------------------------
        private int[] vector;
        private void Prioridedeudas(int conf)
        {

            primeraparte();
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("Opcion 6 -> DEUDAS A CANCELAR PRIMERO ");

            Console.WriteLine("Ingrese cuantas deudas posee ");

            string linea = Console.ReadLine();

            int cant = int.Parse(linea);

            vector = new int[cant];



            for (int f = 0; f < vector.Length; f++)

            {

                Console.Write("Ingrese deuda " + (f + 1) + ": S/.");

                linea = Console.ReadLine();

                vector[f] = int.Parse(linea);

            }

            int t;

            for (int a = 1; a < vector.Length; a++)

            {
                for (int b = 0; b < vector.Length - 1; b++)
                {
                    if (vector[b + 1] < vector[b])

                    {
                        t = vector[b + 1];

                        vector[b + 1] = vector[b];

                        vector[b] = t;

                    }

                }

            }

            Console.WriteLine("Ordenado de forma prioridad de pago ");

            for (int f = 0; f < vector.Length; f++)

            {

                Console.Write(vector[f] + " ");

            }
            Console.WriteLine("");
            Console.WriteLine("Presione cualquier tecla para continuar....");


        }

        private void entrarsorteo(int conf)

        {
            primeraparte();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("OPCION 7 ---> ENTRAR AL SORTEO");
            Console.WriteLine("El sorteo se llevara a cabo en 10 dias");
            Console.WriteLine("Para ello ingresa tu nombre y apellidos, nosotros te generaremos un correo " +
                "con el que participaras");
            Console.WriteLine();
            Console.Write("Escriba su Primer nombre: ");

            String Nombre = Console.ReadLine();

            char[] Caracter = Nombre.ToCharArray();

            Console.Write("Escriba su Primer Apellido: ");

            String Apellido = Console.ReadLine();

            char[] Caracter2 = Apellido.ToCharArray();

            Array.Reverse(Caracter2);

            Console.Write("Escriba su Edad: ");
            String Edad = Console.ReadLine();
            char[] Caracter3 = Edad.ToCharArray();

            String texto = "Su correo seria: ";

            for (int i = 0; i < 3; i++)

            {
                texto += Caracter[i];
            }

            texto += ".";

            for (int i = 0; i < 2; i++)
            {
                texto += Caracter2[i];
            }

            for (int i = 0; i < 2; i++)
            {
                texto += Caracter3[i];
            }

            texto += "@dimadon.com";
         
            Console.WriteLine(texto);
            Console.WriteLine();

            Console.WriteLine("Ahora " + texto + " y ya podras participar en muchos sorteos en nuestra pagina web.");
            Console.WriteLine();
            Console.WriteLine("Presione una tecla para continuar..");

        }
    }
}

