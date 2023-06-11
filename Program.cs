﻿//programa que permita visualizar los departamentos de nicaragua con
//su cantidad poblacional.
//Encuentre: Mayor, menor, sumas y ordene los datos
using System.Collections;
String[] Departamento = { "Boaco", "Carazo", "Chinandega", "Chontales", "Costa Caribe Norte", "Costa Caribe Sur", "Estelí", "Granada", "Jinotega", "León", "Madriz", "Managua", "Masaya", "Matagalpa", "Nueva Segovia", "Río San Juan", "Rivas" };
int[] Poblacion = { 185013, 197139, 439906, 190863, 530586, 414543, 229866, 214317, 475630, 421050, 174744, 1546939, 391903, 593503, 271581, 135446, 182645 };
Dictionary<string, int> diccionario = Departamento
          .Zip(Poblacion, (k, v) => new { Clave = k, Valor = v })
          .ToDictionary(x => x.Clave, x => x.Valor);
//Encontrar el mayor y el menor
int maxDep = Poblacion.Max();
int minDep = Poblacion.Min();
string maxDepkey = "", minDepkey = "";
//Encontrar los nombres del mayor y el menor
for (var i = 0; i < Poblacion.Length; i++)
{
    if (Poblacion[i] == maxDep)
        maxDepkey = Departamento[i];
    if (Poblacion[i] == minDep)
        minDepkey = Departamento[i];
}
//Ordenando con diccionario y Orderby de LINQ
//mostrar el diccionario sin ordenar
System.Console.WriteLine($"Datos desordenados");
foreach(var item in diccionario)
System.Console.Writeline($"{item.Key,-20}==>{item.Value,10:NO}");
Console.WriteLine();
//Sumar todas las poblaciones con LINQ
Console.WriteLine($"Población General:{Poblacion.Sum():N0}");
Console.WriteLine($"Departamento con mayor Población:{maxDepkey}");
Console.WriteLine($"Departamento con menor Población:{minDepkey}");

// Sumar todas las poblaciones con SUM de LINQ
System.Console.WriteLine($"Poblacion general:diccionario.Values.Sum():N0");
System.Console.WriteLine($"Departamento con mayor poblacion:{maxDepKey}");
System.Console.WriteLine($"Departamento con menor poblacion:{minDepKey}");
