namespace HomeWork13.Services
{
    using HomeWork13.ContactCollections;
    using HomeWork13.Entity;
    using HomeWork13.Extensions;
    using HomeWork13.Models;
    using HomeWork13.Repository.Abstractions;
    using HomeWork13.Services.Abstractions;

    public class ContactService : IContactService
    {
        private readonly IContactRepositorie _contactRepositorie;

        public ContactService(IContactRepositorie contactRepositorie)
        {
            _contactRepositorie = contactRepositorie;
        }

        public void AddContact(Contact contact)
        {
            var contactEntity = new ContactEntity()
            {
                Name = contact.Name,
                PhoneNumber = contact.PhoneNumber
            };

            _contactRepositorie.AddContact(contactEntity);
        }

        public ContactCollection<Contact> GetContact(bool useCulture)
        {
            var contactEntitys = _contactRepositorie.GetContacts();
            var contacts = new ContactCollection<Contact>();

            foreach (var contactEntity in contactEntitys) 
            {
                contacts.AddContact(new Contact()
                {
                    Name = contactEntity.Name,
                    PhoneNumber = contactEntity.PhoneNumber,
                });

            }
            var sortedContacts = ContactExtension.InsertionSort(contacts, useCulture);
            return sortedContacts;
        }

        public void DetermineGroup(Contact contact)
        {
            if (char.IsDigit(contact.Name[0]))
            {
                contact.Group = ContactGroup.Number;  
            }

            else if (!char.IsLetter(contact.Name[0]))
            {
                contact.Group = ContactGroup.SpecialCharacter;
            }
            else
            {
                contact.Group = ContactGroup.Alphabet;
            }
        }
    }
}
