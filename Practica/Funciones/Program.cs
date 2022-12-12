//Funciones Simples
using Funciones;

string NombreCompleto() 
{
    return "Marcos Diaz";
}
//Funciones que no retnornan
void FechaActual()
{
    var fecha = DateTime.Now;
    Console.WriteLine(fecha.ToString("dd-MM-yyyyy"));
}

void TuEdad(int ano, int mes = default,  string dia = default) 
{
    var fechaActual = DateTime.Now;
    var yearFechaActual = fechaActual.ToString("yyyy");
    Console.WriteLine($"Tu dedad es: {int.Parse(fechaActual.ToString("yyyy")) - ano}");
}

void ImprimirEnConsola(string nombre, string apellido = default, int? edad = null) 
{
    string  resultado = "Tu Nombre es: " + nombre;
    if (string.IsNullOrEmpty(apellido)) 
    {
       resultado += $", tu apellido es : {apellido}";
    }
    if (edad is not null) 
    {
        resultado += $", tu edad es : {edad}";
    }
    Console.WriteLine(resultado);
}

//FechaActual();
//TuEdad(1994);
//TuEdad(ano : 1994);
//ImprimirEnConsola("Enderson", apellido: "Florian", edad : 21);

double Promedio(int[] numeros)
{
    var resultado = 0.0;

    foreach (var numero in numeros) 
    {
        resultado += numero;
    }
    return resultado / numeros.Length;
}
//ejemplo 1
//Console.WriteLine($"El premipo: {Promedio(new int[] { 1,5,7})}");

//utilizando param
int PromedioNotasEscolares(params int[] notas) 
{
    var resultado = 0;
    foreach (var promedioNota in notas)
    {
        resultado += promedioNota;
    }
    return resultado / notas.Length;
}

//Console.WriteLine($"Tu promedio de notas es: {PromedioNotasEscolares(95,90,95,98)}");


//Mostrar lista dependiendo su tipo  y la cantidad  que exista para tipo del datos
void InfoDelAno (Enum tipo, params int[] datos) 
{
    switch (tipo) 
    {
        case TypeInfoDelAno.Mes:
            RecorrerDatos(typeof(Meses));
            break;
        case TypeInfoDelAno.Estaciones:
            RecorrerDatos(typeof(EstacionesDelAno));
            break;
        case TypeInfoDelAno.Dia:
            RecorrerDatos(typeof(Dias)); 
            break;
    }

    void RecorrerDatos(Type enumType)
    {        
        foreach(var item in datos) 
        {
            var resul= Enum.GetName(enumType, item);
            if (resul is not null)
                Console.WriteLine(resul);
        }
    }  

}

InfoDelAno(TypeInfoDelAno.Estaciones, 2, 3, 7, 2);
//InfoDelAno(TypeInfoDelAno.Dia,new int[] { 2, 3, 7, 2 });