namespace AddressBook
{
    class Program
    {
        public static void FillingDetails(Contact contact)
        {
            Console.WriteLine("Enter first name: ");
            contact.firstName = Console.ReadLine();

            Console.WriteLine("Enter last name: ");
            contact.lastName = Console.ReadLine();

            Console.WriteLine("Enter address: ");
            contact.address = Console.ReadLine();

            Console.WriteLine("Enter city: ");
            contact.city = Console.ReadLine();

            Console.WriteLine("Enter state: ");
            contact.state = Console.ReadLine();

            Console.WriteLine("Enter phone: ");
            contact.phone = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter email: ");
            contact.email = Console.ReadLine();

            Console.WriteLine("Enter zipcode: ");
            contact.zipcode = Convert.ToInt32(Console.ReadLine());
        }

        public static void CreatingContacts()
        {
            Console.WriteLine("Do you want to add new contact press 1 or press 2 to cancle.");
            int num = Convert.ToInt32(Console.ReadLine());


            while (num == 1)
            {
                Contact contact = new Contact();
                FillingDetails(contact);
                contactList.Add(contact);

                Console.WriteLine("Do you want to add anoter contact then press 1 or press 2 for exit ");
                num = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("------------------------");
            Console.WriteLine("Total number of contact in address book:" + contactList.Count);
        }

        public static void DisplayContacts()
        {

            Console.WriteLine("-------------------------");
            Console.WriteLine("Current contacts in adress book:");

            foreach (Contact contact in contactList)
            {
                Console.WriteLine(contact.firstName);
            }
            Console.WriteLine("-------------------------");

        }

        public static void EditContacts()
        {
            Console.WriteLine("Do you want to edit contact details then press 1 or pres 2 for continue: ");
            int num = Convert.ToInt32(Console.ReadLine());
            while (num == 1)
            {
                Console.WriteLine("Enter first name to edit details: ");
                string firstName = Console.ReadLine();
                bool found = false;
                for (int i = 0; i < contactList.Count; i++)
                {

                    if (contactList[i].firstName == firstName)
                    {
                        found = true;  

                        
                        FillingDetails(contactList[i]);
                        break;

                    }
                } 
                if (!found)
                    Console.WriteLine("the contact with given person {0} is not in address book", firstName);

                DisplayContacts();
                Console.WriteLine("Do you want to edit contact press 1 to edit or press 2 to cancle.");
                num = Convert.ToInt32(Console.ReadLine());
            }
        }

        public static void DeleteContacts()
        {
            Console.WriteLine("Do you want to delete contact press 1 to delete or press 2 to cancle.");
            int num = Convert.ToInt32(Console.ReadLine());

            while (num == 1 && contactList.Count > 0)
            {
                Console.WriteLine("Enter contact First name");
                string firstName = Console.ReadLine();

                bool found = false;
                for (int i = 0; i < contactList.Count; i++)
                {

                    if (contactList[i].firstName == firstName)
                    {
                        found = true;  

                        contactList.RemoveAt(i);
                        break;

                    }
                }

                if (found)
                {
                    if (contactList.Count == 0) 
                        break;
                }
                else
                    Console.WriteLine("the contact with given person '{0}' is not in address book", firstName);
                
                DisplayContacts();
                Console.WriteLine("Do you want to delete contact press 1 to delete or press 2 to cancle.");
                num = Convert.ToInt32(Console.ReadLine());

            }
        }

        //creating list of contact
        public static List<Contact> contactList = new List<Contact>();
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to AddressBookManagement System");

            CreatingContacts();
            DisplayContacts();
            EditContacts();
            DeleteContacts();
        }
    }
}
