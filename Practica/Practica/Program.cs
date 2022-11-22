var temperatura = 38;
var permitirValorNull = string.Empty;

//utilizando and
var mensaje = temperatura switch
{
    37 => "No tienes ninguna condicion",
    > 37 and <  39  => "Tienes fiebre",
    >= 39 and < 43 => "Debes ir al medico",
    < 37 => "Puede que tengas baja la azucar",
    _ => throw new ApplicationException("Temperatura Incorrecta")
};

Console.WriteLine(mensaje);

//utilizando or

var dia  = DateTime.Now;

var estacion = dia.Month switch
{
    3 or 4 or 5 => "Primavera",
    6 or 7 or 8 => "Verano",
    9 or 10 or 11 => "Otono",
    12 or 1 or 2 => "Invierno",
    _ => throw new ApplicationException("Mes Incorrecto")
};

Console.WriteLine(estacion);