namespace DogDoors
{
    internal class DogDoorSimulator
    {

        static void Main(string[] args)
        {

            DogDoor door = new DogDoor();
            Remote remote = new Remote(door);

            Console.WriteLine("Fido barks to go outside...");
            remote.PressButton();

            Console.WriteLine("\nFido has gone outside...");

            Console.WriteLine("\nFidp's all done...");


            Console.WriteLine("\nFidp's back inside...");

        }
        

    }
}
