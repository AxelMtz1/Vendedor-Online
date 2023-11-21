namespace Aplicacion.Dominio
{
    public class Publicacion
    {
        public List <Producto> productos;
        //Habilitado se refiere a si la publicación es visible o no//
        public bool Habilitado { get; protected set; } = false;

        public Publicacion (bool Habilitado)
        {
            this.Habilitado = Habilitado;
            this.productos = new List<Producto>();
        }
        public void Habilitar() => this.Habilitado = true;
        public void Deshabilitar() => this.Habilitado = false;
    }
}