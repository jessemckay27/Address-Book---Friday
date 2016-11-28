using System.Collections.Generic;

namespace AddressBook.Objects
{
  public class Contact
  {
    private string _name;
    private string _number;
    private string _address;
    private int _id;
    private static List<Contact> _instances = new List<Contact> {};
    public Contact (string newName, string newNumber, string newAddress)
    {
      _name = newName;
      _number = newNumber;
      _address = newAddress;
      _instances.Add(this);
      _id = _instances.Count;
    }

    public string GetName()
    {
      return _name;
    }

    public string GetNumber()
    {
      return _number;
    }

    public string GetAddress()
    {
      return _address;
    }

    public static List<Contact> GetAll()
    {
      return _instances;
    }

    public int GetId()
    {
      return _id;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Contact Find(int searchId)
    {
      return _instances[searchId - 1];
    }
  }
}
