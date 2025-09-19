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
            buildings.Add(new Building(50, 50));


            // Démarrage
            Application.Run(new AirSpace(fleet, buildings));
        }
    }
}