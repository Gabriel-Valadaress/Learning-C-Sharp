namespace ThirdClass_BoardingHouse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
               The owner of a boarding house has ten rooms available for rent to students, 
               identified by the numbers 1 through 10.
             
                You must create a program that:

                Starts with all ten rooms empty.

                Reads a number N representing the number of students who will rent rooms 
                (N can be from 1 to 10).

                For each student:

                Read the student's name and email address.

                Read the chosen room number (from 1 to 10), ASSUMING that the room selected 
                is always vacant.

                At the end, the program should print a report listing all occupied rooms, 
                sorted by room number.

             */

            Room[] rooms = new Room[10];
            Console.Write("How many rooms will be rented? (1-10) ");
            int quantity = int.Parse(Console.ReadLine());

            for (int i = 1; i <= quantity; i++)
            {
                Console.Write($"\nRent #{i}\nName: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int roomNumber = int.Parse(Console.ReadLine());

                rooms[roomNumber - 1] = new Room { Name = name, Email = email, RoomNumber = roomNumber };
            }

            Console.WriteLine("\nBusy rooms:");
            for (int i = 0; i < rooms.Length; i++)
            {
                if (rooms[i] != null)
                {
                    Console.WriteLine(rooms[i]);
                }
            }


        }
    }
}
