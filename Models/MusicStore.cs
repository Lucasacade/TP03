class MusicStore
{
    public static Dictionary<int, Disco> discos {get;private set;}
    public static Dictionary<int,Disco> InicializarDiscos()
    {
        discos = new Dictionary<int, Disco>();
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
        discos.Add(1,new Disco("AMERI","Duki","Yesan","Trap, Pop, Reguetón y hip hop",canciones,1,"ab67616d0000b273ee67e1ebdbc7a30772972a48.jpg"));

        canciones.Clear();
        canciones.Add(new Cancion("NUEVAYoL",1));
        canciones.Add(new Cancion("VOY A LLeVARTE PA PR",2));
        canciones.Add(new Cancion("BAILE INoLVIDABLE",3));
        canciones.Add(new Cancion("PERFuMITO NUEVO",4));
        canciones.Add(new Cancion("WELTiTA",5));
        canciones.Add(new Cancion("VeLDÁ",6));
        canciones.Add(new Cancion("EL CLúB",7));
        canciones.Add(new Cancion("KETU TeCRÉ",8));
        canciones.Add(new Cancion("BOKeTE",9));
        canciones.Add(new Cancion("KLOuFRENS",10));
        canciones.Add(new Cancion("TURiSTA",11));
        canciones.Add(new Cancion("CAFé CON RON",12));
        canciones.Add(new Cancion("PIToRRO DE COCO",13));
        canciones.Add(new Cancion("LO QUE LE PASÓ A HAWAII",14));
        canciones.Add(new Cancion("EoO",15));
        canciones.Add(new Cancion("DtMF",16));
        canciones.Add(new Cancion("LA MuDANZA",17));
        discos.Add(2,new Disco("DeBÍ TiRAR MÁS FOToS","Bad Buny","Dysbit","Reguetón, Salsa, Música house, Plena, Jíbaro",canciones,2,"ab67616d0000b273bbd45c8d36e0e045ef640411.jpg"));

        canciones.Clear();
        canciones.Add(new Cancion("INTRO: SPEECH CRUZZI",1));
        canciones.Add(new Cancion("AHORA QUÉ",2));
        canciones.Add(new Cancion("YANKEE",3));
        canciones.Add(new Cancion("VISTA AL MAR",4));
        canciones.Add(new Cancion("PLAYA DEL INGLÉS",5));
        canciones.Add(new Cancion("SIN SEÑAL",6));
        canciones.Add(new Cancion("DAME",7));
        canciones.Add(new Cancion("CUÉNTALE",8));
        canciones.Add(new Cancion("LUCES AZULES",9));
        canciones.Add(new Cancion("PUNTO G",10));
        canciones.Add(new Cancion("MUÑECA",11));
        canciones.Add(new Cancion("WANDA",12));
        canciones.Add(new Cancion("ME FALTA ALGO",13));
        canciones.Add(new Cancion("LISBOA",14));
        canciones.Add(new Cancion("ÉRAMOS DOS",15));
        canciones.Add(new Cancion("DONDE QUIERO ESTAR",16));
        discos.Add(3,new Disco("Donde quiero estar","Quevedo","Garabatto","Pop urbano, Reguetón, Trap latino",canciones,3,"ab67616d0000b273d53036b726a5a5a1cda5e891.jpg"));

        canciones.Clear();
        canciones.Add(new Cancion("Masacre en el puticlub",1));
        canciones.Add(new Cancion("Noticias de ayer",2));
        canciones.Add(new Cancion("Aquella solitaria vaca urbana",3));
        canciones.Add(new Cancion("Todo preso es politico",4));
        canciones.Add(new Cancion("Vencedores vencidos",5));
        canciones.Add(new Cancion("Vamos las bandas",6));
        canciones.Add(new Cancion("Ella debe estar tan linda",7));
        canciones.Add(new Cancion("Todo un palo",8));
        discos.Add(4,new Disco("Un baión para el ojo idiota","Patricio rey y sus redonditos de ricota","Patricio Rey y sus Redonditos de Ricota","Rock, Rock Argentino",canciones,4,"ab67616d00001e02ca7cf5470b635a1b0a53fa36.jpg"));

        canciones.Clear();
        canciones.Add(new Cancion("QUE ME FALTE TODO",1));
        canciones.Add(new Cancion("Y TE VAS",2));
        canciones.Add(new Cancion("HOLA PERDIDA",3));
        canciones.Add(new Cancion("OJALÁ",4));
        canciones.Add(new Cancion("SÉ QUE VAS A DOLER",5));
        canciones.Add(new Cancion("YA NO VUELVAS",6));
        canciones.Add(new Cancion("TE FUISTE DE MI VIDA",7));
        canciones.Add(new Cancion("TOCO Y ME VOY",8));
        canciones.Add(new Cancion("LA MOROCHA",9));
        canciones.Add(new Cancion("QUIERO CREER",10));
        canciones.Add(new Cancion("YA NO VUELVAS(version cuarteto)",11));
        discos.Add(5,new Disco("QUE NOS FALTE TODO","LUCK RA","RAMKY","Cuarteto",canciones,5,"ab67616d0000b273546d66125577fdca616ec73c.jpg"));

        canciones.Clear();
        canciones.Add(new Cancion("Facts.mp3",1));
        canciones.Add(new Cancion("Jagger.mp3",2));
        canciones.Add(new Cancion("JET_set.mp3",3));
        canciones.Add(new Cancion("IConic.mp3",4));
        canciones.Add(new Cancion("La_Original.mp3",5));
        canciones.Add(new Cancion("GTA.mp3",6));
        canciones.Add(new Cancion("Exclusive.mp3",7));
        canciones.Add(new Cancion("No_Se_Ve.mp3",8));
        canciones.Add(new Cancion("24_Horas.mp3",9));
        canciones.Add(new Cancion("Muñecos.mp3",10));
        canciones.Add(new Cancion("Ojitos_Verdes.mp3",11));
        canciones.Add(new Cancion("A_1000_Km.mp3",12));
        canciones.Add(new Cancion("Guerrero.mp3",13));
        discos.Add(6,new Disco(".MP3","Emilia","Big One","Pop, RyB contemporaneo, Dance pop, Hip hop, Urban",canciones,6,"ab67616d00001e02bfb94590c914538b193f6931.jpg"));

        canciones.Clear();
        canciones.Add(new Cancion("Mojaa",1));
        canciones.Add(new Cancion("Lokita de Septum",2));
        canciones.Add(new Cancion("Bodka yellow",3));
        canciones.Add(new Cancion("Hello Coto",4));
        canciones.Add(new Cancion("Level Up",5));
        canciones.Add(new Cancion("Lola",6));
        canciones.Add(new Cancion("Rockstar",7));
        canciones.Add(new Cancion("She Don't Give a Fo",8));
        canciones.Add(new Cancion("Batman",9));
        canciones.Add(new Cancion("Y si te vas",10));
        canciones.Add(new Cancion("Adicto",11));
        canciones.Add(new Cancion("Loca",12));
        canciones.Add(new Cancion("La Cooperativa de la Droga",13));
        canciones.Add(new Cancion("B.U.H.O",14));
        canciones.Add(new Cancion("No Vendo Trap",15));
        canciones.Add(new Cancion("Si Te Sentis Sola",16));
        discos.Add(7,new Disco("Mejores Exitos","Duki","Yesan","trap latino, reggaeton, freestyle, hip hop, pop rap, y R&B",canciones,7,"ab67616d0000b2734d6bd72db38ca317e0934baa.jpg"));
        
        canciones.Clear();
        canciones.Add(new Cancion("Confía En Mí",1));
        canciones.Add(new Cancion("Dime Que No",2));
        canciones.Add(new Cancion("No Lo Engañes Más",3));
        canciones.Add(new Cancion("Cómo Quisiera",4));
        canciones.Add(new Cancion("Te Fuiste",5));
        canciones.Add(new Cancion("Dime Si Eres Feliz",6));
        canciones.Add(new Cancion("Yo Que Te Amé",7));
        canciones.Add(new Cancion("Me Extrañarás",8));
        canciones.Add(new Cancion("Te Quiero Corazón",9));
        canciones.Add(new Cancion("Tan Solo Quiero Amarte",10));
        canciones.Add(new Cancion("Dime Tú",11));
        canciones.Add(new Cancion("La Quiero a Ella",12));
        canciones.Add(new Cancion("Si No Estás...",13));
        canciones.Add(new Cancion("Si La Ves Otra Vez",14));
        canciones.Add(new Cancion("Desde Que Te Vi",15));
        canciones.Add(new Cancion("Despójate",16));
        discos.Add(8,new Disco("Confía en Mí","Hernán y la Champions Liga","Confía en Mí","Cumbia y Cuarteto",canciones,8,"ab67616d0000b2734f269221ec9eb997c513c1fe.jpg"));
        return discos;
    }

    
}