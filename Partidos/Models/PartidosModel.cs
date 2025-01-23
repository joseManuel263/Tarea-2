namespace Partidos.Models
{
    public class PartidoModel{
        public Guid Id {get; set;}
        public string Nombre {get; set;}
        public int Votos {get; set;}
        public bool Action {get; set;}

        public PartidoModel(Guid id, string nombre, int votos, bool action)
        {
            Id = id;
            Nombre = nombre;
            Votos = votos;
            Action = action;
        }
    }
}