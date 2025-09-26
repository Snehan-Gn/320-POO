using Drones;

namespace Drones
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();


            // Création de la flotte de drones;
            List<Drone> fleet= new List<Drone>();
            fleet.Add(new Drone("Joe", 100, 100));

            List<Building> buildings= new List<Building>();
            buildings.Add(new Factory(35,100,430.40));
            buildings.Add(new Store(250, 130, "Lundi:8h-18h"));

            try
            {
                // Démarrage
                Application.Run(new AirSpace(fleet, buildings));
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}