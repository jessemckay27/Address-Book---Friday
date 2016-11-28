using Nancy;
using System.Collections.Generic;
using AddressBook.Objects;

namespace AddressBook
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => { //this displays the main page
        return View["index.cshtml"];
      };
      Get["/contact/new_contact"] = _ => { //this displays the contact form page
        return View["contact_form.cshtml"];
      };
      Post["/contact/view_one_contact"] = _ => {
        Contact newContact = new Contact(Request.Form["new-name"], Request.Form["new-number"], Request.Form["new-address"]);
        List<Contact> allContacts = Contact.GetAll();
        return View["view_one_contact.cshtml", newContact];
      };
    }
  }
}
