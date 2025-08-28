// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
public class Hoteles
{
    public int Id;
    public string? Nombre;
    public List<Habitaciones>? Habitaciones; // Un hotel tiene muchas habitaciones
}

public class Habitaciones
{
    public int Id;
    public string? Numero;
    public string? Tipo;  
    public Hoteles? Hotel;  // Relación con Hotel
    public List<Reservas>? Reservas; // Una habitación puede tener varias reservas
}

public class Huespedes
{
    public int Id;
    public string? Nombre;
    public List<Reservas>? Reservas; // Un huésped puede tener varias reservas
}

public class Reservas
{
    public int Id;
    public DateTime FechaInicio;
    public DateTime FechaFin;
    public Habitaciones? Habitacion;
    public Huespedes? Huesped;
}
