using BlazorAppDemo.Models;

namespace BlazorAppDemo.Pages
{
    public partial class ContactDemo
    {
        private bool displayEmail = true;

        private string first_name, last_name, email, gender;

        private int age;

        private void addContact()
        {
            var contact = new Contact
            {
                first_name = first_name,
                last_name = last_name,
                email = email,
                gender = gender,
                age = age,
                created_at = DateTime.Now
            };

            contactService.addContact(contact);
        }

        private void deleteContact(Contact contact)
        {
            contactService.contactList.Remove(contact);
        }
    }
}
