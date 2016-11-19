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
      _id = _instances.Count; //sets id equal to lenth of list
      _instances.Add(this); //moves this object into _instances list
    }
  }
}
