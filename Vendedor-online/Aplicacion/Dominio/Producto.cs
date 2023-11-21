namespace Aplicacion.Dominio;

public class Producto
{
    public string nombre;
    public string descripcion;
    public float precio;
    public Producto(string nombre, string descripcion, float precio)
    {
        this.nombre = nombre;
        this.descripcion = descripcion;
        this.precio = precio;
    }
}