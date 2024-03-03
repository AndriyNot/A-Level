namespace HomeWork13.Extensions
{
    using HomeWork13.ContactCollections;
    using HomeWork13.Models;

    public static class ContactExtension
    {
        public static ContactCollection<Contact> InsertionSort(this ContactCollection<Contact> contacts, bool useCulture)
        {
            int n = contacts.Count;

            for (int i = 1; i < n; ++i)
            {
                var key = contacts[i];
                int j = i - 1;

                for (; j >= 0 && contacts[j].CompareTo(key, useCulture) > 0; j--)
                {
                    contacts[j + 1] = contacts[j];
                }

                contacts[j + 1] = key;
            }

            return contacts;
        }
    }
}
