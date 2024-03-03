namespace HomeWork13.Services.Abstractions
{
    using HomeWork13.ContactCollections;
    using HomeWork13.Models;

    public interface IContactService
    {
        void AddContact(Contact contact);

        ContactCollection<Contact> GetContact(bool useCulture);

        void DetermineGroup(Contact contact);
    }
}
