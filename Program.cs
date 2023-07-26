namespace AddressBookManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******* Welcome to addressBook Management System *******");
            AddressBook addressBook = new AddressBook();
            addressBook.AddContacts();
            addressBook.PrintContacts();
        }
    }
}