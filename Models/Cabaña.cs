namespace TP01bis_ALFIE_FAINSCHTEIN.Models;

public class Cabaña
{
private int ID;

private string nombre;
private string descripcion;
private int capacidad;

private List<string> fotos;
private List<string> ambientes;

public Cabaña(int ID, string nombre, string descripcion, int capacidad, List<string> fotos, List<string> ambientes)
    {
        this.ID = ID;
        this.nombre = nombre;
        this.descripcion = descripcion;
        this.capacidad = capacidad;
        this.fotos = fotos;
        this.ambientes = ambientes;

    }

    

}
