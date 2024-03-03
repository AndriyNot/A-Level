namespace HomeWork13.Entity
{
    using HomeWork13.Models;

    public class ContactEntity
    {
        public string Name { get; set; }

        public string PhoneNumber { get; set; }

        public ContactGroup Group { get; set; }
    }
}