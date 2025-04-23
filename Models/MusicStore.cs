class MusicStore
{
    public Dictionary<int, Disco> discos {get;private set;}
    
    public MusicStore(Dictionary<int, Disco> discos)
    {
        this.discos = discos;
    }
    public Dictionary<int,Disco> InicializarDiscos()
    {
        List<Cancion> canciones = new List<Cancion>();
        canciones.Add(new Cancion("Leitmotiv",1));
        canciones.Add(new Cancion("Nueva Era",2));
        canciones.Add(new Cancion("Brindis",3));
        canciones.Add(new Cancion("Buscarte Lejos",4));
        canciones.Add(new Cancion("Imperio",5));
        canciones.Add(new Cancion("Hardaway",6));
        canciones.Add(new Cancion("Cine",7));
        canciones.Add(new Cancion("Vida de rock",8));
        canciones.Add(new Cancion("No Drama",9));
        canciones.Add(new Cancion("Barro",10));
        canciones.Add(new Cancion("Un dia mas",11));
        canciones.Add(new Cancion("Trato de estar bien",12));
        canciones.Add(new Cancion("Wake up & Bake up",13));
        canciones.Add(new Cancion("Constelación",14));
        canciones.Add(new Cancion("Ameri",15));
        discos.Add(1,new Disco("AMERI","Duki","Yesan","Trap, Pop, Reguetón y hip hop",canciones,1,""));
    }

    
}