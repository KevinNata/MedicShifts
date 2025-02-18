class Medico
{
    public int Id {get; set;}
    public string NombreMedico {get; set;} ="";


    public static List<Medico> ObtenerMedicos()
    {
        List<Medico> medicos = new List<Medico>();

        
        //aca haria una consulta a la base y añadiria los objetos a la lista 'medicos' creada arriba.
        medicos.Add(new Medico()
            {
                Id=1,
                NombreMedico="Dr.Pantalla"
            });

        medicos.Add(new Medico()
            {
                Id=2,
                NombreMedico="Dr.Jarron"
            });

        medicos.Add(new Medico()
            {
                Id=3,
                NombreMedico="Dra.Botella"
            });

        return medicos;
    }
}