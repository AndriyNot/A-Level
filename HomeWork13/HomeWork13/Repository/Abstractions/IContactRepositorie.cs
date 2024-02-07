namespace HomeWork13.Repository.Abstractions
{
    using HomeWork13.ContactCollections;
    using HomeWork13.Entity;

    public interface IContactRepositorie
    {
        void AddContact(ContactEntity newcontact);

        ContactCollection<ContactEntity> GetContacts();
    }
}
