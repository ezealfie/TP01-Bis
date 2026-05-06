using System.Data.Common;
using Microsoft.JSInterop.Infrastructure;

namespace TP01bis_ALFIE_FAINSCHTEIN.Models;

public class Complejo

{
    Dictionary<int, Cabaña> cabañas = new Dictionary<int, Cabaña>();

    public Complejo()
    {

        List<string> fotosRefugio = new List<string> { "refugio01.jpg", "refugio02.jpg", "refugio03.jpg" };
        List<string> ambientesRefugio = new List<string> {"Dormitorio principal con sommier", "Kichenette equipada", "Deck con vista al bosque" ,"Baño con hidromasaje"};
        List<string> fotosSoñada = new List<string> { "sonada01.jpg", "sonada02.jpg", "sonada03.jpg" };
        List<string> ambientesSoñada = new List<string> { "Habitación matrimonial", "Habitación secundaria con tres camas", "Cocina completa", "Parrilla privada"};
        List<string> fotosAltos = new List<string> { "altos01.jpg", "altos02.jpg", "altos03.jpg" };
        List<string> ambientesAltos = new List<string> { "Segundo dormitorio en suite", "Balcón terraza panorámico", "Lavadero propio", "Cochera cubierta" };
        Cabaña cabaña1 = new Cabaña(1, "El Refugio", "Una cabaña acogedora de madera, ideal para una escapada romántica en contacto directo con la naturaleza.", 2, fotosRefugio, ambientesRefugio);
        Cabaña cabaña2 = new Cabaña(2, "La soñada", "Amplia y luminosa, diseñada especialmente para familias que buscan comodidad y espacio para los chicos.", 5, fotosSoñada, ambientesSoñada);
        Cabaña cabaña3 = new Cabaña(3, "Altos del valle", "Ubicada en el punto más alto del complejo, ofrece las mejores vistas y terminaciones de lujo.", 2, fotosAltos, ambientesAltos);
    
        cabañas.Add(cabaña1.getID(), cabaña1);
        cabañas.Add(cabaña2.getID(), cabaña2);
        cabañas.Add(cabaña3.getID(), cabaña3);
       }
public Dictionary<int, Cabaña> devolverComplejo()
    {
        return cabañas;
    }
public Cabaña obtenerCabaña(int ID)
    {
        if (cabañas.ContainsKey(ID)){
            return cabañas[ID];
        }
            return null;
    }
}
