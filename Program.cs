 //programa que permita visualizar los departamentos de nicaragua con
 // su cantidad poblacional
 //Encuentra el Mayor, menor, sumas, y ordene los datos
 using Departamentos;
 //lista de departamentos
 List <depto> IstDeptos = new List <depto>()
 {
     new depto("Boaco",185013),
     new depto("Carazo",197139),
     new depto("Chinandega",439906),
     new depto("Chontales",190863),
     new depto("Costa Caribe Norte",530586),
     new depto("Costa Caribe Sur",414543),
     new depto("Esteli",229866),
     new depto("Granada",214317),
     new depto("Jinotega",475630),
     new depto("Leon",421050),
     new depto("Madriz",174744),
     new depto("Managua",1546939),
     new depto("Masaya",391903),
     new depto("Matagalpa",593503),
     new depto("Nueva segovia",271581),
     new depto("Rio San Juan",271581),
     new depto("Rivas",182645),

 };
 // Encontra el mayor o menor(Poblacion)
 depto minDepto = IstDeptos.OrderBy (d => d.population). First();
 depto maxDepto = IstDeptos.OrderBy (d => d.population). Last();
 //Ordenar los departamentos
 var DeptOrdenado = IstDeptos.OrderBy(d => d.population);
 // Mostrar los departamento ordenados
 foreach (var item in DeptOrdenado)
Console.WriteLine($"{item.Name,-20} ==> {item.population,10:N0}");
// Mostrar el menor y el mayor
 Console.WriteLine($"Dpto con menor poblacion: {minDepto.Name}");
 Console.WriteLine($"Dpto con mayor poblacion: {maxDepto.Name}");
 //sumar todas las poblaciones con SUM de LINQ
 int total = IstDeptos.Select(d => d.population).Sum();
Console.WriteLine($"Poblacion General:{total:N0}");