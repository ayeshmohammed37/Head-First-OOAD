using System;
using System.Threading;


namespace DogDoors
{
    public class Remote
    {
        DogDoor door;


        public Remote(DogDoor door)
        {
            this.door = door;
        }

        public void PressButton()
        {
            Console.WriteLine("Pressing the remote control button...");

            if (door.IsOpen())
            {
                door.Close();
            }
            else
            {
                door.Open();
                Timer timer = null;
                timer = new Timer(_ =>
                {
                    door.Close();
                    timer.Dispose();
                }, null, 5000, Timeout.Infinite);

                


            }
        }
    }
}
