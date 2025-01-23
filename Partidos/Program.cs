using Partidos.Models;

namespace Partidos
{
    internal class Program{
        private static List<PartidoModel> partidos = new List<PartidoModel>();
        static void Main(string[] args){
            int opcion = 0;

            while(opcion != 6)
            {
                Console.WriteLine("----Menu----");
                Console.WriteLine("1) Crear partido.");
                Console.WriteLine("2) Votar partido.");
                Console.WriteLine("3) Borrar partido.");
                Console.WriteLine("4) Modificar partido.");
                Console.WriteLine("5) Obtener partidos.");
                Console.WriteLine("6) Salir.");

                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    switch (opcion)
                    {
                        case 1:
                            //Crear partido
                            CrearPartido();
                            break;
                        case 2:
                            //Votar partido
                            VotarPartido();
                            break;
                        case 3:
                            //Borrar partido
                            BorrarPartido();
                            break;
                        case 4:
                            //Modificar partido
                            ModificarPartido();
                            break;
                        case 5:
                            //Obtener partidos
                            ObtenerPartidos();
                            break;
                        case 6:
                            //Salir
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Ingresa una opcion valida.\n\n");
                }
            }
        }
        private static void CrearPartido()
        {
            Console.WriteLine("Ingresa el nombre del partido....");
            string nombre = Console.ReadLine();

            PartidoModel partido_nuevo = new PartidoModel(Guid.NewGuid(), nombre, 0, true);
            partidos.Add(partido_nuevo);
        }

        private static void ObtenerPartidos()
        {
            Console.WriteLine("Lista de partidos...");
            foreach (var partido in partidos)
            {
                if (partido.Action == true)
                {
                    Console.WriteLine($" Id: {partido.Id} | Nombre: {partido.Nombre} | Votos: {partido.Votos} | Activo: {partido.Action}.\n\n");
                }
            }
        }
        private static void VotarPartido()
        {
            Console.WriteLine("Ingresa el nombre del partido...");
            string nombre = Console.ReadLine();

            foreach (var partido in partidos)
            {
                if(nombre == partido.Nombre && partido.Action == true){
                    partido.Votos = partido.Votos + 1;
                    Console.WriteLine("Realizado...");
                }   
            }
        }
        private static void ModificarPartido()
        {
            Console.WriteLine("Ingresa el Nombre del partido...");
            string nombre = Console.ReadLine();

            foreach (var partido in partidos)
            {
                if(nombre == partido.Nombre && partido.Action == true){
                    Console.WriteLine("Ingresa el nuevo nombre del partido");
                    string nuevo_nombre = Console.ReadLine();
                    partido.Nombre = nuevo_nombre;
                    Console.WriteLine("Realizado...");
                }   
            }
        }
        private static void BorrarPartido()
        {
            Console.WriteLine("Ingresa el Id del partido");
            string nombre = Console.ReadLine();

            foreach (var partido in partidos)
            {
                if(nombre == partido.Nombre && partido.Action == true){
                    partido.Action = false;
                    Console.WriteLine("Realizado...");
                }   
            }
        }
    }
}