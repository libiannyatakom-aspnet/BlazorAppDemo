using BlazorAppDemo.Models;

namespace BlazorAppDemo.Pages
{
    public partial class ContactPage
    {
        private List<Contact> contacts;

        protected async override Task OnInitializedAsync()
        {
            await Task.Delay(3000);

            contacts = new List<Contact> {
                new Contact {
                    first_name = "Libian",
                    last_name = "Nyata",
                    email = "libiannyatakom@gmail.com",
                    gender = "M",
                    created_at = DateTime.Now
                },
                new Contact {
                    first_name = "Adnan",
                    last_name = "Aditya Pradipta",
                    email = "adnan@gmail.com",
                    gender = "M",
                    created_at = DateTime.Now.AddMinutes(3)
                }
            };
            base.OnInitializedAsync();
        }
    }
}
