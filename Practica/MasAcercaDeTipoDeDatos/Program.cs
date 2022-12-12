//using MasAcercaDeTipoDeDatos;

//var estatusVentaCamisa = EstatusVenta.PenditePago;

//switch (estatusVentaCamisa)
//{
//    case EstatusVenta.Exitoso:
//        Console.WriteLine("Estatus exitoso");
//        break;
//    case EstatusVenta.PenditePago:
//        Console.WriteLine("Estatus Pendiente de pago");
//        break;
//    case EstatusVenta.Cancelada:
//        Console.WriteLine("Estatus cancelado");
//        break;
//    default:
//        Console.Error.WriteLine("Estatus desconocido");
//        break;
//}

//var result = developer.Jose;
//switch (result) 
//{
//    case developer.Leilan:
//        Console.WriteLine($"El desarrollador es {developer.Leilan}");
//        break;
//    case developer.Enderson:
//        Console.WriteLine($"El desarrollador es {developer.Enderson}");
//        break;
//    case developer.Enrique:
//        Console.WriteLine($"El desarrollador es {developer.Enrique}");
//        break;
//    case developer.Jose:
//        Console.WriteLine($"El desarrollador es {developer.Jose}");
//        break;
//    default :
//        Console.WriteLine($"El desarrollador no existe");
//        break;
//}

//var dia = DateTime.Now;
//var estacion = dia.Month switch
//{
//    3 or 4 or 5 => "Primavera",
//    6 or 7 or 8 => "Verano",
//    9 or 10 or 11 => "Otono",
//    12 or 1 or 2 => "Invierno",
//    _ => throw new ApplicationException("Mes Incorrecto")
//};


//--------------------------Arreglos
var vocales = new char[] { 'A', 'E', 'I', 'O', 'U' };
Range dosPrimerasVocales = ..5;

var resultado = vocales[dosPrimerasVocales];

foreach (var i in resultado )
{
    Console.WriteLine(i);
}