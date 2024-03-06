internal class Program
{
    private static void Main(string[] args)
    {

        void showMenu()
        {
            Console.WriteLine("\t-= Welcome to my project! =-");
            Console.WriteLine("1. Create Phonebook");
            Console.WriteLine("2. Update Phonebook");
            Console.WriteLine("3. Delete Phonebook");
            Console.WriteLine("4. Read All Phonebooks");
            Console.WriteLine("5. Exit");
        }

        bool retry = true;
        while (retry)
        {
            Console.Clear();
            showMenu();
            Console.Write("Choose >>> ");
            int myChoose = Convert.ToInt32(Console.ReadLine());
            switch (myChoose)
            {
                case 1:
                    Console.WriteLine("Create Phonebook, not implemented!");
                    break;
                case 2:
                    Console.WriteLine("Update Phonebook, not implemented!");
                    break;
                case 3:
                    Console.WriteLine("Delete Phonebook, not implemented!");
                    break;
                case 4:
                    Console.WriteLine("Read All Phonbooks, not implemented!");
                    break;
                case 5:
                    Console.WriteLine("Thanks, Bye!");
                    retry = false;
                    break;
                default:
                    Console.WriteLine("Wrong number selected!");
                    break;
            }
            if (myChoose is not 5)
            {
                Console.Write("Continue? -> ");
                string isContinue = Console.ReadLine();
                if (isContinue == "yes")
                    showMenu();
                else
                {
                    Console.WriteLine("Thanks, Bye!");
                    retry = false;
                }
            }   
        }
    }
}