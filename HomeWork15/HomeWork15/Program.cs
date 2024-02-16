namespace HomeWork15
{
    public class Contact
    {
        public string Name { get; set; }

        public string PhoneNumber { get; set; }
    }

    public class Program
    {
        delegate int CalculateDelegate(int a, int b);

        public static int CalculateSum(int a, int b) 
        {
            return a + b;
        }

        private static void CalculateResultSum(CalculateDelegate calculateDelegate1, CalculateDelegate calculateDelegate2) 
        {
            try
            {
                var result1 = calculateDelegate1(8, 9);
                var result2 = calculateDelegate2(18, 19);
                var sum = result1 + result2;
                Console.WriteLine($"Result sum:{sum}\n");
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error:{ex.Message}");
            }
        }

        static void Main(string[] args)
        {
            CalculateDelegate calculateDelegate1 = CalculateSum;
            CalculateDelegate calculateDelegate2 = CalculateSum;

            calculateDelegate1 += CalculateSum;

            calculateDelegate2 += CalculateSum;

            CalculateResultSum(calculateDelegate1, calculateDelegate2);

            LINQMethod();
        }

        public static void LINQMethod()
        {
            List<Contact> contacts = new List<Contact>
            {
            new Contact { Name = "Bodi", PhoneNumber = "132-542-1111" },
            new Contact { Name = "Alic", PhoneNumber = "011-111-1111" },
            new Contact { Name = "Jon", PhoneNumber = "433-122-0909" },
            new Contact { Name = "Jon", PhoneNumber = "101-321-1233" },
            new Contact { Name = "Alina", PhoneNumber = "988-565-3555" },
            new Contact { Name = "Alina", PhoneNumber = "117-896-5555" },
            new Contact { Name = "Alina", PhoneNumber = "421-233-3098" },
            new Contact { Name = "Alina", PhoneNumber = "223-132-8673" },
            };
            var firstContact = contacts
                .Where(x => x.Name == "Jon")
                .FirstOrDefault();
            Console.WriteLine($"The first contact according to the criterion:\n Name:{firstContact.Name}, Number phone:{firstContact.PhoneNumber}");

            Console.WriteLine();

            var contactNames = contacts
                .Where(x => x.PhoneNumber.StartsWith("1"))
                .Select(x => $"Name: {x.Name}, Number phone:{x.PhoneNumber}");

            Console.WriteLine("Contact numbers");

            foreach (var name in contactNames)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine();
            
            var sortedContacts = contacts
                .Where(x => x.Name.StartsWith("A"))
                .OrderBy(x => x.Name)
                .ThenBy(x => x.PhoneNumber);

            Console.WriteLine("Sorted contacts by a specific criterion:");
            foreach (var contact in sortedContacts)
            {
                Console.WriteLine($"Name:{contact.Name}, Phone number:{contact.PhoneNumber}");
            }

            Console.WriteLine();

            var skipContacts = contacts
                .Where(x => x.Name == "Alina")
                .Skip(2);

            Console.WriteLine("Contacts after skipping the first two contacts:");
            foreach (var contact in skipContacts)
            {
                Console.WriteLine($"Name:{contact.Name}, Phone number:{contact.PhoneNumber}");
            }

            Console.WriteLine();

            var takeContacts = contacts
                .Where(x => x.Name == "Alina")
                .Take(2);

            Console.WriteLine("The first two contacts:");
            foreach (var contact in takeContacts)
            {
                Console.WriteLine($"Name:{contact.Name}, Phone number:{contact.PhoneNumber}");
            }
        }
    }
}
