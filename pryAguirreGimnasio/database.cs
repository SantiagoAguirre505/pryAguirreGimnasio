using System;
using System.Collections.Generic;
using System.Text;
namespace pryAguirreGimnasio
{
    public static class BaseDeDatos
    {

        // 1. ARRAY PARA SOCIOS 

        public static DatosResumen[] ArregloSocios = new DatosResumen[100];
        public static int ContadorSocios = 0;

        // Método para cargar los datos en el array
        public static bool AgregarSocio(DatosResumen nuevoSocio)
        {
            if (ContadorSocios < ArregloSocios.Length)
            {
                ArregloSocios[ContadorSocios] = nuevoSocio;
                ContadorSocios++;
                return true;
            }
            return false;
        }


        // 2. MATRIZ PARA TARJETAS (Arreglo Bidimensional)
        // 100 filas (para 100 tarjetas) y 5 columnas para los datos

        public static string[,] MatrizTarjetas = new string[100, 5];
        public static int ContadorTarjetas = 0;

        // Método para guardar una nueva tarjeta en la matriz
        public static bool AgregarTarjeta(string tipo, string numero, string titular, string vencimiento, string cvv)
        {
            // Verificamos que no nos pasemos del límite de 100 filas (GetLength(0) saca el total de filas)
            if (ContadorTarjetas < MatrizTarjetas.GetLength(0))
            {
                MatrizTarjetas[ContadorTarjetas, 0] = tipo;         // Columna 0: Tipo
                MatrizTarjetas[ContadorTarjetas, 1] = numero;       // Columna 1: Número
                MatrizTarjetas[ContadorTarjetas, 2] = titular;      // Columna 2: Titular
                MatrizTarjetas[ContadorTarjetas, 3] = vencimiento;  // Columna 3: Vencimiento
                MatrizTarjetas[ContadorTarjetas, 4] = cvv;          // Columna 4: Código de Seguridad

                ContadorTarjetas++; // Avanzamos a la siguiente fila para la próxima vez
                return true;
            }
            return false; // Retorna falso si la matriz está llena
        }
        // Matriz de casilleros: columna 0 = número, columna 1 = DNI del socio ("" = libre)
        public static string[,] MatrizCasilleros = new string[30, 2];

        static BaseDeDatos()
        {
            for (int i = 0; i < MatrizCasilleros.GetLength(0); i++)
            {
                MatrizCasilleros[i, 0] = (i + 1).ToString();
                MatrizCasilleros[i, 1] = "";
            }
        }

        // Devuelve el número asignado, o "" si no quedan libres
        public static string AsignarCasillero(string dni)
        {
            for (int i = 0; i < MatrizCasilleros.GetLength(0); i++)
                if (MatrizCasilleros[i, 1] == dni) return MatrizCasilleros[i, 0]; // ya tenía uno

            for (int i = 0; i < MatrizCasilleros.GetLength(0); i++)
                if (MatrizCasilleros[i, 1] == "")
                {
                    MatrizCasilleros[i, 1] = dni;
                    return MatrizCasilleros[i, 0];
                }
            return "";
        }
    }
}