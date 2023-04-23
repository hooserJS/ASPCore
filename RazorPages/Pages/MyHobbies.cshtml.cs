using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPages.Models;

namespace RazorPages.Pages
{
    public class MyHobbiesModel : PageModel
    {
        public List<Hobbies> HobbiesList { get; set; } = new List<Hobbies>();


        public async Task OnGetAsync()
        {
            HobbiesList.Add(new Hobbies()
            { Id = 1, HobbieName = "C#" });
            HobbiesList.Add(new Hobbies()
            { Id = 2, HobbieName = "Cars" });
            HobbiesList.Add(new Hobbies()
            { Id = 3, HobbieName = "Cycling" });

        }
    }
}
