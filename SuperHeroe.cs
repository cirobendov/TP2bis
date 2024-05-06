class SuperHeroe
{
    
    public string Nombre {get; set;}
    public string Ciudad {get; set;}
    public double Peso {get; set;}
    public double Fuerza {get; set;}
    public double Velocidad {get; set;}

    public SuperHeroe (string nombre, string ciudad, double peso, double fuerza, double velocidad)
    {
        Nombre = nombre;
        Ciudad = ciudad;
        Peso = peso;
        Fuerza = fuerza;
        Velocidad = velocidad;
    }
    public double ObtenerSkill()
    {
        double skill = 0;
        Random rd = new Random();
        int random = rd.Next(1, 10);
        skill = random + Fuerza * 0.8 + Velocidad * 0.6;
        return skill;
    }

}