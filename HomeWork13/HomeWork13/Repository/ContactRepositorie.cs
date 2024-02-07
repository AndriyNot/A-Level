namespace HomeWork13.Repository
{
    using HomeWork13.ContactCollections;
    using HomeWork13.Entity;
    using HomeWork13.Repository.Abstractions;

    public class ContactRepositorie : IContactRepositorie
    {
        public ContactCollection<ContactEntity> _contacts { get; set; }

        public ContactRepositorie() 
        {
            _contacts = new ContactCollection<ContactEntity>()
            {
                new ContactEntity()
                {
                    Name = "Tohn Doe",
                    PhoneNumber = "380634568212",
                },

                new ContactEntity()
                {
                    Name = "Kohn D",
                    PhoneNumber = "380625497562",
                },

                new ContactEntity()
                {
                    Name = "Joh Do",
                    PhoneNumber = "380439998760",
                },

                new ContactEntity()
                {
                    Name = "андре боус",
                    PhoneNumber = "380995833331",
                },

                new ContactEntity()
                {
                    Name = "джона шмид",
                    PhoneNumber = "380669999990",
                },

                new ContactEntity()
                {
                    Name = "Doonas Doos",
                    PhoneNumber = "380686850003",
                },

                 new ContactEntity()
                {
                    Name = "Богдан буд",
                    PhoneNumber = "380634568212",
                },

                new ContactEntity()
                {
                    Name = "кован кун",
                    PhoneNumber = "380625497562",
                },

                new ContactEntity()
                {
                    Name = "123 крон",
                    PhoneNumber = "380439998760",
                },

                new ContactEntity()
                {
                    Name = "<>богро",
                    PhoneNumber = "380995833331",
                },

                new ContactEntity()
                {
                    Name = "руна шмид",
                    PhoneNumber = "380669999990",
                },

                new ContactEntity()
                {
                    Name = "Hord kold",
                    PhoneNumber = "380686850003",
                }
            };
        }

        public void AddContact(ContactEntity newcontact)
        {
            _contacts.AddContact(newcontact);
        }

        public ContactCollection<ContactEntity> GetContacts()
        {
           return _contacts;
        }
    }
}
