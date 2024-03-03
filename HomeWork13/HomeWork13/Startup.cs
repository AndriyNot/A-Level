namespace HomeWork13
{
    using HomeWork13.Models;
    using HomeWork13.Services.Abstractions;

    public class Startup
    {
        private readonly IContactService _contactService;

        public Startup(IContactService contactService) 
        { 
            _contactService = contactService; 
        }

        public void Start()
        {
            AddOrder();
            GetOrder();
        }

        private void AddOrder()
        {
            Console.WriteLine("Enter contact name:");
            var inputName = Console.ReadLine();

            Console.WriteLine("Enter contact phone number:");
            var inputNumberPhone = Console.ReadLine();

            var contact = new Contact()
            {
                Name = inputName,
                PhoneNumber = inputNumberPhone
            };

            _contactService.AddContact(contact);

        }

        private void GetOrder()
        {
            Console.WriteLine("Select the culture");

            bool useCulture;
            var input = Console.ReadLine();
            Console.WriteLine();
            if (input?.ToLower().Trim().Equals("y") ?? false)
            {
                useCulture = true;
            }
            else
            {
                useCulture = false;
            }

            var conatct = _contactService.GetContact(useCulture);

            foreach (var contact in conatct)
            {
                _contactService.DetermineGroup(contact);

            }
            conatct.DisplayContacts(conatct);
        }
    }

}
