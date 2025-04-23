class Disco
{
    public string Nombre {get; private set;}
    public string Artista {get; private set;}
    public string Productor {get;private set;}
    public string  GeneroMusical{get; private set;}   
    public List<Cancion> canciones {get; private set;}
    public int IDdisco {get; private set;}
    public string Foto {get; private set;}

    public Disco(string Nombre, string Artista, string Productor, string GeneroMusical,List<Cancion> canciones, int IDdisco, string Foto)
    {
        this.Nombre = Nombre;
        this.Artista = Artista;
        this.Productor = Productor;
        this.GeneroMusical = GeneroMusical;
        this.canciones = canciones;
        this.IDdisco = IDdisco;
        this.Foto = Foto;
    }
}