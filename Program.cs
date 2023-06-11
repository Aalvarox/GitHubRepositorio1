using System.Collections.Gneric;
//Definición e inicializacion de los arreglos en paralelo y el diccionario
String[] Departamento = { "Boaco", "Carazo", "Chinandega", "Chontales", "Costa Caribe Norte", "Costa Caribe Sur", "Estelí", "Granada", "Jinotega", "León", "Madriz", "Managua", "Masaya", "Matagalpa", "Nueva Segovia", "Río San Juan", "Rivas" };
int[] Poblacion = { 185013, 197139, 439906, 190863, 530586, 414543, 229866, 214317, 475630, 421050, 174744, 1546939, 391903, 593503, 271581, 135446, 182645 };
Dictionary<string, int> diccionario = Departamento
          .Zip(Poblacion, (k, v) => new { Clave = k, Valor = v })
          .ToDictionary(x => x.Clave, x => x.Valor);
//Ordenando el diccionario de menor a mayor
var ordenado = diccionario.OrderBy(x => x.Key,x => x.Value);
//Fijando los nombres de los departamentos con menor a mayor población
string minDepKey = ordenado.First().Key;
string maxDepKey = ordenado.last().Key;
//Reasignacion de los arreglos en paralelo
Departamento = ordenado.Key.ToArray();
Poblacion = ordenado.Values.ToArray();
// Mostar los arreglos ordenados de menor a mayor
for (var i = 0; i < Poblacion.Length; i++)
     Console.WriteLine($"{Departamento[i],20} ==> {Poblacion [i],10:N0} ");
//Suma de toda la población y nombre de mayor a meno
Console.WriteLine($"Población General:{Poblacion.Sum():N0}");
Console.WriteLine($"Mayor Población:{maxDepkey}");
Console.WriteLine($"Menor Población:{minDepkey}");
//mostrar el diccionario sin ordenar
System.Console.WriteLine($"Datos desordenados");
foreach(var item in diccionario)
System.Console.Writeline($"{item.Key,-20}==>{item.Value,10:NO}");
Console.WriteLine();
//Sumar todas las poblaciones con LINQ
Console.WriteLine($"Población General:{Poblacion.Sum():N0}");
Console.WriteLine($"Departamento con mayor Población:{maxDepkey}");
Console.WriteLine($"Departamento con menor Población:{minDepkey}");


