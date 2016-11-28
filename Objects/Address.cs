using System.Collections.Generic;

namespace AddressBook.Objects
{
  public class Contact
  {
    private string _name; //defines empty variable
    private string _number; //defines empty variable
    private string _address; //defines empty variable
    private int _id; //defines empty variable
    private static List<Contact> _instances = new List<Contact> {};  //defines empty list

    public Contact (string newName, string newNumber, string newAddress)
    {
      _name = newName;
      _number = newNumber;
      _address = newAddress;
      _instances.Add(this); //moves this object into _instances list
      _id = _instances.Count; //sets id equal to lenth of list
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
