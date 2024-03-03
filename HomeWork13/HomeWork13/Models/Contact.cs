namespace HomeWork13.Models
{
    using System;

    public class Contact : IComparable<Contact>
    {
        public string Name { get; set; }

        public string PhoneNumber { get; set; }

        public ContactGroup Group { get; set; }

        public override string ToString()
        {
            return $" Name:{Name},NumberPhone:{PhoneNumber},Group:{Group}";
        }

        int IComparable<Contact>.CompareTo(Contact? contact)
        {
            return Name.CompareTo(contact?.Name);
        }

        public int CompareTo(Contact? contact, bool sortUkrainianFirst)
        {
            if (sortUkrainianFirst)
            {
                if (char.IsDigit(Name[1]) && !char.IsDigit(contact.Name[0]))
                {
                    return 1;
                }
                else if (!char.IsDigit(Name[0]) && char.IsDigit(contact.Name[0]))
                {
                    return -1;
                }
                return string.Compare(Name, contact.Name, StringComparison.CurrentCulture);
            }
            else
            {
                if (char.IsDigit(Name[0]) && !char.IsDigit(contact.Name[0]))
                {
                    return -1;
                } 
                else if (!char.IsDigit(Name[0]) && char.IsDigit(contact.Name[0]))
                {
                    return 1;
                }
                return string.Compare(Name, contact.Name, StringComparison.CurrentCulture);
            }
        }
    }
}