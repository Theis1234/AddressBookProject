using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AddressBook ab = new AddressBook("Jan");

            ab.AddAddress(new Address("Hans Peter Nielsen", "Birkehøj 5", "2134123456"));
            ab.AddAddress(new Address("Jens Peter Larsen", "Poppelhøj 6", "2345619481"));

            Console.WriteLine(ab.ToString());

            AddressBook ab2 = new AddressBook("Bo");

            ab2.AddAddress(new Address("Niels Peter Hansen", "Bøgehøj 7", "213412345636"));
            ab2.AddAddress(new Address("Lars Peter Jensen", "Fyrrehøj 8", "2345679801"));

            Console.WriteLine(ab2.ToString());

            AddressBook sumAb = new AddressBook("Jan and Bo");

            foreach (Address a in ab._addresses) 
            { 
                sumAb.AddAddress(a);
            }
            foreach (Address a in ab2._addresses)
            {
                sumAb.AddAddress(a);
            }

            Console.WriteLine(sumAb.ToString());

            sumAb.RemoveAddress(0);

            Console.WriteLine(sumAb.ToString());
            Console.ReadLine();
            
            

        }
    }
    class Address
    {
        private string _name;
        private string _streetAddress;
        private string _telephone;

        public Address(string name, string streetAddress, string telephone)
        {
            Name = name;
            StreetAddress = streetAddress;
            Telephone = telephone;
        }

        public string Name { get => _name; set => _name = value; }
        public string StreetAddress { get => _streetAddress; set => _streetAddress = value; }
        public string Telephone { get => _telephone; set => _telephone = value; }

        public override string ToString()
        {
            return $"Name: {_name.ToString()}\tStreet address: {_streetAddress.ToString()}\tTelephone: {_telephone.ToString()}";
        }
        
    }
    class AddressBook
    {
        private string _owner;
        public List<Address> _addresses;

        public AddressBook(string owner)
        {
            Owner = owner;
            _addresses = new List<Address>();
        }

        public string Owner { get => _owner; set => _owner = value; }

        public override string ToString()
        {
            string owner = $"Owner: {_owner.ToString()}\n";
            foreach ( var address in _addresses)
            {
                owner += $"Address: {address.ToString()}\n";
            }
            return owner;
        }
        public void AddAddress(Address address)
        {
            _addresses.Add(address);
        }
        public void RemoveAddress(int index) 
        {
            _addresses.RemoveAt(index);
        }

    }
}
