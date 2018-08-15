using System;
using System.Collections.Generic;
namespace OpenHouse1
{
    class Program
    {
        static void Main(string[] args)
        {
            Room Kitchen1 = new Room();
            Kitchen1.Name = "Kitchen";
            Kitchen1.Descriptions.Add("The walls are dirty");
            Kitchen1.Descriptions.Add("The stove is filthy");


            Room DiningRoom = new Room();
            DiningRoom.Name = "Dining Room";
            DiningRoom.Descriptions.Add("There is a hole in the floor");
            DiningRoom.Descriptions.Add("These curtains are old");
            Furniture DiningRoomTable = new Furniture();
            DiningRoomTable.Name = "Dining Room Table";
            DiningRoomTable.Descriptions.Add("This table is old");

            Room Basement = new Room();
            Basement.Name = "Basement";
            Basement.Descriptions.Add("It smells old and dusty down here");
            


            DiningRoom.Furnitures.Add(DiningRoomTable);

            List<Room> rooms = new List<Room>();
            rooms.Add(Kitchen1);
            rooms.Add(DiningRoom);


            Console.WriteLine("Hello, welcome to my open house");

            Console.WriteLine("Would you like to see the kitchen?");
            string userResponse = Console.ReadLine();

            if (userResponse.ToLower() == "y" || userResponse.ToLower() == "yes")
            {
                Console.WriteLine("Well there is a lot of trash in there, I hope you dont smell it");
            }
            else
            {
                Console.WriteLine("Well ok, lets check out some furniture!");
            }
            Console.WriteLine("Would you like to see the furniture?");
            userResponse = Console.ReadLine();

            if (userResponse.ToLower() == "y" || userResponse.ToLower() == "yes")
            {
                Console.WriteLine("Well, the couch is a little dusty");
            }

            Console.WriteLine("How about we check out the next room");
            Console.WriteLine("Ahh!! we have arrived, this is the Dining Room!!");
            
            foreach(string Description in DiningRoom.Descriptions)
            {
                Console.WriteLine(Description);
            }
            Console.WriteLine("Take a look at this dining room table");
            foreach(string Description in DiningRoomTable.Descriptions)
            {
                Console.WriteLine(Description);
            }

            Console.WriteLine("Well, that's the house Jack!! I hope you enjoyed yourself!");


            Console.ReadLine();
        } 
       
    }
}
