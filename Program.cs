using System.Collections;

namespace Tempo_Garcia_Eider;

class Program
{
    static void Main(string[] args)
    {
        double precioGuitarra = 249.90;
        double precioTrompeta = 189.00;
        double precioPiano = 399.00;
        double precioBateria = 549.00;

        double precioFunda = 35.00;
        double precioPuestaPunto = 25.00;
        double precioGarantia = 45.00;

        double gastosEnvio = 12.00;

        double importeMinimoParaDescuento = 300.00;
        double porcentajeDescuentImporte = 10.00;
        double porcentajeDescuentoSocio = 5.00;

        int operacionesCobradas = 0;
        double recaudado = 0;
        double importeMayor = 0;
        string clienteImporteMayor = "";
        int operacionesConEnvio = 0;
        int operacionesConDescuento = 0;
        int ventasGuitarra = 0;
        int ventasTrompeta = 0;
        int ventasPiano = 0;
        int ventasBateria = 0;

        int opcionMenu = 0;
        while (opcionMenu !=3)
        {
            Console.WriteLine();
            Console.WriteLine("---- TIENDA DE MÚSICA TEMPO ----");
            Console.WriteLine("1. Nueva compra");
            Console.WriteLine("2. Consultar caja");
            Console.WriteLine("3. Salir");
            Console.Write("Elige una opción: ");
            opcionMenu = int.Parse(Console.ReadLine()!);
            switch (opcionMenu)
            {
                case 1:
                    string cliente = "";
                    while (cliente == "")
                    {
                        Console.Write("Nombre del cliente: ");
                        cliente = Console.ReadLine()!.Trim();
                        Console.WriteLine("El nombre no puede estar vacío");
                    }
                    char respuestaSocio = ' ';
                    while (respuestaSocio != 's' && respuestaSocio != 'n')
                    {
                        Console.Write("¿Es socio del club Tempo? (s/n): ");
                        respuestaSocio = char.ToLower(Console.ReadKey().KeyChar);
                        if (respuestaSocio != 's' && respuestaSocio != 'n')
                        {
                            Console.WriteLine("Responde solo con s o n.");
                        }
                    }
                    bool esSocio;
                    if (respuestaSocio == 's')
                    {
                        esSocio = true;
                    }
                    else
                    {
                        esSocio = false;
                    }

                    int opcionInstrumento = 0;
                    string nombreInstrumento =  "";
                    double precioInstrumento = 0.0;
                    while (opcionInstrumento < 1 || opcionInstrumento > 4)
                    {
                        Console.WriteLine("---- INSTRUMENTOS ----");
                        Console.WriteLine("1. Guitarra eléctrica - " + precioGuitarra.ToString("F2") + "€");
                        Console.WriteLine("2. Trompeta - " + precioTrompeta.ToString("F2") + "€");
                        Console.WriteLine("3. Piano - " + precioPiano.ToString("F2") + "€");
                        Console.WriteLine("4. Batería acústica - " + precioBateria.ToString("F2") + "€");
                        Console.Write("Elige un instrumento: ");
                        opcionInstrumento = int.Parse(Console.ReadLine()!);

                        switch (opcionInstrumento)
                        {
                            case 1:
                            nombreInstrumento = "Guitarra eléctrica";
                            precioInstrumento = precioGuitarra;
                            break;
                            case 2: 
                            nombreInstrumento = "Trompeta";
                            precioInstrumento = precioTrompeta;
                            break;
                            case 3:
                            nombreInstrumento = "Piano";
                            precioInstrumento = precioPiano;
                            break;
                            case 4: 
                            nombreInstrumento = "Batería acústica";
                            precioInstrumento = precioBateria;
                            break;
                            default:
                            Console.WriteLine("Opción no válida");
                            break; 
                        } 
                    }
                    bool tieneFunda = false;
                    bool tienePuestaPunto = false;
                    bool tieneGarantia = false;
                    int numeroExtras = 0;
                    double totalExtras = 0;
                    int opcionExtra = -1;
                    while (opcionExtra != 0)
                    {
                        Console.WriteLine("---- EXTRAS ----");
                        Console.WriteLine("0. Terminar de elegir extras");
                        Console.WriteLine("1. Funda protectora - " + precioFunda.ToString("F2") + "€");
                        Console.WriteLine("2. Puesta a punto - " + precioPuestaPunto.ToString("F2") + "€");
                        Console.WriteLine("3. Garantía ampliada 2 años - " + precioGarantia.ToString("F2") + "€");
                        Console.Write("Elige un extra: ");
                        opcionExtra = int.Parse(Console.ReadLine()!);

                        switch (opcionExtra)
                        {
                            case 1: 
                            if (tieneFunda)
                                {
                                    Console.WriteLine("La funda ya está añadida");
                                }
                                else
                                {
                                    tieneFunda = true;
                                    numeroExtras++;
                                    totalExtras += precioFunda;
                                    Console.WriteLine("Funda añadida.");
                                }
                            break;
                            case 2: 
                            if (tienePuestaPunto)
                                {
                                    Console.WriteLine("La puesta a punto ya está añadida.");
                                }
                                else
                                {
                                    tienePuestaPunto = true;
                                    numeroExtras++;
                                    totalExtras += precioPuestaPunto;
                                    Console.WriteLine("Puesta a punto añadida.");
                                }
                            break;
                            case 3:
                            if (tieneGarantia)
                                {
                                    Console.WriteLine("La garantía ya está añadida.");
                                }
                                else
                                {
                                    tieneGarantia = true;
                                    numeroExtras++;
                                    totalExtras += precioGarantia;
                                    Console.WriteLine("Garantía ampliada añadida.");
                                }
                            break;
                            default: 
                            Console.WriteLine("Opción no válida.");
                            break;
                        }
                        Console.WriteLine("Extras elegidos: " + numeroExtras);
                        Console.WriteLine("Importe provisional: " + (precioInstrumento + totalExtras) + "€");
                    }
                    int opcionEntrega = 0;
                    string metodoEntrega = "";
                    string direccion = "";
                    double suplemento = 0;
                    while (opcionEntrega != 1 && opcionEntrega != 2)
                    {
                        Console.WriteLine("---- ENTREGA ----");
                        Console.WriteLine("1. Recogida en tienda (gratis)");
                        Console.WriteLine("2. Envio a domicilio " + gastosEnvio + "€");
                        Console.Write("Elige el método de entrega: ");
                        opcionEntrega = int.Parse(Console.ReadLine()!);
                        switch (opcionEntrega)
                        {
                            case 1:
                            metodoEntrega = "Recogida en tienda";
                            break;
                            case 2:
                            metodoEntrega = "Envio a domicilio";
                            suplemento = gastosEnvio;
                            break;
                            default:
                            Console.WriteLine("Opción no válida");
                            break;
                        }
                    }
                    if (opcionEntrega == 2)
                    {
                        while (direccion == "")
                        {
                            Console.Write("Dirección de envío: ");
                            direccion = Console.ReadLine()!.Trim();
                            if (direccion == "")
                            {
                                Console.WriteLine("La dirección de envío no puede estar vacía.");
                            }
                        }
                    }
                    double subtotal = precioInstrumento + totalExtras;
                    double descuentoImporte = 0;
                    double descuentoSocio = 0;
                    if (subtotal >= importeMinimoParaDescuento)
                    {
                        descuentoImporte = subtotal * porcentajeDescuentImporte / 100;
                    } 
                    if (esSocio)
                    {
                        descuentoSocio = subtotal * porcentajeDescuentoSocio / 100;
                    }
                    double descuento = descuentoImporte + descuentoSocio;
                    double total = subtotal - descuento + suplemento;
                    if (total < 0)
                    {
                        total = 0;
                    }
                    Console.WriteLine("---- DESGLOSE ----");
                    Console.WriteLine("Instrumento: " + precioInstrumento.ToString("F2") + "€");
                    Console.WriteLine("Extras: " + totalExtras.ToString("F2") + "€");
                    Console.WriteLine("Subtotal: " + subtotal.ToString("F2") + "€");
                    Console.WriteLine("Descuento por importe (" + porcentajeDescuentImporte + "%): " + descuentoImporte.ToString("F2"));
                    Console.WriteLine("Descuento por ser socio (" + porcentajeDescuentoSocio + "%): " + descuentoSocio.ToString("F2"));
                    Console.WriteLine("Suplemento de envio: " + suplemento.ToString("F2") + "€");
                    Console.WriteLine("Total a pagar: " + total.ToString("F2") + "€");

                    double dineroDado = 0;
                    int intentosDePago = 0;
                    int maxIntentoPago = 5;
                    while (dineroDado < total && intentosDePago < maxIntentoPago)
                    {
                    Console.Write("Dinero dado (€): ");
                    dineroDado = double.Parse(Console.ReadLine()!);
                    intentosDePago++;
                    if (dineroDado < total)
                        {
                            Console.WriteLine("Pago insuficiente. Debes entregar al menos: " + total + "€");
                            Console.WriteLine("Intento " + intentosDePago + " de " + maxIntentoPago);
                        }
                    }
                    if (dineroDado < total)
                    {
                        Console.WriteLine("Venta cancelada por pago insuficiente.");
                        continue;
                    }
                    double cambio = dineroDado - total;
                    
                    operacionesCobradas++;
                    recaudado += total;
                    if (total > importeMayor)
                    {
                        importeMayor = total;
                        clienteImporteMayor = cliente;
                    }
                    if (opcionEntrega == 2)
                    {
                        operacionesConEnvio++;
                    }
                    if (descuento > 0)
                    {
                        operacionesConDescuento++;
                    }
                    switch (opcionInstrumento)
                    {
                        case 1:
                        ventasGuitarra++;
                        break;
                        case 2: 
                        ventasTrompeta++;
                        break;
                        case 3: 
                        ventasPiano++;
                        break;
                        case 4:
                        ventasBateria++;
                        break;
                    }
                    string textoSocio = "";
                    if (esSocio)
                    {
                        textoSocio = "Sí";
                    }
                    else
                    {
                        textoSocio = "No";
                    }
                    Console.WriteLine("---- TICKET TIENDA DE MÚSICA TEMPO ----");
                    Console.WriteLine("Operación nº: " + operacionesCobradas);
                    Console.WriteLine("CLiente: " + cliente + "(Socio club tempo: " + textoSocio + ")");
                    Console.WriteLine("Instrumento: " + nombreInstrumento + "-" + precioInstrumento.ToString("F2") + "€");
                    if (numeroExtras == 0)
                    {
                        Console.WriteLine("Extras: ninguno");
                    }
                    else
                    {
                        Console.WriteLine("Extras (" + numeroExtras + "): ");
                        if (tieneFunda)
                        {
                            Console.WriteLine(" - Funda protectora: " + precioFunda.ToString("F2") + "€ ");
                        }
                        if (tienePuestaPunto)
                        {
                            Console.WriteLine(" - Puesta a punto: " + precioPuestaPunto.ToString("F2") + "€");
                        }
                        if (tieneGarantia)
                        {
                            Console.WriteLine(" - Garantía ampliada 2 años: " + precioGarantia.ToString("F2") + "€");
                        }
                    }
                    Console.WriteLine("Metodo de entrega: " + metodoEntrega);
                    if (opcionEntrega == 2)
                    {
                        Console.WriteLine("Dirección de entrega: " + direccion);
                    }
                    Console.WriteLine("-------------------------------------------------------");
                    Console.WriteLine("Descuento por importe: -" + descuentoImporte.ToString("F2") + "€");
                    Console.WriteLine("Descuento por ser socio: -" + descuentoSocio.ToString("F2") + "€");
                    Console.WriteLine("Gastos de envío: " + gastosEnvio.ToString("F2") + "€");
                    Console.WriteLine("Total: " + total.ToString("F2") + "€");
                    Console.WriteLine("Dinero entregado: " + dineroDado.ToString("F2") + "€");
                    Console.WriteLine("Cambio: " + cambio.ToString("F2") + "€");
                    Console.WriteLine("¡Gracias por tu compra!");
                break;
                case 2:
                Console.WriteLine("---- Caja de la sesión ----");
                if (operacionesCobradas == 0)
                    {
                        Console.WriteLine("Todavía no hay operaciones cobradas.");
                    } 
                    else
                    {
                        double importeMedio = recaudado / operacionesCobradas;
                        Console.WriteLine("Operaciones cobradas: " + operacionesCobradas);
                        Console.WriteLine("Total recaudado: " + recaudado.ToString("F2") + "€");
                        Console.WriteLine("Importe medio: " + importeMedio.ToString("F2") + "€");
                        Console.WriteLine("Operación más cara: " + importeMayor.ToString("F2") + "€ (Cliente: " + clienteImporteMayor + ")");
                        Console.WriteLine("Operaciones con envío: " + operacionesConEnvio);
                        Console.WriteLine("Operaciones con descuento: " + operacionesConDescuento);
                        Console.WriteLine("---- VENTAS POR INSTRUMENTO ----");
                        Console.WriteLine("Guitarra: " + ventasGuitarra);
                        Console.WriteLine("Trompeta: " + ventasTrompeta);
                        Console.WriteLine("Piano: " + ventasPiano);
                        Console.WriteLine("Batería: " +ventasBateria);
                    }
                break;
                case 3:
                Console.WriteLine("¡Gracias por usar la tienda de música Tempo! Hasta pronto.");
                Console.WriteLine("Resumen: " + operacionesCobradas + " operaciones, " + recaudado.ToString("F2") + " € ingresados.");
                break;
                default:
                Console.WriteLine("Opción no válida");
                break;
            }
        }
    }
}