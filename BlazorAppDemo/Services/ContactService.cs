using BlazorAppDemo.Models;

namespace BlazorAppDemo.Services
{
    public class ContactService
    {
        public List<Contact> contactList = new List<Contact>();

        public void addContact(Contact contact)
        {
            contactList.Add(contact);
        }
    }
}
