using Aplicacion.Dominio;
namespace Aplicacion.Dominio;

public class Vendedor
{
    public string nombre;
    public string apellido;
    public string email;
    public int CUIT;
    public string domicilio;
    public string nomUsuario;
    public string contraseña;
    public List<Publicacion>Publicaciones;
    public Vendedor (string nombre, string apellido, string email, int CUIT, string domicilio, string nomUsuario, string contraseña)
    {
        this.nombre = nombre;
        this.apellido = apellido;
        this.email = email;
        this.CUIT = CUIT;
        this.domicilio = domicilio;
        this.nomUsuario = nomUsuario;
        this.contraseña = contraseña;
        this.Publicaciones = new.List<Publicacion>();
    }
    public void CambiarContraseña(string nuevaContraseña) => this.contraseña = nuevaContraseña;
}