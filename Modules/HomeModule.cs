using Nancy;
using System.Collections.Generic;
using AddressBook.Objects;

namespace AddressBook
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        var allContacts = Contact.GetAll();
        return View["index.cshtml", allContacts];
      };
      Get["contact/{id}"] = parameters => {
        var contact = Contact.Find(parameters.id);
        return View["view_one_contact.cshtml", contact];
      };
      Get["/contact/new_contact"] = _ => {
        return View["contact_form.cshtml"];
      };
      Post["/contact/view_new_contact"] = _ => {
        Contact newContact = new Contact(Request.Form["new-name"], Request.Form["new-number"], Request.Form["new-address"]);
        List<Contact> allContacts = Contact.GetAll();
        return View["view_new_contact.cshtml", newContact];
      };
      Post["/contact/clear_contacts"] = _ => {
        Contact.ClearAll();
        return View["clear_contacts.cshtml"];
      };
    }
  }
}
