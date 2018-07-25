using System;
using System.Collections.Generic;
using System.Text;

namespace Database.Models
{
    public class User
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public string Document { get; private set; }
        public Address Address { get; private set; }

        public User(string name, string document, Address address)
        {
            Id = Guid.NewGuid();
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Document = document ?? throw new ArgumentNullException(nameof(document));
            Address = address ?? throw new ArgumentNullException(nameof(address));
        }

        public void ChangeName(string newName)
        {
            if (string.IsNullOrEmpty(newName) || string.IsNullOrEmpty(newName))
            {
                throw new Exception("Valor não pode ser nulo");
            }

            this.Name = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(newName.Trim().ToLower());
            
        }

        public void AddName(string newName)
        {
            if (string.IsNullOrEmpty(newName) || string.IsNullOrEmpty(newName))
            {
                throw new Exception("Valor não pode ser nulo");
            }

            this.Name = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(newName.Trim().ToLower());

        }

    }
}
