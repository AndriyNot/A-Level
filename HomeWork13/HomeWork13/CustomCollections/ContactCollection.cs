namespace HomeWork13.ContactCollections
{
    public class ContactCollection<T> : List<T>
    {
        public void AddContact(T newContact)
        {
            Add(newContact);
        }

        public void DisplayContacts(ContactCollection<T> newContact)
        {
            foreach (var contact in newContact)
            {
                Console.WriteLine(contact);
            }
        }
    }
}
