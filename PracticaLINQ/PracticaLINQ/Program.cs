#region Introducion
using PracticaLINQ;
using System.ComponentModel.DataAnnotations;

var numero = new int[] { 2, 3, 1, 4 };
var numeroEnunRange = Enumerable.Range(1, 5);

//Sintaxis de Metodo o lamda
var numeroPares = numero.Where(x => x % 2 == 0).ToArray();
var numeroParesEnumerableRange = numeroEnunRange.Where(t=> t %2 ==0).ToArray();

//Sintaxis Query

foreach(var n in numeroPares) 
{
    //Console.WriteLine($"Numeros pares {n}");
}
Console.WriteLine();

foreach (var m  in numeroParesEnumerableRange) 
{
   // Console.WriteLine($"Numero par: {m}");
}
#endregion

#region video 6. Funcion Where
//Filtros

var numeroV6 = Enumerable.Range(1, 25).ToArray();

//Sintaxis de Metodos
var numerosImpares = numeroV6.Where(n => n % 1 == 0).ToList();

//Sintaxis de Query
var numeroImparesv6_2 = from n in numeroV6
                        where n % 1 == 0 && n > 10
                        select n;

//Console.WriteLine("Numero Impares mayor que 10 \nNumero Sintaxis de Metodo");
foreach (var i in numerosImpares)
{
   // Console.WriteLine($"Numeros {i}");
}

//Console.WriteLine("\n Numero Sintaxis de Query:");
foreach (var i in numeroImparesv6_2)
{
    //Console.WriteLine($"Numero {i}");
}
#endregion

#region Video 7.
var  personas = new List<Persona>()
{
    new Persona {Nombre = "Enderson", Edad = 23, Soltero = true, FechaNacimiento = DateTime.Now.AddDays(-1), Telefonos = new List<string>() { "0090293409230" }, FechaIngresoEmpresa = DateTime.Parse("12/12/2013")},
    new Persona {Nombre = "Jose Miguel", Edad = 78, Soltero = false, FechaNacimiento = DateTime.Now.AddDays(-1), Telefonos = new List<string>() { "0090293409230" }, FechaIngresoEmpresa = DateTime.Now.AddDays(-3)},
    new Persona {Nombre = "Anderson", Edad = 23, Soltero = true, FechaNacimiento = DateTime.Parse("2/2/2010"), Telefonos = new List<string>() { "8092391445" }, FechaIngresoEmpresa = DateTime.Parse("4/12/1994")},
    new Persona {Nombre = "Jose", Edad = 14, Soltero = false, FechaNacimiento = DateTime.Parse("2/2/2000"), Telefonos = new List<string>() { "0090293409230" }, FechaIngresoEmpresa = DateTime.Parse("4/12/1992")},
    new Persona {Nombre = "Mario", Edad = 73, Soltero = true, FechaNacimiento = DateTime.Now.AddDays(-1), Telefonos = new List<string>() { "0090293409230" }, FechaIngresoEmpresa = DateTime.Now.AddMonths(-4)},
    new Persona {Nombre = "Franconia", Edad = 33, Soltero = false, FechaNacimiento = DateTime.Parse("2/2/1994"), Telefonos = new List<string>() { "8092391445" }, FechaIngresoEmpresa = DateTime.Parse("12/12/2022")},
    new Persona {Nombre = "Mobil  Eplota", Edad = 73, Soltero = true, FechaNacimiento = DateTime.Parse("2/2/1993"), Telefonos = new List<string>() { "8092391456" }},
    new Persona {Nombre = "Paco4", Edad = 25, Soltero = false, FechaNacimiento = DateTime.Parse("2/2/1993"), Telefonos = new List<string>() { "8492391445" }},
};

//Sintaxis de  Query
//Mayor de de edad con Query
var mayorDeEdadQuery = (from n in personas where n.Edad <= 18 select n).ToList();
//Traer solteron con Query
var solteroQuery  = (from s in personas
                    where s.Soltero
                    select s).ToList();
//Solteros que sean Mayor de edad Query
var solteroMayorDeEdad  = (from sm in personas
                          where sm.Soltero && sm.Edad >= 18
                          select sm).ToList();
//Personas con menos de tres meses Query
var fechaDeIngresoQuery = (from fi in personas
                          where fi.FechaIngresoEmpresa >= DateTime.Now.AddMonths(-3)
                          select fi).ToList();
//Saber todo los que son mayor de de edad 
foreach (var i in personas.Where(p => p.Edad > 19))
{
    //Console.WriteLine($"La edad de {i.Nombre} es {i.Edad}");
}
//traer todos los soltero 
//Console.WriteLine();
foreach (var i in personas.Where(p => p.Soltero))
{
    //Console.WriteLine($"{i.Nombre} esta Soltero");
}
//soltero que sean mayor de edad
foreach (var i in personas.Where(p => p.Edad > 10 && p.Soltero)) 
{
    //Console.WriteLine("{0} esta soltero y es mayor de edad, su  edad es {1} ", i.Nombre, i.Edad);
}
//Personas con menos de tres meses 
foreach(var item in personas.Where(p => p.FechaIngresoEmpresa >= DateTime.Now.AddMonths(-3)).ToList())
{
    //Console.WriteLine(item.Nombre);
}
#endregion

#region Video 8. First
var listaDePersonas = new List<Persona>()
{
    new Persona {Nombre = "Jose Toyos", Edad = 15, Soltero = false, FechaNacimiento = DateTime.Parse("12/02/1992"), FechaIngresoEmpresa = DateTime.Now.AddMonths(-4) },
    new Persona {Nombre = "Leilan Altacantara", Edad = 32 , Soltero= true, FechaNacimiento = DateTime.Parse("04/04/1987"), FechaIngresoEmpresa = DateTime.Parse("04/04/1987") },
    new Persona {Nombre = "Enderson Florian", Edad = 15, Soltero = true, FechaNacimiento = DateTime.Parse("02/12/1994"), FechaIngresoEmpresa = DateTime.Parse("04/04/1987")}
};

//tener la primer persona 
var primeraPersona = listaDePersonas.First();
var primeraPersonaMayorDeEdad = listaDePersonas.FirstOrDefault(p => p.Edad >= 18);

//Console.WriteLine(primeraPersona.Nombre);
//Console.WriteLine(primeraPersonaMayorDeEdad.Nombre);

//probando first
var listaPais = new List<int>();
try
{
    //Console.WriteLine(listaPais.First());
}
catch (Exception Ex) 
{
    //Console.WriteLine($"Error");
}
//Console.WriteLine($"{listaPais.FirstOrDefault()}");


#endregion

#region Video 9. Last
    //last y LastOrDefault
    //Encontrar el ultimo elemento de una coleccion
    //Console.WriteLine($"{listaDePersonas.Last().Nombre}");
    //Console.WriteLine($"{listaDePersonas.LastOrDefault().Nombre}");

#endregion 

#region Video 10. ElementAt
var personaLista = personas.ElementAtOrDefault(5);
//Console.WriteLine(personaLista.Nombre);

//query 
var personaLista2 = (from p in personas
                    select p).ElementAtOrDefault(5);
//Console.WriteLine(personaLista2.Nombre);
#endregion
#region Video 11. Single 
var personSigle = personas.SingleOrDefault(s => s.Edad == 25);
//Console.WriteLine(personSigle.Nombre);
#endregion
