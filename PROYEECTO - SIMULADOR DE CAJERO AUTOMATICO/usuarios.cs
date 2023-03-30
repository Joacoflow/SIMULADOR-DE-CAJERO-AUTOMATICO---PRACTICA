using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYEECTO___SIMULADOR_DE_CAJERO_AUTOMATICO
{
    internal class usuarios
    {   //Deza Diaz Joaquin Alfredo 
        //Registramos los valores que se usaran en el cajero:
        //PARA ESTO USAMOS ARRAYS:
        public int[] id = { 1757, 3456, 2789 }; //USUARIO QUE INGRESAMOS
        public int[] contraseña = { 2012, 2020, 2004 }; //RESPECTIVAS CONTRASEÑAS
        public int[] saldo = {10500, 22000, 14500}; //SUS SALDOS DE CADA UNO
        public int[] points = {2800, 5000, 8900 }; //SUS PUNTOS DE CADA UNO

        public int valDoc(int dni) 

        {
            int respuesta = -1;
            for (int i = 0; i < id.Length; i++)
            {
                if (id[i] == dni)
                {
                    respuesta = i;
                }
            }
            return respuesta;

        }

        public int valPass(int clave) 
        {
            int respuesta = -1;

            for (int i = 0; i < contraseña.Length; i++)
            {
                if (contraseña[i] == clave)
                {
                    respuesta = i;
                }

            }
            return respuesta;   

        }
    }
}
