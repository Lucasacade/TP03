class Cancion
{
   public string nombre {get; private set;}

   public int IDcancion {get; private set;}

   public Cancion(string nombre, int IDcancion)
   {
    this.nombre = nombre;
    this.IDcancion = IDcancion;
   }

}